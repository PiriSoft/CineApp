using CineApp.Entities.ComplexType;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CineApp.Entities.Dtos.MovieDtos
{
    public class MovieAddDto
    {
        [DisplayName("Film Adı")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        [MaxLength(100, ErrorMessage = "{0} alanı {1} karakterden küçük olmalıdır.")]
        public string Title { get; set; }

        [DisplayName("Film Açıklması")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        [MaxLength(1000, ErrorMessage = "{0} alanı {1} karakterden küçük olmalıdır.")]
        public string Description { get; set; }

        [DisplayName("Film Video Uzantısı")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        [MaxLength(500, ErrorMessage = "{0} alanı {1} karakterden küçük olmalıdır.")]
        public string VideoUrl { get; set; }

        [DisplayName("Film Resim Uzantısı")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        [MaxLength(500, ErrorMessage = "{0} alanı {1} karakterden küçük olmalıdır.")]
        public string MovieImage { get; set; }

        [DisplayName("Film Süresi")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        public DateTime MovieTime { get; set; }

        [DisplayName("Film Oy Sayısı")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        public int VoteCount { get; set; }

        [DisplayName("Film Oy Ortalaması")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        public decimal VoteAvarage { get; set; }

        [DisplayName("Film Tipi")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        public MovieType MovieType { get; set; }
    }
}
