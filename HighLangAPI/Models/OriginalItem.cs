// Models/TranslationItem.cs

using System.ComponentModel.DataAnnotations;

namespace HighLangAPI.Models
{
    public class OriginalItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; } = string.Empty;
    }
}
