using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.Migrations
{
    /// <inheritdoc />
    public partial class sequance_test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence<int>(
                name: "Delivery Order",
                startValue: 1000L);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Students",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Students",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "DeliveryOrder",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR [Delivery Order]");

            migrationBuilder.AddColumn<int>(
                name: "DeliveryOrder",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR [Delivery Order]");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Name_Email",
                table: "Students",
                columns: new[] { "Name", "Email" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Students_Name_Email",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "DeliveryOrder",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "DeliveryOrder",
                table: "Books");

            migrationBuilder.DropSequence(
                name: "Delivery Order");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
