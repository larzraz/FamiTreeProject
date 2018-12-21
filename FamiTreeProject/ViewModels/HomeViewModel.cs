using FamiTreeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FamiTreeProject.api;

namespace FamiTreeProject.ViewModels
{
    public class HomeViewModel
    {
        private readonly FamilyMembersDataContext _familyMember = new FamilyMembersDataContext();
        private readonly SubjectsDataContext _subjects = new SubjectsDataContext();


        public FamilyMember SelectedFamilyMember { get; set; }

        public IEnumerable<FamilyMember> FamilyMembers { get; set; }
        public IEnumerable<Subject> Subjects { get; set; }



        public FamilyMember AssignRandomFamilyMember()
        {
            FamilyMember[] listOfFM = _familyMember.GetFamilyMembers().ToArray();

            Random rand = new Random();
            int randomSelectedFamilyMember = rand.Next(listOfFM.Count() - 1);
            return SelectedFamilyMember = listOfFM[randomSelectedFamilyMember];
        }

        public HomeViewModel()
        {

            FamilyMembers = _familyMember.GetFamilyMembers();
            Subjects = _subjects.GetSubjects();
            AssignRandomFamilyMember();

        }






    }
}
