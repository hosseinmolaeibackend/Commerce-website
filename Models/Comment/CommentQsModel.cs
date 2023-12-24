using System.ComponentModel.DataAnnotations;
using Test.Models.Like;
using Test.Models.Qs;
using Test.Models.ReplyComment;
using Test.Models.User;

namespace Test.Models.Comment
{
    public class CommentQsModel
    {
        [Key]
        public int CommentQsId { get; set; }
        public string CommentQsBody { get; set; }

        public int UserId { get; set; }
        public UserModel UserModel { get; set; }
        public int QsId { get; set; }
        public QsModel QsModel{ get; set; }
        public ICollection<ReplyCommentQsModel> ReplyCommentQsModels { get; set; }
        public ICollection<LikeQsCommentModel> LikeQsCommentModels { get; set; }
    }
}
