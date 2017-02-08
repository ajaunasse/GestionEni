using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionEni.Models
{
    public class FormationViewModel
    {
        public IEnumerable<Cursus> Cursus { get; set; }
        public IEnumerable<Site> Site { get; set; }
        public Formation Formation { get; set; }
        private IEnumerable<SelectListItem> selectListCursus;
        private IEnumerable<SelectListItem> selectListSite;

        public IEnumerable<SelectListItem> SelectListCursus
        {
            get
            {
                selectListCursus = new SelectListItem[] { };
                foreach (Cursus c in Cursus)
                {
                    SelectListItem slc = new SelectListItem();

                    slc.Text = c.libelle;
                    slc.Value = c.IdCursus.ToString();
                    selectListCursus = selectListCursus.Concat(new SelectListItem[] { slc });
                }

                return selectListCursus;

            }
        }

        public IEnumerable<SelectListItem> SelectListSite
        {
            get
            {
                selectListSite = new SelectListItem[] { };
                foreach (Site s in Site)
                {
                    SelectListItem slc = new SelectListItem();

                    slc.Text = s.ville;
                    slc.Value = s.IdSite.ToString();
                    selectListSite = selectListSite.Concat(new SelectListItem[] { slc });
                }

                return selectListSite;

            }
        }
    }
}