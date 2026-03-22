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
    public partial class frmLoaiVatLieu : Form
    {
        QLVLDbContext context = new QLVLDbContext();
        bool xuLyThem = false;
        int id;

        public frmLoaiVatLieu()
        {
            InitializeComponent();
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenLoai.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmLoaiVatLieu_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            List<LoaiVatLieu> lsp = new List<LoaiVatLieu>();
            lsp = context.LoaiVatLieu.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = lsp;
            txtTenLoai.DataBindings.Clear();
            txtTenLoai.DataBindings.Add("Text", bindingSource, "TenLoai", false, DataSourceUpdateMode.Never);
            dgvLoaiVatLieu.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenLoai.Clear();
            txtTenLoai.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dgvLoaiVatLieu.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenLoai.Text))
                MessageBox.Show("Vui lòng nhập tên loại sản phẩm?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    LoaiVatLieu lsp = new LoaiVatLieu();
                    lsp.TenLoai = txtTenLoai.Text;
                    context.LoaiVatLieu.Add(lsp);
                    context.SaveChanges();
                }
                else
                {
                    LoaiVatLieu lsp = context.LoaiVatLieu.Find(id);
                    if (lsp != null)
                    {
                        lsp.TenLoai = txtTenLoai.Text;
                        context.LoaiVatLieu.Update(lsp);
                        context.SaveChanges();
                    }
                }
                frmLoaiVatLieu_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dgvLoaiVatLieu.CurrentRow.Cells["ID"].Value);

            var l = context.LoaiVatLieu.Find(id);
            if (l != null)
            {
                context.LoaiVatLieu.Remove(l);
                context.SaveChanges();
            }

            frmLoaiVatLieu_Load(sender, e);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            BatTatChucNang(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thoát", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmLoaiVatLieu_KeyDown(object sender, KeyEventArgs e)
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
