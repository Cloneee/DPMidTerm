using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DPMidTerm.Migrations
{
    public partial class AddToppingPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Toppings",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Toppings");
        }
    }
}
