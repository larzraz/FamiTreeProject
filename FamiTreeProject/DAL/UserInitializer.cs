using FamiTreeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamiTreeProject.DAL
{
    public class UserInitializer
    {
        public async Task Seed(UserContext context)
        {
            var users = new List<User>
            {
                new User{UserID = 01, userName = "bruger1", eMail = "Example1@gmail.com", password = "Password1"},
                new User{UserID = 02, userName = "bruger2", eMail = "Example2@gmail.com", password = "Password2"},
                new User{UserID = 03, userName = "bruger3", eMail = "Example3@gmail.com", password = "Password3"},
            };

            users.ForEach(s => context.Users.Add(s));
            await context.SaveChangesAsync();
        }
    }
}
