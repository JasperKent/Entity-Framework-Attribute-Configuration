using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookLibrary
{
    [Table("Authors")]
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Column(TypeName ="date")]
        public DateTime DateOfBirth { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
