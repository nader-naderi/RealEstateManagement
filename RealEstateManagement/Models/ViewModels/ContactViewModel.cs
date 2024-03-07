using System.ComponentModel.DataAnnotations;

namespace RealEstateManagement.Models.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(1000)]
        public string Message { get; set; }
    }

}
