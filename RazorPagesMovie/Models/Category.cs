using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Category
    {
        public int ID { get; set; }
        
        [MaxLength(200)]
        [Required]
        public string Name { get; set; } = string.Empty;
    }
}