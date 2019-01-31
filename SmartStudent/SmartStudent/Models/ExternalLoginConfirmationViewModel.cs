﻿using System.ComponentModel.DataAnnotations;

namespace SmartStudent.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}