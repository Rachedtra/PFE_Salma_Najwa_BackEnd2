using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Poulina.GestionMs.Data.Migrations
{
    public partial class Micro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Domaine",
                columns: table => new
                {
                    IdDomaine = table.Column<Guid>(nullable: false),
                    Nom = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domaine", x => x.IdDomaine);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    IdL = table.Column<Guid>(nullable: false),
                    Label = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.IdL);
                });

            migrationBuilder.CreateTable(
                name: "Projets",
                columns: table => new
                {
                    IdProjet = table.Column<Guid>(nullable: false),
                    Nom = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projets", x => x.IdProjet);
                });

            migrationBuilder.CreateTable(
                name: "Versions",
                columns: table => new
                {
                    IDversion = table.Column<Guid>(nullable: false),
                    Numero = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Versions", x => x.IDversion);
                });

            migrationBuilder.CreateTable(
                name: "Microservice",
                columns: table => new
                {
                    IdMS = table.Column<Guid>(nullable: false),
                    Label = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    Lien = table.Column<string>(nullable: true),
                    DiagClass = table.Column<string>(nullable: true),
                    LanguageFK = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Microservice", x => x.IdMS);
                    table.ForeignKey(
                        name: "FK_Microservice_Languages_LanguageFK",
                        column: x => x.LanguageFK,
                        principalTable: "Languages",
                        principalColumn: "IdL",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjetDomain",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IdDomaine = table.Column<Guid>(nullable: false),
                    IdProjet = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjetDomain", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjetDomain_Domaine_IdDomaine",
                        column: x => x.IdDomaine,
                        principalTable: "Domaine",
                        principalColumn: "IdDomaine",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjetDomain_Projets_IdProjet",
                        column: x => x.IdProjet,
                        principalTable: "Projets",
                        principalColumn: "IdProjet",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VersionLanguage",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IdL = table.Column<Guid>(nullable: false),
                    IdVersion = table.Column<Guid>(nullable: false),
                    FK_V = table.Column<Guid>(nullable: false),
                    FK_L = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VersionLanguage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VersionLanguage_Languages_FK_L",
                        column: x => x.FK_L,
                        principalTable: "Languages",
                        principalColumn: "IdL",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VersionLanguage_Versions_FK_V",
                        column: x => x.FK_V,
                        principalTable: "Versions",
                        principalColumn: "IDversion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Methodes",
                columns: table => new
                {
                    IdMethod = table.Column<Guid>(nullable: false),
                    Nom = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Input = table.Column<string>(nullable: true),
                    Output = table.Column<string>(nullable: true),
                    FK_MS = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Methodes", x => x.IdMethod);
                    table.ForeignKey(
                        name: "FK_Methodes_Microservice_FK_MS",
                        column: x => x.FK_MS,
                        principalTable: "Microservice",
                        principalColumn: "IdMS",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjetMS",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IdProjet = table.Column<Guid>(nullable: false),
                    IdMS = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjetMS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjetMS_Microservice_IdMS",
                        column: x => x.IdMS,
                        principalTable: "Microservice",
                        principalColumn: "IdMS",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjetMS_Projets_IdProjet",
                        column: x => x.IdProjet,
                        principalTable: "Projets",
                        principalColumn: "IdProjet",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Methodes_FK_MS",
                table: "Methodes",
                column: "FK_MS");

            migrationBuilder.CreateIndex(
                name: "IX_Microservice_LanguageFK",
                table: "Microservice",
                column: "LanguageFK");

            migrationBuilder.CreateIndex(
                name: "IX_ProjetDomain_IdDomaine",
                table: "ProjetDomain",
                column: "IdDomaine");

            migrationBuilder.CreateIndex(
                name: "IX_ProjetDomain_IdProjet",
                table: "ProjetDomain",
                column: "IdProjet");

            migrationBuilder.CreateIndex(
                name: "IX_ProjetMS_IdMS",
                table: "ProjetMS",
                column: "IdMS");

            migrationBuilder.CreateIndex(
                name: "IX_ProjetMS_IdProjet",
                table: "ProjetMS",
                column: "IdProjet");

            migrationBuilder.CreateIndex(
                name: "IX_VersionLanguage_FK_L",
                table: "VersionLanguage",
                column: "FK_L");

            migrationBuilder.CreateIndex(
                name: "IX_VersionLanguage_FK_V",
                table: "VersionLanguage",
                column: "FK_V");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Methodes");

            migrationBuilder.DropTable(
                name: "ProjetDomain");

            migrationBuilder.DropTable(
                name: "ProjetMS");

            migrationBuilder.DropTable(
                name: "VersionLanguage");

            migrationBuilder.DropTable(
                name: "Domaine");

            migrationBuilder.DropTable(
                name: "Microservice");

            migrationBuilder.DropTable(
                name: "Projets");

            migrationBuilder.DropTable(
                name: "Versions");

            migrationBuilder.DropTable(
                name: "Languages");
        }
    }
}
