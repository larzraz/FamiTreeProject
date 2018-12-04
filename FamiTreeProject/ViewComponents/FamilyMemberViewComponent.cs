using FamiTreeProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamiTreeProject.ViewComponents
{
    [ViewComponent]
    public class FamilyMemberViewComponent:ViewComponent
    {
        private readonly FamilyMembersDataContext _familyMembers;
        public FamilyMemberViewComponent(FamilyMembersDataContext familyMembers)
        {
            _familyMembers = familyMembers;
        }
        public IViewComponentResult Invoke()
        {
            var familyMembers = _familyMembers.GetFamilyMembers();
        
            return View(familyMembers);
        }  
          
    }
}
