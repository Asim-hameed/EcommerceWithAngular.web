namespace EcommerceWithAngular.web.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string EmailAddress { get; set; }
        public DateTime? EnteredDate { get; set; }
        public virtual ICollection<CartItems> CartItems{ get;set;}= new HashSet<CartItem>();
        public virtual ICollection<Order> OrderItems { get;set; }= new HashSet<Order>();
    }
}