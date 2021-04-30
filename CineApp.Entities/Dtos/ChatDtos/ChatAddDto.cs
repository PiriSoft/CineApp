using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CineApp.Entities.Dtos.ChatDtos
{
    public class ChatAddDto
    {
        [DisplayName("Sohbet Adı")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        [MaxLength(100, ErrorMessage = "{0} alanı {1} karakterden küçük olmalıdır.")]
        public string Name { get; set; }
       
    }
}
