﻿using System.ComponentModel.DataAnnotations;

namespace DatingApp.DTOs
{
    public class RegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength (8,MinimumLength =6)]
        public string Password { get; set; }
    }
}
