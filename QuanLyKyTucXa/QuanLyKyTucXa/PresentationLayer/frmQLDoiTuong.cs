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
    public partial class frmQLDoiTuong : Form
    {
        public frmQLDoiTuong()
        {
            InitializeComponent();
        }
        DoiTuongBLL DTBLL = new DoiTuongBLL();
        private void frmQLDoiTuong_Load(object sender, EventArgs e)
        {
            cbTenDT.SelectedIndex = 0;
            cbTimKiem.SelectedIndex = 0;
            dgQLDoiTuong.DataSource = DTBLL.Load();
            btSua.Enabled = false;
            btXoa.Enabled = false;
        }

        private void dgQLDoiTuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int HangChon = e.RowIndex;
            if (HangChon != -1)
            {
                txtMaDT.Text = dgQLDoiTuong[0, HangChon].Value.ToString();
                cbTenDT.Text = dgQLDoiTuong[1, HangChon].Value.ToString();
                txtMaNV.Text = dgQLDoiTuong[2, HangChon].Value.ToString();
                txtGhiChu.Text = dgQLDoiTuong[3, HangChon].Value.ToString();
            }
            txtMaDT.Enabled = false;
            txtTimkiem.Text = "";
            btSua.Enabled = true;
            btXoa.Enabled = true;
            btThem.Enabled = false;
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            txtMaDT.Text = "";
            cbTenDT.SelectedIndex = 0;
            txtMaNV.Text = "";
            txtGhiChu.Text = "";
            txtMaDT.Enabled = true;
            btThem.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            dgQLDoiTuong.DataSource = DTBLL.Load();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtMaDT.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập vào mã đối tượng!", "THÔNG BÁO!", MessageBoxButtons.OK);
            }
            else
            {
                if (DTBLL.Dembanghi(txtMaDT.Text) == 1)
                {
                    MessageBox.Show("Mã đối tượng đã tồn tại.Hãy nhập lại mã khác!", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaDT.Text = "";
                }
                else
                {
                    if (cbTenDT.Text.Trim() == "" || txtMaNV.Text.Trim() == "" || txtGhiChu.Text.Trim() == "" )
                    {
                        MessageBox.Show("Bạn chưa nhập đầy đủ thông tin của đối tượng!", "THÔNG BÁO!", MessageBoxButtons.OK);
                    }
                    else
                    {

                        DTBLL.ThemDoiTuong(txtMaDT.Text, cbTenDT.Text, txtMaNV.Text, txtGhiChu.Text);
                        dgQLDoiTuong.DataSource = DTBLL.Load();
                        btLamMoi_Click(sender, e);
                    }
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn sửa đối tượng này không?", "THÔNG BÁO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (cbTenDT.Text.Trim() == "" || txtMaNV.Text.Trim() == "" || txtGhiChu.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin của đối tượng!", "THÔNG BÁO!", MessageBoxButtons.OK);
                }
                else
                {
                    DTBLL.SuaDoiTuong(txtMaDT.Text, cbTenDT.Text, txtMaNV.Text, txtGhiChu.Text);
                    frmQLDoiTuong_Load(sender, e);
                    btLamMoi_Click(sender, e);
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa đối tượng này không?", "THÔNG BÁO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DTBLL.XoaDoiTuong(txtMaDT.Text);
                frmQLDoiTuong_Load(sender, e);
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
            dgQLDoiTuong.DataSource = DTBLL.TimKiem(cbTimKiem.Text, txtTimkiem.Text);
        }
    }
}
