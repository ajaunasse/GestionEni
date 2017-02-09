using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GestionEni.Models;
using GestionEni.Context ;
using Newtonsoft.Json;

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
                personneCo.Cursus1 = null;
                personneCo.Role1 = null;
                var json = JsonConvert.SerializeObject(personneCo, 
                    new JsonSerializerSettings { 
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    });

                var userCookie = new HttpCookie("user", json);
                userCookie.Expires.AddDays(365);
                HttpContext.Response.Cookies.Add(userCookie);


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
            if (Request.Cookies["user"] != null)
            {
                var user = new HttpCookie("user")
                {
                    Expires = DateTime.Now.AddDays(-1),
                    Value = null
                };
                Response.SetCookie(user);
            }

            Session["personneCo"] = null;
            return RedirectToRoute("Home");
        }


    }
}
