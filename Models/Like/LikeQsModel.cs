using System.ComponentModel.DataAnnotations;
using Test.Models.Qs;
using Test.Models.User;

namespace Test.Models.Like
{
    public class LikeQsModel
    {
        [Key]
        public int LikeQsId { get; set; }
        public int LikeCount { get; set; }

        public int UserId { get; set; }
        public UserModel UserModel { get; set; }
        public int QsId { get; set; }
        public QsModel QsModel { get; set; }
    }
}
