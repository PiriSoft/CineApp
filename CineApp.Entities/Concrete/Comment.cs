using CineApp.Core.Entities.Abstract;
using System;

namespace CineApp.Entities.Concrete
{
    public class Comment : EntityBase<int, int>, IEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public string UserComment { get; set; }
        public DateTime? CommentDate { get; set; } = DateTime.Now;
    }

}
