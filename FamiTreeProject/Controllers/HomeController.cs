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
    [Authorize]
    public class HomeController : Controller
    {
        private readonly HomeViewModel hvm;
        private readonly SubjectsDataContext _db;

        public HomeController(SubjectsDataContext db)
        {
            _db = db;
            hvm = new HomeViewModel();
            
        }

        public IActionResult Index()
        {
            return View(hvm);
        }
        [HttpPost]
        public IActionResult Post([FromBody]Subject subject)
        {
            if (subject == null)
            {
                return BadRequest();
            }
            _db.Subjects.Add(subject);
            _db.SaveChanges();
            return Ok(subject);
        }

    }
}
