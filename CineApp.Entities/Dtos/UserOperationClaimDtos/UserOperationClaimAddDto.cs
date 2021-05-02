using CineApp.Core.Entities.Abstract;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CineApp.Entities.Dtos.UserOperationClaimDtos
{
    public class UserOperationClaimAddDto:IDto
    {
       
        [DisplayName("Kullanıcı Kodu")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public int UserId { get; set; }

        
        [DisplayName("Yetki Kodu")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public int OperationClaimId { get; set; }
    }
}
