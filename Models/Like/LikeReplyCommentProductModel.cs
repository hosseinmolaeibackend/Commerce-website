using System.ComponentModel.DataAnnotations;
using Test.Models.ReplyComment;
using Test.Models.User;

namespace Test.Models.Like
{
    public class LikeReplyCommentProductModel
    {
        [Key]
        public int LikeReplyCommentProductId { get; set; }
        public int LikeCount { get; set; }

        public int UserId { get; set; }
        public UserModel UserModel { get; set; }

        public int ReplyCommentId { get; set; }
        public ReplyCommentModel ReplyCommentModel { get; set; }
    }
}
