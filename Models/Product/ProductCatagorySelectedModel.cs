using System.ComponentModel.DataAnnotations;

namespace Test.Models.Product
{
    public class ProductCatagorySelectedModel
    {
        [Key]
        public int ProductCatagorySelectedId { get; set; }
        public int CatagoryId { get; set; }
        public int ProductId { get; set; }

        public ProductCatagoryModel ProductCatagoryModel { get; set; }
        public ProductModel ProductModel { get; set; }

    }
}
