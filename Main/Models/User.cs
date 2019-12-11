using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Main.Models
{
    public class User: IdentityUser
    {
        public string Forename { get; set; }
    }
}
