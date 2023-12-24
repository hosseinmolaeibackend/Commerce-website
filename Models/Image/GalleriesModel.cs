using System.ComponentModel.DataAnnotations;
using Test.Models.Product;

namespace Test.Models.Image
{
    public class GalleriesModel
    {
        [Key]
        public int GalleriesId { get; set; }
        public int ProductId { get; set; }
        public int ImageId { get; set; }

        public ProductModel ProductModel { get; set; }
        public ImageModel ImageModel { get; set; }
    }
}
