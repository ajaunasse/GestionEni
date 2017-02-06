namespace GestionEni.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=ModelGestionEni")
        {
        }

        public virtual DbSet<Cursus> Cursus { get; set; }
        public virtual DbSet<Formation> Formation { get; set; }
        public virtual DbSet<Personne> Personne { get; set; }
        public virtual DbSet<Personne_Formation> Personne_Formation { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Site> Site { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cursus>()
                .HasMany(e => e.Formation)
                .WithOptional(e => e.Cursus1)
                .HasForeignKey(e => e.Cursus);

            modelBuilder.Entity<Cursus>()
                .HasMany(e => e.Personne)
                .WithOptional(e => e.Cursus1)
                .HasForeignKey(e => e.Cursus)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Personne>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<Personne>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Personne>()
                .Property(e => e.lastname)
                .IsUnicode(false);

            modelBuilder.Entity<Personne>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<Personne>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Personne)
                .WithRequired(e => e.Role1)
                .HasForeignKey(e => e.Role);

            modelBuilder.Entity<Site>()
                .Property(e => e.adresse)
                .IsFixedLength();

            modelBuilder.Entity<Site>()
                .Property(e => e.fax)
                .IsFixedLength();

            modelBuilder.Entity<Site>()
                .Property(e => e.telephone)
                .IsFixedLength();

            modelBuilder.Entity<Site>()
                .HasMany(e => e.Formation)
                .WithRequired(e => e.Site1)
                .HasForeignKey(e => e.Site)
                .WillCascadeOnDelete(false);
        }
    }
}
