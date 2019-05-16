using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyKiTucXa.DataAccessLayer;

namespace QuanLyKiTucXa.PresentationLayer
{
    public partial class frmQLDangNhap : Form
    {
        DangNhapDAL DN = new DangNhapDAL();
        public frmQLDangNhap()
        {
            InitializeComponent();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            string QH;
            DataTable dt = new DataTable();
            dt = DN.Taikhoan(txtTenDN.Text, txtMatKhau.Text, cbQuyenSD.Text);
            frmQLKTX main =  (frmQLKTX)this.MdiParent;
            try
            {
                QH = dt.Rows[0][0].ToString();
                if (QH == "Admin")
                {
                    main.Admin();
                    main.Show();
                }
                else
                    if (QH == "Nhân Viên")
                    {

                        main.NhanVien();
                        main.Show();
                    }

                MessageBox.Show("Đăng nhập thành công!");
                Form frm = new frmQLKTX();
                this.Hide();
                frm.Show();
            }
            catch
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu,hoặc quyền hạn không đúng.Hãy nhập lại!");
            }
            txtMatKhau.Text = "";
            txtTenDN.Text = "";
            cbQuyenSD.SelectedIndex = 0;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thực sự muốn thoát không?", "THÔNG BÁO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
