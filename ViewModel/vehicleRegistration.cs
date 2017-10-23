using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineRTo.ViewModel
{
    public class vehicleRegistration
    {
        public int RegId { get; set; }
        public int State { get; set; }
        public string TempRegistration { get; set; }
        public string Owner {get;set;}
        public string Vehicle{get;set;}
        public string Manufacture { get; set; }
        public string ChasisNo { get; set; }
        public string Engine { get; set; }
        public string Color { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public int RTOId { get; set; }
    }
}