using GestionEni.Context;
using GestionEni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionEni.Controllers
{

    [CustomAuthorize("Formateur")]
    public class FormationController : Controller
    {

        private EFFormationRepository repository;
        EFSiteRepository repoSite = new EFSiteRepository();
        EFCursusRepository repoCursus = new EFCursusRepository();

        public ActionResult Index()
        {
            repository = new EFFormationRepository();
            IEnumerable<Formation> Formations = repository.Formations;

            return View(Formations);
        }

        //
        // GET: /Formation/Details/5

        public ActionResult Details(int id)
        {
            repository = new EFFormationRepository();
            Formation formation = repository.Formations.Where(f => f.IdFormation == id).FirstOrDefault();
            return View(formation);
        }

        //
        // GET: /Formation/Create

        public ActionResult Create()
        {
            FormationViewModel fVm = new FormationViewModel();
            fVm.Cursus = repoCursus.Cursus;
            fVm.Site = repoSite.Sites;

            return View(fVm);
        }

        //
        // POST: /Formation/Create

        [HttpPost]
        public ActionResult Create(FormationViewModel fVm)
        {
            try
            {
   
                repository = new EFFormationRepository();
                repository.SaveFormation(fVm.Formation);

                return RedirectToRoute("list_formation");
            }
            catch
            {
                return RedirectToRoute("create_formation");
            }
        }

        //
        // GET: /Formation/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Formation/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Formation/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Formation/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
