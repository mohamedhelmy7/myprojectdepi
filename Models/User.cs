using System.ComponentModel.DataAnnotations;

namespace DEPI_Library.Models
{
    public class User
    {
        public long UserId { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }

        public string PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public ICollection<Borrow>? Borrows { get; set; }
    }

}
