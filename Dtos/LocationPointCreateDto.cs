using System.ComponentModel.DataAnnotations;

namespace TrailService.Dtos
{
    public class LocationPointCreateDto
    {
        [Required]
        public string TrailName { get; set; }
        [Required]
        public int PointId { get; set; }
        [Required]
        public decimal Latitude { get; set; }
        [Required]
        public decimal Longitude { get; set; }
        [Required]
        public decimal Elevation { get; set; }
        public string CommentId { get; set; }

    }


}