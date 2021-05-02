using CineApp.Entities.Dtos.UserDetailDtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using CineApp.Core.Entities.Abstract;

namespace CineApp.Entities.Dtos.AvailibilityUserDtos
{
    public class AvailibilityUserDto:IDto
    {
        public UserDto User { get; set; }

        [DisplayName("Kullanıcı Uygun ilk")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public DateTime? AvailabilityStartDate { get; set; }
        [DisplayName("Kullanıcı Uygun son ")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public DateTime? AvailabilityEndDate { get; set; }
    }
}
