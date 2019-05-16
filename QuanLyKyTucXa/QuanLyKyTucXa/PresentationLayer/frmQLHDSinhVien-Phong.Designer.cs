namespace QuanLyKiTucXa
{
    partial class frmQLHDSinhVien_Phong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLHDSinhVien_Phong));
            this.lbQLHD = new System.Windows.Forms.Label();
            this.lbMaHD = new System.Windows.Forms.Label();
            this.lbNgayLap = new System.Windows.Forms.Label();
            this.lbMaSV = new System.Windows.Forms.Label();
            this.lbNgayVao = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.lbMaPhong = new System.Windows.Forms.Label();
            this.lbGhiChu = new System.Windows.Forms.Label();
            this.lbNgayRa = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.txtNgayLap = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtNgayVao = new System.Windows.Forms.TextBox();
            this.txtNgayRa = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.dgQLHDSinhVienPhong = new System.Windows.Forms.DataGridView();
            this.lbTimKiem = new System.Windows.Forms.Label();
            this.cbTimKiem = new System.Windows.Forms.ComboBox();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btTimkiem = new System.Windows.Forms.Button();
            this.btLamMoi = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.lbcnql = new System.Windows.Forms.Label();
            this.lbdsdn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgQLHDSinhVienPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // lbQLHD
            // 
            this.lbQLHD.AutoSize = true;
            this.lbQLHD.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbQLHD.Location = new System.Drawing.Point(81, 27);
            this.lbQLHD.Name = "lbQLHD";
            this.lbQLHD.Size = new System.Drawing.Size(667, 39);
            this.lbQLHD.TabIndex = 0;
            this.lbQLHD.Text = "QUẢN LÝ HỢP ĐỒNG SINH VIÊN-PHÒNG";
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaHD.Location = new System.Drawing.Point(46, 128);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(50, 16);
            this.lbMaHD.TabIndex = 1;
            this.lbMaHD.Text = "Mã HD:";
            // 
            // lbNgayLap
            // 
            this.lbNgayLap.AutoSize = true;
            this.lbNgayLap.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNgayLap.Location = new System.Drawing.Point(349, 216);
            this.lbNgayLap.Name = "lbNgayLap";
            this.lbNgayLap.Size = new System.Drawing.Size(62, 16);
            this.lbNgayLap.TabIndex = 2;
            this.lbNgayLap.Text = "Ngày lập:";
            // 
            // lbMaSV
            // 
            this.lbMaSV.AutoSize = true;
            this.lbMaSV.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaSV.Location = new System.Drawing.Point(349, 128);
            this.lbMaSV.Name = "lbMaSV";
            this.lbMaSV.Size = new System.Drawing.Size(50, 16);
            this.lbMaSV.TabIndex = 3;
            this.lbMaSV.Text = "Mã SV:";
            // 
            // lbNgayVao
            // 
            this.lbNgayVao.AutoSize = true;
            this.lbNgayVao.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNgayVao.Location = new System.Drawing.Point(349, 173);
            this.lbNgayVao.Name = "lbNgayVao";
            this.lbNgayVao.Size = new System.Drawing.Size(65, 16);
            this.lbNgayVao.TabIndex = 4;
            this.lbNgayVao.Text = "Ngày vào:";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaNV.Location = new System.Drawing.Point(611, 128);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(50, 16);
            this.lbMaNV.TabIndex = 5;
            this.lbMaNV.Text = "Mã NV:";
            // 
            // lbMaPhong
            // 
            this.lbMaPhong.AutoSize = true;
            this.lbMaPhong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaPhong.Location = new System.Drawing.Point(46, 173);
            this.lbMaPhong.Name = "lbMaPhong";
            this.lbMaPhong.Size = new System.Drawing.Size(69, 16);
            this.lbMaPhong.TabIndex = 6;
            this.lbMaPhong.Text = "Mã phòng:";
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbGhiChu.Location = new System.Drawing.Point(611, 173);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(55, 16);
            this.lbGhiChu.TabIndex = 7;
            this.lbGhiChu.Text = "Ghi chú:";
            // 
            // lbNgayRa
            // 
            this.lbNgayRa.AutoSize = true;
            this.lbNgayRa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNgayRa.Location = new System.Drawing.Point(46, 216);
            this.lbNgayRa.Name = "lbNgayRa";
            this.lbNgayRa.Size = new System.Drawing.Size(57, 16);
            this.lbNgayRa.TabIndex = 8;
            this.lbNgayRa.Text = "Ngày ra:";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaPhong.Location = new System.Drawing.Point(111, 173);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(161, 23);
            this.txtMaPhong.TabIndex = 9;
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNgayLap.Location = new System.Drawing.Point(410, 212);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(160, 23);
            this.txtNgayLap.TabIndex = 11;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGhiChu.Location = new System.Drawing.Point(662, 169);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(143, 23);
            this.txtGhiChu.TabIndex = 12;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaSV.Location = new System.Drawing.Point(410, 124);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(160, 23);
            this.txtMaSV.TabIndex = 13;
            // 
            // txtNgayVao
            // 
            this.txtNgayVao.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNgayVao.Location = new System.Drawing.Point(410, 169);
            this.txtNgayVao.Name = "txtNgayVao";
            this.txtNgayVao.Size = new System.Drawing.Size(160, 23);
            this.txtNgayVao.TabIndex = 14;
            // 
            // txtNgayRa
            // 
            this.txtNgayRa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNgayRa.Location = new System.Drawing.Point(111, 212);
            this.txtNgayRa.Name = "txtNgayRa";
            this.txtNgayRa.Size = new System.Drawing.Size(161, 23);
            this.txtNgayRa.TabIndex = 15;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaHD.Location = new System.Drawing.Point(111, 124);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(161, 23);
            this.txtMaHD.TabIndex = 16;
            // 
            // cbMaNV
            // 
            this.cbMaNV.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Items.AddRange(new object[] {
            "NV01",
            "NV02",
            "NV03",
            "NV04",
            "NV05"});
            this.cbMaNV.Location = new System.Drawing.Point(662, 124);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(143, 24);
            this.cbMaNV.TabIndex = 17;
            // 
            // dgQLHDSinhVienPhong
            // 
            this.dgQLHDSinhVienPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgQLHDSinhVienPhong.Location = new System.Drawing.Point(12, 405);
            this.dgQLHDSinhVienPhong.Name = "dgQLHDSinhVienPhong";
            this.dgQLHDSinhVienPhong.Size = new System.Drawing.Size(805, 172);
            this.dgQLHDSinhVienPhong.TabIndex = 18;
            this.dgQLHDSinhVienPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.AutoSize = true;
            this.lbTimKiem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTimKiem.Location = new System.Drawing.Point(30, 353);
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(66, 16);
            this.lbTimKiem.TabIndex = 68;
            this.lbTimKiem.Text = "Tìm kiếm:";
            // 
            // cbTimKiem
            // 
            this.cbTimKiem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbTimKiem.FormattingEnabled = true;
            this.cbTimKiem.Items.AddRange(new object[] {
            "Mã hợp đồng",
            "Mã phòng"});
            this.cbTimKiem.Location = new System.Drawing.Point(97, 345);
            this.cbTimKiem.Name = "cbTimKiem";
            this.cbTimKiem.Size = new System.Drawing.Size(140, 24);
            this.cbTimKiem.TabIndex = 67;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimkiem.Location = new System.Drawing.Point(315, 345);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(212, 23);
            this.txtTimkiem.TabIndex = 66;
            // 
            // btTimkiem
            // 
            this.btTimkiem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btTimkiem.Image")));
            this.btTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimkiem.Location = new System.Drawing.Point(533, 333);
            this.btTimkiem.Name = "btTimkiem";
            this.btTimkiem.Size = new System.Drawing.Size(100, 35);
            this.btTimkiem.TabIndex = 65;
            this.btTimkiem.Text = "Tìm kiếm";
            this.btTimkiem.UseVisualStyleBackColor = true;
            this.btTimkiem.Click += new System.EventHandler(this.btTimkiem_Click);
            // 
            // btLamMoi
            // 
            this.btLamMoi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btLamMoi.Image")));
            this.btLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLamMoi.Location = new System.Drawing.Point(33, 258);
            this.btLamMoi.Name = "btLamMoi";
            this.btLamMoi.Size = new System.Drawing.Size(80, 52);
            this.btLamMoi.TabIndex = 61;
            this.btLamMoi.Text = "   Làm mới";
            this.btLamMoi.UseVisualStyleBackColor = true;
            this.btLamMoi.Click += new System.EventHandler(this.btLamMoi_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(335, 259);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(82, 48);
            this.btXoa.TabIndex = 63;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThoat.Image = ((System.Drawing.Image)(resources.GetObject("btThoat.Image")));
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(736, 260);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(81, 48);
            this.btThoat.TabIndex = 64;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSua.Image = ((System.Drawing.Image)(resources.GetObject("btSua.Image")));
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(236, 259);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(81, 48);
            this.btSua.TabIndex = 62;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(131, 258);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(87, 50);
            this.btThem.TabIndex = 60;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // lbcnql
            // 
            this.lbcnql.AutoSize = true;
            this.lbcnql.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbcnql.Location = new System.Drawing.Point(12, 96);
            this.lbcnql.Name = "lbcnql";
            this.lbcnql.Size = new System.Drawing.Size(132, 16);
            this.lbcnql.TabIndex = 106;
            this.lbcnql.Text = "Chức năng quản lý:";
            // 
            // lbdsdn
            // 
            this.lbdsdn.AutoSize = true;
            this.lbdsdn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbdsdn.Location = new System.Drawing.Point(12, 386);
            this.lbdsdn.Name = "lbdsdn";
            this.lbdsdn.Size = new System.Drawing.Size(144, 16);
            this.lbdsdn.TabIndex = 107;
            this.lbdsdn.Text = "Danh sách hợp đồng:";
            // 
            // frmQLHDSinhVien_Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 578);
            this.Controls.Add(this.lbdsdn);
            this.Controls.Add(this.lbcnql);
            this.Controls.Add(this.lbTimKiem);
            this.Controls.Add(this.cbTimKiem);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.btTimkiem);
            this.Controls.Add(this.btLamMoi);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dgQLHDSinhVienPhong);
            this.Controls.Add(this.cbMaNV);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.txtNgayRa);
            this.Controls.Add(this.txtNgayVao);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtNgayLap);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.lbNgayRa);
            this.Controls.Add(this.lbGhiChu);
            this.Controls.Add(this.lbMaPhong);
            this.Controls.Add(this.lbMaNV);
            this.Controls.Add(this.lbNgayVao);
            this.Controls.Add(this.lbMaSV);
            this.Controls.Add(this.lbNgayLap);
            this.Controls.Add(this.lbMaHD);
            this.Controls.Add(this.lbQLHD);
            this.Name = "frmQLHDSinhVien_Phong";
            this.Text = "frmQLHDSinhVien_Phong";
            this.Load += new System.EventHandler(this.frmQLHDSinhVien_Phong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgQLHDSinhVienPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbQLHD;
        private System.Windows.Forms.Label lbMaHD;
        private System.Windows.Forms.Label lbNgayLap;
        private System.Windows.Forms.Label lbMaSV;
        private System.Windows.Forms.Label lbNgayVao;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label lbMaPhong;
        private System.Windows.Forms.Label lbGhiChu;
        private System.Windows.Forms.Label lbNgayRa;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.TextBox txtNgayLap;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtNgayVao;
        private System.Windows.Forms.TextBox txtNgayRa;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.DataGridView dgQLHDSinhVienPhong;
        private System.Windows.Forms.Label lbTimKiem;
        private System.Windows.Forms.ComboBox cbTimKiem;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btTimkiem;
        private System.Windows.Forms.Button btLamMoi;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label lbcnql;
        private System.Windows.Forms.Label lbdsdn;
    }
}