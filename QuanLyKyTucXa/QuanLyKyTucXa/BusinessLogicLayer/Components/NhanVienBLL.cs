using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyKiTucXa.DataAccessLayer;
using System.Data;
using QuanLyKiTucXa.BusinessLogicLayer.Entities;
using System.Windows.Forms;

namespace QuanLyKiTucXa.BusinessLogicLayer.Components
{
    class NhanVienBLL
    {
        NhanVien NV = new NhanVien();
        NhanVienDAL NVDAL = new NhanVienDAL();
        public string ThemNhanVien(string manv, string tennv,string gioitinh,string ngaysinh, string quequan, string chucvu, string sodienthoai,string ngayvaolam,string lcb,string hsl,string pc,string luong)
        {
            string gt;
            if (NVDAL.DemBanGhi(manv) == 1) gt = "1";
            else
            {
                int Pc = int.Parse(pc);
                int Lcb = int.Parse(lcb);
                double Hsl = double.Parse(hsl);
                double L = double.Parse(luong);
                L = Pc + Lcb * Hsl;
                NV = new NhanVien(manv, Chuanhoaxau(tennv), gioitinh, ngaysinh, Chuanhoaxau(quequan), chucvu, sodienthoai,ngayvaolam,Lcb,Hsl,Pc,L);
                NVDAL.Themnhanvien(NV);
                gt = "2";
            }
            return gt;
        }

        public void SuaNhanVien(string manv, string tennv, string gioitinh, string ngaysinh, string quequan, string chucvu, string sodienthoai, string ngayvaolam, string lcb, string hsl, string pc, string luong)
        {
            int Pc = int.Parse(pc);
            int Lcb = int.Parse(lcb);
            double Hsl = double.Parse(hsl);
            double L = double.Parse(luong);
            L = Pc + Lcb * Hsl;
            NV = new NhanVien(manv, Chuanhoaxau(tennv), gioitinh, ngaysinh, Chuanhoaxau(quequan), chucvu, sodienthoai, ngayvaolam, Lcb, Hsl, Pc, L);
            NVDAL.Suanhanvien(NV);
        }

        public DataTable Load()
        {
            DataTable dt = new DataTable();
            dt = NVDAL.Load();
            return dt;
        }
        public void XoaNhanVien(string MaNV)
        {
            
            NV = new NhanVien(MaNV, "", "","", "", "", "","",'0','0','0','0');
            NVDAL.Xoanhanvien(NV);
        }
        public string Chuanhoaxau(string xau)
        {
            string s = xau.Trim();
            string[] a = s.Split(' ');
            s = "";
            for (int i = 0; i < a.Length; ++i)
            {
                s = s + " " + a[i].Substring(0, 1).ToUpper() + a[i].Substring(1, a[i].Length - 1).ToLower();
            }
            return s.Trim();
        }
        public DataTable TimKiem(string chon, string tim)
        {
            DataTable dt = new DataTable();
            dt = NVDAL.TimKiem(chon, tim);
            return dt;
        }
        public int Dembanghi(string MaNV)
        {
            return NVDAL.DemBanGhi(MaNV);
        }
        public NhanVien Laynhanvientheoma(string maNV)
        {

            DataTable dt = NVDAL.LayNVTheoMa(maNV);
            NhanVien nv = new NhanVien();
            nv.Manhanvien = dt.Rows[0][0].ToString();
            nv.Tennhanvien = dt.Rows[0][1].ToString();
            nv.Gioitinh = dt.Rows[0][2].ToString();
            nv.Ngaysinh = dt.Rows[0][3].ToString();
            nv.Quequan = dt.Rows[0][4].ToString();
            nv.Chuvu = dt.Rows[0][5].ToString();
            nv.Sodienthoai = dt.Rows[0][6].ToString();
            nv.Ngayvaolam = dt.Rows[0][7].ToString();
            nv.Luongcoban = int.Parse(dt.Rows[0][8].ToString());
            nv.Hesoluong = double.Parse(dt.Rows[0][9].ToString());
            nv.Hesophucap = int.Parse(dt.Rows[0][10].ToString());
            nv.luong = double.Parse(dt.Rows[0][11].ToString());
            return nv;
        }
    }
}
