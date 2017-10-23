using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineRTO.ViewModel
{
    public class AuthenticatedUser
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public int UID { get; set; }
    }
}