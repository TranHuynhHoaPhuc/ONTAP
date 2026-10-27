
using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Gắn sự kiện cho các điều khiển
            this.Load += Form1_Load;
            dgvSinhVien.SelectionChanged += dgvSinhVien_SelectionChanged;

            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLamMoi.Click += btnLamMoi_Click;
        }

        // 1. Khi mở form: tải dữ liệu lên bảng
        private void Form1_Load(object sender, EventArgs e)
        {
            TaiDuLieu();
            LamMoi();
        }

        // 2. Đọc dữ liệu từ SQL Server
        private void TaiDuLieu()
        {
            try
            {
                using var db = new QuanLySinhVienContext();

                dgvSinhVien.DataSource = db.SinhVien
                    .AsNoTracking()
                    .OrderBy(s => s.MaSV)
                    .ToList();

                dgvSinhVien.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvSinhVien.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dgvSinhVien.MultiSelect = false;
                dgvSinhVien.ReadOnly = true;
                dgvSinhVien.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không tải được dữ liệu: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // 3. Thêm sinh viên
        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaSV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string tuoiText = txtTuoi.Text.Trim();

            if (ma == "" || hoTen == "" || tuoiText == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!int.TryParse(tuoiText, out int tuoi))
            {
                MessageBox.Show("Tuổi phải là số nguyên!");
                txtTuoi.Focus();
                return;
            }

            if (tuoi < 16 || tuoi > 100)
            {
                MessageBox.Show("Tuổi phải từ 16 đến 100!");
                txtTuoi.Focus();
                return;
            }

            try
            {
                using var db = new QuanLySinhVienContext();

                bool daTonTai = db.SinhVien.Any(s => s.MaSV == ma);

                if (daTonTai)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại!");
                    txtMaSV.Focus();
                    return;
                }

                var sv = new SinhVien
                {
                    MaSV = ma,
                    HoTen = hoTen,
                    Tuoi = tuoi
                };

                db.SinhVien.Add(sv);
                db.SaveChanges();

                MessageBox.Show("Thêm sinh viên thành công!");

                TaiDuLieu();
                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message);
            }
        }

        // 4. Chọn một dòng trên bảng
        private void dgvSinhVien_SelectionChanged(
            object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow == null ||
                dgvSinhVien.CurrentRow.IsNewRow)
            {
                return;
            }

            var row = dgvSinhVien.CurrentRow;

            if (row.DataBoundItem is SinhVien sv)
            {
                txtMaSV.Text = sv.MaSV;
                txtHoTen.Text = sv.HoTen;
                txtTuoi.Text = sv.Tuoi.ToString();
            }
        }

        // 5. Sửa thông tin sinh viên
        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaSV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string tuoiText = txtTuoi.Text.Trim();

            if (ma == "" || hoTen == "" || tuoiText == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!int.TryParse(tuoiText, out int tuoi))
            {
                MessageBox.Show("Tuổi phải là số nguyên!");
                txtTuoi.Focus();
                return;
            }

            if (tuoi < 16 || tuoi > 100)
            {
                MessageBox.Show("Tuổi phải từ 16 đến 100!");
                txtTuoi.Focus();
                return;
            }

            try
            {
                using var db = new QuanLySinhVienContext();

                var sv = db.SinhVien
                    .FirstOrDefault(s => s.MaSV == ma);

                if (sv == null)
                {
                    MessageBox.Show("Không tìm thấy sinh viên!");
                    return;
                }

                sv.HoTen = hoTen;
                sv.Tuoi = tuoi;

                db.SaveChanges();

                MessageBox.Show("Cập nhật sinh viên thành công!");

                TaiDuLieu();
                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message);
            }
        }

        // 6. Xóa sinh viên
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaSV.Text.Trim();

            if (ma == "")
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!");
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa sinh viên này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua != DialogResult.Yes)
                return;

            try
            {
                using var db = new QuanLySinhVienContext();

                var sv = db.SinhVien
                    .FirstOrDefault(s => s.MaSV == ma);

                if (sv == null)
                {
                    MessageBox.Show("Không tìm thấy sinh viên!");
                    return;
                }

                db.SinhVien.Remove(sv);
                db.SaveChanges();

                MessageBox.Show("Xóa sinh viên thành công!");

                TaiDuLieu();
                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
        }

        // 7. Làm mới các ô nhập
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void LamMoi()
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtTuoi.Clear();

            dgvSinhVien.ClearSelection();

            txtMaSV.Focus();
        }
    }
}
