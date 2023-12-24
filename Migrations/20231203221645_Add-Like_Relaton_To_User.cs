using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test.Migrations
{
    /// <inheritdoc />
    public partial class AddLikeRelatonToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "LikeProductModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "LikeCommentModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "LikeCommentArticleModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "LikeArticleModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "LikeReplyCommentArticleModels",
                columns: table => new
                {
                    LikeReplyCommentArticleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LikeCount = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ReplyCommentArticleId = table.Column<int>(type: "int", nullable: false),
                    ReplyCommentArticleModelReplyCommentArticleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikeReplyCommentArticleModels", x => x.LikeReplyCommentArticleId);
                    table.ForeignKey(
                        name: "FK_LikeReplyCommentArticleModels_ReplyCommentArticleModels_ReplyCommentArticleModelReplyCommentArticleId",
                        column: x => x.ReplyCommentArticleModelReplyCommentArticleId,
                        principalTable: "ReplyCommentArticleModels",
                        principalColumn: "ReplyCommentArticleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LikeReplyCommentArticleModels_UserModels_UserId",
                        column: x => x.UserId,
                        principalTable: "UserModels",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LikeReplyCommentProductModels",
                columns: table => new
                {
                    LikeReplyCommentProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LikeCount = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ReplyCommentId = table.Column<int>(type: "int", nullable: false),
                    ReplyCommentModelReplyCommentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikeReplyCommentProductModels", x => x.LikeReplyCommentProductId);
                    table.ForeignKey(
                        name: "FK_LikeReplyCommentProductModels_ReplyCommentModels_ReplyCommentModelReplyCommentId",
                        column: x => x.ReplyCommentModelReplyCommentId,
                        principalTable: "ReplyCommentModels",
                        principalColumn: "ReplyCommentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LikeReplyCommentProductModels_UserModels_UserId",
                        column: x => x.UserId,
                        principalTable: "UserModels",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LikeProductModels_UserId",
                table: "LikeProductModels",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LikeCommentModels_UserId",
                table: "LikeCommentModels",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LikeCommentArticleModels_UserId",
                table: "LikeCommentArticleModels",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LikeArticleModels_UserId",
                table: "LikeArticleModels",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LikeReplyCommentArticleModels_ReplyCommentArticleModelReplyCommentArticleId",
                table: "LikeReplyCommentArticleModels",
                column: "ReplyCommentArticleModelReplyCommentArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_LikeReplyCommentArticleModels_UserId",
                table: "LikeReplyCommentArticleModels",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LikeReplyCommentProductModels_ReplyCommentModelReplyCommentId",
                table: "LikeReplyCommentProductModels",
                column: "ReplyCommentModelReplyCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_LikeReplyCommentProductModels_UserId",
                table: "LikeReplyCommentProductModels",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_LikeArticleModels_UserModels_UserId",
                table: "LikeArticleModels",
                column: "UserId",
                principalTable: "UserModels",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LikeCommentArticleModels_UserModels_UserId",
                table: "LikeCommentArticleModels",
                column: "UserId",
                principalTable: "UserModels",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LikeCommentModels_UserModels_UserId",
                table: "LikeCommentModels",
                column: "UserId",
                principalTable: "UserModels",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LikeProductModels_UserModels_UserId",
                table: "LikeProductModels",
                column: "UserId",
                principalTable: "UserModels",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LikeArticleModels_UserModels_UserId",
                table: "LikeArticleModels");

            migrationBuilder.DropForeignKey(
                name: "FK_LikeCommentArticleModels_UserModels_UserId",
                table: "LikeCommentArticleModels");

            migrationBuilder.DropForeignKey(
                name: "FK_LikeCommentModels_UserModels_UserId",
                table: "LikeCommentModels");

            migrationBuilder.DropForeignKey(
                name: "FK_LikeProductModels_UserModels_UserId",
                table: "LikeProductModels");

            migrationBuilder.DropTable(
                name: "LikeReplyCommentArticleModels");

            migrationBuilder.DropTable(
                name: "LikeReplyCommentProductModels");

            migrationBuilder.DropIndex(
                name: "IX_LikeProductModels_UserId",
                table: "LikeProductModels");

            migrationBuilder.DropIndex(
                name: "IX_LikeCommentModels_UserId",
                table: "LikeCommentModels");

            migrationBuilder.DropIndex(
                name: "IX_LikeCommentArticleModels_UserId",
                table: "LikeCommentArticleModels");

            migrationBuilder.DropIndex(
                name: "IX_LikeArticleModels_UserId",
                table: "LikeArticleModels");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "LikeProductModels");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "LikeCommentModels");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "LikeCommentArticleModels");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "LikeArticleModels");
        }
    }
}
