﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyTour
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuanLyTourEntities : DbContext
    {
        public QuanLyTourEntities()
            : base("name=QuanLyTourEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ChiPhi> ChiPhis { get; set; }
        public virtual DbSet<DiaDiem> DiaDiems { get; set; }
        public virtual DbSet<DoanDuLich> DoanDuLiches { get; set; }
        public virtual DbSet<GiaTour> GiaTours { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiChiPhi> LoaiChiPhis { get; set; }
        public virtual DbSet<LoaiHinhDuLich> LoaiHinhDuLiches { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<NoiDungTour> NoiDungTours { get; set; }
        public virtual DbSet<PhanBoNV_Doan> PhanBoNV_Doan { get; set; }
        public virtual DbSet<ThamQuan> ThamQuans { get; set; }
        public virtual DbSet<TourDuLich> TourDuLiches { get; set; }
    }
}
