using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebChat.Migrations
{
    /// <inheritdoc />
    public partial class Prima : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "utenti",
                columns: table => new
                {
                    IdUtente = table.Column<uint>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_utenti", x => x.IdUtente);
                });

            migrationBuilder.CreateTable(
                name: "messaggi",
                columns: table => new
                {
                    IdMessaggio = table.Column<uint>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MittenteIdUtente = table.Column<uint>(type: "INTEGER", nullable: false),
                    DestinatarioIdUtente = table.Column<uint>(type: "INTEGER", nullable: false),
                    Corpo = table.Column<string>(type: "TEXT", nullable: false),
                    Quando = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_messaggi", x => x.IdMessaggio);
                    table.ForeignKey(
                        name: "FK_messaggi_utenti_DestinatarioIdUtente",
                        column: x => x.DestinatarioIdUtente,
                        principalTable: "utenti",
                        principalColumn: "IdUtente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_messaggi_utenti_MittenteIdUtente",
                        column: x => x.MittenteIdUtente,
                        principalTable: "utenti",
                        principalColumn: "IdUtente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_messaggi_DestinatarioIdUtente",
                table: "messaggi",
                column: "DestinatarioIdUtente");

            migrationBuilder.CreateIndex(
                name: "IX_messaggi_MittenteIdUtente",
                table: "messaggi",
                column: "MittenteIdUtente");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "messaggi");

            migrationBuilder.DropTable(
                name: "utenti");
        }
    }
}
