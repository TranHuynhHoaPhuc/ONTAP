namespace WinFormsApp1
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
            lblMaSV = new Label();
            lblHoTen = new Label();
            lblTuoi = new Label();
            txtTuoi = new TextBox();
            txtMaSV = new TextBox();
            txtHoTen = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            dgvSinhVien = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // lblMaSV
            // 
            lblMaSV.AutoSize = true;
            lblMaSV.Location = new Point(47, 42);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new Size(119, 25);
            lblMaSV.TabIndex = 0;
            lblMaSV.Text = "Mã Sinh Viên:";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(376, 42);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(70, 25);
            lblHoTen.TabIndex = 1;
            lblHoTen.Text = "Họ tên:";
            // 
            // lblTuoi
            // 
            lblTuoi.AutoSize = true;
            lblTuoi.Location = new Point(47, 126);
            lblTuoi.Name = "lblTuoi";
            lblTuoi.Size = new Size(50, 25);
            lblTuoi.TabIndex = 2;
            lblTuoi.Text = "Tuổi:";
            // 
            // txtTuoi
            // 
            txtTuoi.Location = new Point(47, 154);
            txtTuoi.Name = "txtTuoi";
            txtTuoi.Size = new Size(150, 31);
            txtTuoi.TabIndex = 3;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(47, 70);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(150, 31);
            txtMaSV.TabIndex = 4;
           
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(376, 70);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(150, 31);
            txtHoTen.TabIndex = 5;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(47, 217);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(235, 217);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(404, 217);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(606, 217);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(112, 34);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Location = new Point(0, 270);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.RowHeadersWidth = 62;
            dgvSinhVien.Size = new Size(800, 179);
            dgvSinhVien.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvSinhVien);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaSV);
            Controls.Add(txtTuoi);
            Controls.Add(lblTuoi);
            Controls.Add(lblHoTen);
            Controls.Add(lblMaSV);
            Name = "Form1";
            Text = "QUẢN LÝ SINH VIÊN";
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaSV;
        private Label lblHoTen;
        private Label lblTuoi;
        private TextBox txtTuoi;
        private TextBox txtMaSV;
        private TextBox txtHoTen;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private DataGridView dgvSinhVien;
    }
}
