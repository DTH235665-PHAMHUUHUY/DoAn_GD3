using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVatLieuXayDung.Data
{
    public class VatLieu
    {
        public int ID { get; set; }
        public int LoaiVatLieuID { get; set; }
        public int NhaCungCapID { get; set; }

        public string TenVatLieu { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }
        public string? DonViTinh { get; set; }
        public string? HinhAnh { get; set; }

        public virtual ObservableCollectionListSource<HoaDon_ChiTiet> HoaDon_ChiTiet { get; } = new();
        public virtual LoaiVatLieu LoaiVatLieu { get; set; } = null!;
        public virtual NhaCungCap NhaCungCap { get; set; } = null!;
    }
    public class DanhSachSanPham
    {
        public int ID { get; set; }
        public int NhaCungCapID { get; set; }
        public string TenNhaCungCap { get; set; } // Thêm
        public int LoaiVatLieuID { get; set; }
        public string TenLoai { get; set; } // Thêm
        public string TenVatLieu { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }
        public string? HinhAnh { get; set; }
        public string? DonViTinh { get; set; }
    }

}
