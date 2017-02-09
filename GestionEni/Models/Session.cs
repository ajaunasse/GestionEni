namespace GestionEni.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Session")]
    public partial class Session
    {
        public Session()
        {
            Stagiaires1 = new HashSet<Personne>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdSession { get; set; }

        [Required(ErrorMessage = "Entrez une date de début")]
        public DateTime dateDebut { get; set; }

        [Required(ErrorMessage = "Entrez une date de fin")]
        public DateTime dateFin { get; set; }

        [Required(ErrorMessage = "Entrez un formateur")]
        public int formateur { get; set; }

        [Required(ErrorMessage = "Entrez une formation")]
        public int formation { get; set; }

        public virtual Formation Formation1 { get; set; }

        public virtual Personne Formateur1 { get; set; }

        public virtual ICollection<Personne> Stagiaires1 { get; set; }
    }
}
