using DEPI_Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_Library.Controllers
{
    public class AccountController : Controller
    {
        private readonly LibraryContext _context;

        public AccountController(LibraryContext context)
        {
            _context = context;
        }

        // GET: Register page
        [HttpGet]
        public IActionResult Register() => View();

        // POST: Register page
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                using (var hmac = new HMACSHA512())
                {
                    var passwordBytes = Encoding.UTF8.GetBytes(model.Password);
                    var passwordHash = hmac.ComputeHash(passwordBytes);

                    var user = new User
                    {
                        Name = model.Name,
                        Email = model.Email,
                        PasswordHash = Convert.ToBase64String(passwordHash),
                        PasswordSalt = hmac.Key
                    };

                    _context.Users.Add(user);
                    await _context.SaveChangesAsync();

                    return RedirectToAction("Login");
                }
            }

            return View(model);
        }


        // GET: Login page
        [HttpGet]
        public IActionResult Login() => View();

        // POST: Login page
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _context.Users.SingleOrDefaultAsync(u => u.Email == model.Email);
                if (user != null)
                {
                    using (var hmac = new HMACSHA512(user.PasswordSalt))
                    {
                        var inputPasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(model.Password));
                        var inputPasswordHashBase64 = Convert.ToBase64String(inputPasswordHash);

                        if (user.PasswordHash == inputPasswordHashBase64)
                        {
                            HttpContext.Session.SetString("UserId", user.UserId.ToString());
                            return RedirectToAction("Index", "Home");
                        }
                    }
                }
                ModelState.AddModelError("", "Invalid login attempt.");
            }

            return View(model);
        }


        // POST: Logout
        [HttpPost]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("/Category");
        }



    }
}

