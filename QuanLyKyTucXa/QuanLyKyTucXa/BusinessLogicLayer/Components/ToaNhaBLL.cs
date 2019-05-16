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
    class ToaNhaBLL
    {
        ToaNha TN = new ToaNha();
        ToaNhaDAL TNDAL = new ToaNhaDAL();
        public void ThemToaNha(string matn, string tentn, string sophong, string tienphong, string manv, string ghichu)
        {
            TN = new ToaNha(matn, Chuanhoaxau(tentn), sophong, tienphong, manv, Chuanhoaxau(ghichu));
            TNDAL.Themtoanha(TN);
        }

        public void SuaToaNha(string matn, string tentn, string sophong, string tienphong, string manv, string ghichu)
        {

            TN = new ToaNha(matn, Chuanhoaxau(tentn), sophong, tienphong, manv, Chuanhoaxau(ghichu));
            TNDAL.Suatoanha(TN);
        }

        public DataTable Load()
        {
            DataTable dt = new DataTable();
            dt = TNDAL.Load();
            return dt;
        }
        public void XoaToaNha(string MaTN)
        {

            TN = new ToaNha(MaTN, "", "", "", "", "");
            TNDAL.Xoatoanha(TN);
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
            dt = TNDAL.TimKiem(chon, tim);
            return dt;
        }
        public int Dembanghi(string MaTS)
        {
            return TNDAL.DemBanGhi(MaTS);
        }
        public ToaNha Laytoanhatheoma(string maTN)
        {

            DataTable dt = TNDAL.LayTNTheoMa(maTN);
            ToaNha tn = new ToaNha();
            tn.Mantoanha = dt.Rows[0][0].ToString();
            tn.Tentoanha = dt.Rows[0][1].ToString();
            tn.Sophong = dt.Rows[0][2].ToString();
            tn.Tienphong = dt.Rows[0][3].ToString();
            tn.Manhanvien = dt.Rows[0][4].ToString();
            tn.Ghichu = dt.Rows[0][5].ToString();
            return tn;
        }
    }
}
