using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace DomainClass
{
    [Table("Movie",Schema = "Top")]
    public sealed class Movie
    {
        public Movie()
        {
            this.Stars = new HashSet<Star>();
        }
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

      

        public ICollection<Star> Stars { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }

    public enum GenderType
    {
        NotRegister,
        Male ,
        Female  
    }
}