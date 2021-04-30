using CineApp.Entities.ComplexType;
using System;
using System.Text;

namespace CineApp.Entities.Dtos.MovieDtos
{
    public class MovieDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string VideoUrl { get; set; }
        public string MovieImage { get; set; }
        public DateTime MovieTime { get; set; }
        public int VoteCount { get; set; }
        public decimal VoteAvarage { get; set; }
        public MovieType MovieType { get; set; }
    }
}
