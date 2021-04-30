using CineApp.Core.Entities.Abstract;
using System.Collections.Generic;

namespace CineApp.Entities.Dtos.MovieDtos
{
    public class MovieListDto : DtoGetBase
    {
        public IEnumerable<MovieDto> Movies { get; set; }
    }
}
