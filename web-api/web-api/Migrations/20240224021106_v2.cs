using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace web_api.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "username",
                table: "users",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "users",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "users",
                newName: "Sobrenome");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "users",
                newName: "Senha");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "users",
                newName: "PrimeiroNome");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "users",
                newName: "username");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "users",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Sobrenome",
                table: "users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "Senha",
                table: "users",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "PrimeiroNome",
                table: "users",
                newName: "FirstName");
        }
    }
}
