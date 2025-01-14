using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shop.Data.Migrations
{
    /// <inheritdoc />
    public partial class deleteEmployeeIdFromOrders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_ClubCards_ClubCardNumCard",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "ClubCardNumCard",
                table: "Customers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_ClubCards_ClubCardNumCard",
                table: "Customers",
                column: "ClubCardNumCard",
                principalTable: "ClubCards",
                principalColumn: "NumCard");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_ClubCards_ClubCardNumCard",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ClubCardNumCard",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_ClubCards_ClubCardNumCard",
                table: "Customers",
                column: "ClubCardNumCard",
                principalTable: "ClubCards",
                principalColumn: "NumCard",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
