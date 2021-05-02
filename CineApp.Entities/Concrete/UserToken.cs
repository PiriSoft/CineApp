using CineApp.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CineApp.Entities.Concrete
{
    public class UserToken :  IEntity
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string AccessToken { get; set; }
        public DateTime TokenExpiration { get; set; }
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpiration { get; set; }
        public string IpAddress { get; set; }
    }
}
