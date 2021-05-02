using CineApp.Core.Entities.Abstract;
using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CineApp.Entities.Dtos.UserDtos
{
    public class UserLoginDto:IDto
    {
        [DisplayName("E-Posta Adresi")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        [MaxLength(100, ErrorMessage = "{0} alanı {1} karakterden küçük olmalıdır.")]
        [MinLength(10, ErrorMessage = "{0} alanı {1} karakterden büyük olmalıdır.")]
        public string Email { get; set; }

        [DisplayName("Şifre")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        [MaxLength(25, ErrorMessage = "{0} alanı {1} karakterden küçük olmalıdır.")]
        [MinLength(6, ErrorMessage = "{0} alanı {1} karakterden büyük olmalıdır.")]
        public string Password { get; set; }
        [NotMapped]
        [JsonIgnore]
        public string IpAddress { get; set; }
    }
}
