using GestionEni.Context;
using GestionEni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace GestionEni.Controllers
{
    public class SessionController : Controller
    {

        private EFSessionRepository repository;
        EFFormationRepository repoFormation = new EFFormationRepository();
        EFPersonneRepository repoPersonne = new EFPersonneRepository();

        //
        // GET: /Session/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Session/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Session/Create

        public ActionResult Create(Formation formation)
        {
            SessionViewModel sVm = new SessionViewModel();
            sVm.Session =  new Session();
            sVm.Formateurs = repoPersonne.Personnes.Where(x => x.Role1.IdRole == 2);
            sVm.Session.formation = formation.IdFormation;
            sVm.Session.Formation1 = formation ;
            sVm.Stagiaires = repoPersonne.Personnes.Where(x => x.Role1.IdRole == 1);

            return View(sVm);
        }

        //
        // POST: /Session/Create

        [HttpPost]
        public ActionResult Create(SessionViewModel sVm)
        {
            try
            {
                repository = new EFSessionRepository();
                Session session = sVm.Session;
                if (sVm.SelectedStagiaires != null)
                {
                    foreach (var personneId in sVm.SelectedStagiaires)
                    {
                        Personne stag = repoPersonne.Personnes.Where(x => x.IdPersonne == personneId).First();
                        session.Stagiaires1.Add(stag);
                    }
                }
                repository.SaveSession(session);
                return RedirectToRoute("detail_formation", new { id = sVm.formation.IdFormation } );
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Session/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Session/Edit/5

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
        // GET: /Session/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Session/Delete/5

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
