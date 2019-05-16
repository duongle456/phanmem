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
    public partial class frmQLDienNuoc : Form
    {
        public frmQLDienNuoc()
        {
            InitializeComponent();
        }
        DienNuocBLL DNBLL = new DienNuocBLL();
        private void frmQLDienNuoc_Load(object sender, EventArgs e)
        {
            cbTimKiem.SelectedIndex = 0;
            dgQLDienNuoc.DataSource = DNBLL.Load();
            btSua.Enabled = false;
            btXoa.Enabled = false;
        }

        private void dgQLDienNuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int HangChon = e.RowIndex;
            if (HangChon != -1)
            {
                txtMaPTDN.Text = dgQLDienNuoc[0, HangChon].Value.ToString();
                txtMaPhong.Text = dgQLDienNuoc[1, HangChon].Value.ToString();
                txtSoDienThangTruoc.Text = dgQLDienNuoc[2, HangChon].Value.ToString();
                txtSoNuocThangTruoc.Text = dgQLDienNuoc[3, HangChon].Value.ToString();
                txtSoDien.Text = dgQLDienNuoc[4, HangChon].Value.ToString();
                txtSoNuoc.Text = dgQLDienNuoc[5, HangChon].Value.ToString();
                txtDonGiaDien.Text = dgQLDienNuoc[6, HangChon].Value.ToString();
                txtDonGiaNuoc.Text = dgQLDienNuoc[7, HangChon].Value.ToString();
                txtThanhTienDien.Text = dgQLDienNuoc[8, HangChon].Value.ToString();
                txtThanhTienNuoc.Text = dgQLDienNuoc[9, HangChon].Value.ToString();
                txtThangThu.Text = dgQLDienNuoc[10, HangChon].Value.ToString();
                txtMaSV.Text = dgQLDienNuoc[11, HangChon].Value.ToString();
                txtMaNV.Text = dgQLDienNuoc[12, HangChon].Value.ToString();
                txtGhiChu.Text = dgQLDienNuoc[13, HangChon].Value.ToString();
            }
            txtMaPTDN.Enabled = false;
            txtTimkiem.Text = "";
            btSua.Enabled = true;
            btXoa.Enabled = true;
            btThem.Enabled = false;
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {

            txtMaPTDN.Text = "";
            txtMaPhong.Text = "";
            txtSoDienThangTruoc.Text = "";
            txtSoNuocThangTruoc.Text = "";
            txtSoDien.Text = "";
            txtSoNuoc.Text = "";
            txtDonGiaDien.Text = "";
            txtDonGiaNuoc.Text = "";
            txtThanhTienDien.Text = "";
            txtThanhTienNuoc.Text = "";
            txtThangThu.Text = "";
            txtMaSV.Text = "";
            txtMaNV.Text = "";
            txtGhiChu.Enabled = true;
            btThem.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            dgQLDienNuoc.DataSource = DNBLL.Load();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtMaPTDN.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mã điện nước", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else
            {
                if (DNBLL.Dembanghi(txtMaPTDN.Text) == 1)
                {
                    MessageBox.Show("Mã điện nước đã tồn tại!Hãy chọn lại mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaPTDN.Text = "";
                }
                else
                {
                    if (txtMaPhong.Text.Trim() == "" || txtSoDienThangTruoc.Text.Trim() == "" || txtSoNuocThangTruoc.Text.Trim() == "" || txtSoDien.Text.Trim() == "" || txtSoNuoc.Text.Trim() == "" || txtDonGiaDien.Text.Trim() == "" || txtDonGiaNuoc.Text.Trim() == "" || txtThanhTienDien.Text.Trim() == "" || txtThanhTienNuoc.Text.Trim() == "" || txtThangThu.Text.Trim() == "" || txtMaSV.Text.Trim() == "" || txtMaNV.Text.Trim() == "" || txtGhiChu.Text.Trim() == "")
                    {
                        MessageBox.Show("Bạn chưa nhập đầy đủ thông tin cho điện nước", "THÔNG BÁO", MessageBoxButtons.OK);
                    }
                    else
                    {

                        DNBLL.ThemDienNuoc(txtMaPTDN.Text, txtMaPhong.Text, txtSoDienThangTruoc.Text,txtSoNuocThangTruoc.Text,txtSoDien.Text,txtSoNuoc.Text,txtDonGiaDien.Text,txtDonGiaNuoc.Text,txtThanhTienDien.Text,txtThanhTienNuoc.Text, txtThangThu.Text, txtMaSV.Text, txtMaNV.Text, txtGhiChu.Text);
                        dgQLDienNuoc.DataSource = DNBLL.Load();
                        btLamMoi_Click(sender, e);
                    }
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn sửa điện nước này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtMaPhong.Text.Trim() == "" || txtSoDienThangTruoc.Text == "" || txtSoNuocThangTruoc.Text.Trim() == "" || txtDonGiaDien.Text.Trim() == "" || txtSoDien.Text.Trim() == "" || txtSoNuoc.Text.Trim() == "" || txtDonGiaDien.Text.Trim() == "" || txtDonGiaNuoc.Text.Trim() == "" || txtThanhTienDien.Text.Trim() == "" || txtThanhTienNuoc.Text.Trim() == "" || txtThangThu.Text.Trim() == "" || txtMaSV.Text.Trim() == "" || txtMaNV.Text.Trim() == "" || txtGhiChu.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin cho điện nước", "THÔNG BÁO", MessageBoxButtons.OK);
                }
                else
                {
                    DNBLL.SuaDienNuoc(txtMaPTDN.Text, txtMaPhong.Text, txtSoDienThangTruoc.Text,txtSoNuocThangTruoc.Text, txtSoDien.Text,txtSoNuoc.Text,txtDonGiaDien.Text,txtDonGiaNuoc.Text,txtThanhTienDien.Text,txtThanhTienNuoc.Text, txtThangThu.Text, txtMaSV.Text, txtMaNV.Text, txtGhiChu.Text);
                    frmQLDienNuoc_Load(sender, e);
                    btLamMoi_Click(sender, e);
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thưc sự muốn xóa điện nước này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DNBLL.XoaDienNuoc(txtMaPTDN.Text);
                frmQLDienNuoc_Load(sender, e);
                btLamMoi_Click(sender, e);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                frmQLKTX frmktx = new frmQLKTX();
                frmktx.Show();
                this.Hide();
            }
        }

        private void btTimkiem_Click(object sender, EventArgs e)
        {
            dgQLDienNuoc.DataSource = DNBLL.TimKiem(cbTimKiem.Text, txtTimkiem.Text);
        }
        //Tính tiền điện
        private void btTinhTienDien_MouseClick(object sender, MouseEventArgs e)
        {
            float sdt = float.Parse(txtSoDienThangTruoc.Text);
            float sd = float.Parse(txtSoDien.Text);
            float dgd = float.Parse(txtDonGiaDien.Text);
            float td = (sd - sdt) * dgd;
            txtThanhTienDien.Text = td.ToString();
        }
        //Tính tiền nước
        private void btTinhTienNuoc_MouseClick(object sender, MouseEventArgs e)
        {
            float snt = float.Parse(txtSoNuocThangTruoc.Text);
            float sn = float.Parse(txtSoNuoc.Text);
            float dgn = float.Parse(txtDonGiaNuoc.Text);
            float tn = (sn - snt) * dgn;
            txtThanhTienNuoc.Text = tn.ToString();
        }
    }
}
