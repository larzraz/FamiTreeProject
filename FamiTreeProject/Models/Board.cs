using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamiTreeProject.Models
{
    public class Board
    {
        public int SelectedId { get; set; }
        public int FamilyMemberId { get; set; }
        public int HintCounter { get; set; }
        private int noOfFamilyMembers;
        private int noOfPlacedFamilyMembers;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime TimeSpent { get; set; }
    }
}
