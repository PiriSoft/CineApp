using CineApp.Core.Entities.Abstract;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CineApp.Entities.Dtos.UserDetailDtos
{
    public class UserDeleteDto:IDto
    {
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        [DisplayName("Kullanıcı Kodu")]
        public int Id { get; set; }
        [DisplayName("Düzenleyen Kullanıcı")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        public int ModifiedByUserId { get; set; }
    }
}
