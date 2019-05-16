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

namespace QuanLyKiTucXa.PresentationLayer
{
    public partial class frmQLTaiSan : Form
    {
        public frmQLTaiSan()
        {
            InitializeComponent();
        }
        TaiSanBLL TSBLL = new TaiSanBLL();
        private void frmQLTaiSan_Load(object sender, EventArgs e)
        {
            cbTenTS.SelectedIndex = 0;
            cbTimKiem.SelectedIndex = 0;
            dgQLTaiSan.DataSource = TSBLL.Load();
            btSua.Enabled = false;
            btXoa.Enabled = false;
        }

        private void dgQLTaiSan_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int HangChon = e.RowIndex;
            if (HangChon != -1)
            {
                txtMaTS.Text = dgQLTaiSan[0, HangChon].Value.ToString();
                cbTenTS.Text = dgQLTaiSan[1, HangChon].Value.ToString();
                txtMaPhong.Text = dgQLTaiSan[2, HangChon].Value.ToString();
                txtSoLuong.Text = dgQLTaiSan[3, HangChon].Value.ToString();
                txtMaNV.Text = dgQLTaiSan[4, HangChon].Value.ToString();
                txtHienTrang.Text = dgQLTaiSan[5, HangChon].Value.ToString();
            }
            txtMaTS.Enabled = false;
            txtTimkiem.Text = "";
            btSua.Enabled = true;
            btXoa.Enabled = true;
            btThem.Enabled = false;
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            txtMaTS.Text = "";
            cbTenTS.SelectedIndex = 0;
            txtMaPhong.Text = "";
            txtSoLuong.Text = "";
            txtMaNV.Text = "";
            txtHienTrang.Text = "";
            txtMaTS.Enabled = true;
            btThem.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            dgQLTaiSan.DataSource = TSBLL.Load();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtMaTS.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mã cho tài sản!", "THÔNG BÁO!", MessageBoxButtons.OK);
            }
            else
            {
                if (TSBLL.Dembanghi(txtMaTS.Text) == 1)
                {
                    MessageBox.Show("Mã tài sản đã tồn tại.Hãy nhập lại mã khác!", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaTS.Text = "";
                }
                else
                {
                    if (cbTenTS.Text.Trim() == "" || txtMaPhong.Text.Trim() == "" || txtSoLuong.Text.Trim() == "" || txtMaNV.Text.Trim() == "" || txtHienTrang.Text.Trim() == "")
                    {
                        MessageBox.Show("Bạn chưa nhập đầy đủ thông tin của tài sản!", "THÔNG BÁO!", MessageBoxButtons.OK);
                    }
                    else
                    {

                        TSBLL.ThemTaiSan(txtMaTS.Text, cbTenTS.Text, txtMaPhong.Text, txtSoLuong.Text, txtMaNV.Text, txtHienTrang.Text);
                        dgQLTaiSan.DataSource = TSBLL.Load();
                        btLamMoi_Click(sender, e);
                    }
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn sửa tài sản này không?", "THÔNG BÁO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (cbTenTS.Text.Trim() == "" || txtMaPhong.Text.Trim() == "" || txtSoLuong.Text.Trim() == "" || txtMaNV.Text.Trim() == "" || txtHienTrang.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin cho tài sản!", "THÔNG BÁO!", MessageBoxButtons.OK);
                }
                else
                {
                    TSBLL.SuaTaiSan(txtMaTS.Text, cbTenTS.Text, txtMaPhong.Text, txtSoLuong.Text, txtMaNV.Text, txtHienTrang.Text);
                    frmQLTaiSan_Load(sender, e);
                    btLamMoi_Click(sender, e);
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có thực sự muốn xóa tài sản này không?", "THÔNG BÁO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TSBLL.XoaTaiSan(txtMaTS.Text);
                frmQLTaiSan_Load(sender, e);
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
            dgQLTaiSan.DataSource = TSBLL.TimKiem(cbTimKiem.Text, txtTimkiem.Text);
        }
    }
}
