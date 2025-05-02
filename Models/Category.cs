using DEPI_Library.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DEPI_Library.Models
{
    public class Category
    {
        public long CategoryId { get; set; }

        [Required, MaxLength(100)]
        public required string Name { get; set; }

        public ICollection<Book>? Books { get; set; }
    }
}
