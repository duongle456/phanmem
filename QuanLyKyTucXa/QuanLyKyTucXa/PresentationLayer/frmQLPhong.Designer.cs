namespace QuanLyKiTucXa
{
    partial class frmQLPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLPhong));
            this.cbMaToaNha = new System.Windows.Forms.ComboBox();
            this.lbTinhTrang = new System.Windows.Forms.Label();
            this.txtSoLuongNguoi = new System.Windows.Forms.TextBox();
            this.lbSoLuongNguoi = new System.Windows.Forms.Label();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.lbLoaiPhong = new System.Windows.Forms.Label();
            this.lbMaTN = new System.Windows.Forms.Label();
            this.lbTenPhong = new System.Windows.Forms.Label();
            this.lbMaPhong = new System.Windows.Forms.Label();
            this.lbQLPhong = new System.Windows.Forms.Label();
            this.dgQLPhong = new System.Windows.Forms.DataGridView();
            this.lbTimKiem = new System.Windows.Forms.Label();
            this.cbTimKiem = new System.Windows.Forms.ComboBox();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btTimkiem = new System.Windows.Forms.Button();
            this.btLamMoi = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.lbcnql = new System.Windows.Forms.Label();
            this.lbdsdn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgQLPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMaToaNha
            // 
            this.cbMaToaNha.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbMaToaNha.FormattingEnabled = true;
            this.cbMaToaNha.Items.AddRange(new object[] {
            "TN01",
            "TN02"});
            this.cbMaToaNha.Location = new System.Drawing.Point(131, 148);
            this.cbMaToaNha.Name = "cbMaToaNha";
            this.cbMaToaNha.Size = new System.Drawing.Size(156, 24);
            this.cbMaToaNha.TabIndex = 32;
            // 
            // lbTinhTrang
            // 
            this.lbTinhTrang.AutoSize = true;
            this.lbTinhTrang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTinhTrang.Location = new System.Drawing.Point(364, 200);
            this.lbTinhTrang.Name = "lbTinhTrang";
            this.lbTinhTrang.Size = new System.Drawing.Size(72, 16);
            this.lbTinhTrang.TabIndex = 29;
            this.lbTinhTrang.Text = "Tình trạng:";
            // 
            // txtSoLuongNguoi
            // 
            this.txtSoLuongNguoi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoLuongNguoi.Location = new System.Drawing.Point(131, 195);
            this.txtSoLuongNguoi.Name = "txtSoLuongNguoi";
            this.txtSoLuongNguoi.Size = new System.Drawing.Size(156, 23);
            this.txtSoLuongNguoi.TabIndex = 28;
            this.txtSoLuongNguoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuongNguoi_KeyPress);
            // 
            // lbSoLuongNguoi
            // 
            this.lbSoLuongNguoi.AutoSize = true;
            this.lbSoLuongNguoi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSoLuongNguoi.Location = new System.Drawing.Point(36, 202);
            this.lbSoLuongNguoi.Name = "lbSoLuongNguoi";
            this.lbSoLuongNguoi.Size = new System.Drawing.Size(100, 16);
            this.lbSoLuongNguoi.TabIndex = 27;
            this.lbSoLuongNguoi.Text = "Số lượng người:";
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbLoaiPhong.Location = new System.Drawing.Point(440, 146);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(150, 21);
            this.cbLoaiPhong.TabIndex = 26;
            // 
            // lbLoaiPhong
            // 
            this.lbLoaiPhong.AutoSize = true;
            this.lbLoaiPhong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbLoaiPhong.Location = new System.Drawing.Point(364, 151);
            this.lbLoaiPhong.Name = "lbLoaiPhong";
            this.lbLoaiPhong.Size = new System.Drawing.Size(75, 16);
            this.lbLoaiPhong.TabIndex = 25;
            this.lbLoaiPhong.Text = "Loại phòng:";
            // 
            // lbMaTN
            // 
            this.lbMaTN.AutoSize = true;
            this.lbMaTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaTN.Location = new System.Drawing.Point(36, 158);
            this.lbMaTN.Name = "lbMaTN";
            this.lbMaTN.Size = new System.Drawing.Size(77, 16);
            this.lbMaTN.TabIndex = 24;
            this.lbMaTN.Text = "Mã tòa nhà:";
            // 
            // lbTenPhong
            // 
            this.lbTenPhong.AutoSize = true;
            this.lbTenPhong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTenPhong.Location = new System.Drawing.Point(360, 108);
            this.lbTenPhong.Name = "lbTenPhong";
            this.lbTenPhong.Size = new System.Drawing.Size(74, 16);
            this.lbTenPhong.TabIndex = 23;
            this.lbTenPhong.Text = "Tên phòng:";
            // 
            // lbMaPhong
            // 
            this.lbMaPhong.AutoSize = true;
            this.lbMaPhong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaPhong.Location = new System.Drawing.Point(36, 108);
            this.lbMaPhong.Name = "lbMaPhong";
            this.lbMaPhong.Size = new System.Drawing.Size(69, 16);
            this.lbMaPhong.TabIndex = 22;
            this.lbMaPhong.Text = "Mã phòng:";
            // 
            // lbQLPhong
            // 
            this.lbQLPhong.AutoSize = true;
            this.lbQLPhong.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbQLPhong.Location = new System.Drawing.Point(198, 19);
            this.lbQLPhong.Name = "lbQLPhong";
            this.lbQLPhong.Size = new System.Drawing.Size(289, 39);
            this.lbQLPhong.TabIndex = 21;
            this.lbQLPhong.Text = "QUẢN LÝ PHÒNG";
            // 
            // dgQLPhong
            // 
            this.dgQLPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgQLPhong.Location = new System.Drawing.Point(12, 391);
            this.dgQLPhong.Name = "dgQLPhong";
            this.dgQLPhong.Size = new System.Drawing.Size(638, 127);
            this.dgQLPhong.TabIndex = 34;
            this.dgQLPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgQLPhong_CellClick);
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.AutoSize = true;
            this.lbTimKiem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTimKiem.Location = new System.Drawing.Point(11, 341);
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(66, 16);
            this.lbTimKiem.TabIndex = 59;
            this.lbTimKiem.Text = "Tìm kiếm:";
            // 
            // cbTimKiem
            // 
            this.cbTimKiem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbTimKiem.FormattingEnabled = true;
            this.cbTimKiem.Items.AddRange(new object[] {
            "Mã phòng",
            "Tên phòng"});
            this.cbTimKiem.Location = new System.Drawing.Point(78, 333);
            this.cbTimKiem.Name = "cbTimKiem";
            this.cbTimKiem.Size = new System.Drawing.Size(121, 24);
            this.cbTimKiem.TabIndex = 58;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimkiem.Location = new System.Drawing.Point(264, 333);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(212, 23);
            this.txtTimkiem.TabIndex = 57;
            // 
            // btTimkiem
            // 
            this.btTimkiem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btTimkiem.Image")));
            this.btTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimkiem.Location = new System.Drawing.Point(514, 321);
            this.btTimkiem.Name = "btTimkiem";
            this.btTimkiem.Size = new System.Drawing.Size(100, 35);
            this.btTimkiem.TabIndex = 56;
            this.btTimkiem.Text = "Tìm kiếm";
            this.btTimkiem.UseVisualStyleBackColor = true;
            this.btTimkiem.Click += new System.EventHandler(this.btTimkiem_Click);
            // 
            // btLamMoi
            // 
            this.btLamMoi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btLamMoi.Image")));
            this.btLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLamMoi.Location = new System.Drawing.Point(14, 246);
            this.btLamMoi.Name = "btLamMoi";
            this.btLamMoi.Size = new System.Drawing.Size(80, 52);
            this.btLamMoi.TabIndex = 52;
            this.btLamMoi.Text = "   Làm mới";
            this.btLamMoi.UseVisualStyleBackColor = true;
            this.btLamMoi.Click += new System.EventHandler(this.btLamMoi_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(316, 247);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(71, 48);
            this.btXoa.TabIndex = 54;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThoat.Image = ((System.Drawing.Image)(resources.GetObject("btThoat.Image")));
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(533, 246);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(81, 48);
            this.btThoat.TabIndex = 55;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSua.Image = ((System.Drawing.Image)(resources.GetObject("btSua.Image")));
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(217, 247);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(81, 48);
            this.btSua.TabIndex = 53;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(112, 246);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(87, 50);
            this.btThem.TabIndex = 51;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaPhong.Location = new System.Drawing.Point(131, 101);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(156, 23);
            this.txtMaPhong.TabIndex = 60;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenPhong.Location = new System.Drawing.Point(440, 101);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(150, 23);
            this.txtTenPhong.TabIndex = 61;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTinhTrang.Location = new System.Drawing.Point(440, 193);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(150, 23);
            this.txtTinhTrang.TabIndex = 62;
            // 
            // lbcnql
            // 
            this.lbcnql.AutoSize = true;
            this.lbcnql.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbcnql.Location = new System.Drawing.Point(4, 73);
            this.lbcnql.Name = "lbcnql";
            this.lbcnql.Size = new System.Drawing.Size(132, 16);
            this.lbcnql.TabIndex = 110;
            this.lbcnql.Text = "Chức năng quản lý:";
            // 
            // lbdsdn
            // 
            this.lbdsdn.AutoSize = true;
            this.lbdsdn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbdsdn.Location = new System.Drawing.Point(4, 372);
            this.lbdsdn.Name = "lbdsdn";
            this.lbdsdn.Size = new System.Drawing.Size(124, 16);
            this.lbdsdn.TabIndex = 111;
            this.lbdsdn.Text = "Danh sách phòng:";
            // 
            // frmQLPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 518);
            this.Controls.Add(this.lbdsdn);
            this.Controls.Add(this.lbcnql);
            this.Controls.Add(this.txtTinhTrang);
            this.Controls.Add(this.txtTenPhong);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.lbTimKiem);
            this.Controls.Add(this.cbTimKiem);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.btTimkiem);
            this.Controls.Add(this.btLamMoi);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dgQLPhong);
            this.Controls.Add(this.cbMaToaNha);
            this.Controls.Add(this.lbTinhTrang);
            this.Controls.Add(this.txtSoLuongNguoi);
            this.Controls.Add(this.lbSoLuongNguoi);
            this.Controls.Add(this.cbLoaiPhong);
            this.Controls.Add(this.lbLoaiPhong);
            this.Controls.Add(this.lbMaTN);
            this.Controls.Add(this.lbTenPhong);
            this.Controls.Add(this.lbMaPhong);
            this.Controls.Add(this.lbQLPhong);
            this.Name = "frmQLPhong";
            this.Text = "frnQLPhong";
            this.Load += new System.EventHandler(this.frmQLPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgQLPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMaToaNha;
        private System.Windows.Forms.Label lbTinhTrang;
        private System.Windows.Forms.TextBox txtSoLuongNguoi;
        private System.Windows.Forms.Label lbSoLuongNguoi;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.Label lbLoaiPhong;
        private System.Windows.Forms.Label lbMaTN;
        private System.Windows.Forms.Label lbTenPhong;
        private System.Windows.Forms.Label lbMaPhong;
        private System.Windows.Forms.Label lbQLPhong;
        private System.Windows.Forms.DataGridView dgQLPhong;
        private System.Windows.Forms.Label lbTimKiem;
        private System.Windows.Forms.ComboBox cbTimKiem;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btTimkiem;
        private System.Windows.Forms.Button btLamMoi;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Label lbcnql;
        private System.Windows.Forms.Label lbdsdn;
    }
}