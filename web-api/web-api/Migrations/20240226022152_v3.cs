using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace web_api.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrimeiroNome",
                table: "users");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "users",
                newName: "Nome");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "users",
                newName: "Role");

            migrationBuilder.AddColumn<string>(
                name: "PrimeiroNome",
                table: "users",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
