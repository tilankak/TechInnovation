using System.ComponentModel.DataAnnotations;

namespace WebApi.Model
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        public int UserId { get; set; }
        public string Name { get; set; }

        
    }
}
