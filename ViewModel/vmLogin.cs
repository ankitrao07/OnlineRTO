using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineRTO.ViewModel
{
    public class vmLogin
    {
        [Required(ErrorMessage = "Please Enter UserName")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please Enter Passowrd")]
        public string Password { get; set; }
    }
}