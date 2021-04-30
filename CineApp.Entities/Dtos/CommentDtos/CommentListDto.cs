using CineApp.Core.Entities.Abstract;
using System.Collections.Generic;
using System.Text;

namespace CineApp.Entities.Dtos.CommentDtos
{
    public class CommentListDto : DtoGetBase
    {
        public IEnumerable<CommentDto> Comments { get; set; }

    }
}
