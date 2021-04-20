using CineApp.Core.Entities.Abstract;
using System.Collections.Generic;

namespace CineApp.Entities.Concrete
{
    public class Chat : IEntity
    {
        public  int Id{ get; set; }
        public int VisionMovieId{ get; set; }
        public VisionMovie VisionMovie { get; set; }
        public ICollection<Comment> Comments{ get; set; }
    }

}
