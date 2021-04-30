using CineApp.Entities.Concrete;
using System;

namespace CineApp.Entities.Dtos.VisionMovieDtos
{
    public class VisionMovieDto
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int ChatId { get; set; }
        public Chat Chat { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool Status { get; set; }
    }
}
