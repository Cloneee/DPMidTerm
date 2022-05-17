using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DPMidTerm.Migrations
{
    public partial class SomethingIDK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToppingItem_Order_OrderId",
                table: "ToppingItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Order");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "ToppingItem",
                newName: "OrderItemId");

            migrationBuilder.RenameIndex(
                name: "IX_ToppingItem_OrderId",
                table: "ToppingItem",
                newName: "IX_ToppingItem_OrderItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItem_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_ToppingItem_OrderItem_OrderItemId",
                table: "ToppingItem",
                column: "OrderItemId",
                principalTable: "OrderItem",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToppingItem_OrderItem_OrderItemId",
                table: "ToppingItem");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameColumn(
                name: "OrderItemId",
                table: "ToppingItem",
                newName: "OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_ToppingItem_OrderItemId",
                table: "ToppingItem",
                newName: "IX_ToppingItem_OrderId");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ToppingItem_Order_OrderId",
                table: "ToppingItem",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id");
        }
    }
}
