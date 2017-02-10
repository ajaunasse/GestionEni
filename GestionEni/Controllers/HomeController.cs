using GestionEni.Context;
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
        private EFCursusRepository repoCursus = new EFCursusRepository();
        private EFSiteRepository repoSite = new EFSiteRepository();
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
            IEnumerable<Cursus> Cursus = repoCursus.Cursus;
            return View(Cursus);
        }

        public ActionResult Site()
        {
            IEnumerable<Cursus> Cursus = repoCursus.Cursus;
            return View(Cursus);
        }

    }
}
