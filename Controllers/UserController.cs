using DEPI_Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DEPI_Library.Controllers
{
    public class UserAuthController : Controller
    {
        private readonly LibraryContext _context;

        public UserAuthController(LibraryContext context)
        {
            _context = context;
        }

        // GET: UserAuth/Register
        public IActionResult Register()
        {
            return View();
        }

        // POST: UserAuth/Register
        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                if (_context.Users.Any(u => u.Email == user.Email))
                {
                    ModelState.AddModelError("Email", "Email is already registered.");
                    return View(user);
                }

                _context.Users.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Login");
            }

            return View(user);
        }

        // GET: UserAuth/Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: UserAuth/Login
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var user = _context.Users
                .FirstOrDefault(u => u.Email == email && u.Password == password);

            if (user != null)
            {
                TempData["UserName"] = user.Name;
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Invalid email or password.";
            return View();
        }
    }
}
