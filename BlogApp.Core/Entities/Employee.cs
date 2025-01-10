using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Core.Entities
{
    public class Employee:IdentityUser
    {
        public string Fullname { get; set; }
        public ICollection<Assignment> Assignments { get; set; }
    }
}
