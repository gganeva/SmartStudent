using System.ComponentModel.DataAnnotations;

namespace SmartStudent.Data.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}