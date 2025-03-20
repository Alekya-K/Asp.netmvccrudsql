using System.ComponentModel.DataAnnotations;

namespace crudmvc.Models
{
    public class ProductDto
    {
        [Required, MaxLength(100)]
        public string Name { get; set; } = "";

        [Required, MaxLength(100)]
        public string Brand { get; set; } = "";

        [Required, MaxLength(100)]
        public string Category { get; set; } = "";

        [Required]

        public string Price { get; set; } = "";

        [Required, MaxLength(500)]
        public string Description { get; set; } = "";

        public IFormFile? ImageFile { get; set; }
    }
}
