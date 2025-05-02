using DEPI_Library.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace DEPI_Library.Models
{
    public class Borrow
    {
        public long BorrowId { get; set; }

        public long? UserId { get; set; }
        public User? User { get; set; }

        public long? BookId { get; set; }
        public Book? Book { get; set; }

        [DataType(DataType.Date)]
        public DateTimeOffset BorrowDate { get; set; }
    }
}
