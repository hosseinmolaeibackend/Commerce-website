using System.ComponentModel.DataAnnotations;

namespace Test.Models.Image
{
    public class ImageModel
    {
        [Key]
        public int ImageId { get; set; }
        public string NameImage { get; set; }
        public ICollection<GalleriesModel> GalleriesModels { get; set; }

    }
}
