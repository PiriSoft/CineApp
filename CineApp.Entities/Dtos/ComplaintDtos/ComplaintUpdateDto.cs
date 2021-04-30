using CineApp.Entities.ComplexType;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CineApp.Entities.Dtos.ComplaintDtos
{
    public class ComplaintUpdateDto
    {
        [DisplayName("Şikayet Kodu")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        public int Id { get; set; }

        [DisplayName("Şikayet Tipi")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        public ComplaintType ComplaintType { get; set; }

        [DisplayName("Şikayet Yapılan Yorum Kodu")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        public int CommentId { get; set; }
    }
}
