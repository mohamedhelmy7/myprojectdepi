using DEPI_Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class CategoryController : Controller
{
   
    private readonly LibraryContext _context;

    public CategoryController(LibraryContext context)
    // Constructor to initialize the context
    {
       
        _context = context;
       
    }

    public IActionResult Index()
    {
        List<Category> categories =  _context.Categories.ToList();
              

        return View (categories);
    }
    public IActionResult BooksByCategory(long id)
    {
        var category = _context.Categories
            .Include(c => c.Books) // ندرج الكتب الخاصة بالتصنيف
            .FirstOrDefault(c => c.CategoryId == id);

        if (category == null)
            return NotFound();

        return View(category);
    }


}
