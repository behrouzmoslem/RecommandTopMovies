using System;
using System.Data.Entity;

namespace RandomRecommended
{
    internal class ContextList  : System.Data.Entity.DbContext
    {
        public ContextList():base("RecommendTopMovies")
        {
            
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<RecommandedMovie> RecommandedMovies { get; set; }
    }
}