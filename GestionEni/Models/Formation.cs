namespace GestionEni.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Formation")]
    public partial class Formation
    {
        public Formation()
        {
            Session = new HashSet<Session>();
        }

        [Key]
        public int IdFormation { get; set; }

        [StringLength(200)]
        [Required(ErrorMessage = "Entrez un libelle")]
        public string libelle { get; set; }

        public string description { get; set; }

        public int? Cursus { get; set; }

        public int Site { get; set; }

        public virtual Cursus Cursus1 { get; set; }

        public virtual ICollection<Session> Session { get; set; }

        public virtual Site Site1 { get; set; }
    }
}
