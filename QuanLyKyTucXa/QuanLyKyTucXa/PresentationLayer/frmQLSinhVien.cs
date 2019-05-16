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
    public partial class frmQLSV : Form
    {
        public frmQLSV()
        {
            InitializeComponent();
        }
        SinhVienBLL SVBLL = new SinhVienBLL();
        private void frmQLSV_Load(object sender, EventArgs e)
        {
            cbGioiTinh.SelectedIndex = 0;
            cbDoiTuong.SelectedIndex = 0;
            cbTimKiem.SelectedIndex = 0;
            dgQLSinhVien.DataSource = SVBLL.Load();
            btSua.Enabled = false;
            btXoa.Enabled = false;
        }

        private void dgQLSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int HangChon = e.RowIndex;
            if (HangChon != -1)
            {
                txtMaSinhVien.Text = dgQLSinhVien[0, HangChon].Value.ToString();
                txtTenSV.Text = dgQLSinhVien[1, HangChon].Value.ToString();
                txtNgaySinh.Text = dgQLSinhVien[2, HangChon].Value.ToString();
                cbGioiTinh.Text = dgQLSinhVien[3, HangChon].Value.ToString();
                txtQueQuan.Text = dgQLSinhVien[4, HangChon].Value.ToString();
                cbDoiTuong.Text = dgQLSinhVien[5, HangChon].Value.ToString();
                txtMaPhong.Text = dgQLSinhVien[6, HangChon].Value.ToString();
                txtCMTND.Text = dgQLSinhVien[7, HangChon].Value.ToString();
                txtGhiChu.Text = dgQLSinhVien[8, HangChon].Value.ToString();
            }
            txtMaSinhVien.Enabled = false;
            txtTimkiem.Text = "";
            btSua.Enabled = true;
            btXoa.Enabled = true;
            btThem.Enabled = false;
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSinhVien.Text = "";
            txtTenSV.Text = "";
            txtNgaySinh.Text = "";
            cbGioiTinh.SelectedIndex = 0;
            txtQueQuan.Text = "";
            cbDoiTuong.Text = "";
            txtMaPhong.Text = "";
            txtCMTND.Text = "";
            txtGhiChu.Text = "";
            cbTimKiem.SelectedIndex = 0;
            txtTimkiem.Text = "";
            txtMaSinhVien.Enabled = true;
            btThem.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            dgQLSinhVien.DataSource = SVBLL.Load();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtMaSinhVien.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên!", "THÔNG BÁO!", MessageBoxButtons.OK);
            }
            else
            {
                if (SVBLL.Dembanghi(txtMaSinhVien.Text) == 1)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại.Hãy chọn lại mã khác!", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaSinhVien.Text = "";
                }
                else
                {
                    if (txtTenSV.Text.Trim() == "" || txtNgaySinh.Text.Trim() == "" || cbGioiTinh.Text.Trim() == "" || txtQueQuan.Text.Trim() == "" || cbDoiTuong.Text.Trim() == "" || txtMaPhong.Text.Trim() == "" || txtCMTND.Text.Trim() == "" || txtGhiChu.Text.Trim() == "")
                    {
                        MessageBox.Show("Bạn chưa nhập đầy đủ thông tin cho sinh viên!", "THÔNG BÁO!", MessageBoxButtons.OK);
                    }
                    else
                    {

                        SVBLL.ThemSinhVien(txtMaSinhVien.Text, txtTenSV.Text, txtNgaySinh.Text, cbGioiTinh.Text, txtQueQuan.Text,cbDoiTuong.Text, txtMaPhong.Text, txtCMTND.Text, txtGhiChu.Text);
                        dgQLSinhVien.DataSource = SVBLL.Load();
                        btLamMoi_Click(sender, e);
                    }
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn sửa sinh viên này không?", "THÔNG BÁO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtTenSV.Text.Trim() == "" || txtNgaySinh.Text.Trim() == "" || cbGioiTinh.Text.Trim() == "" || txtQueQuan.Text.Trim() == "" || cbDoiTuong.Text.Trim() == "" || txtMaPhong.Text.Trim() == "" || txtCMTND.Text.Trim() == "" || txtGhiChu.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin cho sinh viên", "THÔNG BÁO", MessageBoxButtons.OK);
                }
                else
                {
                    SVBLL.SuaSinhVien(txtMaSinhVien.Text, txtTenSV.Text, txtNgaySinh.Text, cbGioiTinh.Text, txtQueQuan.Text, cbDoiTuong.Text, txtMaPhong.Text,txtCMTND.Text, txtGhiChu.Text);
                    frmQLSV_Load(sender, e);
                    btLamMoi_Click(sender, e);
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thưc sự muốn xóa sinh viên này không?", "THÔNG BÁO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SVBLL.XoaSinhVien(txtMaSinhVien.Text);
                frmQLSV_Load(sender, e);
                btLamMoi_Click(sender, e);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát không?", "THÔNG BÁO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                frmQLKTX frmktx = new frmQLKTX();
                frmktx.Show();
                this.Hide();
            }
        }

        private void btTimkiem_Click(object sender, EventArgs e)
        {
            dgQLSinhVien.DataSource = SVBLL.TimKiem(cbTimKiem.Text, txtTimkiem.Text);
        }

        private void txtTenSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar <= 33 || e.KeyChar >= 64);
        }

        private void txtCMTND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
