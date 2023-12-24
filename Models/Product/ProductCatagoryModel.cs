using System.ComponentModel.DataAnnotations;

namespace Test.Models.Product
{
    public class ProductCatagoryModel
    {
        [Key]
        public int CatagoryId { get; set; }
        public string CatagoryName { get; set; }

        public ICollection<ProductCatagorySelectedModel> ProductCatagorySelectedModels { get; set; }
    }
}
