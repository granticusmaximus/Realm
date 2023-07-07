using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Realm.Data.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string? EmployeName { get; set; }
        public string? Gender { get; set; }
        public string? City { get; set; }
        public string? Designation { get; set; }
    }
}