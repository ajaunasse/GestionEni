namespace GestionEni.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("Personne")]
    public partial class Personne
    {
        public Personne()
        {
            Personne_Formation = new HashSet<Personne_Formation>();
        }

        [Key]
        public int IdPersonne { get; set; }

        [Required(ErrorMessage = "Entrez votre Nom d'utilisateur")]
        [StringLength(50)]
        public string username { get; set; }

        [Required(ErrorMessage = "Entrez un mot de passe")]
        [StringLength(50)]
        public string password { get; set; }

        [StringLength(50)]
        public string lastname { get; set; }

        [StringLength(50)]
        public string firstname { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "Entrez votre Adresse Mail")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Rentrez un mail valide")]
        public string email { get; set; }

        public int Role { get; set; }

        public int? Cursus { get; set; }

        public virtual Cursus Cursus1 { get; set; }

        public virtual ICollection<Personne_Formation> Personne_Formation { get; set; }
         
        public virtual Role Role1 { get; set; }
    }
}
