using DEPI_Library.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace DEPI_Library.Models

{
    public class Book
    {
        public long BookId { get; set; }

        [Required]
        public required string Title { get; set; }

        public required string Author { get; set; }

        public string? Description { get; set; }

        public long? CategoryId { get; set; }
        public Category? Category { get; set; }

        public long? AdminId { get; set; }
        public Admin? Admin { get; set; }

        public ICollection<Borrow>? Borrows { get; set; }
    }

}
