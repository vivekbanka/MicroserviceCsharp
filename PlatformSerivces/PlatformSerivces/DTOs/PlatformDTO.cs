using System.ComponentModel.DataAnnotations;

namespace PlatformSerivces.DTOs
{
    public class PlatformDTO
    {
        [Key]
        [Required]
        public int Id { get; set; } 

        [Required]
        public string Name { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        public string Cost { get; set; }
    }
}
