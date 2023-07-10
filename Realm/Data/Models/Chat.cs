using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Realm.Data.Models
{
    public class Chat
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }
        public string UserId { get; set; } // Foreign key to User

        // Navigation property
        public AppUser User { get; set; }
    }
}