using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AttainTaskSupportSystem.Migrations
{
    /// <inheritdoc />
    public partial class secondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmPassword",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Admin");

            migrationBuilder.RenameColumn(
                name: "role",
                table: "Admin",
                newName: "Role");

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "Admin",
                newName: "role");

            migrationBuilder.AddColumn<string>(
                name: "ConfirmPassword",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
