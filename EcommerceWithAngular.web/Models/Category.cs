namespace EcommerceWithAngular.web.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string categoryName { get; set; }
        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
        public virtual ICollection<SubCategory> SubCategories { get; set; } = new HashSet<SubCategory>();

    }
}
