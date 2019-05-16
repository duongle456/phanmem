namespace QuanLyKiTucXa
{
    partial class frmQLSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLSV));
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.cbDoiTuong = new System.Windows.Forms.ComboBox();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.txtCMTND = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtMaSinhVien = new System.Windows.Forms.TextBox();
            this.lbtensinhvien = new System.Windows.Forms.Label();
            this.lbcmt = new System.Windows.Forms.Label();
            this.lbghichu = new System.Windows.Forms.Label();
            this.lbmadoituong = new System.Windows.Forms.Label();
            this.lbmaphong = new System.Windows.Forms.Label();
            this.lbngaysinh = new System.Windows.Forms.Label();
            this.lbquequan = new System.Windows.Forms.Label();
            this.lbgioitinh = new System.Windows.Forms.Label();
            this.lbmasinhvien = new System.Windows.Forms.Label();
            this.lbQLSinhVien = new System.Windows.Forms.Label();
            this.dgQLSinhVien = new System.Windows.Forms.DataGridView();
            this.lbTimKiem = new System.Windows.Forms.Label();
            this.cbTimKiem = new System.Windows.Forms.ComboBox();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btTimkiem = new System.Windows.Forms.Button();
            this.btLamMoi = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lbcnql = new System.Windows.Forms.Label();
            this.lbdsdn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgQLSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(660, 102);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(121, 21);
            this.cbGioiTinh.TabIndex = 49;
            // 
            // cbDoiTuong
            // 
            this.cbDoiTuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbDoiTuong.FormattingEnabled = true;
            this.cbDoiTuong.Items.AddRange(new object[] {
            "DT01",
            "DT02",
            "DT03",
            "DT04"});
            this.cbDoiTuong.Location = new System.Drawing.Point(406, 157);
            this.cbDoiTuong.Name = "cbDoiTuong";
            this.cbDoiTuong.Size = new System.Drawing.Size(149, 24);
            this.cbDoiTuong.TabIndex = 46;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenSV.Location = new System.Drawing.Point(406, 104);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(146, 22);
            this.txtTenSV.TabIndex = 45;
            this.txtTenSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenSV_KeyPress);
            // 
            // txtCMTND
            // 
            this.txtCMTND.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCMTND.Location = new System.Drawing.Point(406, 211);
            this.txtCMTND.Name = "txtCMTND";
            this.txtCMTND.Size = new System.Drawing.Size(149, 22);
            this.txtCMTND.TabIndex = 44;
            this.txtCMTND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCMTND_KeyPress);
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtQueQuan.Location = new System.Drawing.Point(111, 211);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(140, 22);
            this.txtQueQuan.TabIndex = 43;
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaSinhVien.Location = new System.Drawing.Point(111, 112);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.Size = new System.Drawing.Size(140, 22);
            this.txtMaSinhVien.TabIndex = 42;
            // 
            // lbtensinhvien
            // 
            this.lbtensinhvien.AutoSize = true;
            this.lbtensinhvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbtensinhvien.Location = new System.Drawing.Point(291, 112);
            this.lbtensinhvien.Name = "lbtensinhvien";
            this.lbtensinhvien.Size = new System.Drawing.Size(90, 16);
            this.lbtensinhvien.TabIndex = 41;
            this.lbtensinhvien.Text = "Tên sinh viên:";
            // 
            // lbcmt
            // 
            this.lbcmt.AutoSize = true;
            this.lbcmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbcmt.Location = new System.Drawing.Point(291, 217);
            this.lbcmt.Name = "lbcmt";
            this.lbcmt.Size = new System.Drawing.Size(118, 16);
            this.lbcmt.TabIndex = 40;
            this.lbcmt.Text = "Số chứng minh thư:";
            // 
            // lbghichu
            // 
            this.lbghichu.AutoSize = true;
            this.lbghichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbghichu.Location = new System.Drawing.Point(291, 268);
            this.lbghichu.Name = "lbghichu";
            this.lbghichu.Size = new System.Drawing.Size(55, 16);
            this.lbghichu.TabIndex = 39;
            this.lbghichu.Text = "Ghi chú:";
            // 
            // lbmadoituong
            // 
            this.lbmadoituong.AutoSize = true;
            this.lbmadoituong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbmadoituong.Location = new System.Drawing.Point(291, 165);
            this.lbmadoituong.Name = "lbmadoituong";
            this.lbmadoituong.Size = new System.Drawing.Size(88, 16);
            this.lbmadoituong.TabIndex = 38;
            this.lbmadoituong.Text = "Mã đối tượng:";
            // 
            // lbmaphong
            // 
            this.lbmaphong.AutoSize = true;
            this.lbmaphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbmaphong.Location = new System.Drawing.Point(18, 273);
            this.lbmaphong.Name = "lbmaphong";
            this.lbmaphong.Size = new System.Drawing.Size(71, 16);
            this.lbmaphong.TabIndex = 37;
            this.lbmaphong.Text = "Mã phòng:";
            // 
            // lbngaysinh
            // 
            this.lbngaysinh.AutoSize = true;
            this.lbngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbngaysinh.Location = new System.Drawing.Point(20, 165);
            this.lbngaysinh.Name = "lbngaysinh";
            this.lbngaysinh.Size = new System.Drawing.Size(73, 16);
            this.lbngaysinh.TabIndex = 36;
            this.lbngaysinh.Text = "Ngày Sinh:";
            // 
            // lbquequan
            // 
            this.lbquequan.AutoSize = true;
            this.lbquequan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbquequan.Location = new System.Drawing.Point(20, 217);
            this.lbquequan.Name = "lbquequan";
            this.lbquequan.Size = new System.Drawing.Size(69, 16);
            this.lbquequan.TabIndex = 35;
            this.lbquequan.Text = "Quê quán:";
            // 
            // lbgioitinh
            // 
            this.lbgioitinh.AutoSize = true;
            this.lbgioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbgioitinh.Location = new System.Drawing.Point(600, 107);
            this.lbgioitinh.Name = "lbgioitinh";
            this.lbgioitinh.Size = new System.Drawing.Size(58, 16);
            this.lbgioitinh.TabIndex = 34;
            this.lbgioitinh.Text = "Giới tính:";
            // 
            // lbmasinhvien
            // 
            this.lbmasinhvien.AutoSize = true;
            this.lbmasinhvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbmasinhvien.Location = new System.Drawing.Point(20, 118);
            this.lbmasinhvien.Name = "lbmasinhvien";
            this.lbmasinhvien.Size = new System.Drawing.Size(85, 16);
            this.lbmasinhvien.TabIndex = 33;
            this.lbmasinhvien.Text = "Mã sinh viên:";
            // 
            // lbQLSinhVien
            // 
            this.lbQLSinhVien.AutoSize = true;
            this.lbQLSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbQLSinhVien.Location = new System.Drawing.Point(227, 20);
            this.lbQLSinhVien.Name = "lbQLSinhVien";
            this.lbQLSinhVien.Size = new System.Drawing.Size(346, 37);
            this.lbQLSinhVien.TabIndex = 32;
            this.lbQLSinhVien.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // dgQLSinhVien
            // 
            this.dgQLSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgQLSinhVien.Location = new System.Drawing.Point(9, 455);
            this.dgQLSinhVien.Name = "dgQLSinhVien";
            this.dgQLSinhVien.Size = new System.Drawing.Size(781, 138);
            this.dgQLSinhVien.TabIndex = 51;
            this.dgQLSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgQLSinhVien_CellClick);
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.AutoSize = true;
            this.lbTimKiem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTimKiem.Location = new System.Drawing.Point(20, 404);
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(66, 16);
            this.lbTimKiem.TabIndex = 60;
            this.lbTimKiem.Text = "Tìm kiếm:";
            // 
            // cbTimKiem
            // 
            this.cbTimKiem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbTimKiem.FormattingEnabled = true;
            this.cbTimKiem.Items.AddRange(new object[] {
            "Mã sinh viên",
            "Tên sinh viên"});
            this.cbTimKiem.Location = new System.Drawing.Point(87, 396);
            this.cbTimKiem.Name = "cbTimKiem";
            this.cbTimKiem.Size = new System.Drawing.Size(164, 24);
            this.cbTimKiem.TabIndex = 59;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimkiem.Location = new System.Drawing.Point(342, 397);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(212, 23);
            this.txtTimkiem.TabIndex = 58;
            // 
            // btTimkiem
            // 
            this.btTimkiem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btTimkiem.Image")));
            this.btTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimkiem.Location = new System.Drawing.Point(560, 385);
            this.btTimkiem.Name = "btTimkiem";
            this.btTimkiem.Size = new System.Drawing.Size(100, 35);
            this.btTimkiem.TabIndex = 57;
            this.btTimkiem.Text = "Tìm kiếm";
            this.btTimkiem.UseVisualStyleBackColor = true;
            this.btTimkiem.Click += new System.EventHandler(this.btTimkiem_Click);
            // 
            // btLamMoi
            // 
            this.btLamMoi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btLamMoi.Image")));
            this.btLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLamMoi.Location = new System.Drawing.Point(23, 309);
            this.btLamMoi.Name = "btLamMoi";
            this.btLamMoi.Size = new System.Drawing.Size(80, 52);
            this.btLamMoi.TabIndex = 53;
            this.btLamMoi.Text = "   Làm mới";
            this.btLamMoi.UseVisualStyleBackColor = true;
            this.btLamMoi.Click += new System.EventHandler(this.btLamMoi_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(325, 310);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(71, 48);
            this.btXoa.TabIndex = 55;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThoat.Image = ((System.Drawing.Image)(resources.GetObject("btThoat.Image")));
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(668, 310);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(81, 48);
            this.btThoat.TabIndex = 56;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSua.Image = ((System.Drawing.Image)(resources.GetObject("btSua.Image")));
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(226, 310);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(81, 48);
            this.btSua.TabIndex = 54;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(121, 309);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(87, 50);
            this.btThem.TabIndex = 52;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNgaySinh.Location = new System.Drawing.Point(111, 159);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(140, 22);
            this.txtNgaySinh.TabIndex = 61;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaPhong.Location = new System.Drawing.Point(111, 267);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(140, 22);
            this.txtMaPhong.TabIndex = 62;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGhiChu.Location = new System.Drawing.Point(406, 262);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(149, 22);
            this.txtGhiChu.TabIndex = 63;
            // 
            // lbcnql
            // 
            this.lbcnql.AutoSize = true;
            this.lbcnql.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbcnql.Location = new System.Drawing.Point(6, 76);
            this.lbcnql.Name = "lbcnql";
            this.lbcnql.Size = new System.Drawing.Size(132, 16);
            this.lbcnql.TabIndex = 111;
            this.lbcnql.Text = "Chức năng quản lý:";
            // 
            // lbdsdn
            // 
            this.lbdsdn.AutoSize = true;
            this.lbdsdn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbdsdn.Location = new System.Drawing.Point(6, 436);
            this.lbdsdn.Name = "lbdsdn";
            this.lbdsdn.Size = new System.Drawing.Size(141, 16);
            this.lbdsdn.TabIndex = 112;
            this.lbdsdn.Text = "Danh sách sinh viên:";
            // 
            // frmQLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 594);
            this.Controls.Add(this.lbdsdn);
            this.Controls.Add(this.lbcnql);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.lbTimKiem);
            this.Controls.Add(this.cbTimKiem);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.btTimkiem);
            this.Controls.Add(this.btLamMoi);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dgQLSinhVien);
            this.Controls.Add(this.cbGioiTinh);
            this.Controls.Add(this.cbDoiTuong);
            this.Controls.Add(this.txtTenSV);
            this.Controls.Add(this.txtCMTND);
            this.Controls.Add(this.txtQueQuan);
            this.Controls.Add(this.txtMaSinhVien);
            this.Controls.Add(this.lbtensinhvien);
            this.Controls.Add(this.lbcmt);
            this.Controls.Add(this.lbghichu);
            this.Controls.Add(this.lbmadoituong);
            this.Controls.Add(this.lbmaphong);
            this.Controls.Add(this.lbngaysinh);
            this.Controls.Add(this.lbquequan);
            this.Controls.Add(this.lbgioitinh);
            this.Controls.Add(this.lbmasinhvien);
            this.Controls.Add(this.lbQLSinhVien);
            this.Name = "frmQLSV";
            this.Text = "frmQLSV";
            this.Load += new System.EventHandler(this.frmQLSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgQLSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.ComboBox cbDoiTuong;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.TextBox txtCMTND;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtMaSinhVien;
        private System.Windows.Forms.Label lbtensinhvien;
        private System.Windows.Forms.Label lbcmt;
        private System.Windows.Forms.Label lbghichu;
        private System.Windows.Forms.Label lbmadoituong;
        private System.Windows.Forms.Label lbmaphong;
        private System.Windows.Forms.Label lbngaysinh;
        private System.Windows.Forms.Label lbquequan;
        private System.Windows.Forms.Label lbgioitinh;
        private System.Windows.Forms.Label lbmasinhvien;
        private System.Windows.Forms.Label lbQLSinhVien;
        private System.Windows.Forms.DataGridView dgQLSinhVien;
        private System.Windows.Forms.Label lbTimKiem;
        private System.Windows.Forms.ComboBox cbTimKiem;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btTimkiem;
        private System.Windows.Forms.Button btLamMoi;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lbcnql;
        private System.Windows.Forms.Label lbdsdn;
    }
}