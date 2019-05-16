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
    public partial class frmQLHDSinhVien_Phong : Form
    {
        public frmQLHDSinhVien_Phong()
        {
            InitializeComponent();
        }
        HDSinhVienPhongBLL HDBLL = new HDSinhVienPhongBLL();
        private void frmQLHDSinhVien_Phong_Load(object sender, EventArgs e)
        {
            cbMaNV.SelectedIndex = 0;
            cbTimKiem.SelectedIndex = 0;
            dgQLHDSinhVienPhong.DataSource = HDBLL.Load();
            btSua.Enabled = false;
            btXoa.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int HangChon = e.RowIndex;
            if (HangChon != -1)
            {
                txtMaHD.Text = dgQLHDSinhVienPhong[0, HangChon].Value.ToString();
                txtMaSV.Text = dgQLHDSinhVienPhong[1, HangChon].Value.ToString();
                txtMaPhong.Text = dgQLHDSinhVienPhong[2, HangChon].Value.ToString();
                txtNgayVao.Text = dgQLHDSinhVienPhong[3, HangChon].Value.ToString();
                txtNgayRa.Text = dgQLHDSinhVienPhong[4, HangChon].Value.ToString();
                txtNgayLap.Text = dgQLHDSinhVienPhong[5, HangChon].Value.ToString();
                cbMaNV.Text = dgQLHDSinhVienPhong[6, HangChon].Value.ToString();
                txtGhiChu.Text = dgQLHDSinhVienPhong[7, HangChon].Value.ToString();
            }
            txtMaHD.Enabled = false;
            txtTimkiem.Text = "";
            btSua.Enabled = true;
            btXoa.Enabled = true;
            btThem.Enabled = false;
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = "";
            txtMaSV.Text = "";
            txtMaPhong.Text = "";
            txtNgayVao.Text = "";
            txtNgayRa.Text = "";
            txtNgayLap.Text = "";
            cbMaNV.SelectedIndex = 0;
            txtTimkiem.Text = "";
            txtMaHD.Enabled = true;
            btThem.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            dgQLHDSinhVienPhong.DataSource = HDBLL.Load();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mã cho hợp đồng!", "THÔNG BÁO!", MessageBoxButtons.OK);
            }
            else
            {
                if (HDBLL.Dembanghi(txtMaHD.Text) == 1)
                {
                    MessageBox.Show("Mã hợp đồng đã tồn tại.Hãy chọn lại mã khác!", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaHD.Text = "";
                }
                else
                {
                    if (txtMaHD.Text.Trim() == "" || txtMaSV.Text.Trim() == "" || txtMaPhong.Text.Trim() == "" || txtNgayVao.Text.Trim() == "" || txtNgayRa.Text.Trim() == "" || txtNgayLap.Text.Trim() == "" || cbMaNV.Text.Trim() == "" || txtGhiChu.Text.Trim() == "")
                    {
                        MessageBox.Show("Bạn chưa nhập đầy đủ thông tin cho hợp đồng!", "THÔNG BÁO!", MessageBoxButtons.OK);
                    }
                    else
                    {

                        HDBLL.ThemHopDong(txtMaHD.Text, txtMaSV.Text, txtMaPhong.Text, txtNgayVao.Text, txtNgayRa.Text, txtNgayLap.Text, cbMaNV.Text,txtGhiChu.Text);
                        dgQLHDSinhVienPhong.DataSource = HDBLL.Load();
                        btLamMoi_Click(sender, e);
                    }
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn sửa hợp đồng này không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtMaSV.Text.Trim() == "" || txtMaPhong.Text.Trim() == "" || txtNgayVao.Text.Trim() == "" || txtNgayRa.Text.Trim() == "" || txtNgayLap.Text.Trim() == "" || cbMaNV.Text.Trim() == "" || txtGhiChu.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin cho hợp đồng!", "THÔNG BÁO!", MessageBoxButtons.OK);
                }
                else
                {
                    HDBLL.SuaHopDong(txtMaHD.Text, txtMaSV.Text, txtMaPhong.Text, txtNgayVao.Text, txtNgayRa.Text, txtNgayLap.Text, cbMaNV.Text,txtGhiChu.Text);
                    frmQLHDSinhVien_Phong_Load(sender, e);
                    btLamMoi_Click(sender, e);
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa hợp đồng này không?", "THÔNG BÁO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                HDBLL.XoaHopDong(txtMaHD.Text);
                frmQLHDSinhVien_Phong_Load(sender, e);
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
            dgQLHDSinhVienPhong.DataSource = HDBLL.TimKiem(cbTimKiem.Text, txtTimkiem.Text);
        }
    }
}
