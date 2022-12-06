using System.ComponentModel.DataAnnotations;

namespace TrailService.Dtos
{
    public class TrailCreateDto
    {/*
        [Key]
        [Required]
        //public int PointId { get; set; }
*/
        [Required]
        public string TrailName { get; set; }

        [Required]
        public int TrailId { get; set; }

        /*[Required]
        public decimal Latitude { get; set; }

        [Required]
        public decimal Longitude { get; set; }

        public string CommentId { get; set; }
        [Required]
        public decimal Elevation { get; set; }
        */
        public string TrailOwner { get; set; }

    }


}