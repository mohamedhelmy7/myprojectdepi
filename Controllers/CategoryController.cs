using DEPI_Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DEPI_Library.Controllers
{
    public class CategoryController(LibraryContext context) : Controller
    {
        public IActionResult Index()
        {
            List<Category> categories = [.. context.Categories];
              

            return View (categories);
        }
        public IActionResult BooksByCategory(long id)
        {
            var category = context.Categories
                .Include(c => c.Books) // ندرج الكتب الخاصة بالتصنيف
                .FirstOrDefault(c => c.CategoryId == id);

            if (category == null)
                return NotFound();

            return View(category);
        }


    }
}
