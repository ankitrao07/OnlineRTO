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
    
    public partial class RTO
    {
        public RTO()
        {
            this.Dealers = new HashSet<Dealer>();
        }
    
        public int RTOId { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public string LandlineNo { get; set; }
        public Nullable<int> City { get; set; }
        public Nullable<int> State { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> LoginID { get; set; }
    
        public virtual ICollection<Dealer> Dealers { get; set; }
        public virtual Login Login { get; set; }
    }
}
