using System.ComponentModel.DataAnnotations;
using Test.Models.Like;
using Test.Models.Product;
using Test.Models.ReplyComment;
using Test.Models.User;

namespace Test.Models.Comment
{
    public class CommentModel
    {
        [Key]
        public int CommentId { get; set; }
        public string CommentProductBody { get; set; }

        public int UserId { get; set; }
        public UserModel UserModel { get; set; }

        public int ProductId { get; set; }
        public ProductModel ProductModel { get; set; }

        public ICollection<ReplyCommentModel> ReplyCommentModels { get; set; }

        public ICollection<LikeCommentModel> LikeCommentModels { get; set; }
    }
}
