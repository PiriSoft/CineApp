using CineApp.Core.Entities.Abstract;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CineApp.Entities.Dtos.UserOperationClaimDtos
{
    public class UserOperationClaimDeleteDto:IDto
    {
        //UserId
        [DisplayName("Kullanıcı Kodu")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public int UserId { get; set; }

        //OperationClaimId
        [DisplayName("Yetki Kodu")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public int OperationClaimId { get; set; }
    }
}
