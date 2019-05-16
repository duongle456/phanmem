using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyKiTucXa.PresentationLayer;
using QuanLyKiTucXa.BusinessLogicLayer;
using QuanLyKiTucXa.DataAccessLayer;
using System.Diagnostics;

namespace QuanLyKiTucXa
{
    public partial class frmQLKTX : Form
    {
        public frmQLKTX()
        {
            InitializeComponent();
        }
        //Nhân viên
        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLNhanVien frmnv = new frmQLNhanVien();
            frmnv.Show();
            this.Hide();
        }
        //Phòng
        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLPhong frmph = new frmQLPhong();
            frmph.Show();
            this.Hide();
        }
        //Hợp đồng
        private void hợpĐồngSinhViênPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLHDSinhVien_Phong frmhd = new frmQLHDSinhVien_Phong();
            frmhd.Show();
            this.Hide();
        }
        //Sinh viên
        private void chươngTrìnhTìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLSV frmsv = new frmQLSV();
            frmsv.Show();
            this.Hide();
        }
        //Điện nước
        private void điệnNướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLDienNuoc frmdn = new frmQLDienNuoc();
            frmdn.Show();
            this.Hide();
        }
        //Phiếu thu tiền phòng
        private void phiếuThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLPTTienPhong frmpt = new frmQLPTTienPhong();
            frmpt.Show();
            this.Hide();
        }
        //Tòa nhà
        private void tòaNhàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLToaNha frmtn = new frmQLToaNha();
            frmtn.Show();
            this.Hide();
        }
        //Đối tượng
        private void đốiTượngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLDoiTuong frmdt = new frmQLDoiTuong();
            frmdt.Show();
            this.Hide();
        }
        //Khen thưởng
        private void khenThưởngKỷLuậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLKhenThuongKyLuat frmkt = new frmQLKhenThuongKyLuat();
            frmkt.Show();
            this.Hide();
        }
        //Tài sản
        private void tàiSảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLTaiSan frmts = new frmQLTaiSan();
            frmts.Show();
            this.Hide();
        }
        //Thông tin
        private void thôngTinChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CHƯƠNG TRÌNH QUẢN LÝ KÝ TÚC XÁ\nNgười thực hiện:Lê Văn Dương\n Sinh viên lớp:D15HT01", "Thông tin chương trình", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } 
        //Thoát
        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát không?", "THÔNG BÁO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        //Đăng xuất
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLDangNhap frmdn = new frmQLDangNhap();
            frmdn.Show();
            this.Hide();
        }
        //Chuyển phòng
        private void mnchuyenphong_Click(object sender, EventArgs e)
        {
            frmQLChuyenPhong frmcp = new frmQLChuyenPhong();
            frmcp.Show();
            this.Hide();
        }
        public void An_LoadForm()
        {
            mnhethongquanly.Enabled = false;
        }
        public void Admin()
        {
            mnhethongquanly.Enabled = true;
 
        }
        public void NhanVien()
        {
            mnhethongquanly.Enabled = true;
            mnchuyenphong.Enabled = true;
            mndiennuoc.Enabled = true;
            mndoituong.Enabled = true;
            mnkhenthuongkyluat.Enabled = true;
            mnnhanvien.Enabled = false;
            mnpttienphong.Enabled = true;
            mnphong.Enabled = true;
            mnsinhvien.Enabled = true;
            mntaisan.Enabled = true;
            mntoanha.Enabled = true;
            mnhopdongsvphong.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmQLKTX_Load(object sender, EventArgs e)
        {
            
        }
    }
}
