using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GestionEni.Models;
using GestionEni.Context ;

namespace GestionEni.Controllers
{
    public class LoginController : Controller
    {
        private EFPersonneRepository personneRepository = new EFPersonneRepository();
        
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Authentification()
        {
            Personne personneCo = new Personne();
            

            var login = Request["login"];
            var password = Request["password"];
            personneCo = personneRepository.Personnes
                .Where(p => p.username == login)
                .Where(p => p.password == password)
                .FirstOrDefault();
            if (personneCo != null)
            {
                Session["personneCo"] = personneCo;
                return RedirectToRoute("Admin");
            }
            else
            {
                TempData["message"] = "Bad credentials";
                return RedirectToRoute("Login");

            }
        }

        public ActionResult Logout()
        {
            Session["personneCo"] = null;
            return RedirectToRoute("Home");
        }


    }
}
