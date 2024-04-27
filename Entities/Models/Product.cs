namespace Entities.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string? ProductName { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string? Summary { get; set; } = string.Empty;
        public string? ImageUrl { get; set; }
        public int? CategoryID { get; set; }
        public Category? Category { get; set; }
        public bool ShowCase { get; set; }
    }
}
