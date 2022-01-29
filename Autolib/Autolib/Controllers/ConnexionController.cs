using Autolib.Models.Dao;
using Autolib.Models.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMangaEntity.Models.Utilitaires;

namespace Autolib.Controllers
{
    public class ConnexionController : Controller
    {
        ServiceClient sc = ServiceClient.getInstance();
        // GET: ConnexionController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ConnexionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ConnexionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConnexionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ConnexionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ConnexionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ConnexionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ConnexionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult Controle()
        {
            try
            {
                // on récupère les données du formulaire
                String login = Request.Form["username"];
                String mdp = Request.Form["password"];
                try
                {

                    Client unUtilisateur = ServiceClient.getInstance().GetClient(login);
                    if (unUtilisateur != null)
                    {
                        try
                        {
                            if (sc.CheckClient(login, mdp))
                            {
                                HttpContext.Session.SetInt32("id", unUtilisateur.IdClient);
                                HttpContext.Session.SetString("nom", unUtilisateur.Nom + " " + unUtilisateur.Prenom);
                            }
                            else
                            {
                                ModelState.AddModelError("Erreur", "Erreur lors du contrôle  du mot de passe pour : " + login);
                                return RedirectToAction("Index", "Connexion");
                            }
                        }
                        catch (Exception e)
                        {
                            ModelState.AddModelError("Erreur", "Erreur lors du contrôle : " + e.Message);
                            return RedirectToAction("Index", "Connexion");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("Erreur", "Erreur  login erroné : " + login);
                        return RedirectToAction("Index", "Connexion");
                    }
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("Erreur", "Erreur lors de l'authentification : " + e.Message);
                    return RedirectToAction("Index", "Connexion");
                }
                return RedirectToAction("Index", "Home");
            }
            catch (Exception e)
            {
                ModelState.AddModelError("Erreur", "Erreur lors de l'authentification : " + e.Message);
                return RedirectToAction("Index", "Connexion");
            }
        }

    }
}
