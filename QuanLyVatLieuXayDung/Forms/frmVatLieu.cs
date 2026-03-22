using QuanLyVatLieuXayDung.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVatLieuXayDung.Forms
{
    public partial class frmVatLieu : Form
    {
        QLVLDbContext context = new QLVLDbContext();
        bool xuLyThem = false;
        int id;
        string imagesFolder = Application.StartupPath.Replace("bin\\Debug\\net5.0-windows", "Images");

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            cboNhaCungCap.Enabled = giaTri;
            cboLoaiVatLieu.Enabled = giaTri;
            txtTenVatLieu.Enabled = giaTri;
            numSoLuong.Enabled = giaTri;
            numDonGia.Enabled = giaTri;
            cboDonViTinh.Enabled = giaTri;
            picHinhAnh.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnDoiAnh.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }

        public void LayLoaiVatLieuVaoComboBox()
        {
            cboLoaiVatLieu.DataSource = context.LoaiVatLieu.ToList();
            cboLoaiVatLieu.ValueMember = "ID";
            cboLoaiVatLieu.DisplayMember = "TenLoai";
        }

        public void LayNhaCungCapVaoComboBox()
        {
            cboNhaCungCap.DataSource = context.NhaCungCap.ToList();
            cboNhaCungCap.ValueMember = "ID";
            cboNhaCungCap.DisplayMember = "TenNhaCungCap";
        }
        public frmVatLieu()
        {
            InitializeComponent();
        }

        private void frmVatLieu_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LayLoaiVatLieuVaoComboBox();
            LayNhaCungCapVaoComboBox();

            dgvVatLieu.AutoGenerateColumns = false;
            List<DanhSachSanPham> sp = new List<DanhSachSanPham>();
            sp = context.VatLieu.Select(r => new DanhSachSanPham
            {
                ID = r.ID,
                LoaiVatLieuID = r.LoaiVatLieuID,
                TenLoai = r.LoaiVatLieu.TenLoai,
                NhaCungCapID = r.NhaCungCapID,
                TenNhaCungCap = r.NhaCungCap.TenNhaCungCap,
                TenVatLieu = r.TenVatLieu,
                SoLuong = r.SoLuong,
                DonViTinh = r.DonViTinh,
                DonGia = r.DonGia,
                HinhAnh = r.HinhAnh
            }).ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = sp;
            cboLoaiVatLieu.DataBindings.Clear();
            cboLoaiVatLieu.DataBindings.Add("SelectedValue", bindingSource, "LoaiVatLieuID", false, DataSourceUpdateMode.Never);

            cboNhaCungCap.DataBindings.Clear();
            cboNhaCungCap.DataBindings.Add("SelectedValue", bindingSource, "NhaCungCapID", false, DataSourceUpdateMode.Never);

            cboDonViTinh.DataBindings.Clear();
            cboDonViTinh.DataBindings.Add("Text", bindingSource, "DonViTinh", false, DataSourceUpdateMode.Never);

            txtTenVatLieu.DataBindings.Clear();
            txtTenVatLieu.DataBindings.Add("Text", bindingSource, "TenVatLieu", false, DataSourceUpdateMode.Never);

            numSoLuong.DataBindings.Clear();
            numSoLuong.DataBindings.Add("Value", bindingSource, "SoLuong", false, DataSourceUpdateMode.Never);

            numDonGia.DataBindings.Clear();
            numDonGia.DataBindings.Add("Value", bindingSource, "DonGia", false, DataSourceUpdateMode.Never);

            picHinhAnh.DataBindings.Clear();
            Binding hinhAnh = new Binding("ImageLocation", bindingSource, "HinhAnh");
            hinhAnh.Format += (s, e) =>
            {
                e.Value = Path.Combine(imagesFolder, e.Value.ToString());
            };
            picHinhAnh.DataBindings.Add(hinhAnh);
            dgvVatLieu.DataSource = bindingSource;
        }

        private void dgvVatLieu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvVatLieu.Columns[e.ColumnIndex].Name == "HinhAnh")
            {
                Image image = Image.FromFile(Path.Combine(imagesFolder, e.Value.ToString()));
                image = new Bitmap(image, 24, 24);
                e.Value = image;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            cboLoaiVatLieu.Text = "";
            cboNhaCungCap.Text = "";
            cboDonViTinh.Text = "";
            txtTenVatLieu.Clear();
            numSoLuong.Value = 0;
            numDonGia.Value = 0;
            picHinhAnh.Image = null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dgvVatLieu.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboLoaiVatLieu.Text))
                MessageBox.Show("Vui lòng chọn loại vật liệu.");
            else if (string.IsNullOrWhiteSpace(cboNhaCungCap.Text))
                MessageBox.Show("Vui lòng chọn nhà cung cấp.");
            else if (string.IsNullOrWhiteSpace(txtTenVatLieu.Text))
                MessageBox.Show("Vui lòng nhập tên vật liệu.");
            else if (numSoLuong.Value <= 0)
                MessageBox.Show("Số lượng phải > 0.");
            else if (numDonGia.Value <= 0)
                MessageBox.Show("Đơn giá phải > 0.");
            else
            {
                string tenAnh = picHinhAnh.ImageLocation != null ? Path.GetFileName(picHinhAnh.ImageLocation) : null;

                if (xuLyThem)
                {
                    VatLieu sp = new VatLieu();
                    sp.LoaiVatLieuID = (int)cboLoaiVatLieu.SelectedValue;
                    sp.NhaCungCapID = (int)cboNhaCungCap.SelectedValue;
                    sp.TenVatLieu = txtTenVatLieu.Text;
                    sp.DonGia = (int)numDonGia.Value;
                    sp.SoLuong = (int)numSoLuong.Value;
                    sp.DonViTinh = cboDonViTinh.Text;
                    sp.HinhAnh = tenAnh;

                    context.VatLieu.Add(sp);
                }
                else
                {
                    VatLieu sp = context.VatLieu.Find(id);
                    if (sp != null)
                    {
                        sp.LoaiVatLieuID = (int)cboLoaiVatLieu.SelectedValue;
                        sp.NhaCungCapID = (int)cboNhaCungCap.SelectedValue;
                        sp.TenVatLieu = txtTenVatLieu.Text;
                        sp.DonGia = (int)numDonGia.Value;
                        sp.SoLuong = (int)numSoLuong.Value;
                        sp.DonViTinh = cboDonViTinh.Text;
                        sp.HinhAnh = tenAnh;
                    }
                }

                context.SaveChanges();
                frmVatLieu_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa sản phẩm " + txtTenVatLieu.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvVatLieu.CurrentRow.Cells["ID"].Value.ToString());

                VatLieu sp = context.VatLieu.Find(id);
                if (sp != null)
                {
                    context.VatLieu.Remove(sp);
                }
                context.SaveChanges();
                frmVatLieu_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmVatLieu_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thoát", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileName(ofd.FileName);
                string destPath = Path.Combine(imagesFolder, fileName);

                File.Copy(ofd.FileName, destPath, true);

                picHinhAnh.ImageLocation = destPath;
            }
        }
    }
}
