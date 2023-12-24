using System.ComponentModel.DataAnnotations;
using Test.Models.Comment;
using Test.Models.User;

namespace Test.Models.Like
{
    public class LikeCommentArticleModel
    {
        [Key]
        public int LikeCommentArticleId { get; set; }
        public int LikeCount { get; set; }

        public int UserId { get; set; }
        public UserModel UserModel { get; set; }
        public int CommentArticleId { get; set; }
        public CommentArticleModel CommentArticleModel { get; set; }
    }
}
