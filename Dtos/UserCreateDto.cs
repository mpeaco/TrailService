using System;
using System.ComponentModel.DataAnnotations;

namespace TrailService.Dtos
{
    public class UserCreateDto
    {
        [Key]
        [Required]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string User_role { get; set; }
    }
}