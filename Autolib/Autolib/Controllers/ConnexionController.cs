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
        // GET: HomeController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController1/Create
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

        // GET: HomeController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController1/Edit/5
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

        // GET: HomeController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController1/Delete/5
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
                String login = Request.Form["login"];
                String mdp = Request.Form["pwd"];
                try
                {

                    Client unUtilisateur = ServiceClient.getInstance().GetUnUtilisateur(login);
                    if (unUtilisateur != null)
                    {
                        try
                        {
                            Byte[] selmdp = MonMotPassHash.GenerateSalt();
                            Byte[] mdpByte = MonMotPassHash.PasswordHashe("secret", selmdp);
                            String mdpS = MonMotPassHash.BytesToString(mdpByte);
                            String saltS = MonMotPassHash.BytesToString(selmdp);
                            String sel = unUtilisateur.Salt;
                            // on récupère le sel 
                            Byte[] salt = MonMotPassHash.transformeEnBytes(unUtilisateur.Salt);
                            // on génère le mot de passe 
                            Byte[] tempo = MonMotPassHash.transformeEnBytes(unUtilisateur.Paswd);
                            if (MonMotPassHash.VerifyPassword(salt, mdp, tempo))
                            {
                                HttpContext.Session.SetInt32("id", unUtilisateur.IdClient);
                                HttpContext.Session.SetString("name", unUtilisateur.Nom + " " + unUtilisateur.Prenom);
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
