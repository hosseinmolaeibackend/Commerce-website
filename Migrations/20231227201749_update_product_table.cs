using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test.Migrations
{
    /// <inheritdoc />
    public partial class updateproducttable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "ProductModels",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "ProductModels");
        }
    }
}
