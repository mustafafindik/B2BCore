using Microsoft.EntityFrameworkCore.Migrations;

namespace EkominiB2B.WebUI.Migrations
{
    public partial class NewFixes2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_orderStatuses_OrderStatusId",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "OrderStatusId",
                table: "Orders",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_orderStatuses_OrderStatusId",
                table: "Orders",
                column: "OrderStatusId",
                principalTable: "orderStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_orderStatuses_OrderStatusId",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "OrderStatusId",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_orderStatuses_OrderStatusId",
                table: "Orders",
                column: "OrderStatusId",
                principalTable: "orderStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
