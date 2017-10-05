using System.ComponentModel.DataAnnotations.Schema;

namespace DomainClass
{
    [ComplexType]
    public class Gender
    { 
        public int Id { get; set; }
        public string Title { get; set; }
    }
}