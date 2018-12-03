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
           private readonly TestClassDataC _testClass;
        public TestClassViewComponent(TestClassDataC testClassC)
        {
            _testClass = testClassC;
        }
        public IViewComponentResult Invoke()
        {
         
            
            var testClass = _testClass.GetTestClass();
            var hestClass = JsonConvert.SerializeObject(testClass);
            return View(hestClass);
        }

    }
}
