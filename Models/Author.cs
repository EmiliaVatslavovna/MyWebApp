using System.ComponentModel.DataAnnotations;

namespace MyWebApp.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public string? Name { get; set; }
        public string? Bio { get; set; }
        public string? PhotoURL { get; set; }  
    }
}
