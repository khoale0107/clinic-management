﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhongKham
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PhongKhamEntities : DbContext
    {
        public PhongKhamEntities()
            : base("name=PhongKhamEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tBenhNhan> tBenhNhans { get; set; }
        public virtual DbSet<tChiTietToaThuoc> tChiTietToaThuocs { get; set; }
        public virtual DbSet<tThuoc> tThuocs { get; set; }
        public virtual DbSet<tToaThuoc> tToaThuocs { get; set; }
    }
}
