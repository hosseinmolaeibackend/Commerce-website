using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test.Migrations
{
    /// <inheritdoc />
    public partial class addGalleries : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ImageModel",
                columns: table => new
                {
                    ImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageModel", x => x.ImageId);
                });

            migrationBuilder.CreateTable(
                name: "GalleriesModel",
                columns: table => new
                {
                    GalleriesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ImageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GalleriesModel", x => x.GalleriesId);
                    table.ForeignKey(
                        name: "FK_GalleriesModel_ImageModel_ImageId",
                        column: x => x.ImageId,
                        principalTable: "ImageModel",
                        principalColumn: "ImageId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GalleriesModel_ProductModels_ProductId",
                        column: x => x.ProductId,
                        principalTable: "ProductModels",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GalleriesModel_ImageId",
                table: "GalleriesModel",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_GalleriesModel_ProductId",
                table: "GalleriesModel",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GalleriesModel");

            migrationBuilder.DropTable(
                name: "ImageModel");
        }
    }
}
