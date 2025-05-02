using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DEPI_Library.Models;

public class AdminsController : Controller
{
    private readonly LibraryContext _context;

    public AdminsController(LibraryContext context)
    {
        _context = context;
    }

   public IActionResult Index()
    {
        var admins = _context.Admins
            .Include(a => a.Books)
            .ToList();
        return View(admins);
    }
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Admin admin)
    {
        if (ModelState.IsValid)
        {
            _context.Admins.Add(admin);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(admin);
    }
}
