using DEPI_Library.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DEPI_Library.Models
{
    public class Admin
    {
        public long AdminId { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        public ICollection<Book>? Books { get; set; }
    }
}
