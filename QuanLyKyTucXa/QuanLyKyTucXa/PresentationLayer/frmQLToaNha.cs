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
    public partial class frmQLToaNha : Form
    {
        public frmQLToaNha()
        {
            InitializeComponent();
        }
        ToaNhaBLL TNBLL = new ToaNhaBLL();
        private void frmQLToaNha_Load(object sender, EventArgs e)
        {
            cbTenTN.SelectedIndex = 0;
            cbTimKiem.SelectedIndex = 0;
            dgQLToaNha.DataSource = TNBLL.Load();
            btSua.Enabled = false;
            btXoa.Enabled = false;
        }

        private void dgQLToaNha_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int HangChon = e.RowIndex;
            if (HangChon != -1)
            {
                txtMaTN.Text = dgQLToaNha[0, HangChon].Value.ToString();
                cbTenTN.Text = dgQLToaNha[1, HangChon].Value.ToString();
                txtSoPhong.Text = dgQLToaNha[2, HangChon].Value.ToString();
                txtTienPhong.Text = dgQLToaNha[3, HangChon].Value.ToString();
                txtMaNV.Text = dgQLToaNha[4, HangChon].Value.ToString();
                txtGhiChu.Text = dgQLToaNha[5, HangChon].Value.ToString();
            }
            txtMaTN.Enabled = false;
            txtTimkiem.Text = "";
            btSua.Enabled = true;
            btXoa.Enabled = true;
            btThem.Enabled = false;
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            txtMaTN.Text = "";
            cbTenTN.SelectedIndex = 0;
            txtSoPhong.Text = "";
            txtTienPhong.Text = "";
            txtMaNV.Text = "";
            txtGhiChu.Text = "";
            txtMaTN.Enabled = true;
            btThem.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            dgQLToaNha.DataSource = TNBLL.Load();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtMaTN.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mã cho tòa nhà!", "THÔNG BÁO!", MessageBoxButtons.OK);
            }
            else
            {
                if (TNBLL.Dembanghi(txtMaTN.Text) == 1)
                {
                    MessageBox.Show("Mã tòa nhà đã tồn tại.Hãy nhập lại mã khác!", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaTN.Text = "";
                }
                else
                {
                    if (cbTenTN.Text.Trim() == "" || txtSoPhong.Text.Trim() == "" || txtTienPhong.Text.Trim() == "" || txtMaNV.Text.Trim() == "" || txtGhiChu.Text.Trim() == "")
                    {
                        MessageBox.Show("Bạn chưa nhập đầy đủ thông tin của tòa nhà!", "THÔNG BÁO!", MessageBoxButtons.OK);
                    }
                    else
                    {

                        TNBLL.ThemToaNha(txtMaTN.Text, cbTenTN.Text, txtSoPhong.Text, txtTienPhong.Text, txtMaNV.Text, txtGhiChu.Text);
                        dgQLToaNha.DataSource = TNBLL.Load();
                        btLamMoi_Click(sender, e);
                    }
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn sửa tòa nhà  này không?", "THÔNG BÁO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (cbTenTN.Text.Trim() == "" || txtSoPhong.Text.Trim() == "" || txtTienPhong.Text.Trim() == "" || txtMaNV.Text.Trim() == "" || txtGhiChu.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin cho tòa nhà!", "THÔNG BÁO!", MessageBoxButtons.OK);
                }
                else
                {
                    TNBLL.SuaToaNha(txtMaTN.Text, cbTenTN.Text, txtSoPhong.Text, txtTienPhong.Text, txtMaNV.Text, txtGhiChu.Text);
                    frmQLToaNha_Load(sender, e);
                    btLamMoi_Click(sender, e);
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa tòa nhà này không?", "THÔNG BÁO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TNBLL.XoaToaNha(txtMaTN.Text);
                frmQLToaNha_Load(sender, e);
                btLamMoi_Click(sender, e);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn thoát không?", "THÔNG BÁO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                frmQLKTX frmktx = new frmQLKTX();
                frmktx.Show();
                this.Hide();
            }
        }

        private void btTimkiem_Click(object sender, EventArgs e)
        {
            dgQLToaNha.DataSource = TNBLL.TimKiem(cbTimKiem.Text, txtTimkiem.Text);
        }
    }
}
