using CourseSignupSystem.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSignupSystem.Data.EF
{
    public class CSSDbContext : DbContext
    {
        public CSSDbContext(DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<BangDiem> BangDiems { get; set; }
        public virtual DbSet<dangnhap> dangnhaps { get; set; }
        public virtual DbSet<DSGiaoVien> DSGiaoViens { get; set; }
        public virtual DbSet<DSHocVien> DSHocViens { get; set; }
        public virtual DbSet<DSHocVienDaNopTienPhi> DSHocVienDaNopTienPhis { get; set; }
        public virtual DbSet<DSKhoa> DSKhoas { get; set; }
        public virtual DbSet<DSLichNghi> DSLichNghis { get; set; }
        public virtual DbSet<DSLop> DSLops { get; set; }
        public virtual DbSet<DSLopHoc> DSLopHocs { get; set; }
        public virtual DbSet<DSMonHoc> DSMonHocs { get; set; }
        public virtual DbSet<DSNguoiDung> DSNguoiDungs { get; set; }
        public virtual DbSet<DSVaiTro> DSVaiTroes { get; set; }
        public virtual DbSet<FileDoanhThu> FileDoanhThus { get; set; }
        public virtual DbSet<HocPhi> HocPhis { get; set; }
        public virtual DbSet<LoaiDiem> LoaiDiems { get; set; }
        public virtual DbSet<LoaiDiemMon> LoaiDiemMons { get; set; }
        public virtual DbSet<LuongNV> LuongNVs { get; set; }
        public virtual DbSet<PhanCong> PhanCongs { get; set; }
        public virtual DbSet<ThongTinSV> ThongTinSVs { get; set; }
        public virtual DbSet<ToBoMon> ToBoMons { get; set; }

    }
}

