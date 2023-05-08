using Microsoft.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

namespace PlatformSerivces.Models
{
    public class Platform
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Publisher { get; set; }
        public string Cost { get; set; }
    }
}
