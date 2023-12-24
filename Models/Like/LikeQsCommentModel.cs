using System.ComponentModel.DataAnnotations;
using Test.Models.Comment;
using Test.Models.Qs;
using Test.Models.User;

namespace Test.Models.Like
{
    public class LikeQsCommentModel
    {
        [Key]
        public int LikeQsId { get; set; }
        public int LikeCount { get; set; }

        public int UserId { get; set; }
        public UserModel UserModel { get; set; }
        public int CommentQsId { get; set; }
        public CommentQsModel CommentQsModel { get; set; }
    }
}
