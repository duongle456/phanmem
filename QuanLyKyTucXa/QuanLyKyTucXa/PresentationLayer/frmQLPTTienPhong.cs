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
    public partial class frmQLPTTienPhong : Form
    {
        public frmQLPTTienPhong()
        {
            InitializeComponent();
        }
        PTTienPhongBLL PTBLL = new PTTienPhongBLL();
        private void frmQLPTTienPhong_Load(object sender, EventArgs e)
        {
            
            cbTimKiem.SelectedIndex = 0;
            dgQLPTTienPhong.DataSource = PTBLL.Load();
            btSua.Enabled = false;
            btXoa.Enabled = false;
        }

        private void dgQLPTTienPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int HangChon = e.RowIndex;
            if (HangChon != -1)
            {
                txtMaPT.Text = dgQLPTTienPhong[0, HangChon].Value.ToString();
                txtMaPhong.Text = dgQLPTTienPhong[1, HangChon].Value.ToString();
                txtTienPhong.Text = dgQLPTTienPhong[2, HangChon].Value.ToString();
                txtThangThu.Text = dgQLPTTienPhong[3, HangChon].Value.ToString();
                txtMaSV.Text = dgQLPTTienPhong[4, HangChon].Value.ToString();
                txtMaNV.Text = dgQLPTTienPhong[5, HangChon].Value.ToString();
                txtGhiChu.Text = dgQLPTTienPhong[6, HangChon].Value.ToString();
            }
            txtMaPT.Enabled = false;
            txtTimkiem.Text = "";
            btSua.Enabled = true;
            btXoa.Enabled = true;
            btThem.Enabled = false;
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            txtMaPT.Text = "";
            txtMaPhong.Text = "";
            txtTienPhong.Text="";
            txtThangThu.Text = "";
            txtMaSV.Text = "";
            txtMaNV.Text = "";
            txtGhiChu.Text = "";
            txtMaPT.Enabled = true;
            btThem.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            dgQLPTTienPhong.DataSource = PTBLL.Load();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtMaPT.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mã phiếu thu!", "THÔNG BÁO!", MessageBoxButtons.OK);
            }
            else
            {
                if (PTBLL.Dembanghi(txtMaPT.Text) == 1)
                {
                    MessageBox.Show("Mã phiếu thu đã tồn tại.Hãy nhập lại mã khác!", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaPT.Text = "";
                }
                else
                {
                    if (txtMaPhong.Text.Trim() == "" || txtTienPhong.Text.Trim() == "" || txtThangThu.Text.Trim() == "" || txtMaSV.Text.Trim() == "" || txtMaNV.Text.Trim() ==""|| txtGhiChu.Text.Trim() == "")
                    {
                        MessageBox.Show("Bạn chưa nhập đầy đủ thông tin cho phiếu thu!", "THÔNG BÁO!", MessageBoxButtons.OK);
                    }
                    else
                    {

                        PTBLL.ThemPhieuThu(txtMaPT.Text, txtMaPhong.Text, txtTienPhong.Text, txtThangThu.Text, txtMaSV.Text, txtMaNV.Text,txtGhiChu.Text);
                        dgQLPTTienPhong.DataSource = PTBLL.Load();
                        btLamMoi_Click(sender, e);
                    }
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn sửa phiếu thu này không?", "THÔNG BÁO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtMaPhong.Text.Trim() == "" || txtTienPhong.Text.Trim() == "" || txtThangThu.Text.Trim() == "" || txtMaSV.Text.Trim() == "" || txtMaNV.Text.Trim() == "" || txtGhiChu.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin cho phiếu thu!", "THÔNG BÁO!", MessageBoxButtons.OK);
                }
                else
                {
                    PTBLL.SuaPhieuThu(txtMaPT.Text, txtMaPhong.Text, txtTienPhong.Text, txtThangThu.Text, txtMaSV.Text, txtMaNV.Text,txtGhiChu.Text);
                    frmQLPTTienPhong_Load(sender, e);
                    btLamMoi_Click(sender, e);
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn xóa phiếu thu này không?", "THÔNG BÁO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PTBLL.XoaPhieuThu(txtMaPT.Text);
                frmQLPTTienPhong_Load(sender, e);
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
            dgQLPTTienPhong.DataSource = PTBLL.TimKiem(cbTimKiem.Text, txtTimkiem.Text);
        }
    }
}
