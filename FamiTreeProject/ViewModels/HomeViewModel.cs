using FamiTreeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FamiTreeProject.ViewModels
{
    public class HomeViewModel
    {
        private readonly FamilyMembersDataContext _familyMember = new FamilyMembersDataContext();
        private readonly TestClassDataC _testClass = new TestClassDataC();
        public FamilyMember SelectedFamilyMember { get; set; }
        public FamilyMember ClickedFamilyMember { get; set; }
        private Board SelectedBoard;
        public IEnumerable<FamilyMember> FamilyMembers { get; set; }
        public IEnumerable<TestClass> TestClass { get; set; }



        public FamilyMember AssignRandomFamilyMember()
        {
            FamilyMember[] listOfFM =_familyMember.GetFamilyMembers().ToArray();

            Random rand = new Random();
            int randomSelectedFamilyMember = rand.Next(listOfFM.Count() - 1);
            return SelectedFamilyMember = listOfFM[randomSelectedFamilyMember];
        }

        public HomeViewModel()
        {
           
           FamilyMembers = _familyMember.GetFamilyMembers();
            TestClass = _testClass.GetTestClass();
           AssignRandomFamilyMember();
           
        }
        
          
        



    }
}
