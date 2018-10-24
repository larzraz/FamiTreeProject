using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamiTreeProject.Models
{
    public class FamilyMember
    {
       

        public int HintId { get; set; }
        public string Name { get; set; }
        public int Generation { get; set; }
        public int GenerationPlaceID { get; set; }
        public int ParentID { get; set; }
        
    }
}
