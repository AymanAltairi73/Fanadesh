using System.ComponentModel.DataAnnotations;

namespace fenadesh.Models
{
    public class Home
    {
        [Required]
        [Display]
        public int Id { get; set; }
        [Required]
        [Display]
        public string? Title { get; set; }
        [Required]
        [Display]
        public string? Description { get; set; }
        [Required]
        [Display]
        public string? ImageUrl { get; set; }

    }
}
