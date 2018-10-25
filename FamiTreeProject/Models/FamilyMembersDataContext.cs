using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamiTreeProject.Models
{

    public class FamilyMembersDataContext
    {
        public IEnumerable<FamilyMember> GetFamilyMembers()
        {
            return new[]
            {
                new FamilyMember
                {
                    HintId = 1,
                    Name = "Hanna",
                    Generation = 1,
                    GenerationPlaceID = 1,
                    ParentID = 0,


                },
                new FamilyMember
                {
                    HintId = 2,
                    Name = "Jonna",
                    Generation = 1,
                    GenerationPlaceID = 2,
                    ParentID = 0,
                },
                new FamilyMember
                {
                    HintId = 3,
                    Name = "Jeff",
                    Generation = 2,
                    GenerationPlaceID = 1,
                    ParentID = 2,
                },
                new FamilyMember
                {
                    HintId = 4,
                    Name = "Jorah",
                    Generation = 2,
                    GenerationPlaceID = 2,
                    ParentID = 2,

                },
                new FamilyMember
                {
                    HintId = 5,
                    Name = "Rasmus",
                    Generation = 2,
                    GenerationPlaceID = 3,
                    ParentID = 2,
                },
                new FamilyMember
                {
                    HintId = 6,
                    Name = "Hunnah",
                    Generation = 3,
                    GenerationPlaceID = 1,
                    ParentID = 4,
                },
                new FamilyMember
                {
                    HintId = 7,
                    Name = "Benjamin",
                    Generation = 3,
                    GenerationPlaceID = 2,
                    ParentID = 4,
                },
            };           
        }          
    }
}
