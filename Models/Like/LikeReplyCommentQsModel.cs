using System.ComponentModel.DataAnnotations;
using Test.Models.ReplyComment;
using Test.Models.User;

namespace Test.Models.Like
{
    public class LikeReplyCommentQsModel
    {
        [Key]
        public int LikeReplyCommentQsId { get; set; }
        public int LikeCount { get; set; }

        public int UserId { get; set; }
        public UserModel UserModel { get; set; }

        public int ReplyCommentQsId { get; set; }
        public ReplyCommentQsModel ReplyCommentQsModel { get; set; }
    }
}
