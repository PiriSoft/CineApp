using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CineApp.Entities.Dtos.CommentDtos
{
    public class CommentUpdateDto
    {
        [DisplayName("Yorum Kodu")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public int Id { get; set; }

        [DisplayName("Yorum Yapanın Kodu")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        public int UserId { get; set; }

        [DisplayName("Yorum Mesajı")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        [MaxLength(500, ErrorMessage = "{0} alanı {1} karakterden küçük olmalıdır.")]
        public string UserComment { get; set; }

    }
}
