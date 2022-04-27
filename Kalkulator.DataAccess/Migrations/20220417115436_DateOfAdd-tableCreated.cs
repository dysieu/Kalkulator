using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kalkulator.DataAccess.Migrations
{
    public partial class DateOfAddtableCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_PaymentCategory_PaymentCategoryId",
                table: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentCategory",
                table: "PaymentCategory");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Payments");

            migrationBuilder.RenameTable(
                name: "PaymentCategory",
                newName: "PaymentsCategory");

            migrationBuilder.AddColumn<int>(
                name: "DateOfAddId",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "PaymentsCategory",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<double>(
                name: "Amount",
                table: "PaymentsCategory",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentsCategory",
                table: "PaymentsCategory",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "DateOfAdd",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateOfAdd", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payments_DateOfAddId",
                table: "Payments",
                column: "DateOfAddId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_DateOfAdd_DateOfAddId",
                table: "Payments",
                column: "DateOfAddId",
                principalTable: "DateOfAdd",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_PaymentsCategory_PaymentCategoryId",
                table: "Payments",
                column: "PaymentCategoryId",
                principalTable: "PaymentsCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_DateOfAdd_DateOfAddId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_PaymentsCategory_PaymentCategoryId",
                table: "Payments");

            migrationBuilder.DropTable(
                name: "DateOfAdd");

            migrationBuilder.DropIndex(
                name: "IX_Payments_DateOfAddId",
                table: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentsCategory",
                table: "PaymentsCategory");

            migrationBuilder.DropColumn(
                name: "DateOfAddId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "PaymentsCategory");

            migrationBuilder.RenameTable(
                name: "PaymentsCategory",
                newName: "PaymentCategory");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "PaymentCategory",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentCategory",
                table: "PaymentCategory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_PaymentCategory_PaymentCategoryId",
                table: "Payments",
                column: "PaymentCategoryId",
                principalTable: "PaymentCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
