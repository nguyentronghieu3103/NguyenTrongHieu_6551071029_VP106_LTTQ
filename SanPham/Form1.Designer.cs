namespace SanPham
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMa = new Label();
            lblTen = new Label();
            lblGia = new Label();
            txtMa = new TextBox();
            txtTen = new TextBox();
            txtGia = new TextBox();
            lblThongTin = new Label();
            lblThaoTac = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            lblDanhSach = new Label();
            dgvSanPham = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            SuspendLayout();
            // 
            // lblMa
            // 
            lblMa.AutoSize = true;
            lblMa.Location = new Point(33, 40);
            lblMa.Name = "lblMa";
            lblMa.Size = new Size(102, 20);
            lblMa.TabIndex = 0;
            lblMa.Text = "Mã Sản Phẩm:";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(31, 83);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(104, 20);
            lblTen.TabIndex = 1;
            lblTen.Text = "Tên Sản Phẩm:";
            // 
            // lblGia
            // 
            lblGia.AutoSize = true;
            lblGia.Location = new Point(33, 123);
            lblGia.Name = "lblGia";
            lblGia.Size = new Size(108, 20);
            lblGia.TabIndex = 2;
            lblGia.Text = "Giá Bán (VND):";
            // 
            // txtMa
            // 
            txtMa.Location = new Point(163, 37);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(152, 27);
            txtMa.TabIndex = 3;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(163, 83);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(217, 27);
            txtTen.TabIndex = 4;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(163, 123);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(152, 27);
            txtGia.TabIndex = 5;
            txtGia.KeyPress += ChiNhapSo_keyPress;
            // 
            // lblThongTin
            // 
            lblThongTin.AutoSize = true;
            lblThongTin.Location = new Point(12, 9);
            lblThongTin.Name = "lblThongTin";
            lblThongTin.Size = new Size(143, 20);
            lblThongTin.TabIndex = 6;
            lblThongTin.Text = "Thông tin sản phẩm:";
            // 
            // lblThaoTac
            // 
            lblThaoTac.AutoSize = true;
            lblThaoTac.Location = new Point(420, 20);
            lblThaoTac.Name = "lblThaoTac";
            lblThaoTac.Size = new Size(69, 20);
            lblThaoTac.TabIndex = 7;
            lblThaoTac.Text = "Thao tác:";
            lblThaoTac.Click += lblThaoTac_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(447, 62);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(87, 48);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(566, 62);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 48);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(692, 62);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(81, 48);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(803, 62);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(81, 48);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lblDanhSach
            // 
            lblDanhSach.AutoSize = true;
            lblDanhSach.Location = new Point(22, 178);
            lblDanhSach.Name = "lblDanhSach";
            lblDanhSach.Size = new Size(148, 20);
            lblDanhSach.TabIndex = 12;
            lblDanhSach.Text = "Danh sách sản phẩm:";
            // 
            // dgvSanPham
            // 
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Location = new Point(22, 210);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.Size = new Size(862, 295);
            dgvSanPham.TabIndex = 13;
            dgvSanPham.CellClick += dgvSanPham_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 540);
            Controls.Add(dgvSanPham);
            Controls.Add(lblDanhSach);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(lblThaoTac);
            Controls.Add(lblThongTin);
            Controls.Add(txtGia);
            Controls.Add(txtTen);
            Controls.Add(txtMa);
            Controls.Add(lblGia);
            Controls.Add(lblTen);
            Controls.Add(lblMa);
            Name = "Form1";
            Text = "Quản lý sản phẩm/ hàng hóa";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMa;
        private Label lblTen;
        private Label lblGia;
        private TextBox txtMa;
        private TextBox txtTen;
        private TextBox txtGia;
        private Label lblThongTin;
        private Label lblThaoTac;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private Label lblDanhSach;
        private DataGridView dgvSanPham;
    }
}
