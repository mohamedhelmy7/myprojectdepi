using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DEPI_Library.Migrations
{
    /// <inheritdoc />
    public partial class SeedDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "AdminId", "Email", "Name", "Password" },
                values: new object[,]
                {
                    { 1L, "alice@admin.com", "Alice Admin", "admin123" },
                    { 2L, "bob@admin.com", "Bob Admin", "admin123" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1L, "Science Fiction" },
                    { 2L, "Fantasy" },
                    { 3L, "Mystery" },
                    { 4L, "Biography" },
                    { 5L, "History" },
                    { 6L, "Self Help" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "Name", "Password", "Phone" },
                values: new object[,]
                {
                    { 1L, "john@example.com", "John Doe", "user123", "1234567890" },
                    { 2L, "jane@example.com", "Jane Smith", "user123", "9876543210" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AdminId", "Author", "CategoryId", "Description", "Title" },
                values: new object[,]
                {
                    { 1L, 1L, "Frank Herbert", 1L, "A desert planet and political intrigue.", "Dune" },
                    { 2L, 1L, "William Gibson", 1L, "Cyberpunk pioneer.", "Neuromancer" },
                    { 3L, 1L, "Isaac Asimov", 1L, "A galactic empire's fall.", "Foundation" },
                    { 4L, 1L, "Neal Stephenson", 1L, "A hacker in the Metaverse.", "Snow Crash" },
                    { 5L, 2L, "Dan Simmons", 1L, "Pilgrims on a doomed world.", "Hyperion" },
                    { 6L, 2L, "Ursula K. Le Guin", 1L, "Gender and diplomacy on another planet.", "The Left Hand of Darkness" },
                    { 7L, 2L, "Andy Weir", 1L, "Survival on Mars.", "The Martian" },
                    { 8L, 2L, "Kim Stanley Robinson", 1L, "Terraforming Mars.", "Red Mars" },
                    { 9L, 1L, "Peter Watts", 1L, "Contact with alien intelligence.", "Blindsight" },
                    { 10L, 1L, "Robert A. Heinlein", 1L, "Military science fiction.", "Starship Troopers" },
                    { 11L, 1L, "Yuval Noah Harari", 2L, "Human evolution and culture.", "Sapiens" },
                    { 12L, 1L, "Jared Diamond", 2L, "Geography and societal development.", "Guns, Germs, and Steel" },
                    { 13L, 2L, "Peter Frankopan", 2L, "History through trade routes.", "The Silk Roads" },
                    { 14L, 2L, "Susan Wise Bauer", 2L, "From the earliest accounts.", "The History of the Ancient World" },
                    { 15L, 1L, "David McCullough", 2L, "American Revolution.", "1776" },
                    { 16L, 2L, "Thomas Asbridge", 2L, "Religious wars of Europe.", "The Crusades" },
                    { 17L, 1L, "Tony Judt", 2L, "Europe after WWII.", "Postwar" },
                    { 18L, 2L, "John Lewis Gaddis", 2L, "Superpower tension.", "The Cold War" },
                    { 19L, 1L, "Howard Zinn", 2L, "History from below.", "A People's History of the United States" },
                    { 20L, 1L, "David McCullough", 2L, "Early aviation.", "The Wright Brothers" },
                    { 21L, 2L, "Robert C. Martin", 3L, "Write readable code.", "Clean Code" },
                    { 22L, 2L, "Andy Hunt", 3L, "Programming philosophy.", "The Pragmatic Programmer" },
                    { 23L, 2L, "Erich Gamma et al.", 3L, "Reusable object-oriented solutions.", "Design Patterns" },
                    { 24L, 2L, "Martin Fowler", 3L, "Improve existing code.", "Refactoring" },
                    { 25L, 2L, "Eric Evans", 3L, "Complex software design.", "Domain-Driven Design" },
                    { 26L, 1L, "Kyle Simpson", 3L, "Deep JavaScript concepts.", "You Don’t Know JS" },
                    { 27L, 1L, "Jon Skeet", 3L, "Advanced C# concepts.", "C# in Depth" },
                    { 28L, 1L, "Steve McConnell", 3L, "Software construction.", "Code Complete" },
                    { 29L, 1L, "Frederick Brooks", 3L, "Software project management.", "The Mythical Man-Month" },
                    { 30L, 2L, "Gayle Laakmann McDowell", 3L, "Interview preparation.", "Cracking the Coding Interview" },
                    { 31L, 1L, "J.R.R. Tolkien", 4L, "A journey to the Lonely Mountain.", "The Hobbit" },
                    { 32L, 1L, "J.R.R. Tolkien", 4L, "First part of Lord of the Rings.", "The Fellowship of the Ring" },
                    { 33L, 2L, "George R. R. Martin", 4L, "War of the Seven Kingdoms.", "A Game of Thrones" },
                    { 34L, 2L, "Patrick Rothfuss", 4L, "A wizard’s coming of age.", "The Name of the Wind" },
                    { 35L, 2L, "Brandon Sanderson", 4L, "Epic fantasy world.", "The Way of Kings" },
                    { 36L, 2L, "Brandon Sanderson", 4L, "Magical heists.", "Mistborn" },
                    { 37L, 1L, "Christopher Paolini", 4L, "A dragon rider's tale.", "Eragon" },
                    { 38L, 1L, "Robert Jordan", 4L, "A long prophecy-filled saga.", "The Wheel of Time" },
                    { 39L, 1L, "C.S. Lewis", 4L, "Fantasy for all ages.", "The Chronicles of Narnia" },
                    { 40L, 1L, "Scott Lynch", 4L, "Fantasy thievery.", "The Lies of Locke Lamora" },
                    { 41L, 2L, "Anne Frank", 5L, "A teenage girl's WWII diary.", "The Diary of Anne Frank" },
                    { 42L, 2L, "Nelson Mandela", 5L, "Mandela's autobiography.", "Long Walk to Freedom" },
                    { 43L, 1L, "Walter Isaacson", 5L, "Biography of Apple founder.", "Steve Jobs" },
                    { 44L, 1L, "Walter Isaacson", 5L, "Biography of Albert Einstein.", "Einstein" },
                    { 45L, 2L, "Michelle Obama", 5L, "Memoir of the First Lady.", "Becoming" },
                    { 46L, 2L, "Tara Westover", 5L, "A woman’s quest for knowledge.", "Educated" },
                    { 47L, 1L, "Paul Kalanithi", 5L, "Life and death of a doctor.", "When Breath Becomes Air" },
                    { 48L, 1L, "David McCullough", 5L, "Pioneers of aviation.", "The Wright Brothers" },
                    { 49L, 1L, "Walter Isaacson", 5L, "Renaissance genius.", "Leonardo da Vinci" },
                    { 50L, 2L, "Tina Fey", 5L, "Comedian’s life story.", "Bossypants" },
                    { 51L, 2L, "Plato", 6L, "Justice and politics.", "The Republic" },
                    { 52L, 1L, "Marcus Aurelius", 6L, "Stoic thoughts of a Roman emperor.", "Meditations" },
                    { 53L, 2L, "Friedrich Nietzsche", 6L, "Moral philosophy.", "Beyond Good and Evil" },
                    { 54L, 2L, "Immanuel Kant", 6L, "Theory of knowledge.", "Critique of Pure Reason" },
                    { 55L, 2L, "Martin Heidegger", 6L, "Existential ontology.", "Being and Time" },
                    { 56L, 1L, "Niccolò Machiavelli", 6L, "Power and politics.", "The Prince" },
                    { 57L, 1L, "Laozi", 6L, "Taoist philosophy.", "Tao Te Ching" },
                    { 58L, 1L, "Sun Tzu", 6L, "Strategy and conflict.", "The Art of War" },
                    { 59L, 2L, "Seneca", 6L, "Roman Stoic wisdom.", "Letters from a Stoic" },
                    { 60L, 2L, "Albert Camus", 6L, "Absurdism and meaning.", "The Myth of Sisyphus" }
                });

            migrationBuilder.InsertData(
                table: "Borrows",
                columns: new[] { "BorrowId", "BookId", "BorrowDate", "UserId" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTimeOffset(new DateTime(2025, 4, 21, 21, 7, 26, 671, DateTimeKind.Unspecified).AddTicks(1723), new TimeSpan(0, 3, 0, 0, 0)), 1L },
                    { 2L, 2L, new DateTimeOffset(new DateTime(2025, 4, 26, 21, 7, 26, 678, DateTimeKind.Unspecified).AddTicks(6385), new TimeSpan(0, 3, 0, 0, 0)), 1L },
                    { 3L, 3L, new DateTimeOffset(new DateTime(2025, 4, 29, 21, 7, 26, 678, DateTimeKind.Unspecified).AddTicks(6407), new TimeSpan(0, 3, 0, 0, 0)), 2L },
                    { 4L, 4L, new DateTimeOffset(new DateTime(2025, 4, 30, 21, 7, 26, 678, DateTimeKind.Unspecified).AddTicks(6412), new TimeSpan(0, 3, 0, 0, 0)), 2L },
                    { 5L, 5L, new DateTimeOffset(new DateTime(2025, 5, 1, 21, 7, 26, 678, DateTimeKind.Unspecified).AddTicks(6414), new TimeSpan(0, 3, 0, 0, 0)), 1L }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "BorrowId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "BorrowId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "BorrowId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "BorrowId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "BorrowId",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AdminId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AdminId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1L);
        }
    }
}
