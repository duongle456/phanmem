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
    public partial class frmQLKhenThuongKyLuat : Form
    {
        public frmQLKhenThuongKyLuat()
        {
            InitializeComponent();
        }
        KhenThuongKyLuatBLL KTBLL = new KhenThuongKyLuatBLL();
        private void frmQLKhenThuongKyLuat_Load(object sender, EventArgs e)
        {
            cbTenPhieu.SelectedIndex = 0;
            cbTimKiem.SelectedIndex = 0;
            dgQLKTKL.DataSource = KTBLL.Load();
            btSua.Enabled = false;
            btXoa.Enabled = false;
        }

        private void dgQLKTKL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int HangChon = e.RowIndex;
            if (HangChon != -1)
            {
                txtMaPH.Text = dgQLKTKL[0, HangChon].Value.ToString();
                cbTenPhieu.Text = dgQLKTKL[1, HangChon].Value.ToString();
                txtMaSV.Text = dgQLKTKL[2, HangChon].Value.ToString();
                txtNoiDung.Text = dgQLKTKL[3, HangChon].Value.ToString();
                txtHinhThuc.Text = dgQLKTKL[4, HangChon].Value.ToString();
                txtNgayLap.Text = dgQLKTKL[5, HangChon].Value.ToString();
                txtMaNV.Text = dgQLKTKL[6, HangChon].Value.ToString();
                txtGhiChu.Text = dgQLKTKL[7, HangChon].Value.ToString();
            }
            txtMaPH.Enabled = false;
            txtTimkiem.Text = "";
            btSua.Enabled = true;
            btXoa.Enabled = true;
            btThem.Enabled = false;
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            txtMaPH.Text = "";
            cbTenPhieu.SelectedIndex = 0;
            txtMaSV.Text = "";
            txtNoiDung.Text = "";
            txtHinhThuc.Text = "";
            txtNgayLap.Text = "";
            txtMaNV.Text = "";
            txtGhiChu.Text = "";
            txtMaPH.Enabled = true;
            btThem.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            dgQLKTKL.DataSource = KTBLL.Load();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtMaPH.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mã khen thưởng kỷ luật!", "THÔNG BÁO!", MessageBoxButtons.OK);
            }
            else
            {
                if (KTBLL.Dembanghi(txtMaPH.Text) == 1)
                {
                    MessageBox.Show("Mã phiếu thu đã tồn tại.Hãy nhập lại mã khác!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaPH.Text = "";
                }
                else
                {
                    if (cbTenPhieu.Text.Trim() == "" || txtMaSV.Text.Trim() == "" || txtNoiDung.Text.Trim() == "" || txtHinhThuc.Text.Trim() == "" || txtNgayLap.Text.Trim() == "" || txtMaNV.Text.Trim() == "" || txtGhiChu.Text.Trim() == "")
                    {
                        MessageBox.Show("Bạn chưa nhập đầy đủ thông tin cho phiếu khen thưởng kỷ luật!", "THÔNG BÁO!", MessageBoxButtons.OK);
                    }
                    else
                    {

                        KTBLL.ThemKTKL(txtMaPH.Text, cbTenPhieu.Text, txtMaSV.Text, txtNoiDung.Text, txtHinhThuc.Text, txtNgayLap.Text, txtMaNV.Text, txtGhiChu.Text);
                        dgQLKTKL.DataSource = KTBLL.Load();
                        btLamMoi_Click(sender, e);
                    }
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn sửa phiếu khen thưởng kỷ luật này không?", "THÔNG BÁO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (cbTenPhieu.Text.Trim() == "" || txtMaSV.Text.Trim() == "" || txtNoiDung.Text.Trim() == "" || txtHinhThuc.Text.Trim() == "" || txtNgayLap.Text.Trim() == "" || txtMaNV.Text.Trim() == "" || txtGhiChu.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin cho phiếu!", "THÔNG BÁO", MessageBoxButtons.OK);
                }
                else
                {
                    KTBLL.SuaKTKL(txtMaPH.Text, cbTenPhieu.Text, txtMaSV.Text, txtNoiDung.Text, txtHinhThuc.Text,txtNgayLap.Text, txtMaNV.Text, txtGhiChu.Text);
                    frmQLKhenThuongKyLuat_Load(sender, e);
                    btLamMoi_Click(sender, e);
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa phiếu này không?", "THÔNG BÁO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                KTBLL.XoaKTKL(txtMaPH.Text);
                frmQLKhenThuongKyLuat_Load(sender, e);
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
            dgQLKTKL.DataSource = KTBLL.TimKiem(cbTimKiem.Text, txtTimkiem.Text);
        }
    }
}
