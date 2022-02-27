using Microsoft.EntityFrameworkCore.Migrations;

namespace ITech_Project.Migrations
{
    public partial class Model_Updated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "ModelLabtop",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "ModelMobile",
                table: "OrderDetails");

            migrationBuilder.AddColumn<byte>(
                name: "Accessories",
                table: "Products",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "OrderDetails",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Accessories",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<byte>(
                name: "Color",
                table: "OrderDetails",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "ModelLabtop",
                table: "OrderDetails",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "ModelMobile",
                table: "OrderDetails",
                type: "tinyint",
                nullable: true);
        }
    }
}
