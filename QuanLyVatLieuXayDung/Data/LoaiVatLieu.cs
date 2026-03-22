using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVatLieuXayDung.Data
{
    public class LoaiVatLieu
    {
        public int ID { get; set; }
        public string TenLoai { get; set; }

        public virtual ObservableCollectionListSource<VatLieu> VatLieu { get; } = new();
    }
}
