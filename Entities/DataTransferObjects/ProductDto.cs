using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects
{
    public record ProductDto
    {
        public int ProductID { get; init; }
        [Display(Name = "Product Name")]
        [Required(ErrorMessage = "Product Name is required.")]
        public string? ProductName { get; init; } = string.Empty;
        [Display(Name = "Price")]
        [Required(ErrorMessage = "Price is required.")]
        public decimal Price { get; init; }
        public string? Summary { get; init; } = string.Empty;
        [Display(Name = "Image Url")]
        public string? ImageUrl { get; set; }
        public int? CategoryID { get; init; }
        public bool ShowCase { get; set; }
    }
}
