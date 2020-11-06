using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookLibrary
{
    [Table("Volumes")]
    public class Book
    {
        [Key]
        public string ISBN { get; set; }

        [Required]
        [MaxLength(20)]
        public string Title { get; set; }

        [Column("Year")]
        public int? YearOfPublication { get; set; }
        
        [Column(TypeName ="decimal (5,2)")]
        public decimal Price { get; set; }

        public int Id_Author { get; set; }

        [ForeignKey(nameof(Id_Author))]
        public Author Author { get; set; } = null!;
    }
}
