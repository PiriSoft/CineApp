using CineApp.Core.Entities.Abstract;
using CineApp.Entities.ComplexType;
using System;
using System.Collections.Generic;

namespace CineApp.Entities.Concrete
{
    public class Movie : EntityBase<int, int>, IEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string VideoUrl { get; set; }
        public string MovieImage { get; set; }
        public DateTime MovieTime { get; set; }
        public int VoteCount{ get; set; }
        public decimal VoteAvarage{ get; set; }
        public ICollection<MovieType> MovieType{ get; set; }

    }

}
