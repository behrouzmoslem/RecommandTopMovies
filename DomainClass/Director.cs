using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainClass
{
    public class Director  
    {
        
 
        public int DirectorId { get; set; }
        [InverseProperty("FirstDirector")]
        public virtual ICollection<Movie> MoviesAsFirstDirector { get; set; }
        [InverseProperty("SecondDirector")]
        public virtual ICollection<Movie> MoviesAsSecondDirector { get; set; }
        public Person Person { get; set; }
    }
}