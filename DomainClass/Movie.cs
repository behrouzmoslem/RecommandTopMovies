using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace DomainClass
{
    [Table("Movie",Schema = "TOP")]
    public  class Movie
    { 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [MaxLength(150, ErrorMessage = "Up to 150 chars")]
        [Required(ErrorMessage = "Please Latin Name is insert")]
        public string LatinName { get; set; }
        [MaxLength(150, ErrorMessage = "Up to 150 chars")]
        [Required(ErrorMessage = "Please Persian Name is insert")]
        public string PersianName { get; set; }
        [Range(1, 10)]
        public double Rate { get; set; }  
    } 
}