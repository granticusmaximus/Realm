using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Realm.Data.Models
{
    public class AppUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public List<Chat> Chats { get; set; }
        public byte[]? ProfilePicture { get; set; } // This line is added
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
    }
}