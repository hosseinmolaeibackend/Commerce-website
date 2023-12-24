using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test.Migrations
{
    /// <inheritdoc />
    public partial class addcatagory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductCatagoryModels",
                columns: table => new
                {
                    CatagoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CatagoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCatagoryModels", x => x.CatagoryId);
                });

            migrationBuilder.CreateTable(
                name: "ProductCatagorySelectedModels",
                columns: table => new
                {
                    ProductCatagorySelectedId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CatagoryId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCatagorySelectedModels", x => x.ProductCatagorySelectedId);
                    table.ForeignKey(
                        name: "FK_ProductCatagorySelectedModels_ProductCatagoryModels_CatagoryId",
                        column: x => x.CatagoryId,
                        principalTable: "ProductCatagoryModels",
                        principalColumn: "CatagoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductCatagorySelectedModels_ProductModels_ProductId",
                        column: x => x.ProductId,
                        principalTable: "ProductModels",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductCatagorySelectedModels_CatagoryId",
                table: "ProductCatagorySelectedModels",
                column: "CatagoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCatagorySelectedModels_ProductId",
                table: "ProductCatagorySelectedModels",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCatagorySelectedModels");

            migrationBuilder.DropTable(
                name: "ProductCatagoryModels");
        }
    }
}
