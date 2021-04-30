using CineApp.Entities.Concrete;
using System;

namespace CineApp.Entities.Dtos.CommentDtos
{
    public class CommentDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string UserComment { get; set; }
        public DateTime? CommentDate { get; set; } = DateTime.Now;

    }
}
