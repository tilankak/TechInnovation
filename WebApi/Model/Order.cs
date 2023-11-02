namespace WebApi.Model
{
    public class Order
    {
        public Guid Id { get; set; }
        public int OrderId { get; set; }
        public string Description { get; set; }

        public int UserId { get; set; }

        public int ProductId { get; set; }
    }
}
