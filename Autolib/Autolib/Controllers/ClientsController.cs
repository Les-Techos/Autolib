using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Autolib.Models.Domain;
using Autolib.Models.Dao;
using Microsoft.AspNetCore.Http;
using Autolib.Models.ViewModel;

namespace Autolib.Controllers
{
    public class ClientsController : Controller
    {
        private readonly autolibContext _context;

        public ClientsController(autolibContext context)
        {
            _context = context;
        }

        // GET: Clients
        public async Task<IActionResult> Index()
        {
            return View(await _context.Client.ToListAsync());
        }

        // GET: Clients/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            ClientsModel CM = null;
            if (id == null)
            {
                return NotFound();
            }

            var client = await _context.Client
                .FirstOrDefaultAsync(m => m.IdClient == id);
            if (client == null)
            {
                return NotFound();
            }
            CM = new ClientsModel(client, ServiceReservation.getInstance().getReservations(client));

            return View(CM);
        }public async Task<IActionResult> RemoveResa(int? clientId, DateTime debut, DateTime fin)
        {
            Reservation r = null;
            ClientsModel CM = null;
            if (clientId == null)
            {
                return NotFound();
            }
            var client = ServiceClient.getInstance().GetClient((int) clientId);
            if (client == null)
            {
                return NotFound();
            }
            r = ServiceReservation.getInstance().getReservations(client, debut, fin).FirstOrDefault();
            if (r == null)
            {
                return NotFound();
            }
            try
            {
                ServiceReservation.getInstance().annule_resa(r);
            }catch(Exception e)
            {
                return NotFound();
            }

            
            CM = new ClientsModel(client, ServiceReservation.getInstance().getReservations(client));

            return View("Details", CM);
        }

        // POST: Clients/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create()
        {
            Client c = new Client();
            if (ModelState.IsValid)
            {
                if (ServiceClient.getInstance().GetClient(Request.Form["signupusername"]) == null)
                {
                     c.Login = Request.Form["signupusername"];
                }
                else
                {
                    return View("../Connexion/Index", "Cet identifiant est déjà utilisé, choisissez en un autre !");
                }
               
                if(Request.Form["signuppassword"] == Request.Form["signupcpassword"])
                {
                    c.Paswd = Request.Form["signuppassword"];
                }
                else
                {
                    return View("../Connexion/Index", "Les mots de passe ne correspondent pas !");
                }

                c.Nom = Request.Form["signupname"];
                c.Prenom = Request.Form["signupforname"];
                if (!String.IsNullOrEmpty(Request.Form["naissance"]))
                {
                    c.DateNaissance = DateTime.Parse(Request.Form["naissance"]);
                }
                else
                {
                    c.DateNaissance = DateTime.Now;
                }
                ServiceClient.getInstance().InsertClient(c);
                return RedirectToAction("Index", "Home");
            }
            return View(c);
        }

        // GET: Clients/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = await _context.Client.FindAsync(id);
            if (client == null)
            {
                return NotFound();
            }
            return View(client);
        }

        // POST: Clients/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdClient,Login,Paswd,Salt,Nom,Prenom,DateNaissance")] Client client)
        {
            if (id != client.IdClient)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    Client c = ServiceClient.getInstance().GetClient(client.IdClient);
                    c.Login = client.Login;
                    if(client.Paswd != null || client.Paswd!="")
                    {
                        c.Paswd = client.Paswd;
                    }                
                    c.Nom = client.Nom;
                    c.Prenom = client.Prenom;
                    c.DateNaissance = client.DateNaissance;
                    ServiceClient.getInstance().UpdateClient(c);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientExists(client.IdClient))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "Clients", new { id = client.IdClient} );
            }
            return View(client);
        }

        // GET: Clients/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = ServiceClient.getInstance().GetClient((int) id);
            if (client == null)
            {
                return NotFound();
            }
            foreach(Reservation r in ServiceReservation.getInstance().getReservations(client))
            {
                _context.Reservation.Remove(r);
            }
            foreach(Utilise u in ServiceUtilise.getInstance().getUtilises(client))
            {
                _context.Utilise.Remove(u);
            }
            _context.SaveChanges();

            
            _context.Client.Remove(client);
            await _context.SaveChangesAsync();
            HttpContext.Session.SetString("nom", "");
            HttpContext.Session.SetInt32("id", 0);
            return RedirectToAction("Index", "Home");
        }

        // POST: Clients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var client = await _context.Client.FindAsync(id);
            _context.Client.Remove(client);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientExists(int id)
        {
            return _context.Client.Any(e => e.IdClient == id);
        }
    }
}
