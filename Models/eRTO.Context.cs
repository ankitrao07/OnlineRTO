﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class eRTOEntities : DbContext
    {
        public eRTOEntities()
            : base("name=eRTOEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CityMaster> CityMasters { get; set; }
        public virtual DbSet<Dealer> Dealers { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<RTO> RTOes { get; set; }
        public virtual DbSet<StateMaster> StateMasters { get; set; }
    }
}
