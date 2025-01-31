﻿using CineApp.Core.Entities.Abstract;
using CineApp.Entities.Dtos.UserDetailDtos;
using CineApp.Entities.Dtos.UserTokenDtos;

namespace CineApp.Entities.Dtos.UserDtos
{
    public class UseWithTokenDto:IDto
    {
        public UserDto User { get; set; }
        public UserTokenDto UserToken { get; set; }
    }
}
