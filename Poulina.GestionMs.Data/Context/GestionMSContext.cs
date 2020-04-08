using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Poulina.GestionMS.Domain.Models;


namespace Poulina.GestionMs.Data.Context
{
   public class GestionMSContext : DbContext
    {
        public GestionMSContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<MS> Microservice { get; set; }
        public DbSet<Domaine> Domaine { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Methode> Methodes { get; set; }
        public DbSet<Versions> Versions { get; set; }
        public DbSet<Projet> Projets { get; set; }

        public VersionLanguage LanguageVersions { get; set; }
        public ProjetDomain ProjetDomains { get; set; }
        public ProjetMS ProjetMs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MS>(entity => entity.HasKey(d => d.IdMS));
            modelBuilder.Entity<Versions>(entity => entity.HasKey(d => d.IDversion));
            modelBuilder.Entity<Language>(entity => entity.HasKey(d => d.IdL));
            modelBuilder.Entity<Domaine>(entity => entity.HasKey(d => d.IdDomaine));
            modelBuilder.Entity<Methode>(entity => entity.HasKey(d => d.IdMethod));
            modelBuilder.Entity<Projet>(entity => entity.HasKey(d => d.IdProjet));

            modelBuilder.Entity<VersionLanguage>(entity => entity.HasKey(d => d.Id));
            modelBuilder.Entity<ProjetMS>(entity => entity.HasKey(d => d.Id));
            modelBuilder.Entity<ProjetDomain>(entity => entity.HasKey(d => d.Id));

            //Method
            modelBuilder.Entity<Methode>()
           .HasOne(e => e.Microservices)
           .WithMany(s => s.Methods)
            .HasForeignKey(p => p.FK_MS); //one to many

            //Microservice
            modelBuilder.Entity<MS>()
            .HasOne(e => e.Languages)
            .WithMany(s => s.Microservices)
            .HasForeignKey(p => p.LanguageFK); //one to many

            //LanguageVersion
            modelBuilder.Entity<VersionLanguage>()
          .HasOne(e => e.Versions)
          .WithMany(s => s.LanguageVersions)
           .HasForeignKey(p => p.FK_V); //many to many

            modelBuilder.Entity<VersionLanguage>()
          .HasOne(e => e.Languages)
          .WithMany(s => s.LanguageVersions)
           .HasForeignKey(p => p.FK_L); //many to many
            base.OnModelCreating(modelBuilder);

            //ProjetDomain
            modelBuilder.Entity<ProjetDomain>()
    .HasOne(e => e.Projets)
    .WithMany(s => s.ProjetDomains)
     .HasForeignKey(p => p.IdProjet); //many to many

            modelBuilder.Entity<ProjetDomain>()
          .HasOne(e => e.Domaine)
          .WithMany(s => s.ProjetDomains)
           .HasForeignKey(p => p.IdDomaine); //many to many
            base.OnModelCreating(modelBuilder);
            //ProjetMS

            modelBuilder.Entity<ProjetMS>()
     .HasOne(e => e.Projets)
     .WithMany(s => s.ProjetMs)
      .HasForeignKey(p => p.IdProjet); //many to many

            modelBuilder.Entity<ProjetMS>()
          .HasOne(e => e.Microservices)
          .WithMany(s => s.ProjetMs)
           .HasForeignKey(p => p.IdMS); //many to many
            base.OnModelCreating(modelBuilder);
        }
    }
}
