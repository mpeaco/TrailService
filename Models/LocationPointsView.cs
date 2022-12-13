using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrailService.Models
{
    [Table("LocationPointView", Schema = "CW1")]
    public class LocationPointsView
    {
        // Trail_name
        // Point_id
        // Latitude
        // Longitude
        // Elevation
        // Comment_id

        [Required]
        [Key]
        [Column("Trail_name")]
        public string TrailName { get; set; }
        [Required]
        [Column("Point_id")]
        public int PointId { get; set; }
        [Required]
        [Column("Latitude")]
        public decimal Latitude { get; set; }
        [Required]
        [Column("Longitude")]
        public decimal Longitude { get; set; }
        [Required]
        [Column("Elevation")]
        public decimal Elevation { get; set; }
        [Column("Comment_id")]
        public string CommentId { get; set; }
    }
}
