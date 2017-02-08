
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
        private EFPersonneRepository repository = new EFPersonneRepository();
        EFRoleRepository repoRole = new EFRoleRepository();

        public ActionResult Index()
        {
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
            

            Personne personne = repository.Personnes
                .FirstOrDefault(p => p.IdPersonne == id);

            EditPersonneViewModel epVm = new EditPersonneViewModel();
            epVm.Personne = personne;
            
            epVm.Roles = repoRole.Roles;
            return View(epVm);
        }

        //
        // POST: /Personne/Edit/5

        [HttpPost]
        public ViewResult Edit(EditPersonneViewModel editpersonne)
        {
            int i = 0;
                if (ModelState.IsValid)
                {
                    
                    /*repository.SavePersonne();
                    TempData["message"] = string.Format("{0} a été sauvegardé", product.Name);*/
                    return View(editpersonne);
                }
                else
                {
                    editpersonne.Roles = repoRole.Roles;
                    return View(editpersonne);
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
