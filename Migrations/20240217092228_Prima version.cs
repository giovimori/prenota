using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace prenota.Migrations
{
    /// <inheritdoc />
    public partial class Primaversion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Partecipazione",
                table: "Utenti");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Partecipazione",
                table: "Utenti",
                type: "INTEGER",
                nullable: true);
        }
    }
}
