using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kalkulator.DataAccess.Migrations
{
    public partial class AddPaymentCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PaymentCategoryId",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentCategoryId",
                table: "Payments");
        }
    }
}
