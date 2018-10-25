using FamiTreeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamiTreeProject.ViewModels
{
    public class HomeViewModel
    {
        private readonly FamilyMembersDataContext _familyMember = new FamilyMembersDataContext();
        public FamilyMember SelectedFamilyMember { get; set; }
        public FamilyMember ClickedFamilyMember { get; set; }
        private Board SelectedBoard;
        public IEnumerable<FamilyMember> FamilyMembers { get; set; }



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
           AssignRandomFamilyMember();
           
        }
        
          
        



    }
}
