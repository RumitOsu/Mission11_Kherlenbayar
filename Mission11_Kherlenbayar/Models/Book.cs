using System.ComponentModel.DataAnnotations;

namespace Mission11_Kherlenbayar.Models
{
    public class Book
    {
        public int BookID { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public string? Author { get; set; }

        [Required]
        public string? Publisher { get; set; }

        [Required]
        [StringLength(13, MinimumLength = 10)]
        public string? ISBN { get; set; }

        [Required]
        public string? Classification { get; set; }

        [Required]
        public string? Category { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int PageCount { get; set; }

        [Required]
        [Range(0.01, double.MaxValue)]
        public double Price { get; set; }
    }
}
