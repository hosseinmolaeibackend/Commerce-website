using System.ComponentModel.DataAnnotations;

namespace Test.Models.Qs
{
    public class QsCategorySelectedModel
    {
        [Key]
        public int QsCategorySelectedId { get; set; }

        public int QsCategoryId { get; set; }
        public QsCategoryModel QsCategoryModel { get; set; }

        public int QsId { get; set; }
        public QsModel QsModel { get; set; }
    }
}
