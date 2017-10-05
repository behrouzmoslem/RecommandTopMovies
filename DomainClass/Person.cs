using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainClass
{
 
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
}