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
    public class CursusController : Controller
    {
        private EFCursusRepository repository = new EFCursusRepository();

        public ActionResult Index()
        {
            IEnumerable<Cursus> Cursus = repository.Cursus;

            return View(Cursus);
        }

        //
        // GET: /Cursus/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Cursus/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Cursus/Create

        [HttpPost]
        public ActionResult Create(Cursus cursus)
        {
            try
            {
                repository.SaveCursus(cursus);
                return RedirectToRoute("list_cursus");
               
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Cursus/Edit/5

        public ActionResult Edit(int id)
        {
            Cursus cursus = repository.Cursus.Where(c => c.IdCursus == id).FirstOrDefault();
            return View(cursus);
        }

        //
        // POST: /Cursus/Edit/5

        [HttpPost]
        public ActionResult Edit(Cursus cursus)
        {
            try
            {
                repository.SaveCursus(cursus);

                return RedirectToRoute("list_cursus");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Cursus/Delete/5

        public ActionResult Delete(int id)
        {
            repository.DeleteCursus(id);
            return RedirectToRoute("list_cursus");
        }

        //
        // POST: /Cursus/Delete/5

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
