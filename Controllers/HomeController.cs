using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GOT.Models;

namespace GOT.Controllers
{
    public class HomeController : Controller
    {
               private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult CreateUser(LoginViewModel viewModel)
        {
            Console.WriteLine("############################");

            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u=>u.Email == viewModel.newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$");
                    return View("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                viewModel.newUser.Password = Hasher.HashPassword(viewModel.newUser, viewModel.newUser.Password);

                dbContext.Users.Add(viewModel.newUser);
                dbContext.SaveChanges();

                HttpContext.Session.SetInt32("InSession", viewModel.newUser.UserId);

                return RedirectToAction("Dashboard");


            }
                else
                {
                    Console.WriteLine("********************");
                    return View("Index");
                }
        }

         [HttpPost("login")]
        public IActionResult LoginUser(LoginViewModel viewModel)
        {
             if(ModelState.IsValid)
            {
                var dbUser = dbContext.Users.FirstOrDefault(u=>u.Email == viewModel.newLogin.loginEmail);
                if(dbUser == null)
                {
                    ModelState.AddModelError("Email", "Invalid Email");
                    return View("Index");
                }

                var hasher = new PasswordHasher<Login>();
                var result = hasher.VerifyHashedPassword(viewModel.newLogin, dbUser.Password, viewModel.newLogin.loginPassword);
                if(result == 0)
                {
                    ModelState.AddModelError("Password", "Password does not match email");
                    return View("Index");
                }
                HttpContext.Session.SetInt32("InSession", dbUser.UserId);

                return RedirectToAction("Dashboard");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet("Dashboard")]
        public IActionResult Dashboard()
        {
            if(HttpContext.Session.GetInt32("InSession")!=null)
            {
                DashboardViewModel viewModel = new DashboardViewModel();

                viewModel.currentShow = dbContext.Shows
                    .Include(w=>w.UserShows)
                    .ThenInclude(u=>u.User)
                    .ToList();

                viewModel.currentUser = dbContext.Users
                    .FirstOrDefault(u=>u.UserId==HttpContext.Session.GetInt32("InSession"));

                return View("Dashboard", viewModel);
            }
            return RedirectToAction("Index");
        }

        [HttpGet("/CreateShow")]
        public IActionResult CreateShow()
        {
            if(HttpContext.Session.GetInt32("InSession")!=null)
            {
                return View("Create");
            }
            return RedirectToAction("Index");
        }

        [HttpPost("AddShow")]
        public IActionResult AddShow(NewShowViewModel viewModel)
        {
            if(HttpContext.Session.GetInt32("InSession")!=null)
            {
                if(ModelState.IsValid)
                {
                    Show newShow = viewModel.newShow;
                    newShow.Host = dbContext.Users  
                        .FirstOrDefault(u=>u.UserId == HttpContext.Session.GetInt32("InSession"));
                    dbContext.Add(newShow);
                    dbContext.SaveChanges();
                    return RedirectToAction("Dashboard");
                }
                return View("Create");
            }
            return RedirectToAction("Index");
        }

        [HttpGet("UpcomingShows")]
        public IActionResult UpcomingShows()
        {
            if(HttpContext.Session.GetInt32("InSession")!=null)
            {
                List<Show> showList = dbContext.Shows
                    .OrderByDescending(s=>s.CreatedAt)
                    .ToList();
            
                return View("Shows", showList);
            }
            return RedirectToAction("Index");
        }

        [HttpGet("/ViewShow/{ShowId}")]
        public IActionResult ViewShow(int ShowId)
        {
            if(HttpContext.Session.GetInt32("InSession")!=null)
            {
                ViewShowViewModel viewModel = new ViewShowViewModel();

                viewModel.thisShow = dbContext.Shows
                    .Include(uw=>uw.UserShows)
                    .ThenInclude(ug=>ug.User)
                    .FirstOrDefault(p=>p.ShowId==ShowId);
                
                viewModel.thisUser = dbContext.Users
                    .FirstOrDefault(u=>u.UserId==HttpContext.Session.GetInt32("InSession"));
                return View("ViewShow", viewModel);
            }
            return RedirectToAction("Index");
        }

        [HttpGet("JoinEvent/{ShowId}/{UserId}")]
        public IActionResult JoinEvent(int ShowId, int UserId)
        {
            System.Console.WriteLine("*******************");
            if(HttpContext.Session.GetInt32("InSession")!=null)
            {
                System.Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&");
                UserShow userShow = new UserShow();
                userShow.UserId = UserId;
                userShow.ShowId = ShowId;

                dbContext.UserShows.Add(userShow);
                dbContext.SaveChanges();
                System.Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                return RedirectToAction("UpcomingShows");
            }
            return RedirectToAction("Index");
        }

        [HttpGet("CancelEvent/{ShowId}/{UserId}")]
        public IActionResult CancelEvent(int ShowId, int UserId)
        {
            Show show = dbContext.Shows
                .Include(w=>w.Host)
                .FirstOrDefault(w=>w.ShowId==ShowId);
            
            if(show.Host.UserId!=HttpContext.Session.GetInt32("InSession"))
            {
                return RedirectToAction("Index");
            }
            dbContext.Shows.Remove(show);
            dbContext.SaveChanges();
            return RedirectToAction("UpcomingShows");
        }

        [HttpGet("unJoin/{ShowId}/{UserId}")]
        public IActionResult unJoin(int ShowId, int UserId)
        {
            User user = dbContext.Users
                .FirstOrDefault(u=>u.UserId==UserId);

            Show show = dbContext.Shows
                .FirstOrDefault(s=>s.ShowId==ShowId);
            
            UserShow userShow = dbContext.UserShows
                .Where(us=>us.ShowId== ShowId && us.UserId==UserId)
                .FirstOrDefault();
            dbContext.UserShows.Remove(userShow);
            dbContext.SaveChanges();
            return RedirectToAction("ViewShow", new{ShowId=ShowId});
        }

        [HttpGet("/Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }


    }
}
