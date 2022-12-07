using System.ComponentModel.DataAnnotations;

namespace TrailService.Dtos
{
    public class TrailCreateDto
    {
        [Required]
        public string TrailName { get; set; }

        [Required]
        public int TrailId { get; set; }

        public string TrailOwner { get; set; }

    }


}