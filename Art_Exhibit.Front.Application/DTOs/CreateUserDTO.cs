using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace Art_Exhibit.Front.Application.DTOs
{
    public class CreateUserDTO
    {
        [Required(ErrorMessage = "Required")]
        public string? Type { get; set; }

        [Required(ErrorMessage = "Required")]
        [MinLength(3, ErrorMessage = "Identifier is too short")]
        public string? Username { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Required")]
        public string? Password { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Required")]

        public string? Email { get; set; } = string.Empty;
    }
}
