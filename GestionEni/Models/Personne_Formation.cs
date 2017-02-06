namespace GestionEni.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Personne_Formation
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdPersonne { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdFormation { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime dateFormation { get; set; }

        public virtual Formation Formation { get; set; }

        public virtual Personne Personne { get; set; }
    }
}
