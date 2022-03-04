using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ActivityCenter.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace ActivityCenter.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private MyContext _context;

        public HomeController(ILogger<HomeController> logger, MyContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Index");
        }

        [HttpPost("register")]
        public IActionResult Register(User newUser)
        {
            if (ModelState.IsValid)
            {
                if (_context.Users.Any(u => u.email == newUser.email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.password = Hasher.HashPassword(newUser, newUser.password);

                _context.Users.Add(newUser);
                _context.SaveChanges();

                HttpContext.Session.SetString("email", newUser.email);
                HttpContext.Session.SetString("userId", newUser.userId.ToString());
                return RedirectToAction("dashboard");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpPost("login")]
        public IActionResult Login(LogUser logUser)
        {
            if (ModelState.IsValid)
            {
                User userInDb = _context.Users.FirstOrDefault(s => s.email == logUser.userEmail);
                if (userInDb == null)
                {
                    ModelState.AddModelError("Email", "Invalid login attempt");
                    return View("Index");
                }


                PasswordHasher<LogUser> Hasher = new PasswordHasher<LogUser>();

                PasswordVerificationResult result = Hasher.VerifyHashedPassword(logUser, userInDb.password, logUser.userPassword);

                if (result == 0)
                {
                    ModelState.AddModelError("Email", "Invalid login attempt");
                    return View("Index");
                }

                HttpContext.Session.SetString("email", logUser.userEmail);
                return RedirectToAction("dashboard");

            }
            return View("Index");
        }

        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            string email = HttpContext.Session.GetString("email");

            if (email == null)
            {

                return View("Index");
            }
            User currentUser = _context.Users.FirstOrDefault(z => z.email == email);
            ViewBag.userID = currentUser.userId;


            ViewBag.allShindigs = _context.Shindigs.Where(d => (d.date >= DateTime.Today)).OrderBy(t => t.date).Include(s => s.UserRef).Include(y => y.connections).ThenInclude(z => z.User).ToList();



            return View(currentUser);
        }


        [HttpPost("join")]
        public IActionResult Join(User_Shindig connection)
        {
            _context.User_Shindigs.Add(connection);
            _context.SaveChanges();

            return RedirectToAction("dashboard");
        }

        [HttpPost("leave")]
        public IActionResult Leave(User_Shindig connection)
        {
            _context.Remove(connection);
            _context.SaveChanges();

            return RedirectToAction("dashboard");
        }

        [HttpPost("join2")]
        public IActionResult Join2(User_Shindig connection)
        {

            _context.User_Shindigs.Add(connection);
            _context.SaveChanges();

            return RedirectToAction("dashboard");
        }

        [HttpPost("leave2")]
        public IActionResult Leave2(User_Shindig connection)
        {

            _context.Remove(connection);
            _context.SaveChanges();

            return RedirectToAction("dashboard");
        }

        [HttpGet("delete/{sid}")]
        public IActionResult Delete(int sid)
        {
            Shindig shindigToDelete = _context.Shindigs.SingleOrDefault(z => z.shindigId == sid);
            _context.Remove(shindigToDelete);

            List<User_Shindig> connectionsToDelete = _context.User_Shindigs.Where(y => y.shindigId == sid).ToList();

            foreach (User_Shindig c in connectionsToDelete)
            {
                _context.Remove(c);
            }
            _context.SaveChanges();

            return RedirectToAction("dashboard");
        }

        [HttpGet("form")]
        public IActionResult Form()
        {
            string email = HttpContext.Session.GetString("email");
            User currentUser = _context.Users.FirstOrDefault(z => z.email == email);
            ViewBag.userID = currentUser.userId;

            return View();
        }

        [HttpPost("details")]
        public IActionResult Details(Shindig newShindig)
        {
            if (ModelState.IsValid)
            {
                _context.Shindigs.Add(newShindig);
                _context.SaveChanges();
                return Redirect($"/oneShindig/{newShindig.shindigId}");
            }
            return View("form");
        }

        [HttpGet("oneShindig/{sid}")]
        public IActionResult OneShindig(int sid)
        {
            string email = HttpContext.Session.GetString("email");
            User currentUser = _context.Users.FirstOrDefault(z => z.email == email);
            ViewBag.user = currentUser;

            Shindig oneShindig = _context.Shindigs.Include(a => a.UserRef).Include(s => s.connections).ThenInclude(z => z.User).FirstOrDefault(z => z.shindigId == sid);

            return View(oneShindig);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
