using CineApp.Core.Entities.Abstract;
using System.Collections.Generic;

namespace CineApp.Entities.Dtos.AvailibilityUserDtos
{
    public class AvailibilityUserListDto:IDto
    {
        public IEnumerable<AvailibilityUserDto> Users { get; set; }
    }

}
