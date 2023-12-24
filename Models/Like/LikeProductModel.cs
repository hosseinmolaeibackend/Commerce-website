using System.ComponentModel.DataAnnotations;
using Test.Models.Product;
using Test.Models.User;

namespace Test.Models.Like
{
    public class LikeProductModel
    {
        [Key]
        public int LikeProductId { get; set; }
        public int LikeCount { get; set; }

        public int UserId { get; set; }
        public UserModel UserModel { get; set; }
        public int ProductId { get; set; }
        public ProductModel ProductModel { get; set; }
    }
}
