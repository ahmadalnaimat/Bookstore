using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Bookstore.Models
{
    public class Book
    {
        public int BookId { get; set; }
        [Required]
        [StringLength(50,MinimumLength =10)]
        public string Title { get; set; }
        [Required]
        [StringLength(50,MinimumLength =2)]
        public string Author { get; set; }
        [Required]
        [Range(0, 1000.0)]
        public decimal Price { get; set; }
        [Required]
        public string Genre { get; set; }
    }
}
