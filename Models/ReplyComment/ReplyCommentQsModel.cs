using System.ComponentModel.DataAnnotations;
using Test.Models.Comment;
using Test.Models.Like;
using Test.Models.User;

namespace Test.Models.ReplyComment
{
    public class ReplyCommentQsModel
    {
        [Key]
        public int ReplyCommentQsId { get; set; }
        public string ReplyCommentText { get; set; }

        public int UserId { get; set; }
        public UserModel UserModel { get; set; }

        public int CommentQsId { get; set; }
        public CommentQsModel CommentQsModel { get; set; }

        public ICollection<LikeReplyCommentQsModel> LikeReplyCommentQsModels { get; set; }
    }
}
