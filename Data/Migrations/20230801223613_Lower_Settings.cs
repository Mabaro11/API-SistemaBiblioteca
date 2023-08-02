using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Lower_Settings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "availability",
                table: "Books",
                newName: "Lower");

            migrationBuilder.AlterColumn<int>(
                name: "status",
                table: "Transactions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "Lower",
                table: "Readers",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Lower",
                table: "Categories",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lower",
                table: "Readers");

            migrationBuilder.DropColumn(
                name: "Lower",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "Lower",
                table: "Books",
                newName: "availability");

            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "Transactions",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
