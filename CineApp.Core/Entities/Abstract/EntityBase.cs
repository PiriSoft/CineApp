using System;

namespace CineApp.Core.Entities.Abstract
{
    public abstract class EntityBase<TId, TUser> where TId : struct where TUser : struct
    {
        public virtual TId Id { get; set; }
        public virtual bool IsDeleted { get; set; } = false;
        public virtual bool IsActive { get; set; } = true;
        public virtual TUser? CreatedByUserId { get; set; }
        public virtual TUser? ModifiedByUserId { get; set; }
        public virtual DateTime? CreatedDateByUser { get; set; } = DateTime.Now;
        public virtual DateTime? ModifiedDateByUser { get; set; } = DateTime.Now;
        public virtual DateTime? CreatedDate { get; set; } = DateTime.Now;
        public virtual DateTime? ModifiedDate { get; set; } = DateTime.Now;
    }
}
