using DEPI_Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DEPI_Library.Controllers
{
    public class UserAuthController(LibraryContext context) : Controller
    {

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
                if (context.Users.Any(u => u.Email == user.Email))
                {
                    ModelState.AddModelError("Email", "Email is already registered.");
                    return View(user);
                }

                context.Users.Add(user);
                context.SaveChanges();
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
            var user = context.Users
                .FirstOrDefault(u => u.Email == email && u.PasswordHash == password);

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
