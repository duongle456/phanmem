namespace QuanLyKiTucXa
{
    partial class frmQLKTX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLKTX));
            this.mnChinh = new System.Windows.Forms.MenuStrip();
            this.mnhethongquanly = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsinhvien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnnhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnphong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnpttienphong = new System.Windows.Forms.ToolStripMenuItem();
            this.mndiennuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnkhenthuongkyluat = new System.Windows.Forms.ToolStripMenuItem();
            this.mntaisan = new System.Windows.Forms.ToolStripMenuItem();
            this.mntoanha = new System.Windows.Forms.ToolStripMenuItem();
            this.mnhopdongsvphong = new System.Windows.Forms.ToolStripMenuItem();
            this.mndoituong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnchuyenphong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnthongtinchuongtrinh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnchucnang = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnChinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnChinh
            // 
            this.mnChinh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnhethongquanly,
            this.mnthongtinchuongtrinh,
            this.mnchucnang});
            this.mnChinh.Location = new System.Drawing.Point(0, 0);
            this.mnChinh.Name = "mnChinh";
            this.mnChinh.Size = new System.Drawing.Size(780, 24);
            this.mnChinh.TabIndex = 25;
            this.mnChinh.Text = "menuChinh";
            // 
            // mnhethongquanly
            // 
            this.mnhethongquanly.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsinhvien,
            this.mnnhanvien,
            this.mnphong,
            this.mnpttienphong,
            this.mndiennuoc,
            this.mnkhenthuongkyluat,
            this.mntaisan,
            this.mntoanha,
            this.mnhopdongsvphong,
            this.mndoituong,
            this.mnchuyenphong});
            this.mnhethongquanly.Image = ((System.Drawing.Image)(resources.GetObject("mnhethongquanly.Image")));
            this.mnhethongquanly.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnhethongquanly.Name = "mnhethongquanly";
            this.mnhethongquanly.Size = new System.Drawing.Size(127, 20);
            this.mnhethongquanly.Text = "Hệ thống quản lý";
            // 
            // mnsinhvien
            // 
            this.mnsinhvien.Image = ((System.Drawing.Image)(resources.GetObject("mnsinhvien.Image")));
            this.mnsinhvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnsinhvien.Name = "mnsinhvien";
            this.mnsinhvien.Size = new System.Drawing.Size(216, 22);
            this.mnsinhvien.Text = "Sinh viên";
            this.mnsinhvien.Click += new System.EventHandler(this.chươngTrìnhTìmKiếmToolStripMenuItem_Click);
            // 
            // mnnhanvien
            // 
            this.mnnhanvien.Image = ((System.Drawing.Image)(resources.GetObject("mnnhanvien.Image")));
            this.mnnhanvien.Name = "mnnhanvien";
            this.mnnhanvien.Size = new System.Drawing.Size(216, 22);
            this.mnnhanvien.Text = "Nhân viên";
            this.mnnhanvien.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // mnphong
            // 
            this.mnphong.Image = ((System.Drawing.Image)(resources.GetObject("mnphong.Image")));
            this.mnphong.Name = "mnphong";
            this.mnphong.Size = new System.Drawing.Size(216, 22);
            this.mnphong.Text = "Phòng";
            this.mnphong.Click += new System.EventHandler(this.phòngToolStripMenuItem_Click);
            // 
            // mnpttienphong
            // 
            this.mnpttienphong.Image = ((System.Drawing.Image)(resources.GetObject("mnpttienphong.Image")));
            this.mnpttienphong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnpttienphong.Name = "mnpttienphong";
            this.mnpttienphong.Size = new System.Drawing.Size(216, 22);
            this.mnpttienphong.Text = "PT tiền phòng";
            this.mnpttienphong.Click += new System.EventHandler(this.phiếuThuToolStripMenuItem_Click);
            // 
            // mndiennuoc
            // 
            this.mndiennuoc.Image = ((System.Drawing.Image)(resources.GetObject("mndiennuoc.Image")));
            this.mndiennuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mndiennuoc.Name = "mndiennuoc";
            this.mndiennuoc.Size = new System.Drawing.Size(216, 22);
            this.mndiennuoc.Text = "Điện nước";
            this.mndiennuoc.Click += new System.EventHandler(this.điệnNướcToolStripMenuItem_Click);
            // 
            // mnkhenthuongkyluat
            // 
            this.mnkhenthuongkyluat.Image = ((System.Drawing.Image)(resources.GetObject("mnkhenthuongkyluat.Image")));
            this.mnkhenthuongkyluat.Name = "mnkhenthuongkyluat";
            this.mnkhenthuongkyluat.Size = new System.Drawing.Size(216, 22);
            this.mnkhenthuongkyluat.Text = "Khen thưởng-Kỷ luật";
            this.mnkhenthuongkyluat.Click += new System.EventHandler(this.khenThưởngKỷLuậtToolStripMenuItem_Click);
            // 
            // mntaisan
            // 
            this.mntaisan.Image = ((System.Drawing.Image)(resources.GetObject("mntaisan.Image")));
            this.mntaisan.Name = "mntaisan";
            this.mntaisan.Size = new System.Drawing.Size(216, 22);
            this.mntaisan.Text = "Tài sản";
            this.mntaisan.Click += new System.EventHandler(this.tàiSảnToolStripMenuItem_Click);
            // 
            // mntoanha
            // 
            this.mntoanha.Image = ((System.Drawing.Image)(resources.GetObject("mntoanha.Image")));
            this.mntoanha.Name = "mntoanha";
            this.mntoanha.Size = new System.Drawing.Size(216, 22);
            this.mntoanha.Text = "Tòa nhà";
            this.mntoanha.Click += new System.EventHandler(this.tòaNhàToolStripMenuItem_Click);
            // 
            // mnhopdongsvphong
            // 
            this.mnhopdongsvphong.Image = ((System.Drawing.Image)(resources.GetObject("mnhopdongsvphong.Image")));
            this.mnhopdongsvphong.Name = "mnhopdongsvphong";
            this.mnhopdongsvphong.Size = new System.Drawing.Size(216, 22);
            this.mnhopdongsvphong.Text = "Hợp đồng sinh viên phòng";
            this.mnhopdongsvphong.Click += new System.EventHandler(this.hợpĐồngSinhViênPhòngToolStripMenuItem_Click);
            // 
            // mndoituong
            // 
            this.mndoituong.Image = ((System.Drawing.Image)(resources.GetObject("mndoituong.Image")));
            this.mndoituong.Name = "mndoituong";
            this.mndoituong.Size = new System.Drawing.Size(216, 22);
            this.mndoituong.Text = "Đối tượng";
            this.mndoituong.Click += new System.EventHandler(this.đốiTượngToolStripMenuItem_Click);
            // 
            // mnchuyenphong
            // 
            this.mnchuyenphong.Image = ((System.Drawing.Image)(resources.GetObject("mnchuyenphong.Image")));
            this.mnchuyenphong.Name = "mnchuyenphong";
            this.mnchuyenphong.Size = new System.Drawing.Size(216, 22);
            this.mnchuyenphong.Text = "Chuyển phòng";
            this.mnchuyenphong.Click += new System.EventHandler(this.mnchuyenphong_Click);
            // 
            // mnthongtinchuongtrinh
            // 
            this.mnthongtinchuongtrinh.Image = ((System.Drawing.Image)(resources.GetObject("mnthongtinchuongtrinh.Image")));
            this.mnthongtinchuongtrinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnthongtinchuongtrinh.Name = "mnthongtinchuongtrinh";
            this.mnthongtinchuongtrinh.Size = new System.Drawing.Size(159, 20);
            this.mnthongtinchuongtrinh.Text = "Thông tin chương trình";
            this.mnthongtinchuongtrinh.Click += new System.EventHandler(this.thôngTinChươngTrìnhToolStripMenuItem_Click);
            // 
            // mnchucnang
            // 
            this.mnchucnang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem1});
            this.mnchucnang.Image = ((System.Drawing.Image)(resources.GetObject("mnchucnang.Image")));
            this.mnchucnang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnchucnang.Name = "mnchucnang";
            this.mnchucnang.Size = new System.Drawing.Size(93, 20);
            this.mnchucnang.Text = "Chức năng";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("đăngXuấtToolStripMenuItem.Image")));
            this.đăngXuấtToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem1
            // 
            this.thoátToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("thoátToolStripMenuItem1.Image")));
            this.thoátToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.thoátToolStripMenuItem1.Name = "thoátToolStripMenuItem1";
            this.thoátToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.thoátToolStripMenuItem1.Text = "Thoát";
            this.thoátToolStripMenuItem1.Click += new System.EventHandler(this.thoátToolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyKyTucXa.Properties.Resources.dhtdm;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(780, 387);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmQLKTX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 415);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mnChinh);
            this.Name = "frmQLKTX";
            this.Text = "frmQLKTX";
            this.Load += new System.EventHandler(this.frmQLKTX_Load);
            this.mnChinh.ResumeLayout(false);
            this.mnChinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnChinh;
        private System.Windows.Forms.ToolStripMenuItem mnhethongquanly;
        private System.Windows.Forms.ToolStripMenuItem mnsinhvien;
        private System.Windows.Forms.ToolStripMenuItem mnnhanvien;
        private System.Windows.Forms.ToolStripMenuItem mnphong;
        private System.Windows.Forms.ToolStripMenuItem mnpttienphong;
        private System.Windows.Forms.ToolStripMenuItem mndiennuoc;
        private System.Windows.Forms.ToolStripMenuItem mnkhenthuongkyluat;
        private System.Windows.Forms.ToolStripMenuItem mntaisan;
        private System.Windows.Forms.ToolStripMenuItem mntoanha;
        private System.Windows.Forms.ToolStripMenuItem mnhopdongsvphong;
        private System.Windows.Forms.ToolStripMenuItem mndoituong;
        private System.Windows.Forms.ToolStripMenuItem mnthongtinchuongtrinh;
        private System.Windows.Forms.ToolStripMenuItem mnchucnang;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnchuyenphong;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

