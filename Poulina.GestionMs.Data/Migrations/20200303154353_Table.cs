using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Poulina.GestionMs.Data.Migrations
{
    public partial class Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Domaine",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nom = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domaine", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Versions",
                columns: table => new
                {
                    IDV = table.Column<Guid>(nullable: false),
                    Numero = table.Column<int>(nullable: false),
                    VerFK = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Versions", x => x.IDV);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    LDV = table.Column<Guid>(nullable: false),
                    Label = table.Column<string>(nullable: true),
                    VersionsIDV = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.LDV);
                    table.ForeignKey(
                        name: "FK_Languages_Versions_VersionsIDV",
                        column: x => x.VersionsIDV,
                        principalTable: "Versions",
                        principalColumn: "IDV",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Microservice",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Label = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    Lien = table.Column<string>(nullable: true),
                    DiagClass = table.Column<string>(nullable: true),
                    DomaineFK = table.Column<Guid>(nullable: false),
                    LanguageFK = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Microservice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Microservice_Domaine_DomaineFK",
                        column: x => x.DomaineFK,
                        principalTable: "Domaine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Microservice_Languages_LanguageFK",
                        column: x => x.LanguageFK,
                        principalTable: "Languages",
                        principalColumn: "LDV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VersionLanguage",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IDV = table.Column<Guid>(nullable: false),
                    LDV = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VersionLanguage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VersionLanguage_Versions_IDV",
                        column: x => x.IDV,
                        principalTable: "Versions",
                        principalColumn: "IDV",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VersionLanguage_Languages_LDV",
                        column: x => x.LDV,
                        principalTable: "Languages",
                        principalColumn: "LDV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Methodes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nom = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Input = table.Column<string>(nullable: true),
                    Output = table.Column<string>(nullable: true),
                    MSFK = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Methodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Methodes_Microservice_MSFK",
                        column: x => x.MSFK,
                        principalTable: "Microservice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Languages_VersionsIDV",
                table: "Languages",
                column: "VersionsIDV");

            migrationBuilder.CreateIndex(
                name: "IX_Methodes_MSFK",
                table: "Methodes",
                column: "MSFK");

            migrationBuilder.CreateIndex(
                name: "IX_Microservice_DomaineFK",
                table: "Microservice",
                column: "DomaineFK");

            migrationBuilder.CreateIndex(
                name: "IX_Microservice_LanguageFK",
                table: "Microservice",
                column: "LanguageFK");

            migrationBuilder.CreateIndex(
                name: "IX_VersionLanguage_IDV",
                table: "VersionLanguage",
                column: "IDV");

            migrationBuilder.CreateIndex(
                name: "IX_VersionLanguage_LDV",
                table: "VersionLanguage",
                column: "LDV");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Methodes");

            migrationBuilder.DropTable(
                name: "VersionLanguage");

            migrationBuilder.DropTable(
                name: "Microservice");

            migrationBuilder.DropTable(
                name: "Domaine");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Versions");
        }
    }
}
