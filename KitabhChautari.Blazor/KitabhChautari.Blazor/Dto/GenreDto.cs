namespace KitabhChautari.Maui.Models
{
    using System.ComponentModel.DataAnnotations;

    public class GenreDto
    {
        public int Genre_id { get; set; }

        [Required(ErrorMessage = "Genre name is required")]
        [StringLength(100, ErrorMessage = "Genre name cannot be longer than 100 characters")]
        public string Genre_Name { get; set; } = string.Empty;
    }
}