using MyWebApp.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace MyWebApp.Models
{
    public class Book
    {
            [Key]
            public int BookId { get; set; }
            public string? Title { get; set; }
            public string? Description { get; set; }
            public string? Author { get; set; }
            public BookCategory BookCategory { get; set; } 
    }
}
