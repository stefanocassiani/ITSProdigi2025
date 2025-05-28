using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebChat.Migrations
{
    /// <inheritdoc />
    public partial class Seconda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_messaggi_utenti_DestinatarioIdUtente",
                table: "messaggi");

            migrationBuilder.DropForeignKey(
                name: "FK_messaggi_utenti_MittenteIdUtente",
                table: "messaggi");

            migrationBuilder.AlterColumn<uint>(
                name: "MittenteIdUtente",
                table: "messaggi",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(uint),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<uint>(
                name: "DestinatarioIdUtente",
                table: "messaggi",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(uint),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_messaggi_utenti_DestinatarioIdUtente",
                table: "messaggi",
                column: "DestinatarioIdUtente",
                principalTable: "utenti",
                principalColumn: "IdUtente",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_messaggi_utenti_MittenteIdUtente",
                table: "messaggi",
                column: "MittenteIdUtente",
                principalTable: "utenti",
                principalColumn: "IdUtente",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_messaggi_utenti_DestinatarioIdUtente",
                table: "messaggi");

            migrationBuilder.DropForeignKey(
                name: "FK_messaggi_utenti_MittenteIdUtente",
                table: "messaggi");

            migrationBuilder.AlterColumn<uint>(
                name: "MittenteIdUtente",
                table: "messaggi",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0u,
                oldClrType: typeof(uint),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<uint>(
                name: "DestinatarioIdUtente",
                table: "messaggi",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0u,
                oldClrType: typeof(uint),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_messaggi_utenti_DestinatarioIdUtente",
                table: "messaggi",
                column: "DestinatarioIdUtente",
                principalTable: "utenti",
                principalColumn: "IdUtente",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_messaggi_utenti_MittenteIdUtente",
                table: "messaggi",
                column: "MittenteIdUtente",
                principalTable: "utenti",
                principalColumn: "IdUtente",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
