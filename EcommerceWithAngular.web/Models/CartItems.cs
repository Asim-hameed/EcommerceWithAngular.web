namespace EcommerceWithAngular.web.Models
{
    public class CartItems
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Price { get; set; }
        public virtual Customer Customer { get; set; }

    }
}