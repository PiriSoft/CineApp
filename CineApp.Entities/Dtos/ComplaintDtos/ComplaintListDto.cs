using CineApp.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CineApp.Entities.Dtos.ComplaintDtos
{
    public class ComplaintListDto : DtoGetBase
    {
        public IEnumerable<ComplaintDto> Complaints { get; set; }
    }
}
