﻿using System.ComponentModel.DataAnnotations;

namespace SmartStudent.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}