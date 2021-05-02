using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CineApp.Entities.Dtos.UserTokenDtos
{
    public class UserRefreshTheTokenDto
    {
        [Required]
        public string AccessToken { get; set; }
        [Required]
        public string RefreshToken { get; set; }
        [Required]
        public string SecretKey { get; set; }
        [NotMapped]
        [JsonIgnore]
        public string IpAddress { get; set; }
    }
}
