namespace GestionEni.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EFDbContext : DbContext
    {
        public EFDbContext()
            : base("name=GestionEni")
        {
        }

        public virtual DbSet<Cursus> Cursus { get; set; }
        public virtual DbSet<Formation> Formations { get; set; }
        public virtual DbSet<Personne> Personnes { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }
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

            modelBuilder.Entity<Formation>()
                .HasMany(e => e.Session)
                .WithRequired(e => e.Formation1)
                .HasForeignKey(e => e.formation)
                .WillCascadeOnDelete(false);

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

            modelBuilder.Entity<Personne>()
                .HasMany(e => e.Session)
                .WithRequired(e => e.Formateur1)
                .HasForeignKey(e => e.formateur)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Personne)
                .WithRequired(e => e.Role1)
                .HasForeignKey(e => e.Role);

            modelBuilder.Entity<Session>()
                .HasMany(e => e.Stagiaires1)
                .WithMany(e => e.Session1)
                .Map(m => m.ToTable("Session_Stagiaires").MapLeftKey("IdSession").MapRightKey("IdStagiaire"));

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
