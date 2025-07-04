using System.ComponentModel.DataAnnotations;

namespace MovieApi.Models.DTOs
{
    public class MovieDetailsDto
    {
        [Required]
        [StringLength(100)]
        public string Synopsis { get; set; } = string.Empty;
        [Required]
        public string Language { get; set; } = string.Empty;
        [Required] 
        public decimal Budget { get; set; }


    }
}
