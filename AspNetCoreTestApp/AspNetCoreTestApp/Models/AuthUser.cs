using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTestApp.Models
{
    public class AuthUser
    {
        public int UserId { get; set; }
        public string TokenString { get; set; }
        public bool IsAdmin { get; set; }
    }
}
