using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace DomainClass
{
    [Table("Movie",Schema = "Top")]
    public class Movie
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int Id { get; set; }
        [MaxLength(150, ErrorMessage = "Up to 150 chars")]
        [Required(ErrorMessage = "Please Latin Name is insert")]
        [ConcurrencyCheck]
        public string LatinName { get; set; }
        [MaxLength(150, ErrorMessage = "Up to 150 chars")]
        [Required(ErrorMessage = "Please Persian Name is insert")]
        [ConcurrencyCheck]
        public string PersianName { get; set; }
        [Range(1,10)]
        [DefaultValue(1)]
        public double Rate { get; set; } 

        [StringLength(1000)]
        public string Description { get; set; }

        [InverseProperty("MoviesAsFirstDirector")]
        public   Director FirstDirector { get; set; }
        [InverseProperty("MoviesAsSecondDirector")]
        public   Director SecondDirector { get; set; }

        public Actor MaleActor { get; set; }
        public Actor FeMaleActor { get; set; }



        [Timestamp]
        public byte[] RowVersion { get; set; }
    }

    public class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key] 
        public int Id { get; set; }
        [StringLength(100)]
        public string FirstName { get; set; } 
        [StringLength(100)]
        public string LastName { get; set; }
        [NotMapped]
        public string FullName => FirstName + " " + LastName;

        public Gender Gender { get; set; }
    }
    [ComplexType]
    public class Gender
    { 
        public int Id { get; set; }
        public string Title { get; set; }
    }

    public enum GenderType
    {
        NotRegister,
        Male ,
        Female  
    }
    public class Director  
    {
        
        public Person Person { get; set; }
        public int DirectorId { get; set; }
        [InverseProperty("FirstDirector")]
        public virtual ICollection<Movie> MoviesAsFirstDirector { get; set; }
        [InverseProperty("SecondDirector")]
        public virtual ICollection<Movie> MoviesAsSecondDirector { get; set; }
        
    }


    public class Actor  
    {
        public Person Person { get; set; }
        public int ActorId { get; set; }
    
        public virtual ICollection<Movie> ActorMovies { get; set; }
      

    }



}