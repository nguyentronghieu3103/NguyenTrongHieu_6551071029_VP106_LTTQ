using SanPham.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace SanPham
{
    public partial class Form1 : Form
    {
        private DuLieuContext _context = new DuLieuContext(
            new DbContextOptionsBuilder<DuLieuContext>()
                .UseSqlServer("Data Source=MSI\\SQLEXPRESS;Initial Catalog=DuLieu;User Id=sa;Password=Hieu2006#;Encrypt=False;TrustServerCertificate=True")
                .Options
            );
        public Form1()
        {
            InitializeComponent();
        }

        private void lblThaoTac_Click(object sender, EventArgs e)
        {

        }
        private void ResetForm()
        {
            txtMa.Clear();
            txtTen.Clear();
            txtGia.Clear();
            txtMa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = true;
            txtMa.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetForm();
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                var list = _context.SanPhams.Select(p => new
                {
                    MaSP = p.MaSanPham,
                    TenSP = p.TenSanPham,
                    Gia = p.GiaBan,
                }).ToList();
                dgvSanPham.DataSource = list;

                if (dgvSanPham.Columns["MaSP"] != null)
                {
                    dgvSanPham.Columns["MaSP"]!.HeaderText = "Mã Sản Phẩm";
                }
                if (dgvSanPham.Columns["TenSp"] != null)
                {
                    dgvSanPham.Columns["TenSp"]!.HeaderText = "Tên Sản Phẩm";
                }
                if (dgvSanPham.Columns["Gia"] != null)
                {
                    dgvSanPham.Columns["Gia"]!.HeaderText = "Giá Bán";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
        private void ChiNhapSo_keyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];
            txtMa.Text = row.Cells["MaSP"].Value?.ToString() ?? "";
            txtTen.Text = row.Cells["TenSP"].Value?.ToString() ?? "";
            txtGia.Text = row.Cells["Gia"].Value?.ToString() ?? "";

            txtMa.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThoat.Enabled = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text) || string.IsNullOrWhiteSpace(txtTen.Text) || string.IsNullOrWhiteSpace(txtGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if (_context.SanPhams.Any(p => p.MaSanPham == txtMa.Text.Trim()))
            {
                MessageBox.Show("Mã vật liệu đã tồn tại");
                txtMa.Focus();
                return;
            }
            try
            {
                var item = new SanPham.Models.SanPham
                {
                    MaSanPham = txtMa.Text.Trim(),
                    TenSanPham = txtTen.Text.Trim(),
                    GiaBan = txtGia.Text.Trim(),
                };
                _context.SanPhams.Add(item);
                _context.SaveChanges();
                MessageBox.Show("Thêm vật liệu thành công");
                txtMa.Clear();
                txtTen.Clear();
                txtGia.Clear();
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThoat.Enabled = true;
                txtMa.Focus();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm" + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var item = _context.SanPhams.FirstOrDefault(p => p.MaSanPham == txtMa.Text.Trim());
            if (item != null)
            {
                item.TenSanPham = txtTen.Text.Trim();
                item.GiaBan = txtGia.Text.Trim();
                _context.SaveChanges();
                MessageBox.Show("Cập nhật thành công");
                txtMa.Clear();
                txtTen.Clear();
                txtGia.Clear();
                btnThem.Enabled = true;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThoat.Enabled = true;
                txtMa.Focus();
                LoadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa sản phẩm này không ?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var item = _context.SanPhams.FirstOrDefault(p => p.MaSanPham == txtMa.Text.Trim());
                if (item != null)
                {
                    _context.SanPhams.Remove(item);
                    _context.SaveChanges();
                    MessageBox.Show("Đã xóa thành công");
                    txtMa.Clear();
                    txtTen.Clear();
                    txtGia.Clear();
                    btnThem.Enabled = true;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnThoat.Enabled = true;
                    txtMa.Focus();
                    LoadData();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
