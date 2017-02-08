using GestionEni.Context;
using GestionEni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionEni.Controllers
{
    public class FormationController : Controller
    {

        private EFFormationRepository repository;

        public ActionResult Index()
        {
            repository = new EFFormationRepository();
            IEnumerable<Formation> Formations = repository.Formations;

            return View();
        }

        //
        // GET: /Formation/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Formation/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Formation/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
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
