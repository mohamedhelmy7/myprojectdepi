using DEPI_Library.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DEPI_Library.Models
{
    public class User
    {
        public long UserId { get; set; }

        [Required, MaxLength(100)]
        public required string Name { get; set; }

        [Required, EmailAddress]
        public required string Email { get; set; }

        [Required, DataType(DataType.Password)]
        public required string Password { get; set; }

        [Phone]
        public string? Phone { get; set; }

        public ICollection<Borrow>? Borrows { get; set; }
    }
}
