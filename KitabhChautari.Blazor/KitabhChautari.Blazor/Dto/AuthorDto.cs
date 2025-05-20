namespace KitabhChautari.Blazor.Models
{
    public class AuthorDto
    {
        public int Author_id { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Author name is required")]
        [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Author name cannot be longer than 100 characters")]
        public string Author_name { get; set; } = string.Empty;
    }
}