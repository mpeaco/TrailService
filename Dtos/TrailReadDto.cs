using System;

namespace TrailService.Dtos
{
    public class TrailReadDto
    {
        public string TrailName { get; set; }

        public int TrailId { get; set; }
        public string TrailOwner { get; set; }
    }
}