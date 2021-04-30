using CineApp.Core.Entities.Abstract;
using System.Collections.Generic;
using System.Text;

namespace CineApp.Entities.Dtos.VisionMovieDtos
{
    public class VisionMovieListDto: DtoGetBase
    {
        public IEnumerable<VisionMovieDto> VisionMovies { get; set; }
    }
}
