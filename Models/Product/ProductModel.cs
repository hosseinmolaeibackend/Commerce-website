using System.ComponentModel.DataAnnotations;
using Test.Models.Comment;
using Test.Models.Image;
using Test.Models.Like;
using Test.Models.User;

namespace Test.Models.Product
{
    public class ProductModel
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }

        public int UserId { get; set; }
        public UserModel UserModel { get; set; }

        public ICollection<CommentModel> commentModels { get; set; }
        public ICollection<ProductCatagorySelectedModel> ProductCatagorySelectedModels { get; set; }
        public ICollection<GalleriesModel> GalleriesModels { get; set; }
        public ICollection<LikeProductModel> LikeProductModels { get; set; }
    }
}
