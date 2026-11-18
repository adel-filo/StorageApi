using System.ComponentModel.DataAnnotations;

namespace StorageApi.DTOs
{
    public class CreateProductDto
    {
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; } = string.Empty;

        [Range(0, int.MaxValue, ErrorMessage = "Price must be 0 or higher.")]
        public int Price { get; set; }

        [Required]
        [StringLength(50)]
        public string Category { get; set; } = string.Empty;

        [Required]
        [StringLength(20)]
        public string Shelf { get; set; } = string.Empty;

        [Range(0, int.MaxValue, ErrorMessage = "Count must be 0 or higher.")]
        public int Count { get; set; }

        [StringLength(500)]
        public string Description { get; set; } = string.Empty;
    }
}
