using CineApp.Core.Entities.Abstract;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CineApp.Entities.Dtos.UserOperationClaimDtos
{
    public class UserOperationClaimUpdateDto:IDto
    {
        //UserId
        [DisplayName("UserID")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public int UserId { get; set; }

        //OperationClaimId
        [DisplayName("OperationClaimID")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public int OperationClaimId { get; set; }
    }
}
