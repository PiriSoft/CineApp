using CineApp.Core.Entities.Abstract;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CineApp.Entities.Dtos.AvailibilityUserDtos
{
    public class AvailibilityUserUpdateDto:IDto
    {
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        [DisplayName("Kullanıcı Kodu")]
        public int Id { get; set; }
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

        [DisplayName("Kullanıcı Uygun")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public DateTime AvailabilityStartDate { get; set; }
        [DisplayName("Kullanıcı Uygun")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public DateTime AvailabilityEndDate { get; set; }

        [DisplayName("Aktif Mi?")]
        public bool IsActive { get; set; }
        [DisplayName("Silinmiş Mi?")]
        public bool IsDeleted { get; set; }

        [DisplayName("Düzenleyen Kullanıcı")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        public int ModifiedByUserId { get; set; }
    }
}
