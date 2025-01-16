using System.ComponentModel.DataAnnotations;

namespace api.Dtos.Comment
{
    public class UpdateCommentRequestDto
    {
        [Required]
        [MinLength(5, ErrorMessage = "Title must be 5 characters at least")]
        [MaxLength(28, ErrorMessage = "Title must be 28 characters at most")]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MinLength(5, ErrorMessage = "Content must be 5 characters at least")]
        [MaxLength(280, ErrorMessage = "Content must be 280 characters at most")]
        public string Content { get; set; } = string.Empty;
    }
}
