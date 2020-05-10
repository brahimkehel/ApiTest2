using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace coreTest3Api.Models
{
    public partial class Pfa_dbContext : DbContext
    {
        public Pfa_dbContext()
        {
        }

        public Pfa_dbContext(DbContextOptions<Pfa_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Absence> Absence { get; set; }
        public virtual DbSet<Administrateur> Administrateur { get; set; }
        public virtual DbSet<AnneeScolaire> AnneeScolaire { get; set; }
        public virtual DbSet<Classe> Classe { get; set; }
        public virtual DbSet<Enseignant> Enseignant { get; set; }
        public virtual DbSet<Etudiant> Etudiant { get; set; }
        public virtual DbSet<Filiere> Filiere { get; set; }
        public virtual DbSet<Matiere> Matiere { get; set; }
        public virtual DbSet<Seance> Seance { get; set; }
        public virtual DbSet<Utilisateur> Utilisateur { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("server=MIC;database=Pfa_db;integrated security=true");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Absence>(entity =>
            {
                entity.Property(e => e.Date)
                    .HasColumnName("_Date")
                    .HasColumnType("date");

                entity.Property(e => e.IdEtud).HasColumnName("Id_Etud");

                entity.Property(e => e.IdSeance).HasColumnName("Id_Seance");

                entity.HasOne(d => d.IdEtudNavigation)
                    .WithMany(p => p.Absence)
                    .HasForeignKey(d => d.IdEtud)
                    .HasConstraintName("FK__Absence__Id_Etud__2B3F6F97");

                entity.HasOne(d => d.IdSeanceNavigation)
                    .WithMany(p => p.Absence)
                    .HasForeignKey(d => d.IdSeance)
                    .HasConstraintName("FK__Absence__Id_Sean__2C3393D0");
            });

            modelBuilder.Entity<Administrateur>(entity =>
            {
                entity.Property(e => e.Adresse)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cin)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cne)
                    .HasColumnName("CNE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateNais)
                    .HasColumnName("Date_nais")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Genre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nom)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Prenom)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AnneeScolaire>(entity =>
            {
                entity.ToTable("Annee_Scolaire");

                entity.Property(e => e.Annee)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Classe>(entity =>
            {
                entity.Property(e => e.IdAnnee).HasColumnName("Id_Annee");

                entity.Property(e => e.IdFiliere).HasColumnName("Id_Filiere");

                entity.Property(e => e.Libelle)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAnneeNavigation)
                    .WithMany(p => p.Classe)
                    .HasForeignKey(d => d.IdAnnee)
                    .HasConstraintName("FK__Classe__Id_Annee__145C0A3F");

                entity.HasOne(d => d.IdFiliereNavigation)
                    .WithMany(p => p.Classe)
                    .HasForeignKey(d => d.IdFiliere)
                    .HasConstraintName("FK__Classe__Id_Filie__15502E78");
            });

            modelBuilder.Entity<Enseignant>(entity =>
            {
                entity.Property(e => e.Adresse)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cin)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cnss)
                    .HasColumnName("CNSS")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateEmb)
                    .HasColumnName("Date_Emb")
                    .HasColumnType("date");

                entity.Property(e => e.DateNais)
                    .HasColumnName("Date_nais")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Genre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nom)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Prenom)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Etudiant>(entity =>
            {
                entity.Property(e => e.Adresse)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cin)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cne)
                    .HasColumnName("CNE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateNais)
                    .HasColumnName("Date_nais")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Genre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdFiliere).HasColumnName("Id_Filiere");

                entity.Property(e => e.MotdePasse)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nom)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Prenom)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdFiliereNavigation)
                    .WithMany(p => p.Etudiant)
                    .HasForeignKey(d => d.IdFiliere)
                    .HasConstraintName("FK__Etudiant__Id_Fil__1920BF5C");
            });

            modelBuilder.Entity<Filiere>(entity =>
            {
                entity.Property(e => e.Libelle)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Matiere>(entity =>
            {
                entity.Property(e => e.IdEns).HasColumnName("Id_Ens");

                entity.Property(e => e.Libelle)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEnsNavigation)
                    .WithMany(p => p.Matiere)
                    .HasForeignKey(d => d.IdEns)
                    .HasConstraintName("FK__Matiere__Id_Ens__21B6055D");
            });

            modelBuilder.Entity<Seance>(entity =>
            {
                entity.Property(e => e.Date)
                    .HasColumnName("_Date")
                    .HasColumnType("date");

                entity.Property(e => e.IdClasse).HasColumnName("Id_Classe");

                entity.Property(e => e.IdEns).HasColumnName("Id_Ens");

                entity.Property(e => e.IdMat).HasColumnName("Id_Mat");

                entity.Property(e => e.Sujet)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClasseNavigation)
                    .WithMany(p => p.Seance)
                    .HasForeignKey(d => d.IdClasse)
                    .HasConstraintName("FK__Seance__Id_Class__24927208");

                entity.HasOne(d => d.IdEnsNavigation)
                    .WithMany(p => p.Seance)
                    .HasForeignKey(d => d.IdEns)
                    .HasConstraintName("FK__Seance__Id_Ens__25869641");

                entity.HasOne(d => d.IdMatNavigation)
                    .WithMany(p => p.Seance)
                    .HasForeignKey(d => d.IdMat)
                    .HasConstraintName("FK__Seance__Id_Mat__267ABA7A");
            });

            modelBuilder.Entity<Utilisateur>(entity =>
            {
                entity.HasKey(e => e.IdUti)
                    .HasName("PK__Utilisat__52A339DC65BDC8AA");

                entity.Property(e => e.IdUti).HasColumnName("Id_Uti");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MotdePasse)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("_Status")
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.Nom)
                    .HasColumnName("Nom")
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.Prenom)
                    .HasColumnName("Prenom")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
