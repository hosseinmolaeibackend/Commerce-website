using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test.Migrations
{
    /// <inheritdoc />
    public partial class AddReolyComment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReplyCommentArticleModels",
                columns: table => new
                {
                    ReplyCommentArticleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReplyCommentArticleText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentArticleId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReplyCommentArticleModels", x => x.ReplyCommentArticleId);
                    table.ForeignKey(
                        name: "FK_ReplyCommentArticleModels_CommentArticleModels_CommentArticleId",
                        column: x => x.CommentArticleId,
                        principalTable: "CommentArticleModels",
                        principalColumn: "CommentArticleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReplyCommentArticleModels_UserModels_UserId",
                        column: x => x.UserId,
                        principalTable: "UserModels",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReplyCommentModels",
                columns: table => new
                {
                    ReplyCommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReplyCommentText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CommentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReplyCommentModels", x => x.ReplyCommentId);
                    table.ForeignKey(
                        name: "FK_ReplyCommentModels_CommentModels_CommentId",
                        column: x => x.CommentId,
                        principalTable: "CommentModels",
                        principalColumn: "CommentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReplyCommentModels_UserModels_UserId",
                        column: x => x.UserId,
                        principalTable: "UserModels",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReplyCommentArticleModels_CommentArticleId",
                table: "ReplyCommentArticleModels",
                column: "CommentArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_ReplyCommentArticleModels_UserId",
                table: "ReplyCommentArticleModels",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ReplyCommentModels_CommentId",
                table: "ReplyCommentModels",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_ReplyCommentModels_UserId",
                table: "ReplyCommentModels",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReplyCommentArticleModels");

            migrationBuilder.DropTable(
                name: "ReplyCommentModels");
        }
    }
}
