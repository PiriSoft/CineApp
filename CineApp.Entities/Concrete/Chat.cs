using CineApp.Core.Entities.Abstract;
using System.Collections.Generic;

namespace CineApp.Entities.Concrete
{
    public class Chat : IEntity
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public ICollection<Comment> Comments{ get; set; }
    }

}
