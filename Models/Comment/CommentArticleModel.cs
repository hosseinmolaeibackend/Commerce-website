using System.ComponentModel.DataAnnotations;
using Test.Models.Article;
using Test.Models.Like;
using Test.Models.ReplyComment;
using Test.Models.User;

namespace Test.Models.Comment
{
    public class CommentArticleModel
    {
        [Key]
        public int CommentArticleId { get; set; }
        public string CommentArticleBody { get; set; }

        public int UserId { get; set; }
        public UserModel UserModel { get; set; }
        public int ArticleId { get; set; }
        public ArticleModel ArticleModel { get; set; }

        public ICollection<ReplyCommentArticleModel> ReplyCommentArticleModels { get; set; }
        public ICollection<LikeCommentArticleModel> LikeCommentArticleModels { get; set; }
    }
}
