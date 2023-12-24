using System.ComponentModel.DataAnnotations;
using Test.Models.Comment;
using Test.Models.Like;
using Test.Models.User;

namespace Test.Models.Article
{
    public class ArticleModel
    {
        [Key]
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string? Image { get; set; }
        public DateTime CreateTime { get; set; }
        public string? TimeRead { get; set; }

        public int UserId { get; set; }
        public UserModel UserModel { get; set; }

        public ICollection<CommentArticleModel> CommentArticleModels { get; set; }
        public ICollection<LikeArticleModel> LikeArticleModels { get; set; }
    }
}
