using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test.Migrations
{
    /// <inheritdoc />
    public partial class addLikeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LikeArticleModels",
                columns: table => new
                {
                    LikeArticleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LikeCount = table.Column<int>(type: "int", nullable: false),
                    ArticleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikeArticleModels", x => x.LikeArticleId);
                    table.ForeignKey(
                        name: "FK_LikeArticleModels_ArticleModels_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "ArticleModels",
                        principalColumn: "ArticleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LikeCommentArticleModels",
                columns: table => new
                {
                    LikeCommentArticleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LikeCount = table.Column<int>(type: "int", nullable: false),
                    CommentArticleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikeCommentArticleModels", x => x.LikeCommentArticleId);
                    table.ForeignKey(
                        name: "FK_LikeCommentArticleModels_CommentArticleModels_CommentArticleId",
                        column: x => x.CommentArticleId,
                        principalTable: "CommentArticleModels",
                        principalColumn: "CommentArticleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LikeCommentModels",
                columns: table => new
                {
                    LikeProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LikeCount = table.Column<int>(type: "int", nullable: false),
                    CommentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikeCommentModels", x => x.LikeProductId);
                    table.ForeignKey(
                        name: "FK_LikeCommentModels_CommentModels_CommentId",
                        column: x => x.CommentId,
                        principalTable: "CommentModels",
                        principalColumn: "CommentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LikeArticleModels_ArticleId",
                table: "LikeArticleModels",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_LikeCommentArticleModels_CommentArticleId",
                table: "LikeCommentArticleModels",
                column: "CommentArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_LikeCommentModels_CommentId",
                table: "LikeCommentModels",
                column: "CommentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LikeArticleModels");

            migrationBuilder.DropTable(
                name: "LikeCommentArticleModels");

            migrationBuilder.DropTable(
                name: "LikeCommentModels");
        }
    }
}
