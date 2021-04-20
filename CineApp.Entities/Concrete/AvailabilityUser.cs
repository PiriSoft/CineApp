using CineApp.Core.Entities.Abstract;
using System;
using System.Text;

namespace CineApp.Entities.Concrete
{
    public class AvailabilityUser:EntityBase<int , int >,IEntity
    {
        public int UserId{ get; set; }
        public User User{ get; set; }

        public  DateTime? AvailabilityStartDate { get; set; } 
        public DateTime? AvailabilityEndDate { get; set; }
    }

}
