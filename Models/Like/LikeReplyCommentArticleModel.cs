using System.ComponentModel.DataAnnotations;
using Test.Models.ReplyComment;
using Test.Models.User;

namespace Test.Models.Like
{
    public class LikeReplyCommentArticleModel
    {
        [Key]
        public int LikeReplyCommentArticleId { get; set; }
        public int LikeCount { get; set; }

        public int UserId { get; set; }
        public UserModel UserModel { get; set; }

        public int ReplyCommentArticleId { get; set; }
        public ReplyCommentArticleModel ReplyCommentArticleModel {  get; set; }
    }
}
