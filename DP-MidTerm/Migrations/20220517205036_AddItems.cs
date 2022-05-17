using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DPMidTerm.Migrations
{
    public partial class AddItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Orders_OrderId",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_ToppingItem_OrderItem_OrderItemId",
                table: "ToppingItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ToppingItem",
                table: "ToppingItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItem",
                table: "OrderItem");

            migrationBuilder.RenameTable(
                name: "ToppingItem",
                newName: "ToppingItems");

            migrationBuilder.RenameTable(
                name: "OrderItem",
                newName: "OrderItems");

            migrationBuilder.RenameIndex(
                name: "IX_ToppingItem_OrderItemId",
                table: "ToppingItems",
                newName: "IX_ToppingItems_OrderItemId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItems",
                newName: "IX_OrderItems_OrderId");

            migrationBuilder.AddColumn<int>(
                name: "ToppingId",
                table: "ToppingItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToppingItems",
                table: "ToppingItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ToppingItems_OrderItems_OrderItemId",
                table: "ToppingItems",
                column: "OrderItemId",
                principalTable: "OrderItems",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ToppingItems_OrderItems_OrderItemId",
                table: "ToppingItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ToppingItems",
                table: "ToppingItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "ToppingId",
                table: "ToppingItems");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "OrderItems");

            migrationBuilder.RenameTable(
                name: "ToppingItems",
                newName: "ToppingItem");

            migrationBuilder.RenameTable(
                name: "OrderItems",
                newName: "OrderItem");

            migrationBuilder.RenameIndex(
                name: "IX_ToppingItems_OrderItemId",
                table: "ToppingItem",
                newName: "IX_ToppingItem_OrderItemId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItem",
                newName: "IX_OrderItem_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToppingItem",
                table: "ToppingItem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItem",
                table: "OrderItem",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Orders_OrderId",
                table: "OrderItem",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ToppingItem_OrderItem_OrderItemId",
                table: "ToppingItem",
                column: "OrderItemId",
                principalTable: "OrderItem",
                principalColumn: "Id");
        }
    }
}
