using DEPI_Library.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class BooksController : Controller
{
    private readonly LibraryContext _context;

    public BooksController(LibraryContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var books = _context.Books
            .Include(b => b.Category)
            .ToList(); // Removed Admin
        return View(books);
    }

    public IActionResult Create()
    {
        ViewBag.Categories = new SelectList(_context.Categories, "CategoryId", "Name");
        return View();
    }

    [HttpPost]
    public IActionResult Create(Book book)
    {
        if (ModelState.IsValid)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        ViewBag.Categories = new SelectList(_context.Categories, "CategoryId", "Name", book.CategoryId);
        return View(book);
    }

    // ========== EDIT ==========

    public IActionResult Edit(long id)
    {
        var book = _context.Books.Find(id);
        if (book == null) return NotFound();

        ViewBag.Categories = new SelectList(_context.Categories, "CategoryId", "Name", book.CategoryId);
        return View(book);
    }

    [HttpPost]
    public IActionResult Edit(Book book)
    {
        if (ModelState.IsValid)
        {
            _context.Books.Update(book);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        ViewBag.Categories = new SelectList(_context.Categories, "CategoryId", "Name", book.CategoryId);
        return View(book);
    }

    // ========== DELETE ==========

    public IActionResult Delete(long id)
    {
        var book = _context.Books
            .Include(b => b.Category)
            .FirstOrDefault(b => b.BookId == id);

        if (book == null) return NotFound();
        return View(book);
    }

    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteConfirmed(long id)
    {
        var book = _context.Books.Find(id);
        if (book == null) return NotFound();

        _context.Books.Remove(book);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}
