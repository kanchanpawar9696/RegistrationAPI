using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegistrationAPI.Migrations
{
    /// <inheritdoc />
    public partial class dbbbbbbbbbb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmailId",
                table: "UserInformation",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailId",
                table: "UserInformation");
        }
    }
}
