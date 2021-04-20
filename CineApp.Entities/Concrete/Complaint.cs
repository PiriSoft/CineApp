using CineApp.Core.Entities.Abstract;
using CineApp.Entities.ComplexType;

namespace CineApp.Entities.Concrete
{
    public class Complaint : EntityBase<int, int>, IEntity
    {
        public ComplaintType ComplaintType { get; set; }
        public int CommentId { get; set; }
        public Comment Comment { get; set; }
    }

}
