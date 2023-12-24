using System.ComponentModel.DataAnnotations;
using Test.Models.Article;
using Test.Models.User;

namespace Test.Models.Like
{
    public class LikeArticleModel
    {
        [Key]
        public int LikeArticleId { get; set; }
        public int LikeCount { get; set; }

        public int UserId { get; set; }
        public UserModel UserModel { get; set; }
        public int ArticleId { get; set; }
        public ArticleModel ArticleModel { get; set; }
    }
}
