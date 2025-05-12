using DEPI_Library.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DEPI_Library.Controllers
{

    public class BooksController(LibraryContext context) : Controller
    {
        public IActionResult Index()
        {
            var books = context.Books
                .Include(b => b.Category)
                .ToList(); // Removed Admin
            return View(books);
        }

        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(context.Categories, "CategoryId", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                context.Books.Add(book);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Categories = new SelectList(context.Categories, "CategoryId", "Name", book.CategoryId);
            return View(book);
        }

        // ========== EDIT ==========

        public IActionResult Edit(long id)
        {
            var book = context.Books.Find(id);
            if (book == null) return NotFound();

            ViewBag.Categories = new SelectList(context.Categories, "CategoryId", "Name", book.CategoryId);
            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                context.Books.Update(book);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Categories = new SelectList(context.Categories, "CategoryId", "Name", book.CategoryId);
            return View(book);
        }

        // ========== DELETE ==========

        public IActionResult Delete(long id)
        {
            var book = context.Books
                .Include(b => b.Category)
                .FirstOrDefault(b => b.BookId == id);

            if (book == null) return NotFound();
            return View(book);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(long id)
        {
            var book = context.Books.Find(id);
            if (book == null) return NotFound();

            // 🆕 Delete related Borrows first
            var borrows = context.Borrows.Where(b => b.BookId == book.BookId);
            context.Borrows.RemoveRange(borrows);

            // Then delete the book
            context.Books.Remove(book);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
