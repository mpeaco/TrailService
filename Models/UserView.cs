using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrailService.Models
{
    [Table("Users", Schema = "CW1")] //    Needs to change to CW2 for submission using remote server
    public class UserView
    {
        [Key]
        [Column("Username")]
        [Required]
        public string Username { get; set; }

        [Required]
        [Column("Email")]
        public string Email { get; set; }

        [Required]
        [Column("User_role")]
        public string User_role { get; set; }

    }
}