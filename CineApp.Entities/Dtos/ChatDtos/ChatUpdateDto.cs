using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CineApp.Entities.Dtos.ChatDtos
{
    public class ChatUpdateDto
    {
        [DisplayName("Sohbet Kodu")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        public int Id { get; set; }

        [DisplayName("Sohbet Adı")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        [MaxLength(100, ErrorMessage = "{0} alanı {1} karakterden küçük olmalıdır.")]
        [MinLength(2, ErrorMessage = "{0} alanı {1} karakterden büyük olmalıdır.")]
        public string Name { get; set; }
    }
}
