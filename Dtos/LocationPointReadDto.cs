using System;

namespace TrailService.Dtos
{
    public class LocationPointReadDto
    {
        public string TrailName { get; set; }
        public int PointId { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public decimal Elevation { get; set; }
        public string CommentId { get; set; }
    }
}