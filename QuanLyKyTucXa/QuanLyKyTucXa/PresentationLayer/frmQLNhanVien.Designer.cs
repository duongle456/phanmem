namespace QuanLyKiTucXa
{
    partial class frmQLNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLNhanVien));
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.lbSoDienThoai = new System.Windows.Forms.Label();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.lbQueQuan = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbTenNhanVien = new System.Windows.Forms.Label();
            this.lbMaNhanVien = new System.Windows.Forms.Label();
            this.dgQLNhanVien = new System.Windows.Forms.DataGridView();
            this.lbQLNhanVien = new System.Windows.Forms.Label();
            this.btLamMoi = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btTimkiem = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.cbTimKiem = new System.Windows.Forms.ComboBox();
            this.lbTimKiem = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtNgayVaoLam = new System.Windows.Forms.TextBox();
            this.lbNgayVaoLam = new System.Windows.Forms.Label();
            this.txtLCB = new System.Windows.Forms.TextBox();
            this.lbLCB = new System.Windows.Forms.Label();
            this.txtHeSoLuong = new System.Windows.Forms.TextBox();
            this.lbHSL = new System.Windows.Forms.Label();
            this.lbHSPC = new System.Windows.Forms.Label();
            this.txtHeSoPC = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.lbLuong = new System.Windows.Forms.Label();
            this.btTinhLuong = new System.Windows.Forms.Button();
            this.lbluongcb = new System.Windows.Forms.Label();
            this.lbnvd = new System.Windows.Forms.Label();
            this.lbcnql = new System.Windows.Forms.Label();
            this.lbdsdn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgQLNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtQueQuan.Location = new System.Drawing.Point(397, 140);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(133, 23);
            this.txtQueQuan.TabIndex = 36;
            // 
            // txtChucVu
            // 
            this.txtChucVu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtChucVu.Location = new System.Drawing.Point(600, 140);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(142, 23);
            this.txtChucVu.TabIndex = 35;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoDienThoai.Location = new System.Drawing.Point(123, 177);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(142, 23);
            this.txtSoDienThoai.TabIndex = 33;
            this.txtSoDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDienThoai_KeyPress);
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenNhanVien.Location = new System.Drawing.Point(397, 102);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(133, 23);
            this.txtTenNhanVien.TabIndex = 32;
            this.txtTenNhanVien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenNhanVien_KeyPress);
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(123, 140);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(142, 24);
            this.cbGioiTinh.TabIndex = 31;
            // 
            // lbSoDienThoai
            // 
            this.lbSoDienThoai.AutoSize = true;
            this.lbSoDienThoai.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSoDienThoai.Location = new System.Drawing.Point(38, 180);
            this.lbSoDienThoai.Name = "lbSoDienThoai";
            this.lbSoDienThoai.Size = new System.Drawing.Size(88, 16);
            this.lbSoDienThoai.TabIndex = 29;
            this.lbSoDienThoai.Text = "Số điện thoại:";
            // 
            // lbChucVu
            // 
            this.lbChucVu.AutoSize = true;
            this.lbChucVu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbChucVu.Location = new System.Drawing.Point(536, 143);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(59, 16);
            this.lbChucVu.TabIndex = 28;
            this.lbChucVu.Text = "Chức vụ:";
            // 
            // lbQueQuan
            // 
            this.lbQueQuan.AutoSize = true;
            this.lbQueQuan.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbQueQuan.Location = new System.Drawing.Point(307, 143);
            this.lbQueQuan.Name = "lbQueQuan";
            this.lbQueQuan.Size = new System.Drawing.Size(68, 16);
            this.lbQueQuan.TabIndex = 27;
            this.lbQueQuan.Text = "Quê quán:";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNgaySinh.Location = new System.Drawing.Point(536, 110);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(68, 16);
            this.lbNgaySinh.TabIndex = 26;
            this.lbNgaySinh.Text = "Ngày sinh:";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbGioiTinh.Location = new System.Drawing.Point(38, 148);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(59, 16);
            this.lbGioiTinh.TabIndex = 25;
            this.lbGioiTinh.Text = "Giới tính:";
            // 
            // lbTenNhanVien
            // 
            this.lbTenNhanVien.AutoSize = true;
            this.lbTenNhanVien.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTenNhanVien.Location = new System.Drawing.Point(307, 110);
            this.lbTenNhanVien.Name = "lbTenNhanVien";
            this.lbTenNhanVien.Size = new System.Drawing.Size(94, 16);
            this.lbTenNhanVien.TabIndex = 24;
            this.lbTenNhanVien.Text = "Tên nhân viên:";
            // 
            // lbMaNhanVien
            // 
            this.lbMaNhanVien.AutoSize = true;
            this.lbMaNhanVien.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaNhanVien.Location = new System.Drawing.Point(38, 110);
            this.lbMaNhanVien.Name = "lbMaNhanVien";
            this.lbMaNhanVien.Size = new System.Drawing.Size(89, 16);
            this.lbMaNhanVien.TabIndex = 23;
            this.lbMaNhanVien.Text = "Mã nhân viên:";
            
            // 
            // dgQLNhanVien
            // 
            this.dgQLNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgQLNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgQLNhanVien.Location = new System.Drawing.Point(8, 410);
            this.dgQLNhanVien.Name = "dgQLNhanVien";
            this.dgQLNhanVien.Size = new System.Drawing.Size(804, 183);
            this.dgQLNhanVien.TabIndex = 22;
            this.dgQLNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgQLNhanVien_CellClick);
            // 
            // lbQLNhanVien
            // 
            this.lbQLNhanVien.AutoSize = true;
            this.lbQLNhanVien.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbQLNhanVien.Location = new System.Drawing.Point(207, 22);
            this.lbQLNhanVien.Name = "lbQLNhanVien";
            this.lbQLNhanVien.Size = new System.Drawing.Size(357, 39);
            this.lbQLNhanVien.TabIndex = 21;
            this.lbQLNhanVien.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // btLamMoi
            // 
            this.btLamMoi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btLamMoi.Image")));
            this.btLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLamMoi.Location = new System.Drawing.Point(28, 267);
            this.btLamMoi.Name = "btLamMoi";
            this.btLamMoi.Size = new System.Drawing.Size(80, 52);
            this.btLamMoi.TabIndex = 43;
            this.btLamMoi.Text = "   Làm mới";
            this.btLamMoi.UseVisualStyleBackColor = true;
            this.btLamMoi.Click += new System.EventHandler(this.btLamMoi_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(330, 268);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(86, 48);
            this.btXoa.TabIndex = 45;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThoat.Image = ((System.Drawing.Image)(resources.GetObject("btThoat.Image")));
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(673, 268);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(81, 48);
            this.btThoat.TabIndex = 46;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSua.Image = ((System.Drawing.Image)(resources.GetObject("btSua.Image")));
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(231, 268);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(84, 48);
            this.btSua.TabIndex = 44;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(126, 267);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(87, 50);
            this.btThem.TabIndex = 42;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btTimkiem
            // 
            this.btTimkiem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btTimkiem.Image")));
            this.btTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimkiem.Location = new System.Drawing.Point(565, 338);
            this.btTimkiem.Name = "btTimkiem";
            this.btTimkiem.Size = new System.Drawing.Size(100, 35);
            this.btTimkiem.TabIndex = 47;
            this.btTimkiem.Text = "Tìm kiếm";
            this.btTimkiem.UseVisualStyleBackColor = true;
            this.btTimkiem.Click += new System.EventHandler(this.btTimkiem_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimkiem.Location = new System.Drawing.Point(347, 350);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(212, 23);
            this.txtTimkiem.TabIndex = 48;
            // 
            // cbTimKiem
            // 
            this.cbTimKiem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbTimKiem.FormattingEnabled = true;
            this.cbTimKiem.Items.AddRange(new object[] {
            "Mã nhân viên",
            "Tên nhân viên"});
            this.cbTimKiem.Location = new System.Drawing.Point(92, 349);
            this.cbTimKiem.Name = "cbTimKiem";
            this.cbTimKiem.Size = new System.Drawing.Size(152, 24);
            this.cbTimKiem.TabIndex = 49;
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.AutoSize = true;
            this.lbTimKiem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTimKiem.Location = new System.Drawing.Point(25, 357);
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(66, 16);
            this.lbTimKiem.TabIndex = 50;
            this.lbTimKiem.Text = "Tìm kiếm:";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaNhanVien.Location = new System.Drawing.Point(123, 103);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(142, 23);
            this.txtMaNhanVien.TabIndex = 51;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNgaySinh.Location = new System.Drawing.Point(600, 104);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(142, 23);
            this.txtNgaySinh.TabIndex = 52;
            // 
            // txtNgayVaoLam
            // 
            this.txtNgayVaoLam.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNgayVaoLam.Location = new System.Drawing.Point(397, 177);
            this.txtNgayVaoLam.Name = "txtNgayVaoLam";
            this.txtNgayVaoLam.Size = new System.Drawing.Size(133, 23);
            this.txtNgayVaoLam.TabIndex = 53;
            // 
            // lbNgayVaoLam
            // 
            this.lbNgayVaoLam.AutoSize = true;
            this.lbNgayVaoLam.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNgayVaoLam.Location = new System.Drawing.Point(307, 180);
            this.lbNgayVaoLam.Name = "lbNgayVaoLam";
            this.lbNgayVaoLam.Size = new System.Drawing.Size(90, 16);
            this.lbNgayVaoLam.TabIndex = 54;
            this.lbNgayVaoLam.Text = "Ngày vào làm:";
            // 
            // txtLCB
            // 
            this.txtLCB.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLCB.Location = new System.Drawing.Point(600, 177);
            this.txtLCB.Name = "txtLCB";
            this.txtLCB.Size = new System.Drawing.Size(142, 23);
            this.txtLCB.TabIndex = 55;
            // 
            // lbLCB
            // 
            this.lbLCB.AutoSize = true;
            this.lbLCB.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbLCB.Location = new System.Drawing.Point(536, 179);
            this.lbLCB.Name = "lbLCB";
            this.lbLCB.Size = new System.Drawing.Size(65, 16);
            this.lbLCB.TabIndex = 56;
            this.lbLCB.Text = "Lương cb:";
            // 
            // txtHeSoLuong
            // 
            this.txtHeSoLuong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHeSoLuong.Location = new System.Drawing.Point(123, 218);
            this.txtHeSoLuong.Name = "txtHeSoLuong";
            this.txtHeSoLuong.Size = new System.Drawing.Size(142, 23);
            this.txtHeSoLuong.TabIndex = 57;
            // 
            // lbHSL
            // 
            this.lbHSL.AutoSize = true;
            this.lbHSL.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbHSL.Location = new System.Drawing.Point(38, 221);
            this.lbHSL.Name = "lbHSL";
            this.lbHSL.Size = new System.Drawing.Size(81, 16);
            this.lbHSL.TabIndex = 58;
            this.lbHSL.Text = "Hệ số lương:";
            // 
            // lbHSPC
            // 
            this.lbHSPC.AutoSize = true;
            this.lbHSPC.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbHSPC.Location = new System.Drawing.Point(307, 221);
            this.lbHSPC.Name = "lbHSPC";
            this.lbHSPC.Size = new System.Drawing.Size(62, 16);
            this.lbHSPC.TabIndex = 59;
            this.lbHSPC.Text = "Hệ số pc:";
            // 
            // txtHeSoPC
            // 
            this.txtHeSoPC.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHeSoPC.Location = new System.Drawing.Point(397, 218);
            this.txtHeSoPC.Name = "txtHeSoPC";
            this.txtHeSoPC.Size = new System.Drawing.Size(133, 23);
            this.txtHeSoPC.TabIndex = 60;
            // 
            // txtLuong
            // 
            this.txtLuong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLuong.Location = new System.Drawing.Point(600, 218);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(142, 23);
            this.txtLuong.TabIndex = 61;
            // 
            // lbLuong
            // 
            this.lbLuong.AutoSize = true;
            this.lbLuong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbLuong.Location = new System.Drawing.Point(539, 221);
            this.lbLuong.Name = "lbLuong";
            this.lbLuong.Size = new System.Drawing.Size(48, 16);
            this.lbLuong.TabIndex = 62;
            this.lbLuong.Text = "Lương:";
            // 
            // btTinhLuong
            // 
            this.btTinhLuong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btTinhLuong.Image = ((System.Drawing.Image)(resources.GetObject("btTinhLuong.Image")));
            this.btTinhLuong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTinhLuong.Location = new System.Drawing.Point(435, 268);
            this.btTinhLuong.Name = "btTinhLuong";
            this.btTinhLuong.Size = new System.Drawing.Size(95, 48);
            this.btTinhLuong.TabIndex = 63;
            this.btTinhLuong.Text = "    Tính lương";
            this.btTinhLuong.UseVisualStyleBackColor = true;
            this.btTinhLuong.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btTinhLuong_MouseClick);
            // 
            // lbluongcb
            // 
            this.lbluongcb.AutoSize = true;
            this.lbluongcb.Location = new System.Drawing.Point(748, 181);
            this.lbluongcb.Name = "lbluongcb";
            this.lbluongcb.Size = new System.Drawing.Size(46, 13);
            this.lbluongcb.TabIndex = 64;
            this.lbluongcb.Text = "đ/tháng";
            // 
            // lbnvd
            // 
            this.lbnvd.AutoSize = true;
            this.lbnvd.Location = new System.Drawing.Point(748, 223);
            this.lbnvd.Name = "lbnvd";
            this.lbnvd.Size = new System.Drawing.Size(30, 13);
            this.lbnvd.TabIndex = 65;
            this.lbnvd.Text = "VND";
            // 
            // lbcnql
            // 
            this.lbcnql.AutoSize = true;
            this.lbcnql.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbcnql.Location = new System.Drawing.Point(5, 84);
            this.lbcnql.Name = "lbcnql";
            this.lbcnql.Size = new System.Drawing.Size(132, 16);
            this.lbcnql.TabIndex = 108;
            this.lbcnql.Text = "Chức năng quản lý:";
            // 
            // lbdsdn
            // 
            this.lbdsdn.AutoSize = true;
            this.lbdsdn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbdsdn.Location = new System.Drawing.Point(5, 391);
            this.lbdsdn.Name = "lbdsdn";
            this.lbdsdn.Size = new System.Drawing.Size(147, 16);
            this.lbdsdn.TabIndex = 109;
            this.lbdsdn.Text = "Danh sách nhân viên:";
            // 
            // frmQLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 592);
            this.Controls.Add(this.lbdsdn);
            this.Controls.Add(this.lbcnql);
            this.Controls.Add(this.lbnvd);
            this.Controls.Add(this.lbluongcb);
            this.Controls.Add(this.btTinhLuong);
            this.Controls.Add(this.lbLuong);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.txtHeSoPC);
            this.Controls.Add(this.lbHSPC);
            this.Controls.Add(this.lbHSL);
            this.Controls.Add(this.txtHeSoLuong);
            this.Controls.Add(this.lbLCB);
            this.Controls.Add(this.txtLCB);
            this.Controls.Add(this.lbNgayVaoLam);
            this.Controls.Add(this.txtNgayVaoLam);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.lbTimKiem);
            this.Controls.Add(this.cbTimKiem);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.btTimkiem);
            this.Controls.Add(this.btLamMoi);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.txtQueQuan);
            this.Controls.Add(this.txtChucVu);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.txtTenNhanVien);
            this.Controls.Add(this.cbGioiTinh);
            this.Controls.Add(this.lbSoDienThoai);
            this.Controls.Add(this.lbChucVu);
            this.Controls.Add(this.lbQueQuan);
            this.Controls.Add(this.lbNgaySinh);
            this.Controls.Add(this.lbGioiTinh);
            this.Controls.Add(this.lbTenNhanVien);
            this.Controls.Add(this.lbMaNhanVien);
            this.Controls.Add(this.dgQLNhanVien);
            this.Controls.Add(this.lbQLNhanVien);
            this.Name = "frmQLNhanVien";
            this.Text = "frmQLNhanVien";
            this.Load += new System.EventHandler(this.frmQLNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgQLNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.Label lbSoDienThoai;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.Label lbQueQuan;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label lbTenNhanVien;
        private System.Windows.Forms.Label lbMaNhanVien;
        private System.Windows.Forms.DataGridView dgQLNhanVien;
        private System.Windows.Forms.Label lbQLNhanVien;
        private System.Windows.Forms.Button btLamMoi;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btTimkiem;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.ComboBox cbTimKiem;
        private System.Windows.Forms.Label lbTimKiem;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtNgayVaoLam;
        private System.Windows.Forms.Label lbNgayVaoLam;
        private System.Windows.Forms.TextBox txtLCB;
        private System.Windows.Forms.Label lbLCB;
        private System.Windows.Forms.TextBox txtHeSoLuong;
        private System.Windows.Forms.Label lbHSL;
        private System.Windows.Forms.Label lbHSPC;
        private System.Windows.Forms.TextBox txtHeSoPC;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Label lbLuong;
        private System.Windows.Forms.Button btTinhLuong;
        private System.Windows.Forms.Label lbluongcb;
        private System.Windows.Forms.Label lbnvd;
        private System.Windows.Forms.Label lbcnql;
        private System.Windows.Forms.Label lbdsdn;
    }
}