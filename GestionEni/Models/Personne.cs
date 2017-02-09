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

        [Required]
        [StringLength(50)]
        public string username { get; set; }

        [Required]
        [StringLength(50)]
        public string password { get; set; }

        [StringLength(50)]
        public string lastname { get; set; }

        [StringLength(50)]
        public string firstname { get; set; }

        [StringLength(150)]
        public string email { get; set; }

        public int Role { get; set; }

        public int? Cursus { get; set; }

        public virtual Cursus Cursus1 { get; set; }

        public virtual ICollection<Session> Session { get; set; }

        public virtual Role Role1 { get; set; }

        public virtual ICollection<Session> Session1 { get; set; }
    }
}
