using BookLibrary;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace EFCoreWeb.Models
{
    public class BookModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Display(Name = "Year of Publication")]
        public int YearOfPublication { get; set; }
        
        public string Author { get; set; }
    }
}
