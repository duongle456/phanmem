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
    class SinhVienBLL
    {
        SinhVien SV = new SinhVien();
        SinhVienDAL SVDAL = new SinhVienDAL();
        public string ThemSinhVien(string masv, string tensv,string ngaysinh,string gioitinh, string quequan, string madoituong, string maphong, string socmtnd, string ghichu)
        {
            string gt;
            if (SVDAL.DemBanGhi(masv) == 1) gt = "1";
            else
            {

                SV = new SinhVien(masv, Chuanhoaxau(tensv), ngaysinh, gioitinh, Chuanhoaxau(quequan), madoituong, maphong, socmtnd, Chuanhoaxau(ghichu));
                SVDAL.Themsinhvien(SV);
                gt = "2";
            }
            return gt;
        }

        public void SuaSinhVien(string masv, string tensv,string ngaysinh,string gioitinh, string quequan, string madoituong, string maphong, string socmtnd, string ghichu)
        {

            SV = new SinhVien(masv, Chuanhoaxau(tensv), ngaysinh, Chuanhoaxau(gioitinh), Chuanhoaxau(quequan), madoituong, maphong, socmtnd,Chuanhoaxau( ghichu));
            SVDAL.Suasinhvien(SV);
        }

        public DataTable Load()
        {
            DataTable dt = new DataTable();
            dt = SVDAL.Load();
            return dt;
        }
        public void XoaSinhVien(string MaSV)
        {
            
            SV = new SinhVien(MaSV, "", "","", "", "", "","","");
            SVDAL.Xoasinhvien(SV);
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
            dt = SVDAL.TimKiem(chon, tim);
            return dt;
        }
        public int Dembanghi(string MaSV)
        {
            return SVDAL.DemBanGhi(MaSV);
        }
        public SinhVien Laysinhvientheoma(string maSV)
        {

            DataTable dt = SVDAL.LaySVTheoMa(maSV);
            SinhVien sv = new SinhVien();
            sv.Masinhvien = dt.Rows[0][0].ToString();
            sv.Tensinhvien = dt.Rows[0][1].ToString();
            sv.Ngaysinh = dt.Rows[0][2].ToString();
            sv.Gioitinh = dt.Rows[0][3].ToString();
            sv.Quequan = dt.Rows[0][4].ToString();
            sv.Madoituong = dt.Rows[0][5].ToString();
            sv.Maphong = dt.Rows[0][6].ToString();
            sv.Socmtnd = dt.Rows[0][7].ToString();
            sv.Ghichu = dt.Rows[0][8].ToString();
            return sv;
        }
    }
 }

