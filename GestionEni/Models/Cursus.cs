namespace GestionEni.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

    public partial class Cursus
    {
        public Cursus()
        {
            Formation = new HashSet<Formation>();
            Personne = new HashSet<Personne>();
        }

        [Key]
        public int IdCursus { get; set; }

        [Required]
        [StringLength(150)]
        public string libelle { get; set; }

        [AllowHtml]
        public string description { get; set; }

        public string niveauEtude { get; set; }


        public virtual ICollection<Formation> Formation { get; set; }

        public virtual ICollection<Personne> Personne { get; set; }
    }
}
