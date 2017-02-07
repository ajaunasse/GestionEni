
﻿using GestionEni.Context;
using GestionEni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionEni.Controllers
{
    public class PersonneController : Controller
    {
        //
        // GET: /Personne/
        private EFPersonneRepository repository;

        public ActionResult Index()
        {
            repository = new EFPersonneRepository();
            IEnumerable<Personne> Personnes = repository.Personnes;
            return View(Personnes);
        }

        //
        // GET: /Personne/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Personne/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Personne/Create

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
        // GET: /Personne/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Personne/Edit/5

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
        // GET: /Personne/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Personne/Delete/5

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
