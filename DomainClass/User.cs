using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DomainClass
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(80, ErrorMessage = "Up to 80 chars")]
        [Required(ErrorMessage = "Please LastName is insert")]
        public string UserName { get; set; } 
        public bool IsActived { get; set; } 

    }
}