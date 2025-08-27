using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AttainTaskSupportSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddStaffAndClientFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Telephone",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "Telephone",
                table: "Admin");
        }
    }
}
