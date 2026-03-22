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
    public partial class frmNhaCungCap : Form
    {

        QLVLDbContext context = new QLVLDbContext();
        bool xuLyThem = false;
        int id;

        public frmNhaCungCap()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenNhaCungCap.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            List<NhaCungCap> list = context.NhaCungCap.ToList();

            BindingSource bs = new BindingSource();
            bs.DataSource = list;

            txtTenNhaCungCap.DataBindings.Clear();
            txtTenNhaCungCap.DataBindings.Add("Text", bs, "TenNhaCungCap", false, DataSourceUpdateMode.Never);

            dgvNhaCungCap.DataSource = bs;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenNhaCungCap.Clear();
            txtTenNhaCungCap.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dgvNhaCungCap.CurrentRow.Cells["ID"].Value);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNhaCungCap.Text))
            {
                MessageBox.Show("Nhập tên nhà cung cấp!");
                return;
            }

            if (xuLyThem)
            {
                NhaCungCap ncc = new NhaCungCap();
                ncc.TenNhaCungCap = txtTenNhaCungCap.Text;
                context.NhaCungCap.Add(ncc);
            }
            else
            {
                var ncc = context.NhaCungCap.Find(id);
                if (ncc != null)
                {
                    ncc.TenNhaCungCap = txtTenNhaCungCap.Text;
                    context.NhaCungCap.Update(ncc);
                }
            }

            context.SaveChanges();
            frmNhaCungCap_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa nhà cung cấp?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvNhaCungCap.CurrentRow.Cells["ID"].Value);

                var ncc = context.NhaCungCap.Find(id);
                if (ncc != null)
                {
                    context.NhaCungCap.Remove(ncc);
                    context.SaveChanges();
                }

                frmNhaCungCap_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmNhaCungCap_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thoát", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmNhaCungCap_KeyDown(object sender, KeyEventArgs e)
        {
            // ENTER → Lưu
            if (e.KeyCode == Keys.Enter)
            {
                btnLuu.PerformClick();
                e.SuppressKeyPress = true;
            }

            // DELETE → Xóa
            if (e.KeyCode == Keys.Delete)
            {
                btnXoa.PerformClick();
            }

            // ESC → Hủy
            if (e.KeyCode == Keys.Escape)
            {
                btnHuyBo.PerformClick();
            }

            // Ctrl + S → Lưu
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnLuu.PerformClick();
            }

            // Ctrl + N → Thêm mới
            if (e.Control && e.KeyCode == Keys.N)
            {
                btnThem.PerformClick();
            }

            // Ctrl + E → Thoát
            if (e.Control && e.KeyCode == Keys.E)
            {
                btnThoat.PerformClick();
            }
        }
    }
}
