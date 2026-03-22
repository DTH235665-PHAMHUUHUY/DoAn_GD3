namespace QuanLyVatLieuXayDung.Forms
{
    partial class frmVatLieu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label6 = new Label();
            label5 = new Label();
            txtTenVatLieu = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnDoiAnh = new Button();
            picHinhAnh = new PictureBox();
            btnXuat = new Button();
            btnNhap = new Button();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnThem = new Button();
            cboDonViTinh = new ComboBox();
            numDonGia = new NumericUpDown();
            numSoLuong = new NumericUpDown();
            label4 = new Label();
            cboNhaCungCap = new ComboBox();
            cboLoaiVatLieu = new ComboBox();
            groupBox2 = new GroupBox();
            dgvVatLieu = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenLoai = new DataGridViewTextBoxColumn();
            TenNhaCungCap = new DataGridViewTextBoxColumn();
            TenVatLieu = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonViTinh = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVatLieu).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(421, 108);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 10;
            label6.Text = "Đơn Giá:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(405, 67);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 9;
            label5.Text = "Đơn vị tính:";
            // 
            // txtTenVatLieu
            // 
            txtTenVatLieu.Location = new Point(118, 104);
            txtTenVatLieu.Name = "txtTenVatLieu";
            txtTenVatLieu.Size = new Size(230, 23);
            txtTenVatLieu.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 108);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 2;
            label3.Text = "Tên vật liệu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 67);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 1;
            label2.Text = "Nhà cung cấp(*):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 27);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 0;
            label1.Text = "Loại vật liệu(*):";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDoiAnh);
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(cboDonViTinh);
            groupBox1.Controls.Add(numDonGia);
            groupBox1.Controls.Add(numSoLuong);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cboNhaCungCap);
            groupBox1.Controls.Add(cboLoaiVatLieu);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTenVatLieu);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1107, 183);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên:";
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Location = new Point(852, 17);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(88, 27);
            btnDoiAnh.TabIndex = 37;
            btnDoiAnh.Text = "Đổi ảnh";
            btnDoiAnh.UseVisualStyleBackColor = true;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Location = new Point(725, 17);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(100, 116);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 36;
            picHinhAnh.TabStop = false;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(955, 145);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(88, 27);
            btnXuat.TabIndex = 35;
            btnXuat.Text = "Xuất.....";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(840, 145);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(88, 27);
            btnNhap.TabIndex = 34;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(725, 145);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(88, 27);
            btnTimKiem.TabIndex = 33;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(610, 145);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(88, 27);
            btnThoat.TabIndex = 32;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(495, 145);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(88, 27);
            btnHuyBo.TabIndex = 31;
            btnHuyBo.Text = "Hủy Bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(380, 145);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(88, 27);
            btnXoa.TabIndex = 30;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(265, 145);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(88, 27);
            btnLuu.TabIndex = 29;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(150, 145);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(88, 27);
            btnSua.TabIndex = 28;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(35, 145);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(88, 27);
            btnThem.TabIndex = 27;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // cboDonViTinh
            // 
            cboDonViTinh.FormattingEnabled = true;
            cboDonViTinh.Items.AddRange(new object[] { "Tấn", "Cây", "Thùng", "Viên", "Cái", "Bao" });
            cboDonViTinh.Location = new Point(479, 63);
            cboDonViTinh.Name = "cboDonViTinh";
            cboDonViTinh.Size = new Size(197, 23);
            cboDonViTinh.TabIndex = 26;
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(479, 104);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(197, 23);
            numDonGia.TabIndex = 25;
            numDonGia.ThousandsSeparator = true;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(479, 23);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(197, 23);
            numSoLuong.TabIndex = 24;
            numSoLuong.ThousandsSeparator = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(416, 27);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 23;
            label4.Text = "Số lượng:";
            // 
            // cboNhaCungCap
            // 
            cboNhaCungCap.FormattingEnabled = true;
            cboNhaCungCap.Location = new Point(118, 63);
            cboNhaCungCap.Name = "cboNhaCungCap";
            cboNhaCungCap.Size = new Size(230, 23);
            cboNhaCungCap.TabIndex = 22;
            // 
            // cboLoaiVatLieu
            // 
            cboLoaiVatLieu.FormattingEnabled = true;
            cboLoaiVatLieu.Location = new Point(118, 23);
            cboLoaiVatLieu.Name = "cboLoaiVatLieu";
            cboLoaiVatLieu.Size = new Size(230, 23);
            cboLoaiVatLieu.TabIndex = 21;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvVatLieu);
            groupBox2.Location = new Point(12, 195);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1107, 292);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách vật liệu:";
            // 
            // dgvVatLieu
            // 
            dgvVatLieu.AllowUserToAddRows = false;
            dgvVatLieu.AllowUserToDeleteRows = false;
            dgvVatLieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVatLieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVatLieu.Columns.AddRange(new DataGridViewColumn[] { ID, TenLoai, TenNhaCungCap, TenVatLieu, SoLuong, DonViTinh, DonGia, HinhAnh });
            dgvVatLieu.Dock = DockStyle.Fill;
            dgvVatLieu.Location = new Point(3, 19);
            dgvVatLieu.MultiSelect = false;
            dgvVatLieu.Name = "dgvVatLieu";
            dgvVatLieu.Size = new Size(1101, 270);
            dgvVatLieu.TabIndex = 0;
            dgvVatLieu.CellFormatting += dgvVatLieu_CellFormatting;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Resizable = DataGridViewTriState.True;
            // 
            // TenLoai
            // 
            TenLoai.DataPropertyName = "TenLoai";
            TenLoai.HeaderText = "Loại vật liệu";
            TenLoai.Name = "TenLoai";
            // 
            // TenNhaCungCap
            // 
            TenNhaCungCap.DataPropertyName = "TenNhaCungCap";
            TenNhaCungCap.HeaderText = "Nhà cung cấp";
            TenNhaCungCap.Name = "TenNhaCungCap";
            // 
            // TenVatLieu
            // 
            TenVatLieu.DataPropertyName = "TenVatLieu";
            TenVatLieu.HeaderText = "Tên vật liệu";
            TenVatLieu.Name = "TenVatLieu";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số lượng";
            SoLuong.Name = "SoLuong";
            // 
            // DonViTinh
            // 
            DonViTinh.DataPropertyName = "DonViTinh";
            DonViTinh.HeaderText = "Đơn vị";
            DonViTinh.Name = "DonViTinh";
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Đơn giá";
            DonGia.Name = "DonGia";
            // 
            // HinhAnh
            // 
            HinhAnh.DataPropertyName = "HinhAnh";
            HinhAnh.HeaderText = "Hình ảnh";
            HinhAnh.Name = "HinhAnh";
            HinhAnh.Resizable = DataGridViewTriState.True;
            HinhAnh.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // frmVatLieu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 499);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmVatLieu";
            Text = "Vật liệu";
            Load += frmVatLieu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVatLieu).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label6;
        private Label label5;
        private TextBox txtTenVatLieu;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private ComboBox cboNhaCungCap;
        private ComboBox cboLoaiVatLieu;
        private ComboBox cboDonViTinh;
        private NumericUpDown numDonGia;
        private NumericUpDown numSoLuong;
        private GroupBox groupBox2;
        private DataGridView dgvVatLieu;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnSua;
        private Button btnThem;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
        private Button btnDoiAnh;
        private PictureBox picHinhAnh;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenLoai;
        private DataGridViewTextBoxColumn TenNhaCungCap;
        private DataGridViewTextBoxColumn TenVatLieu;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonViTinh;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewImageColumn HinhAnh;
    }
}