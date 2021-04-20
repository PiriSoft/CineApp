using CineApp.Core.Entities.Abstract;
using System;

namespace CineApp.Entities.Concrete
{
    public class VisionMovie : EntityBase<int, int>, IEntity
    {
        public int MovieId{ get; set; }
        public Movie Movie{ get; set; }

        public int ChatId{ get; set; }
        public Chat Chat{ get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool Status { get; set; }
    }

}
