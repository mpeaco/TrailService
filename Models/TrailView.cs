using System.ComponentModel.DataAnnotations;

namespace TrailService.Models
{


    public class TrailView
    {
        [Required]
        public string TrailName { get; set; }
        [Key]
        [Required]
        public int TrailId { get; set; }

        public string TrailOwner { get; set; }

    }



}