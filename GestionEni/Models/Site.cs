namespace GestionEni.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Site")]
    public partial class Site
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Site()
        {
            Formation = new HashSet<Formation>();
        }

        [Key]
        public int IdSite { get; set; }

        [Required]
        [StringLength(150)]
        public string ville { get; set; }

        [StringLength(200)]
        public string adresse { get; set; }

        [StringLength(15)]
        public string fax { get; set; }

        [Required]
        [StringLength(15)]
        public string telephone { get; set; }

        public int codepostal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Formation> Formation { get; set; }
    }
}
