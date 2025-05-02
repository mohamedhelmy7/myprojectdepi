using DEPI_Library.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DEPI_Library.Models
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options)
        : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Borrow> Borrows { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Admins
            modelBuilder.Entity<Admin>().HasData(
                new Admin { AdminId = 1, Name = "Alice Admin", Email = "alice@admin.com", Password = "admin123" },
                new Admin { AdminId = 2, Name = "Bob Admin", Email = "bob@admin.com", Password = "admin123" }
            );

            // Seed Users
            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, Name = "John Doe", Email = "john@example.com", Password = "user123", Phone = "1234567890" },
                new User { UserId = 2, Name = "Jane Smith", Email = "jane@example.com", Password = "user123", Phone = "9876543210" }
            );

            // Seed Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Science Fiction" },
                new Category { CategoryId = 2, Name = "Fantasy" },
                new Category { CategoryId = 3, Name = "Mystery" },
                new Category { CategoryId = 4, Name = "Biography" },
                new Category { CategoryId = 5, Name = "History" },
                new Category { CategoryId = 6, Name = "Self Help" }
            );

            // Seed Books
            modelBuilder.Entity<Book>().HasData(
                // Science Fiction (1)
                new Book { BookId = 1, Title = "Dune", Author = "Frank Herbert", Description = "A desert planet and political intrigue.", CategoryId = 1, AdminId = 1 },
                new Book { BookId = 2, Title = "Neuromancer", Author = "William Gibson", Description = "Cyberpunk pioneer.", CategoryId = 1, AdminId = 1 },
                new Book { BookId = 3, Title = "Foundation", Author = "Isaac Asimov", Description = "A galactic empire's fall.", CategoryId = 1, AdminId = 1 },
                new Book { BookId = 4, Title = "Snow Crash", Author = "Neal Stephenson", Description = "A hacker in the Metaverse.", CategoryId = 1, AdminId = 1 },
                new Book { BookId = 5, Title = "Hyperion", Author = "Dan Simmons", Description = "Pilgrims on a doomed world.", CategoryId = 1, AdminId = 2 },
                new Book { BookId = 6, Title = "The Left Hand of Darkness", Author = "Ursula K. Le Guin", Description = "Gender and diplomacy on another planet.", CategoryId = 1, AdminId = 2 },
                new Book { BookId = 7, Title = "The Martian", Author = "Andy Weir", Description = "Survival on Mars.", CategoryId = 1, AdminId = 2 },
                new Book { BookId = 8, Title = "Red Mars", Author = "Kim Stanley Robinson", Description = "Terraforming Mars.", CategoryId = 1, AdminId = 2 },
                new Book { BookId = 9, Title = "Blindsight", Author = "Peter Watts", Description = "Contact with alien intelligence.", CategoryId = 1, AdminId = 1 },
                new Book { BookId = 10, Title = "Starship Troopers", Author = "Robert A. Heinlein", Description = "Military science fiction.", CategoryId = 1, AdminId = 1 },

                // History (2)
                new Book { BookId = 11, Title = "Sapiens", Author = "Yuval Noah Harari", Description = "Human evolution and culture.", CategoryId = 2, AdminId = 1 },
                new Book { BookId = 12, Title = "Guns, Germs, and Steel", Author = "Jared Diamond", Description = "Geography and societal development.", CategoryId = 2, AdminId = 1 },
                new Book { BookId = 13, Title = "The Silk Roads", Author = "Peter Frankopan", Description = "History through trade routes.", CategoryId = 2, AdminId = 2 },
                new Book { BookId = 14, Title = "The History of the Ancient World", Author = "Susan Wise Bauer", Description = "From the earliest accounts.", CategoryId = 2, AdminId = 2 },
                new Book { BookId = 15, Title = "1776", Author = "David McCullough", Description = "American Revolution.", CategoryId = 2, AdminId = 1 },
                new Book { BookId = 16, Title = "The Crusades", Author = "Thomas Asbridge", Description = "Religious wars of Europe.", CategoryId = 2, AdminId = 2 },
                new Book { BookId = 17, Title = "Postwar", Author = "Tony Judt", Description = "Europe after WWII.", CategoryId = 2, AdminId = 1 },
                new Book { BookId = 18, Title = "The Cold War", Author = "John Lewis Gaddis", Description = "Superpower tension.", CategoryId = 2, AdminId = 2 },
                new Book { BookId = 19, Title = "A People's History of the United States", Author = "Howard Zinn", Description = "History from below.", CategoryId = 2, AdminId = 1 },
                new Book { BookId = 20, Title = "The Wright Brothers", Author = "David McCullough", Description = "Early aviation.", CategoryId = 2, AdminId = 1 },
    // Programming (3)
    new Book { BookId = 21, Title = "Clean Code", Author = "Robert C. Martin", Description = "Write readable code.", CategoryId = 3, AdminId = 2 },
    new Book { BookId = 22, Title = "The Pragmatic Programmer", Author = "Andy Hunt", Description = "Programming philosophy.", CategoryId = 3, AdminId = 2 },
    new Book { BookId = 23, Title = "Design Patterns", Author = "Erich Gamma et al.", Description = "Reusable object-oriented solutions.", CategoryId = 3, AdminId = 2 },
    new Book { BookId = 24, Title = "Refactoring", Author = "Martin Fowler", Description = "Improve existing code.", CategoryId = 3, AdminId = 2 },
    new Book { BookId = 25, Title = "Domain-Driven Design", Author = "Eric Evans", Description = "Complex software design.", CategoryId = 3, AdminId = 2 },
    new Book { BookId = 26, Title = "You Don’t Know JS", Author = "Kyle Simpson", Description = "Deep JavaScript concepts.", CategoryId = 3, AdminId = 1 },
    new Book { BookId = 27, Title = "C# in Depth", Author = "Jon Skeet", Description = "Advanced C# concepts.", CategoryId = 3, AdminId = 1 },
    new Book { BookId = 28, Title = "Code Complete", Author = "Steve McConnell", Description = "Software construction.", CategoryId = 3, AdminId = 1 },
    new Book { BookId = 29, Title = "The Mythical Man-Month", Author = "Frederick Brooks", Description = "Software project management.", CategoryId = 3, AdminId = 1 },
    new Book { BookId = 30, Title = "Cracking the Coding Interview", Author = "Gayle Laakmann McDowell", Description = "Interview preparation.", CategoryId = 3, AdminId = 2 },

    // Fantasy (4)
    new Book { BookId = 31, Title = "The Hobbit", Author = "J.R.R. Tolkien", Description = "A journey to the Lonely Mountain.", CategoryId = 4, AdminId = 1 },
    new Book { BookId = 32, Title = "The Fellowship of the Ring", Author = "J.R.R. Tolkien", Description = "First part of Lord of the Rings.", CategoryId = 4, AdminId = 1 },
    new Book { BookId = 33, Title = "A Game of Thrones", Author = "George R. R. Martin", Description = "War of the Seven Kingdoms.", CategoryId = 4, AdminId = 2 },
    new Book { BookId = 34, Title = "The Name of the Wind", Author = "Patrick Rothfuss", Description = "A wizard’s coming of age.", CategoryId = 4, AdminId = 2 },
    new Book { BookId = 35, Title = "The Way of Kings", Author = "Brandon Sanderson", Description = "Epic fantasy world.", CategoryId = 4, AdminId = 2 },
    new Book { BookId = 36, Title = "Mistborn", Author = "Brandon Sanderson", Description = "Magical heists.", CategoryId = 4, AdminId = 2 },
    new Book { BookId = 37, Title = "Eragon", Author = "Christopher Paolini", Description = "A dragon rider's tale.", CategoryId = 4, AdminId = 1 },
    new Book { BookId = 38, Title = "The Wheel of Time", Author = "Robert Jordan", Description = "A long prophecy-filled saga.", CategoryId = 4, AdminId = 1 },
    new Book { BookId = 39, Title = "The Chronicles of Narnia", Author = "C.S. Lewis", Description = "Fantasy for all ages.", CategoryId = 4, AdminId = 1 },
    new Book { BookId = 40, Title = "The Lies of Locke Lamora", Author = "Scott Lynch", Description = "Fantasy thievery.", CategoryId = 4, AdminId = 1 },

    // Biography (5)
    new Book { BookId = 41, Title = "The Diary of Anne Frank", Author = "Anne Frank", Description = "A teenage girl's WWII diary.", CategoryId = 5, AdminId = 2 },
    new Book { BookId = 42, Title = "Long Walk to Freedom", Author = "Nelson Mandela", Description = "Mandela's autobiography.", CategoryId = 5, AdminId = 2 },
    new Book { BookId = 43, Title = "Steve Jobs", Author = "Walter Isaacson", Description = "Biography of Apple founder.", CategoryId = 5, AdminId = 1 },
    new Book { BookId = 44, Title = "Einstein", Author = "Walter Isaacson", Description = "Biography of Albert Einstein.", CategoryId = 5, AdminId = 1 },
    new Book { BookId = 45, Title = "Becoming", Author = "Michelle Obama", Description = "Memoir of the First Lady.", CategoryId = 5, AdminId = 2 },
    new Book { BookId = 46, Title = "Educated", Author = "Tara Westover", Description = "A woman’s quest for knowledge.", CategoryId = 5, AdminId = 2 },
    new Book { BookId = 47, Title = "When Breath Becomes Air", Author = "Paul Kalanithi", Description = "Life and death of a doctor.", CategoryId = 5, AdminId = 1 },
    new Book { BookId = 48, Title = "The Wright Brothers", Author = "David McCullough", Description = "Pioneers of aviation.", CategoryId = 5, AdminId = 1 },
    new Book { BookId = 49, Title = "Leonardo da Vinci", Author = "Walter Isaacson", Description = "Renaissance genius.", CategoryId = 5, AdminId = 1 },
    new Book { BookId = 50, Title = "Bossypants", Author = "Tina Fey", Description = "Comedian’s life story.", CategoryId = 5, AdminId = 2 },

    // Philosophy (6)
    new Book { BookId = 51, Title = "The Republic", Author = "Plato", Description = "Justice and politics.", CategoryId = 6, AdminId = 2 },
    new Book { BookId = 52, Title = "Meditations", Author = "Marcus Aurelius", Description = "Stoic thoughts of a Roman emperor.", CategoryId = 6, AdminId = 1 },
    new Book { BookId = 53, Title = "Beyond Good and Evil", Author = "Friedrich Nietzsche", Description = "Moral philosophy.", CategoryId = 6, AdminId = 2 },
    new Book { BookId = 54, Title = "Critique of Pure Reason", Author = "Immanuel Kant", Description = "Theory of knowledge.", CategoryId = 6, AdminId = 2 },
    new Book { BookId = 55, Title = "Being and Time", Author = "Martin Heidegger", Description = "Existential ontology.", CategoryId = 6, AdminId = 2 },
    new Book { BookId = 56, Title = "The Prince", Author = "Niccolò Machiavelli", Description = "Power and politics.", CategoryId = 6, AdminId = 1 },
    new Book { BookId = 57, Title = "Tao Te Ching", Author = "Laozi", Description = "Taoist philosophy.", CategoryId = 6, AdminId = 1 },
    new Book { BookId = 58, Title = "The Art of War", Author = "Sun Tzu", Description = "Strategy and conflict.", CategoryId = 6, AdminId = 1 },
    new Book { BookId = 59, Title = "Letters from a Stoic", Author = "Seneca", Description = "Roman Stoic wisdom.", CategoryId = 6, AdminId = 2 },
    new Book { BookId = 60, Title = "The Myth of Sisyphus", Author = "Albert Camus", Description = "Absurdism and meaning.", CategoryId = 6, AdminId = 2 }
            );

            // Seed Borrows
            modelBuilder.Entity<Borrow>().HasData(
                new Borrow { BorrowId = 1, UserId = 1, BookId = 1, BorrowDate = new DateTimeOffset(2025, 4, 15, 0, 0, 0, TimeSpan.Zero) },
                new Borrow { BorrowId = 2, UserId = 1, BookId = 2, BorrowDate = new DateTimeOffset(2025, 4, 20, 0, 0, 0, TimeSpan.Zero) },
                new Borrow { BorrowId = 3, UserId = 2, BookId = 3, BorrowDate = new DateTimeOffset(2025, 4, 22, 0, 0, 0, TimeSpan.Zero) },
                new Borrow { BorrowId = 4, UserId = 2, BookId = 4, BorrowDate = new DateTimeOffset(2025, 4, 25, 0, 0, 0, TimeSpan.Zero) },
                new Borrow { BorrowId = 5, UserId = 1, BookId = 5, BorrowDate = new DateTimeOffset(2025, 5, 1, 0, 0, 0, TimeSpan.Zero) }
            );
        }

    }
}
