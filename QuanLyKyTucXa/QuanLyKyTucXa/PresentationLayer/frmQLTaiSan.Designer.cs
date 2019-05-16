namespace QuanLyKiTucXa.PresentationLayer
{
    partial class frmQLTaiSan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLTaiSan));
            this.lbTimKiem = new System.Windows.Forms.Label();
            this.cbTimKiem = new System.Windows.Forms.ComboBox();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btTimkiem = new System.Windows.Forms.Button();
            this.btLamMoi = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtMaTS = new System.Windows.Forms.TextBox();
            this.lbMaPhong = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTenTS = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMaTS = new System.Windows.Forms.Label();
            this.lbQLTaiSan = new System.Windows.Forms.Label();
            this.dgQLTaiSan = new System.Windows.Forms.DataGridView();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.txtHienTrang = new System.Windows.Forms.TextBox();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.cbTenTS = new System.Windows.Forms.ComboBox();
            this.lbcnql = new System.Windows.Forms.Label();
            this.lbdsdn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgQLTaiSan)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.AutoSize = true;
            this.lbTimKiem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTimKiem.Location = new System.Drawing.Point(24, 312);
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
            "Mã tài sản",
            "Tên tài sản"});
            this.cbTimKiem.Location = new System.Drawing.Point(91, 304);
            this.cbTimKiem.Name = "cbTimKiem";
            this.cbTimKiem.Size = new System.Drawing.Size(121, 24);
            this.cbTimKiem.TabIndex = 67;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimkiem.Location = new System.Drawing.Point(277, 304);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(212, 23);
            this.txtTimkiem.TabIndex = 66;
            // 
            // btTimkiem
            // 
            this.btTimkiem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btTimkiem.Image")));
            this.btTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimkiem.Location = new System.Drawing.Point(527, 292);
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
            this.btLamMoi.Location = new System.Drawing.Point(27, 217);
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
            this.btXoa.Location = new System.Drawing.Point(329, 218);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(71, 48);
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
            this.btThoat.Location = new System.Drawing.Point(591, 217);
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
            this.btSua.Location = new System.Drawing.Point(230, 218);
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
            this.btThem.Location = new System.Drawing.Point(125, 217);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(87, 50);
            this.btThem.TabIndex = 60;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoLuong.Location = new System.Drawing.Point(81, 157);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(133, 23);
            this.txtSoLuong.TabIndex = 78;
            // 
            // txtMaTS
            // 
            this.txtMaTS.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaTS.Location = new System.Drawing.Point(81, 98);
            this.txtMaTS.Name = "txtMaTS";
            this.txtMaTS.Size = new System.Drawing.Size(133, 23);
            this.txtMaTS.TabIndex = 75;
            // 
            // lbMaPhong
            // 
            this.lbMaPhong.AutoSize = true;
            this.lbMaPhong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaPhong.Location = new System.Drawing.Point(487, 103);
            this.lbMaPhong.Name = "lbMaPhong";
            this.lbMaPhong.Size = new System.Drawing.Size(69, 16);
            this.lbMaPhong.TabIndex = 74;
            this.lbMaPhong.Text = "Mã phòng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(487, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 73;
            this.label4.Text = "Hiện trạng:";
            // 
            // lbTenTS
            // 
            this.lbTenTS.AutoSize = true;
            this.lbTenTS.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTenTS.Location = new System.Drawing.Point(254, 103);
            this.lbTenTS.Name = "lbTenTS";
            this.lbTenTS.Size = new System.Drawing.Size(77, 16);
            this.lbTenTS.TabIndex = 72;
            this.lbTenTS.Text = "Tên tài sản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(11, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 71;
            this.label2.Text = "Số lượng:";
            // 
            // lbMaTS
            // 
            this.lbMaTS.AutoSize = true;
            this.lbMaTS.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaTS.Location = new System.Drawing.Point(11, 103);
            this.lbMaTS.Name = "lbMaTS";
            this.lbMaTS.Size = new System.Drawing.Size(72, 16);
            this.lbMaTS.TabIndex = 70;
            this.lbMaTS.Text = "Mã tài sản:";
            // 
            // lbQLTaiSan
            // 
            this.lbQLTaiSan.AutoSize = true;
            this.lbQLTaiSan.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbQLTaiSan.Location = new System.Drawing.Point(167, 18);
            this.lbQLTaiSan.Name = "lbQLTaiSan";
            this.lbQLTaiSan.Size = new System.Drawing.Size(303, 39);
            this.lbQLTaiSan.TabIndex = 69;
            this.lbQLTaiSan.Text = "QUẢN LÝ TÀI SẢN";
            // 
            // dgQLTaiSan
            // 
            this.dgQLTaiSan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgQLTaiSan.Location = new System.Drawing.Point(14, 361);
            this.dgQLTaiSan.Name = "dgQLTaiSan";
            this.dgQLTaiSan.Size = new System.Drawing.Size(672, 144);
            this.dgQLTaiSan.TabIndex = 80;
            this.dgQLTaiSan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgQLTaiSan_CellClick);
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaPhong.Location = new System.Drawing.Point(555, 96);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(131, 23);
            this.txtMaPhong.TabIndex = 81;
            // 
            // txtHienTrang
            // 
            this.txtHienTrang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHienTrang.Location = new System.Drawing.Point(555, 150);
            this.txtHienTrang.Name = "txtHienTrang";
            this.txtHienTrang.Size = new System.Drawing.Size(131, 23);
            this.txtHienTrang.TabIndex = 82;
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaNV.Location = new System.Drawing.Point(254, 162);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(50, 16);
            this.lbMaNV.TabIndex = 83;
            this.lbMaNV.Text = "Mã NV:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaNV.Location = new System.Drawing.Point(327, 154);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(131, 23);
            this.txtMaNV.TabIndex = 84;
            // 
            // cbTenTS
            // 
            this.cbTenTS.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbTenTS.FormattingEnabled = true;
            this.cbTenTS.Items.AddRange(new object[] {
            "Bóng điện",
            "Quạt trần",
            "Giường ngủ"});
            this.cbTenTS.Location = new System.Drawing.Point(329, 98);
            this.cbTenTS.Name = "cbTenTS";
            this.cbTenTS.Size = new System.Drawing.Size(129, 24);
            this.cbTenTS.TabIndex = 85;
            // 
            // lbcnql
            // 
            this.lbcnql.AutoSize = true;
            this.lbcnql.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbcnql.Location = new System.Drawing.Point(11, 70);
            this.lbcnql.Name = "lbcnql";
            this.lbcnql.Size = new System.Drawing.Size(132, 16);
            this.lbcnql.TabIndex = 112;
            this.lbcnql.Text = "Chức năng quản lý:";
            // 
            // lbdsdn
            // 
            this.lbdsdn.AutoSize = true;
            this.lbdsdn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbdsdn.Location = new System.Drawing.Point(11, 342);
            this.lbdsdn.Name = "lbdsdn";
            this.lbdsdn.Size = new System.Drawing.Size(128, 16);
            this.lbdsdn.TabIndex = 113;
            this.lbdsdn.Text = "Danh sách tài sản:";
            // 
            // frmQLTaiSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 507);
            this.Controls.Add(this.lbdsdn);
            this.Controls.Add(this.lbcnql);
            this.Controls.Add(this.cbTenTS);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.lbMaNV);
            this.Controls.Add(this.txtHienTrang);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.dgQLTaiSan);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtMaTS);
            this.Controls.Add(this.lbMaPhong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTenTS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbMaTS);
            this.Controls.Add(this.lbQLTaiSan);
            this.Controls.Add(this.lbTimKiem);
            this.Controls.Add(this.cbTimKiem);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.btTimkiem);
            this.Controls.Add(this.btLamMoi);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Name = "frmQLTaiSan";
            this.Text = "frmQLTaiSan";
            this.Load += new System.EventHandler(this.frmQLTaiSan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgQLTaiSan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTimKiem;
        private System.Windows.Forms.ComboBox cbTimKiem;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btTimkiem;
        private System.Windows.Forms.Button btLamMoi;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtMaTS;
        private System.Windows.Forms.Label lbMaPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTenTS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMaTS;
        private System.Windows.Forms.Label lbQLTaiSan;
        private System.Windows.Forms.DataGridView dgQLTaiSan;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.TextBox txtHienTrang;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.ComboBox cbTenTS;
        private System.Windows.Forms.Label lbcnql;
        private System.Windows.Forms.Label lbdsdn;
    }
}