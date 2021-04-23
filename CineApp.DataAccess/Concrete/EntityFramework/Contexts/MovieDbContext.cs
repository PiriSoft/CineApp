using CineApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CineApp.Core.Concrete.EntityFramework.Contexts
{
    public class MovieDbContext : DbContext
    {

        public MovieDbContext() : base() { }

        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MovieDB;Trusted_Connection=true");
        }


        //const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=ClientDb;Trusted_Connection=True;";

       

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(connectionString);
        //}
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<VisionMovie> VisionMovies { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Complaint> Complaints { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<AvailabilityUser> AvailabilityUsers { get; set; }








        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //modelBuilder.ApplyConfiguration(new CustomerOriginMap());
        //}
        

    }
}
