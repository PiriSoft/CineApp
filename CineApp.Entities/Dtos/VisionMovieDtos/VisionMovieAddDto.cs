using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CineApp.Entities.Dtos.VisionMovieDtos
{
    public class VisionMovieAddDto
    {
        [DisplayName("Film Kodu")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        public int MovieId { get; set; }

        [DisplayName("Sohbet Kodu")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        public int ChatId { get; set; }

        [DisplayName("Durum Kodu")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        public bool Status { get; set; }
    }
}
