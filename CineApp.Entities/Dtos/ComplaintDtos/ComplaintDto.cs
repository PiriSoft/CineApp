using CineApp.Entities.ComplexType;
using CineApp.Entities.Concrete;

namespace CineApp.Entities.Dtos.ComplaintDtos
{
    public class ComplaintDto
    {
        public int Id { get; set; }
        public ComplaintType ComplaintType { get; set; }
        public int CommentId { get; set; }
        public Comment Comment { get; set; }
    }
}
