﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Poulina.GestionMs.Data.Context;

namespace Poulina.GestionMs.Data.Migrations
{
    [DbContext(typeof(GestionMSContext))]
    partial class GestionMSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Poulina.GestionMS.Domain.Models.Domaine", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nom");

                    b.HasKey("Id");

                    b.ToTable("Domaine");
                });

            modelBuilder.Entity("Poulina.GestionMS.Domain.Models.Language", b =>
                {
                    b.Property<Guid>("LDV")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Label");

                    b.Property<Guid?>("VersionsIDV");

                    b.HasKey("LDV");

                    b.HasIndex("VersionsIDV");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("Poulina.GestionMS.Domain.Models.MS", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<string>("Description");

                    b.Property<string>("DiagClass");

                    b.Property<Guid>("DomaineFK");

                    b.Property<string>("Label");

                    b.Property<Guid>("LanguageFK");

                    b.Property<string>("Lien");

                    b.HasKey("Id");

                    b.HasIndex("DomaineFK");

                    b.HasIndex("LanguageFK");

                    b.ToTable("Microservice");
                });

            modelBuilder.Entity("Poulina.GestionMS.Domain.Models.Methode", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Input");

                    b.Property<Guid>("MSFK");

                    b.Property<string>("Nom");

                    b.Property<string>("Output");

                    b.HasKey("Id");

                    b.HasIndex("MSFK");

                    b.ToTable("Methodes");
                });

            modelBuilder.Entity("Poulina.GestionMS.Domain.Models.VersionLanguage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("IDV");

                    b.Property<Guid>("LDV");

                    b.HasKey("Id");

                    b.HasIndex("IDV");

                    b.HasIndex("LDV");

                    b.ToTable("VersionLanguage");
                });

            modelBuilder.Entity("Poulina.GestionMS.Domain.Models.Versions", b =>
                {
                    b.Property<Guid>("IDV")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Numero");

                    b.Property<Guid>("VerFK");

                    b.HasKey("IDV");

                    b.ToTable("Versions");
                });

            modelBuilder.Entity("Poulina.GestionMS.Domain.Models.Language", b =>
                {
                    b.HasOne("Poulina.GestionMS.Domain.Models.Versions")
                        .WithMany("Languages")
                        .HasForeignKey("VersionsIDV");
                });

            modelBuilder.Entity("Poulina.GestionMS.Domain.Models.MS", b =>
                {
                    b.HasOne("Poulina.GestionMS.Domain.Models.Domaine", "Domaine")
                        .WithMany("Microservice")
                        .HasForeignKey("DomaineFK")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Poulina.GestionMS.Domain.Models.Language", "Language")
                        .WithMany("Microservice")
                        .HasForeignKey("LanguageFK")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Poulina.GestionMS.Domain.Models.Methode", b =>
                {
                    b.HasOne("Poulina.GestionMS.Domain.Models.MS", "Microservice")
                        .WithMany("Methodes")
                        .HasForeignKey("MSFK")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Poulina.GestionMS.Domain.Models.VersionLanguage", b =>
                {
                    b.HasOne("Poulina.GestionMS.Domain.Models.Versions", "Versions")
                        .WithMany("VersionLanguages")
                        .HasForeignKey("IDV")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Poulina.GestionMS.Domain.Models.Language", "Languages")
                        .WithMany("VersionLanguages")
                        .HasForeignKey("LDV")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
