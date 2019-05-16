using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyKiTucXa.BusinessLogicLayer.Entities;
using QuanLyKiTucXa.BusinessLogicLayer.Components;

namespace QuanLyKiTucXa
{
    public partial class frmQLNhanVien : Form
    {
        public frmQLNhanVien()
        {
            InitializeComponent();
        }
        NhanVienBLL NVBLL = new NhanVienBLL();
        //Sự kiện Load
        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {
            cbGioiTinh.SelectedIndex = 0;
            cbTimKiem.SelectedIndex = 0;
            dgQLNhanVien.DataSource = NVBLL.Load();
            btSua.Enabled = false;
            btXoa.Enabled = false;
        }
        //Tính lương
        private void btTinhLuong_MouseClick(object sender, MouseEventArgs e)
        {
            float pc = float.Parse(txtHeSoPC.Text);
            float hsl = float.Parse(txtHeSoLuong.Text);
            float lcb = float.Parse(txtLCB.Text);
            float l = pc + lcb * hsl;
            txtLuong.Text = l.ToString();
        }
        //Sự kiên CellClick
        private void dgQLNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           int HangChon = e.RowIndex;
            if (HangChon != -1)
            {
                txtMaNhanVien.Text = dgQLNhanVien[0, HangChon].Value.ToString();
                txtTenNhanVien.Text = dgQLNhanVien[1, HangChon].Value.ToString();
                cbGioiTinh.Text = dgQLNhanVien[2, HangChon].Value.ToString();
                txtNgaySinh.Text = dgQLNhanVien[3, HangChon].Value.ToString();
                txtQueQuan.Text = dgQLNhanVien[4, HangChon].Value.ToString();
                txtChucVu.Text = dgQLNhanVien[5, HangChon].Value.ToString();
                txtSoDienThoai.Text = dgQLNhanVien[6, HangChon].Value.ToString();
                txtNgayVaoLam.Text = dgQLNhanVien[7, HangChon].Value.ToString();
                txtLCB.Text = dgQLNhanVien[8, HangChon].Value.ToString();
                txtHeSoLuong.Text = dgQLNhanVien[9, HangChon].Value.ToString();
                txtHeSoPC.Text = dgQLNhanVien[10, HangChon].Value.ToString();
                txtLuong.Text = dgQLNhanVien[11, HangChon].Value.ToString();
            }
            txtMaNhanVien.Enabled = false;
            txtTimkiem.Text = "";
            btSua.Enabled = true;
            btXoa.Enabled = true;
            btThem.Enabled = false;
        }
        //Sự kiện mới
        private void btLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Text = "";
            txtTenNhanVien.Text = "";
            cbGioiTinh.SelectedIndex = 0;
            txtNgaySinh.Text = "";
            txtQueQuan.Text = "";
            txtChucVu.Text = "";
            txtSoDienThoai.Text = "";
            txtNgayVaoLam.Text = "";
            txtLCB.Text = "";
            txtHeSoLuong.Text = "";
            txtHeSoPC.Text = "";
            txtLuong.Text = "";
            cbTimKiem.SelectedIndex = 0;
            txtTimkiem.Text = "";
            txtMaNhanVien.Enabled = true;
            btThem.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            dgQLNhanVien.DataSource = NVBLL.Load();
        }
        //Sự kiện thêm
        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập Mã nhân viên!", "THÔNG BÁO!", MessageBoxButtons.OK);
            }
            else
            {
                if (NVBLL.Dembanghi(txtMaNhanVien.Text) == 1)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại.Hãy nhập lại mã khác!", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaNhanVien.Text = "";
                }
                else
                {
                    if (txtTenNhanVien.Text.Trim() == "" || cbGioiTinh.Text.Trim() == "" || txtNgaySinh.Text.Trim() == "" || txtQueQuan.Text.Trim() == "" || txtChucVu.Text.Trim() == "" || txtSoDienThoai.Text.Trim() == "" || txtNgayVaoLam.Text.Trim() == "" || txtLCB.Text.Trim() == "" || txtHeSoLuong.Text.Trim() == "" || txtHeSoPC.Text.Trim() == "" || txtLuong.Text.Trim() == "")
                    {
                        MessageBox.Show("Bạn chưa nhập đầy đủ thông tin của nhân viên!", "THÔNG BÁO!", MessageBoxButtons.OK);
                    }
                    else
                    {

                        NVBLL.ThemNhanVien(txtMaNhanVien.Text, txtTenNhanVien.Text, cbGioiTinh.Text, txtNgaySinh.Text, txtQueQuan.Text, txtChucVu.Text, txtSoDienThoai.Text, txtNgayVaoLam.Text, txtLCB.Text, txtHeSoLuong.Text, txtHeSoPC.Text, txtLuong.Text);
                        dgQLNhanVien.DataSource = NVBLL.Load();
                        btLamMoi_Click(sender, e);
                    }
                }
            }
        }
        //Sự kiện sửa
        private void btSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn sửa nhân viên này?", "THÔNG BÁO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtTenNhanVien.Text.Trim() == "" || cbGioiTinh.Text.Trim() == "" || txtNgaySinh.Text.Trim() == "" || txtQueQuan.Text.Trim() == "" || txtChucVu.Text.Trim() == "" || txtSoDienThoai.Text.Trim() == "" || txtNgayVaoLam.Text.Trim() == "" || txtLCB.Text.Trim() == "" || txtHeSoLuong.Text.Trim() == "" || txtHeSoPC.Text.Trim() == "" || txtLuong.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin của nhân viên!", "THÔNG BÁO!", MessageBoxButtons.OK);
                }
                else
                {
                    NVBLL.SuaNhanVien(txtMaNhanVien.Text, txtTenNhanVien.Text, cbGioiTinh.Text, txtNgaySinh.Text, txtQueQuan.Text, txtChucVu.Text, txtSoDienThoai.Text, txtNgayVaoLam.Text, txtLCB.Text, txtHeSoLuong.Text, txtHeSoPC.Text, txtLuong.Text);
                    frmQLNhanVien_Load(sender, e);
                    btLamMoi_Click(sender, e);
                }
            }
        }
        //Sự kiện xóa
        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa nhân viên này?", "THÔNG BÁO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NVBLL.XoaNhanVien(txtMaNhanVien.Text);
                frmQLNhanVien_Load(sender, e);
                btLamMoi_Click(sender, e);
            }
        }
        //Sự kiện thoát
        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát không?", "THÔNG BÁO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                frmQLKTX frmktx = new frmQLKTX();
                frmktx.Show();
                this.Hide();
            }
        }
        //Sự kiện tìm kiếm
        private void btTimkiem_Click(object sender, EventArgs e)
        {
            dgQLNhanVien.DataSource = NVBLL.TimKiem(cbTimKiem.Text, txtTimkiem.Text);
        }

        private void txtTenNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar <= 33 || e.KeyChar >= 64);
        }

        private void txtNgaySinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
