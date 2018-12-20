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

        public IActionResult Index()
        {
            return View(hvm);
        }

      
    }
}
