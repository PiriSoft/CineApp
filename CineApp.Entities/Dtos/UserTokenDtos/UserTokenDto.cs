using System;

namespace CineApp.Entities.Dtos.UserTokenDtos
{
    public class UserTokenDto
    {
        public string AccessToken { get; set; }
        public DateTime TokenExpiration { get; set; }
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpiration { get; set; }
    }
}
