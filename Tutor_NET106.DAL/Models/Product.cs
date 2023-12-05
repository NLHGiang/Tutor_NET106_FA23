namespace Tutor_NET106.DAL.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public string ProductName { get; set; }
        public float Price { get; set; }
        public int Amount { get; set; }

        public virtual Category? Category { get; set; }
    }
}
