namespace KitabhChautari.Maui.Models
{
    using System.ComponentModel.DataAnnotations;

    public class MemberDto
    {
        public int MemberId { get; set; }

        [Required]
        [MaxLength(100)]
        [MinLength(2)]
        public required string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        [MinLength(2)]
        public required string LastName { get; set; }

        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        //public MembershipStatus MembershipStatus { get; set; } = MembershipStatus.Active;

        [DataType(DataType.DateTime)]
        public DateTime RegistrationDate { get; set; } = DateTime.UtcNow;
    }
}