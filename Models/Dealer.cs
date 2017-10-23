//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineRTO.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dealer
    {
        public Dealer()
        {
            this.Registrations = new HashSet<Registration>();
        }
    
        public int Id { get; set; }
        public string DealerName { get; set; }
        public string MobileNo { get; set; }
        public string EmailID { get; set; }
        public string Address { get; set; }
        public Nullable<int> City { get; set; }
        public Nullable<int> State { get; set; }
        public Nullable<int> RTO { get; set; }
        public Nullable<int> LoginID { get; set; }
    
        public virtual Login Login { get; set; }
        public virtual RTO RTO1 { get; set; }
        public virtual ICollection<Registration> Registrations { get; set; }
    }
}