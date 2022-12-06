using System;

namespace TrailService.Dtos
{
    public class TrailReadDto
    {

        public int PointId { get; set; }

        public string TrailName { get; set; }

        public int TrailId { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }

        public string CommentId { get; set; }

        public decimal Elevation { get; set; }

        public string TrailOwner { get; set; }
    }
}