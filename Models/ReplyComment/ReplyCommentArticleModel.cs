using System.ComponentModel.DataAnnotations;
using Test.Models.Comment;
using Test.Models.User;

namespace Test.Models.ReplyComment
{
    public class ReplyCommentArticleModel
    {
        [Key]
        public int ReplyCommentArticleId { get; set; }
        public string ReplyCommentArticleText { get; set; }

        public int CommentArticleId { get; set; }
        public CommentArticleModel CommentArticleModel { get; set; }

        public int UserId { get; set; }
        public UserModel UserModel { get; set; }
    }
}
