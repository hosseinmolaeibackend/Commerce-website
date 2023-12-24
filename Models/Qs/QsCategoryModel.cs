using System.ComponentModel.DataAnnotations;

namespace Test.Models.Qs
{
    public class QsCategoryModel
    {
        [Key]
        public int QsCategoryId { get; set; }
        public string CategoryTitle { get; set; }

        public ICollection<QsCategorySelectedModel> QsCategorySelectedModels { get; set; }

    }
}
