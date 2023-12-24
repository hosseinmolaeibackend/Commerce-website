using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test.Migrations
{
    /// <inheritdoc />
    public partial class addLikeProductTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GalleriesModel_ImageModel_ImageId",
                table: "GalleriesModel");

            migrationBuilder.DropForeignKey(
                name: "FK_GalleriesModel_ProductModels_ProductId",
                table: "GalleriesModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImageModel",
                table: "ImageModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GalleriesModel",
                table: "GalleriesModel");

            migrationBuilder.RenameTable(
                name: "ImageModel",
                newName: "ImageModels");

            migrationBuilder.RenameTable(
                name: "GalleriesModel",
                newName: "GalleriesModels");

            migrationBuilder.RenameIndex(
                name: "IX_GalleriesModel_ProductId",
                table: "GalleriesModels",
                newName: "IX_GalleriesModels_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_GalleriesModel_ImageId",
                table: "GalleriesModels",
                newName: "IX_GalleriesModels_ImageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImageModels",
                table: "ImageModels",
                column: "ImageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GalleriesModels",
                table: "GalleriesModels",
                column: "GalleriesId");

            migrationBuilder.CreateTable(
                name: "LikeProductModels",
                columns: table => new
                {
                    LikeProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LikeCount = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikeProductModels", x => x.LikeProductId);
                    table.ForeignKey(
                        name: "FK_LikeProductModels_ProductModels_ProductId",
                        column: x => x.ProductId,
                        principalTable: "ProductModels",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LikeProductModels_ProductId",
                table: "LikeProductModels",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_GalleriesModels_ImageModels_ImageId",
                table: "GalleriesModels",
                column: "ImageId",
                principalTable: "ImageModels",
                principalColumn: "ImageId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GalleriesModels_ProductModels_ProductId",
                table: "GalleriesModels",
                column: "ProductId",
                principalTable: "ProductModels",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GalleriesModels_ImageModels_ImageId",
                table: "GalleriesModels");

            migrationBuilder.DropForeignKey(
                name: "FK_GalleriesModels_ProductModels_ProductId",
                table: "GalleriesModels");

            migrationBuilder.DropTable(
                name: "LikeProductModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImageModels",
                table: "ImageModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GalleriesModels",
                table: "GalleriesModels");

            migrationBuilder.RenameTable(
                name: "ImageModels",
                newName: "ImageModel");

            migrationBuilder.RenameTable(
                name: "GalleriesModels",
                newName: "GalleriesModel");

            migrationBuilder.RenameIndex(
                name: "IX_GalleriesModels_ProductId",
                table: "GalleriesModel",
                newName: "IX_GalleriesModel_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_GalleriesModels_ImageId",
                table: "GalleriesModel",
                newName: "IX_GalleriesModel_ImageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImageModel",
                table: "ImageModel",
                column: "ImageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GalleriesModel",
                table: "GalleriesModel",
                column: "GalleriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_GalleriesModel_ImageModel_ImageId",
                table: "GalleriesModel",
                column: "ImageId",
                principalTable: "ImageModel",
                principalColumn: "ImageId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GalleriesModel_ProductModels_ProductId",
                table: "GalleriesModel",
                column: "ProductId",
                principalTable: "ProductModels",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
