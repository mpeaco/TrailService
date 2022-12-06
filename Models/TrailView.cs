using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrailService.Models
{

    [Table("Trails", Schema = "Cw1")]
    public class TrailView
    {
        [Column("Trail_name")]
        [Required]
        public string TrailName { get; set; }
        [Key]
        [Required]
        [Column("Trail_id")]
        public int TrailId { get; set; }

        [Column("Trail_owner")]
        public string TrailOwner { get; set; }

    }



}