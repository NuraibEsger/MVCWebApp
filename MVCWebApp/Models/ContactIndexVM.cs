using MVCWebApp.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCWebApp.Models
{
    public class ContactIndexVM
    {
        [Required(ErrorMessage = "Name is required!")]
        [MinLength(3, ErrorMessage = "Name can't be less than 5 characters!")]
        [MaxLength(20, ErrorMessage = "Name can't be more than 10 characters!")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Subject is required")]
        [MaxLength(120)]
        public string? Subject { get; set; }
        [Required(ErrorMessage = "Message is required")]
        [MaxLength(255)]
        public string? Message { get; set; }
    }
}
