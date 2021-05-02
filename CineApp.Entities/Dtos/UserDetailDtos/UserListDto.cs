using CineApp.Core.Entities.Abstract;
using System.Collections.Generic;

namespace CineApp.Entities.Dtos.UserDetailDtos
{
    public class UserListDto:IDto
    {
        public IEnumerable<UserDto> Users { get; set; }
    }
}
