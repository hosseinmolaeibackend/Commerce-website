using System.ComponentModel.DataAnnotations;
using Test.Models.Comment;
using Test.Models.Like;
using Test.Models.User;

namespace Test.Models.ReplyComment
{
    public class ReplyCommentModel
    {
        [Key]
        public int ReplyCommentId { get; set; }
        public string ReplyCommentText { get; set; }

        public int UserId { get; set; }
        public UserModel UserModel { get; set; }
        public int CommentId { get; set; }
        public CommentModel CommentModel { get; set; }

        public ICollection<LikeReplyCommentProductModel> LikeReplyCommentProductModels { get; set; }
    }
}
