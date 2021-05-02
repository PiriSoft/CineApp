using CineApp.Core.Entities.Abstract;
using CineApp.Entities.ComplexType;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CineApp.Entities.Dtos.UserDetailDtos
{
    public class UserAddDto : IDto
    {
        [DisplayName("Kullanıcı Adı")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        [MaxLength(50, ErrorMessage = "{0} alanı {1} karakterden küçük olmalıdır.")]
        [MinLength(2, ErrorMessage = "{0} alanı {1} karakterden büyük olmalıdır.")]
        public string FirstName { get; set; }

        [DisplayName("Kullanıcı Soyadı")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        [MaxLength(50, ErrorMessage = "{0} alanı {1} karakterden küçük olmalıdır.")]
        [MinLength(2, ErrorMessage = "{0} alanı {1} karakterden büyük olmalıdır.")]
        public string LastName { get; set; }

        [DisplayName("E-Posta Adresi")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        [MaxLength(100, ErrorMessage = "{0} alanı {1} karakterden küçük olmalıdır.")]
        [MinLength(10, ErrorMessage = "{0} alanı {1} karakterden büyük olmalıdır.")]
        public string Email { get; set; }
        [DisplayName("Kullanıcı Resmi")]
        public string UserImage { get; set; }
        [DisplayName("Kullanıcı TakmaAdı")]
        [MaxLength(50, ErrorMessage = "{0} alanı {1} karakterden küçük olmalıdır.")]
        [MinLength(2, ErrorMessage = "{0} alanı {1} karakterden büyük olmalıdır.")]
        public string NickName { get; set; }

        [DisplayName("Kullanıcı Rolü")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        public UserRole UserRole { get; set; }
    }
}
