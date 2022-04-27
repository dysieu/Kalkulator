using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kalkulator.DataAccess.Migrations
{
    public partial class AddPaymentCategory2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PaymentCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentCategory", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PaymentCategoryId",
                table: "Payments",
                column: "PaymentCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_PaymentCategory_PaymentCategoryId",
                table: "Payments",
                column: "PaymentCategoryId",
                principalTable: "PaymentCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_PaymentCategory_PaymentCategoryId",
                table: "Payments");

            migrationBuilder.DropTable(
                name: "PaymentCategory");

            migrationBuilder.DropIndex(
                name: "IX_Payments_PaymentCategoryId",
                table: "Payments");
        }
    }
}
