namespace GestionEni.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Personne")]
    public partial class Personne
    {
        public Personne()
        {
            Session = new HashSet<Session>();
            Session1 = new HashSet<Session>();
        }

        [Key]
        public int IdPersonne { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Entrez un nom d'utilisateur")]
        public string username { get; set; }

        [Required]
        [StringLength(50)]
        public string password { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Entrez un nom")]
        public string lastname { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Entrez un prénom")]
        public string firstname { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "Entrez votre Adresse Mail")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Rentrez un mail valide")]
        public string email { get; set; }

        public int Role { get; set; }

        public int? Cursus { get; set; }

        public virtual Cursus Cursus1 { get; set; }

        public virtual ICollection<Session> Session { get; set; }

        public virtual Role Role1 { get; set; }

        public virtual ICollection<Session> Session1 { get; set; }
    }
}
