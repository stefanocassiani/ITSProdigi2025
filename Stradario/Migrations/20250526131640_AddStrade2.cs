using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stradario.Migrations
{
    /// <inheritdoc />
    public partial class AddStrade2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_strade_nodi_AidNodo",
                table: "strade");

            migrationBuilder.DropIndex(
                name: "IX_strade_AidNodo",
                table: "strade");

            migrationBuilder.DropColumn(
                name: "AidNodo",
                table: "strade");

            migrationBuilder.AlterColumn<uint>(
                name: "IdStrada",
                table: "strade",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddForeignKey(
                name: "FK_strade_nodi_IdStrada",
                table: "strade",
                column: "IdStrada",
                principalTable: "nodi",
                principalColumn: "idNodo",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_strade_nodi_IdStrada",
                table: "strade");

            migrationBuilder.AlterColumn<uint>(
                name: "IdStrada",
                table: "strade",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<uint>(
                name: "AidNodo",
                table: "strade",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0u);

            migrationBuilder.CreateIndex(
                name: "IX_strade_AidNodo",
                table: "strade",
                column: "AidNodo");

            migrationBuilder.AddForeignKey(
                name: "FK_strade_nodi_AidNodo",
                table: "strade",
                column: "AidNodo",
                principalTable: "nodi",
                principalColumn: "idNodo",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
