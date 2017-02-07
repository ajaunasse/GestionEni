namespace GestionEni.Context
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using GestionEni.Models;

    public partial class EFDbContext : DbContext
    {
        public EFDbContext()
            : base("name=ModelGestionEni")
        {
        }

        public virtual DbSet<Cursus> Cursuss { get; set; }
        public virtual DbSet<Formation> Formations { get; set; }
        public virtual DbSet<Personne> Personnes { get; set; }
        public virtual DbSet<Personne_Formation> Personne_Formations { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Site> Sites { get; set; }

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
