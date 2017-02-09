namespace GestionEni.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Role")]
    public partial class Role
    {
        public Role()
        {
            Personne = new HashSet<Personne>();
        }

        [Key]
        public int IdRole { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Entrez un libelle")]
        public string libelle { get; set; }

        public virtual ICollection<Personne> Personne { get; set; }
    }
}
