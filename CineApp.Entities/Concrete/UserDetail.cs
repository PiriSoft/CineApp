using CineApp.Core.Entities.Abstract;

namespace CineApp.Entities.Concrete
{
    public class UserDetail : EntityBase<int, int>, IEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public string UserImage { get; set; }
        public string NickName { get; set; }
        public bool IsBanned { get; set; } = false;
    }

}
