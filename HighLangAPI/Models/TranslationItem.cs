using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HighLangAPI.Models
{
    public class TranslationItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(10)]
        public string Lang { get; set; } = string.Empty;
        [Required]
        public string HTMLText { get; set; } = string.Empty;
        [Required]
        [ForeignKey("OriginalId")]
        public OriginalItem OriginalItem { get; set; }
        [Required]
        public string AudioPath { get; set; } = string.Empty;
    }
}
