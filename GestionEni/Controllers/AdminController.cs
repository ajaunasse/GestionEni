using GestionEni.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionEni.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            if (Request.Cookies["user"] != null)
            {
                Session["personneCo"] = JsonConvert.DeserializeObject<Personne>(Request.Cookies["user"].Value);
            }
            else
            {
                Session["personneCo"] = null;
            }

            if (Session["personneCo"] == null)
            {
                return RedirectToRoute("Login");
            }
            return View();
        }

    }
}
