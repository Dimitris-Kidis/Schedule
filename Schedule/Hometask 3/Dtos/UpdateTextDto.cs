using System.ComponentModel.DataAnnotations;

namespace HT3.Dtos
{
    public class UpdateTextDto
    {
        [Required]
        [StringLength(400)]
        public string TextContent { get; set; }
        [Required]
        [StringLength(40)]
        public string Author { get; set; }
        [Required]
        [Range(1,5)]
        public int Level { get; set; }
    }
}
