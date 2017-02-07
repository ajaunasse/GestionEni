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
            Personne_Formation = new HashSet<Personne_Formation>();
        }

        [Key]
        public int IdFormation { get; set; }

        [Required]
        [StringLength(200)]
        public string libelle { get; set; }

        public string description { get; set; }

        public int? Cursus { get; set; }

        public int Site { get; set; }

        public virtual Cursus Cursus1 { get; set; }

        public virtual Site Site1 { get; set; }

        public virtual ICollection<Personne_Formation> Personne_Formation { get; set; }
    }
}
