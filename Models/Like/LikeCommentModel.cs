using System.ComponentModel.DataAnnotations;
using Test.Models.Comment;
using Test.Models.User;

namespace Test.Models.Like
{
    public class LikeCommentModel
    {
        [Key]
        public int LikeProductId { get; set; }
        public int LikeCount { get; set; }

        public int UserId { get; set; }
        public UserModel UserModel { get; set; }
        public int CommentId { get; set; }
        public CommentModel CommentModel { get; set; }
    }
}
