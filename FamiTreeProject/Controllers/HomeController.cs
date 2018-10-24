using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FamiTreeProject.Models;

namespace FamiTreeProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly FamilyMembersDataContext _familyMember;

        public HomeController(FamilyMembersDataContext fmc)
        {
            _familyMember = fmc;
        }
        public IActionResult Index()
        {
            
            return View(_familyMember.GetFamilyMembers());
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
    }
}
