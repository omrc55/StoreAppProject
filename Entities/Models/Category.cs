namespace Entities.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string? CategoryName { get; set; } = string.Empty;
        public ICollection<Product>? Products { get; set; }
    }
}
