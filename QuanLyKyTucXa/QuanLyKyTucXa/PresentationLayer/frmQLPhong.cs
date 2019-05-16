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
    public partial class frmQLPhong : Form
    {
        public frmQLPhong()
        {
            InitializeComponent();
        }
        PhongBLL PHBLL = new PhongBLL();
        private void frmQLPhong_Load(object sender, EventArgs e)
        {
            cbMaToaNha.SelectedIndex = 0;
            cbLoaiPhong.SelectedIndex = 0;
            cbTimKiem.SelectedIndex = 0;
            dgQLPhong.DataSource = PHBLL.Load();
            btSua.Enabled = false;
            btXoa.Enabled = false;
        }
        private void dgQLPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int HangChon = e.RowIndex;
            if (HangChon != -1)
            {
                txtMaPhong.Text = dgQLPhong[0, HangChon].Value.ToString();
                txtTenPhong.Text = dgQLPhong[1, HangChon].Value.ToString();
                cbMaToaNha.Text = dgQLPhong[2, HangChon].Value.ToString();
                cbLoaiPhong.Text = dgQLPhong[3, HangChon].Value.ToString();
                txtSoLuongNguoi.Text = dgQLPhong[4, HangChon].Value.ToString();
                txtTinhTrang.Text = dgQLPhong[5, HangChon].Value.ToString();
            }
            txtMaPhong.Enabled = false;
            txtTimkiem.Text = "";
            btSua.Enabled = true;
            btXoa.Enabled = true;
            btThem.Enabled = false;
        }
        private void btLamMoi_Click(object sender, EventArgs e)
        {
            txtMaPhong.Text = "";
            txtTenPhong.Text = "";
            cbMaToaNha.SelectedIndex = 0;
            cbLoaiPhong.Text = "";
            txtSoLuongNguoi.Text = "";
            txtTinhTrang.Text = "";
            cbTimKiem.SelectedIndex = 0;
            txtTimkiem.Text = "";
            txtMaPhong.Enabled = true;
            btThem.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            dgQLPhong.DataSource = PHBLL.Load();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mã phòng!", "THÔNG BÁO!", MessageBoxButtons.OK);
            }
            else
            {
                if (PHBLL.Dembanghi(txtMaPhong.Text) == 1)
                {
                    MessageBox.Show("Mã phòng đã tồn tại.Hãy nhập lại mã khác!", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaPhong.Text = "";
                }
                else
                {
                    if (txtTenPhong.Text.Trim() == "" || cbMaToaNha.Text.Trim() == "" || cbLoaiPhong.Text.Trim() == "" || txtSoLuongNguoi.Text.Trim() == "" || txtTinhTrang.Text.Trim() == "")
                    {
                        MessageBox.Show("Bạn chưa nhập đầy đủ thông tin cho phòng!", "THÔNG BÁO!", MessageBoxButtons.OK);
                    }
                    else
                    {

                        PHBLL.ThemPhong(txtMaPhong.Text, txtTenPhong.Text, cbMaToaNha.Text, cbLoaiPhong.Text, txtSoLuongNguoi.Text, txtTinhTrang.Text);
                        dgQLPhong.DataSource = PHBLL.Load();
                        btLamMoi_Click(sender, e);
                    }
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa phòng này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtTenPhong.Text.Trim() == "" || cbMaToaNha.Text.Trim() == "" || cbLoaiPhong.Text.Trim() == "" || txtSoLuongNguoi.Text.Trim() == "" || txtTinhTrang.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin cho phòng!", "THÔNG BÁO!", MessageBoxButtons.OK);
                }
                else
                {
                    PHBLL.SuaPhong(txtMaPhong.Text, txtTenPhong.Text, cbMaToaNha.Text, cbLoaiPhong.Text, txtSoLuongNguoi.Text, txtTinhTrang.Text);
                    frmQLPhong_Load(sender, e);
                    btLamMoi_Click(sender, e);
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa phòng này?", "THÔNG BÁO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PHBLL.XoaPhong(txtMaPhong.Text);
                frmQLPhong_Load(sender, e);
                btLamMoi_Click(sender, e);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát không?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                frmQLKTX frmktx = new frmQLKTX();
                frmktx.Show();
                this.Hide();
            }
        }

        private void btTimkiem_Click(object sender, EventArgs e)
        {
            dgQLPhong.DataSource = PHBLL.TimKiem(cbTimKiem.Text, txtTimkiem.Text);
        }

        private void txtSoLuongNguoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
