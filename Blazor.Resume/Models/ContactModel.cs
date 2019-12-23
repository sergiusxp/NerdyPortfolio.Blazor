using System.ComponentModel.DataAnnotations;

namespace Blazor.Resume.Models
{
    public class ContactModel
    {
        [Required]
        [StringLength(20, ErrorMessage = "Name is too long.")]
        public string Name { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Surname is too long.")]
        public string Surname { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Subjet is too long.")]
        public string Subject { get; set; }

        [Required]
        public string Category { get; set; } = "Work";

        [Required]
        public string Text { get; set; }
    }
}
