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
    public partial class frmQLChuyenPhong : Form
    {
        public frmQLChuyenPhong()
        {
            InitializeComponent();
        }
        ChuyenPhongBLL CPBLL = new ChuyenPhongBLL();
        private void frmQLChuyenPhong_Load(object sender, EventArgs e)
        {
            cbLoaiPhong.SelectedIndex = 0;
            cbTimKiem.SelectedIndex = 0;
            dgQLChuyenPhong.DataSource = CPBLL.Load();
            btSua.Enabled = false;
            btXoa.Enabled = false;
        }

        private void dgQLChuyenPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int HangChon = e.RowIndex;
            if (HangChon != -1)
            {
                txtMaPC.Text = dgQLChuyenPhong[0, HangChon].Value.ToString();
                txtMaSV.Text = dgQLChuyenPhong[1, HangChon].Value.ToString();
                txtMaPhongCu.Text = dgQLChuyenPhong[2, HangChon].Value.ToString();
                txtMaPhongMoi.Text = dgQLChuyenPhong[3, HangChon].Value.ToString();
                cbLoaiPhong.Text = dgQLChuyenPhong[4, HangChon].Value.ToString();
                txtNgayChuyen.Text = dgQLChuyenPhong[5, HangChon].Value.ToString();
                txtMaNV.Text = dgQLChuyenPhong[6, HangChon].Value.ToString();
                txtGhiChu.Text = dgQLChuyenPhong[7, HangChon].Value.ToString();
            }
            txtMaPC.Enabled = false;
            txtTimkiem.Text = "";
            btSua.Enabled = true;
            btXoa.Enabled = true;
            btThem.Enabled = false;
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            txtMaPC.Text = "";
            txtMaSV.Text = "";
            txtMaPhongCu.Text = "";
            txtMaPhongMoi.Text = "";
            cbLoaiPhong.SelectedIndex = 0;
            txtNgayChuyen.Text = "";
            txtMaNV.Text = "";
            txtGhiChu.Text = "";
            cbTimKiem.SelectedIndex = 0;
            txtTimkiem.Text = "";
            txtMaPC.Enabled = true;
            btThem.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            dgQLChuyenPhong.DataSource = CPBLL.Load();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtMaPC.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mã phiếu chuyển!", "THÔNG BÁO!", MessageBoxButtons.OK);
            }
            else
            {
                if (CPBLL.Dembanghi(txtMaPC.Text) == 1)
                {
                    MessageBox.Show("Mã phiếu chuyển đã tồn tại.Hãy nhập lại mã khác!", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaPC.Text = "";
                }
                else
                {
                    if (txtMaSV.Text.Trim() == "" || txtMaPhongCu.Text.Trim() == "" || txtMaPhongMoi.Text.Trim() == "" || cbLoaiPhong.Text.Trim() == "" || txtNgayChuyen.Text.Trim() == "" || txtMaNV.Text.Trim() == "" || txtGhiChu.Text.Trim() == "")
                    {
                        MessageBox.Show("Bạn chưa nhập đầy đủ thông tin của phiếu chuyển!", "THÔNG BÁO!", MessageBoxButtons.OK);
                    }
                    else
                    {

                        CPBLL.ThemPhieuChuyen(txtMaPC.Text, txtMaSV.Text, txtMaPhongCu.Text, txtMaPhongMoi.Text, cbLoaiPhong.Text, txtNgayChuyen.Text,txtMaNV.Text, txtGhiChu.Text);
                        dgQLChuyenPhong.DataSource = CPBLL.Load();
                        btLamMoi_Click(sender, e);
                    }
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn sửa phiếu chuyển này không?", "THÔNG BÁO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtMaSV.Text.Trim() == "" ||txtMaPhongCu.Text.Trim() == "" || txtMaPhongMoi.Text.Trim() == "" || cbLoaiPhong.Text.Trim() == "" || txtNgayChuyen.Text.Trim() == "" || txtMaNV.Text.Trim() == "" || txtGhiChu.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin của phiếu chuyển!", "THÔNG BÁO!", MessageBoxButtons.OK);
                }
                else
                {
                    CPBLL.SuaPhieuChuyen(txtMaPC.Text, txtMaSV.Text, txtMaPhongCu.Text, txtMaPhongMoi.Text, cbLoaiPhong.Text, txtNgayChuyen.Text, txtMaNV.Text, txtGhiChu.Text);
                    frmQLChuyenPhong_Load(sender, e);
                    btLamMoi_Click(sender, e);
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa phiếu chuyển này không?", "THÔNG BÁO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CPBLL.XoaPhieuChuyen(txtMaPC.Text);
                frmQLChuyenPhong_Load(sender, e);
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
            dgQLChuyenPhong.DataSource = CPBLL.TimKiem(cbTimKiem.Text, txtTimkiem.Text);
        }
    }
}
