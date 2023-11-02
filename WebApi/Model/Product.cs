using System.ComponentModel.DataAnnotations;

namespace WebApi.Model
{
    public class Product
    {
       

        [Key]
        public Guid Id { get; set; }

        public int ProductId { get; set; }
        public string Name { get; set; }

        public int Price { get; set; }
    }
}
