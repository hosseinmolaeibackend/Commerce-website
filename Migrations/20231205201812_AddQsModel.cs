using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test.Migrations
{
    /// <inheritdoc />
    public partial class AddQsModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QsCategoryModels",
                columns: table => new
                {
                    QsCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryTitle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QsCategoryModels", x => x.QsCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "QsModels",
                columns: table => new
                {
                    QsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QsModels", x => x.QsId);
                    table.ForeignKey(
                        name: "FK_QsModels_UserModels_UserId",
                        column: x => x.UserId,
                        principalTable: "UserModels",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CommentQsModels",
                columns: table => new
                {
                    CommentQsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentQsBody = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    QsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentQsModels", x => x.CommentQsId);
                    table.ForeignKey(
                        name: "FK_CommentQsModels_QsModels_QsId",
                        column: x => x.QsId,
                        principalTable: "QsModels",
                        principalColumn: "QsId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CommentQsModels_UserModels_UserId",
                        column: x => x.UserId,
                        principalTable: "UserModels",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LikeQsModel",
                columns: table => new
                {
                    LikeQsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LikeCount = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    QsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikeQsModel", x => x.LikeQsId);
                    table.ForeignKey(
                        name: "FK_LikeQsModel_QsModels_QsId",
                        column: x => x.QsId,
                        principalTable: "QsModels",
                        principalColumn: "QsId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LikeQsModel_UserModels_UserId",
                        column: x => x.UserId,
                        principalTable: "UserModels",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QsCategorySelectedModels",
                columns: table => new
                {
                    QsCategorySelectedId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QsCategoryId = table.Column<int>(type: "int", nullable: false),
                    QsCategoryModelQsCategoryId = table.Column<int>(type: "int", nullable: false),
                    QsId = table.Column<int>(type: "int", nullable: false),
                    QsModelQsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QsCategorySelectedModels", x => x.QsCategorySelectedId);
                    table.ForeignKey(
                        name: "FK_QsCategorySelectedModels_QsCategoryModels_QsCategoryModelQsCategoryId",
                        column: x => x.QsCategoryModelQsCategoryId,
                        principalTable: "QsCategoryModels",
                        principalColumn: "QsCategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QsCategorySelectedModels_QsModels_QsModelQsId",
                        column: x => x.QsModelQsId,
                        principalTable: "QsModels",
                        principalColumn: "QsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LikeQsCommentModel",
                columns: table => new
                {
                    LikeQsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LikeCount = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CommentQsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikeQsCommentModel", x => x.LikeQsId);
                    table.ForeignKey(
                        name: "FK_LikeQsCommentModel_CommentQsModels_CommentQsId",
                        column: x => x.CommentQsId,
                        principalTable: "CommentQsModels",
                        principalColumn: "CommentQsId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LikeQsCommentModel_UserModels_UserId",
                        column: x => x.UserId,
                        principalTable: "UserModels",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReplyCommentQsModels",
                columns: table => new
                {
                    ReplyCommentQsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReplyCommentText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CommentQsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReplyCommentQsModels", x => x.ReplyCommentQsId);
                    table.ForeignKey(
                        name: "FK_ReplyCommentQsModels_CommentQsModels_CommentQsId",
                        column: x => x.CommentQsId,
                        principalTable: "CommentQsModels",
                        principalColumn: "CommentQsId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReplyCommentQsModels_UserModels_UserId",
                        column: x => x.UserId,
                        principalTable: "UserModels",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LikeReplyCommentQsModel",
                columns: table => new
                {
                    LikeReplyCommentQsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LikeCount = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ReplyCommentQsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikeReplyCommentQsModel", x => x.LikeReplyCommentQsId);
                    table.ForeignKey(
                        name: "FK_LikeReplyCommentQsModel_ReplyCommentQsModels_ReplyCommentQsId",
                        column: x => x.ReplyCommentQsId,
                        principalTable: "ReplyCommentQsModels",
                        principalColumn: "ReplyCommentQsId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LikeReplyCommentQsModel_UserModels_UserId",
                        column: x => x.UserId,
                        principalTable: "UserModels",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommentQsModels_QsId",
                table: "CommentQsModels",
                column: "QsId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentQsModels_UserId",
                table: "CommentQsModels",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LikeQsCommentModel_CommentQsId",
                table: "LikeQsCommentModel",
                column: "CommentQsId");

            migrationBuilder.CreateIndex(
                name: "IX_LikeQsCommentModel_UserId",
                table: "LikeQsCommentModel",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LikeQsModel_QsId",
                table: "LikeQsModel",
                column: "QsId");

            migrationBuilder.CreateIndex(
                name: "IX_LikeQsModel_UserId",
                table: "LikeQsModel",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LikeReplyCommentQsModel_ReplyCommentQsId",
                table: "LikeReplyCommentQsModel",
                column: "ReplyCommentQsId");

            migrationBuilder.CreateIndex(
                name: "IX_LikeReplyCommentQsModel_UserId",
                table: "LikeReplyCommentQsModel",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_QsCategorySelectedModels_QsCategoryModelQsCategoryId",
                table: "QsCategorySelectedModels",
                column: "QsCategoryModelQsCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_QsCategorySelectedModels_QsModelQsId",
                table: "QsCategorySelectedModels",
                column: "QsModelQsId");

            migrationBuilder.CreateIndex(
                name: "IX_QsModels_UserId",
                table: "QsModels",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ReplyCommentQsModels_CommentQsId",
                table: "ReplyCommentQsModels",
                column: "CommentQsId");

            migrationBuilder.CreateIndex(
                name: "IX_ReplyCommentQsModels_UserId",
                table: "ReplyCommentQsModels",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LikeQsCommentModel");

            migrationBuilder.DropTable(
                name: "LikeQsModel");

            migrationBuilder.DropTable(
                name: "LikeReplyCommentQsModel");

            migrationBuilder.DropTable(
                name: "QsCategorySelectedModels");

            migrationBuilder.DropTable(
                name: "ReplyCommentQsModels");

            migrationBuilder.DropTable(
                name: "QsCategoryModels");

            migrationBuilder.DropTable(
                name: "CommentQsModels");

            migrationBuilder.DropTable(
                name: "QsModels");
        }
    }
}
