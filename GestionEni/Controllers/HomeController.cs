using GestionEni.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionEni.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            if (Request.Cookies["user"] != null)
            {
                Session["personneCo"] = JsonConvert.DeserializeObject<Personne>(Request.Cookies["user"].Value);
                //Session.Add("personneCo", JsonConvert.DeserializeObject<Personne>(Request.Cookies["user"].Value));
            }
            
            return View();
        }

        public ActionResult Formation()
        {
            return View();
        }

    }
}
