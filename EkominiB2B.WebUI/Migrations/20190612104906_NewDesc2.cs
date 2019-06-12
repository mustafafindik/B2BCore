using Microsoft.EntityFrameworkCore.Migrations;

namespace EkominiB2B.WebUI.Migrations
{
    public partial class NewDesc2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "DiscountRatio",
                table: "Products",
                nullable: true,
                oldClrType: typeof(decimal),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "DiscountRatio",
                table: "Products",
                nullable: true,
                oldClrType: typeof(double),
                oldNullable: true);
        }
    }
}
