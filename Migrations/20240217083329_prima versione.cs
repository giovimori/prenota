/*using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace prenota.Migrations
{
    /// <inheritdoc />
    public partial class primaversione : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Utenti",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Cognome = table.Column<string>(type: "TEXT", nullable: true),
                    EMail = table.Column<string>(type: "TEXT", nullable: true),
                    Citta = table.Column<string>(type: "TEXT", nullable: true),
                    Partecipazione = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utenti", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Utenti");
        }
    }
}*/
