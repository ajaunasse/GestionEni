using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionEni.Models
{
    public class EditPersonneViewModel
    {
        public IEnumerable<Role> Roles { get; set; }
        public Personne Personne { get; set; }
        private IEnumerable<SelectListItem> selectList;

        public IEnumerable<SelectListItem> SelectList
        {
            get {
                selectList = new SelectListItem[] { };
                foreach (Role r in Roles)
                {
                    SelectListItem slc = new SelectListItem();

                    slc.Text = r.libelle;
                    slc.Value = r.IdRole.ToString();
                    selectList = selectList.Concat(new SelectListItem[] { slc });
                }

                return selectList; 
            
            }
        }


    }
}