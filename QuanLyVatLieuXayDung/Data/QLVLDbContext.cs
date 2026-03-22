using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace QuanLyVatLieuXayDung.Data
{
    public class QLVLDbContext : DbContext
    {
        public DbSet<LoaiVatLieu> LoaiVatLieu { get; set; }
        public DbSet<NhaCungCap> NhaCungCap { get; set; }
        public DbSet<VatLieu> VatLieu { get; set; }

        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                ConfigurationManager.ConnectionStrings["QLVLConnection"].ConnectionString
            );
        }
    }
}
