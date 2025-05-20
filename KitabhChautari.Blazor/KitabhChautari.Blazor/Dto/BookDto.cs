using System.ComponentModel.DataAnnotations;

namespace KitabhChautari.Maui.Models
{
    public class BookDto
    {
        public int BookId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string AuthorName { get; set; } = string.Empty;

        [Required]
        public decimal Price { get; set; }

        public int Stock { get; set; }

        [MaxLength(500)]
        public string CoverImageUrl { get; set; } = string.Empty;

        public bool IsOnSale { get; set; }

        [Range(0, 100)]
        public decimal? DiscountPercentage { get; set; }
    }

    public class BookEditDto
    {
        public int BookId { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [MaxLength(200, ErrorMessage = "Title cannot exceed 200 characters")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "ISBN is required")]
        [MaxLength(13, ErrorMessage = "ISBN cannot exceed 13 characters")]
        public string ISBN { get; set; } = string.Empty;

        [Required(ErrorMessage = "Price is required")]
        [Range(0, double.MaxValue, ErrorMessage = "Price must be non-negative")]
        public decimal Price { get; set; }

        public DateTime PublishedDate { get; set; } = DateTime.UtcNow;

        [Range(0, int.MaxValue, ErrorMessage = "Pages must be non-negative")]
        public int Pages { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Stock count must be non-negative")]
        public int StockCount { get; set; }

        [MaxLength(1000, ErrorMessage = "Synopsis cannot exceed 1000 characters")]
        public string Synopsis { get; set; } = string.Empty;

        [MaxLength(500, ErrorMessage = "Cover image URL cannot exceed 500 characters")]
        public string CoverImageUrl { get; set; } = string.Empty;

        public bool IsOnSale { get; set; }

        [Range(0, 100, ErrorMessage = "Discount must be between 0% and 100%")]
        public decimal? DiscountPercentage { get; set; }

        public Category? Category { get; set; }

        [Required(ErrorMessage = "Author ID is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Author ID must be a positive integer")]
        public int Author_id { get; set; }

        [Required(ErrorMessage = "Genre ID is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Genre ID must be a positive integer")]
        public int Genre_id { get; set; }

        [Required(ErrorMessage = "Publisher ID is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Publisher ID must be a positive integer")]
        public int Publisher_id { get; set; }
    }

  
}