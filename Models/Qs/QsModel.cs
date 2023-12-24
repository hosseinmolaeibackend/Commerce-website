using System.ComponentModel.DataAnnotations;
using Test.Models.Comment;
using Test.Models.Like;
using Test.Models.User;

namespace Test.Models.Qs
{
    public class QsModel
    {
        [Key]
        public int QsId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public UserModel UserModel{ get; set; }

        public ICollection<QsCategorySelectedModel> QsCategorySelectedModels { get; set; }
        public ICollection<CommentQsModel> CommentQsModels { get; set; }
        public ICollection<LikeQsModel> LikeQsModels{ get; set; }

    }
}
