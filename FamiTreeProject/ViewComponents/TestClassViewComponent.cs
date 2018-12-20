using FamiTreeProject.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamiTreeProject.ViewComponents
{
    [ViewComponent]
    public class TestClassViewComponent : ViewComponent
    {
           private readonly SubjectsDataContext _testClass;
        public TestClassViewComponent(SubjectsDataContext testClassC)
        {
            _testClass = testClassC;
        }
        public IViewComponentResult Invoke()
        {
         
            
            var testClass = _testClass.GetSubjects();
            var hestClass = JsonConvert.SerializeObject(testClass);
            return View(hestClass);
        }

    }
}
