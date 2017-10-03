using System.Data.Entity;
using DomainClass;

namespace DataLayer
{
    public class ContextList  : System.Data.Entity.DbContext
    {
        public ContextList():base("RecommendTopMovies")
        {
            
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserMovie> UserMovieList { get; set; }
    }
}