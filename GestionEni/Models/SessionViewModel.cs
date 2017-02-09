using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionEni.Models
{
    public class SessionViewModel
    {
        public Session Session { get; set; }
        public IEnumerable<Personne> Formateurs { get; set; }
        public IEnumerable<Personne> Stagiaires { get; set; }
        public List<int> SelectedStagiaires { get; set; }
        public Formation formation { get; set; }


        private IEnumerable<SelectListItem> selectFormateurs;
        private IEnumerable<SelectListItem> selectStagiaires;


        public IEnumerable<SelectListItem> SelectFormateurs
        {
            get
            {
                selectFormateurs = new SelectListItem[] { };
                foreach (Personne f in Formateurs)
                {
                    SelectListItem slc = new SelectListItem();

                    slc.Text = f.firstname + " " + f.lastname;
                    slc.Value = f.IdPersonne.ToString();
                    selectFormateurs = selectFormateurs.Concat(new SelectListItem[] { slc });
                }

                return selectFormateurs;

            }
        }

        public IEnumerable<SelectListItem> SelectStagiaires
        {
            get
            {
                selectStagiaires = new SelectListItem[] { };
                foreach (Personne s in Stagiaires)
                {
                    SelectListItem slc = new SelectListItem();

                    slc.Text = s.firstname + " " + s.lastname;
                    slc.Value = s.IdPersonne.ToString();
                    selectStagiaires = selectStagiaires.Concat(new SelectListItem[] { slc });
                }

                return selectStagiaires;

            }
        }
    }
}