using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GestionEni.Models;

namespace GestionEni.Controllers
{
    public class LoginController : Controller
    {
        
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
            var stagiaire = Request["stagiaire"];
            var formateur = Request["formateur"];

            System.Diagnostics.Debug.WriteLine("SomeText");

            return View();
        }


    }
}
