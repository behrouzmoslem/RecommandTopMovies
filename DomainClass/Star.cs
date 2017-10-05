using System.Collections.Generic;

namespace DomainClass
{
    public sealed class Star  
    {
        public Star()
        {
            this.Movies = new HashSet<Movie>();
        }
 
        public int StarId { get; set; }
    
        public ICollection<Movie> Movies { get; set; }
        public Person Person { get; set; }
    }
}