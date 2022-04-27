using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kalkulator.DataAccess.Migrations
{
    public partial class AmountFieldRemovedFromPaymentCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "PaymentsCategory");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Amount",
                table: "PaymentsCategory",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
