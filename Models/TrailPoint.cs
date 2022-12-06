using System.ComponentModel.DataAnnotations;

namespace TrailService.Models
{
    // This object is for each location point in the Trail - 
    // This will use a view implemented in mssql containing all points(Lat/Lon) for a specific trail 
    public class TrailPoint
    {
        [Key]
        [Required]
        public int PointId { get; set; }

        [Required]
        public string TrailName { get; set; }

        [Required]
        public int TrailId { get; set; }

        [Required]
        public decimal Latitude { get; set; }

        [Required]
        public decimal Longitude { get; set; }

        public string CommentId { get; set; }
        [Required]
        public decimal Elevation { get; set; }
        public string TrailOwner { get; set; }

    }
}