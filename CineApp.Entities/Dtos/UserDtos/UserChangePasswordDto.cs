using CineApp.Core.Entities.Abstract;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CineApp.Entities.Dtos.UserDtos
{
    public class UserChangePasswordDto:IDto
    {
        //Id
        [DisplayName("Kullanıcı")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public int Id { get; set; }

        //Password
        [DisplayName("Şifre")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        [MaxLength(25, ErrorMessage = "{0} alanı {1} karakterden küçük olmalıdır.")]
        [MinLength(6, ErrorMessage = "{0} alanı {1} karakterden büyük olmalıdır.")]
        public string Password { get; set; }

        //New password
        [DisplayName("Yeni Şifre")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        [MaxLength(25, ErrorMessage = "{0} alanı {1} karakterden küçük olmalıdır.")]
        [MinLength(6, ErrorMessage = "{0} alanı {1} karakterden büyük olmalıdır.")]
        public string NewPassword { get; set; }
    }
}
