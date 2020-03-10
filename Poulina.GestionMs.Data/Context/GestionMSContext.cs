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
        public DbSet<Versions> Domaines { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Methode> Methodes { get; set; }
        public DbSet<Versions> Versions { get; set; }
        public VersionLanguage VersionLanguages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MS>(entity => entity.HasKey(d => d.Id));
            modelBuilder.Entity<Versions>(entity => entity.HasKey(d => d.IDV));
            modelBuilder.Entity<Language>(entity => entity.HasKey(d => d.LDV));
            modelBuilder.Entity<Domaine>(entity => entity.HasKey(d => d.Id));
            modelBuilder.Entity<Methode>(entity => entity.HasKey(d => d.Id));
            modelBuilder.Entity<VersionLanguage>(entity => entity.HasKey(d => d.Id));

            modelBuilder.Entity<MS>()
                .HasOne(e => e.Domaine)
                .WithMany(s => s.Microservice)
                 .HasForeignKey(p => p.DomaineFK); //one to many
           
            modelBuilder.Entity<Methode>()
            .HasOne(e => e.Microservice)
            .WithMany(s => s.Methodes)
             .HasForeignKey(p => p.MSFK); //one to many
          
            modelBuilder.Entity<MS>()
          .HasOne(e => e.Language)
          .WithMany(s => s.Microservice)
           .HasForeignKey(p => p.LanguageFK); //one to many

            modelBuilder.Entity<VersionLanguage>()
            .HasOne(e => e.Versions)
            .WithMany(s => s.VersionLanguages)
             .HasForeignKey(p => p.IDV); //many to many
           
            modelBuilder.Entity<VersionLanguage>()
          .HasOne(e => e.Languages)
          .WithMany(s => s.VersionLanguages)
           .HasForeignKey(p => p.LDV); //many to many
            base.OnModelCreating(modelBuilder);
            hhhhhhhh
        }
    }
}
     
