using System.ComponentModel.DataAnnotations;

namespace TYPO.Hometask_3.Dtos
{
    public class UpdateTextContentDto
    {
        [Required]
        [StringLength(400)]
        public string TextContent { get; set; }
    }
}
