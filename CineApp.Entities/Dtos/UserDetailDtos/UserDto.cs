using CineApp.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CineApp.Entities.Dtos.UserDetailDtos
{
    public class UserDto:IDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
        public IEnumerable<string> Roles { get; set; }
        public string UserImage { get; set; }
        public string NickName { get; set; }
        public bool IsBanned { get; set; }
    }
}
