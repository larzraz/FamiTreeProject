using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FamiTreeProject.Models;
using FamiTreeProject.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace FamiTreeProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly HomeViewModel hvm;
        

        public HomeController()
        {

            hvm = new HomeViewModel();
            
        }

        public IActionResult Login()
        {
            return View();
        }
       
        public IActionResult Index()
        {
            return View(hvm);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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

        [Authorize]
        [HttpGet, Route("Create")]
        public IActionResult Create()
        {
            return View();
        }

        //[Authorize]
        //[HttpPost, Route("Create")]
        //public IActionResult Create(Post post)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View();

        //        post.Author = User.Identity.Name;
        //        post.Posted = DateTime.Now;

        //        _db.Posts.Add(post);
        //        _db.SaveChanges();

        //        return RedirectToAction("Post", "Blog", new
        //        {
        //            year = post.Posted.Year,
        //            month = post.Posted.Month,
        //            key = post.Key
        //        });
        //    }
        //}
    }
}
