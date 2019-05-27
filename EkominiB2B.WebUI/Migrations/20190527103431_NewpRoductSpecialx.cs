using Microsoft.EntityFrameworkCore.Migrations;

namespace EkominiB2B.WebUI.Migrations
{
    public partial class NewpRoductSpecialx : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsFutured",
                table: "Products",
                newName: "IsFeatured");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsFeatured",
                table: "Products",
                newName: "IsFutured");
        }
    }
}
