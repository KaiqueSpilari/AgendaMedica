using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendaMedica.Data.Migrations
{
    /// <inheritdoc />
    public partial class Paciente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paciente_AspNetUsers_IdentityUserId",
                table: "Paciente");

            migrationBuilder.DropIndex(
                name: "IX_Paciente_IdentityUserId",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Paciente");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Paciente",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Paciente",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_IdentityUserId",
                table: "Paciente",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Paciente_AspNetUsers_IdentityUserId",
                table: "Paciente",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
