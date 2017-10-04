using System.ComponentModel.DataAnnotations.Schema;

namespace DomainClass
{
    public class UserMovie
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int UserId { get; set; }

        [Column("IsActived")]
        public bool Accepted { get; set; } = false;
    }
}