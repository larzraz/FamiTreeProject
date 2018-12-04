using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamiTreeProject.Models
{
    public class User
    {
        public int RoleId { get; set; } //admin, bruger, pårørende 
        public int UserID { get; set; }
        public string userName { get; set; }
        public string eMail { get; set; }
        public string password { get; set; }
    }
}
