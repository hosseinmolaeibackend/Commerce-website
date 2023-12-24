using System.ComponentModel.DataAnnotations;
using Test.Models.Article;
using Test.Models.Comment;
using Test.Models.Like;
using Test.Models.Product;
using Test.Models.Qs;
using Test.Models.ReplyComment;

namespace Test.Models.User
{
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? Phone { get; set; }
        public string? Profilimg { get; set; }

        public ICollection<ProductModel> ProductModels { get; set; }
        public ICollection<CommentModel> CommentModels { get; set; }
        public ICollection<ReplyCommentModel> ReplyCommentModels { get; set; }

        public ICollection<ArticleModel> ArticleModels { get; set; }
        public ICollection<CommentArticleModel> CommentArticleModels { get; set; }
        public ICollection<ReplyCommentArticleModel> ReplyCommentArticleModels { get; set; }

        public ICollection<QsModel> QsModels{ get; set; }
        public ICollection<CommentQsModel> CommentQsModels { get; set; }
        public ICollection<ReplyCommentQsModel> ReplyCommentQsModels { get; set; }

        public ICollection<LikeArticleModel> LikeArticleModels { get; set; }
        public ICollection<LikeProductModel> LikeProductModels { get; set; }
        public ICollection<LikeCommentArticleModel> LikeCommentArticleModels { get; set; }
        public ICollection<LikeCommentModel> LikeCommentModels { get; set; }
        public ICollection<LikeReplyCommentArticleModel> LikeReplyCommentArticleModels { get; set; }
        public ICollection<LikeReplyCommentProductModel> LikeReplyCommentProductModels { get; set; }
        public ICollection<LikeQsModel> LikeQsModels { get; set; }
        public ICollection<LikeQsCommentModel> LikeQsCommentModels { get; set; }
        public ICollection<LikeReplyCommentQsModel> LikeReplyCommentQsModels { get; set; }
    }
}
