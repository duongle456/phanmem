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
    class DoiTuongBLL
    {
        DoiTuong DT = new DoiTuong();
        DoiTuongDAL DTDAL = new DoiTuongDAL();
        public void ThemDoiTuong(string madt, string tendt,string manv, string ghichu)
        {
                DT = new DoiTuong(madt, Chuanhoaxau(tendt),manv,Chuanhoaxau(ghichu));
                DTDAL.Themdoituong(DT);
        }

        public void SuaDoiTuong(string madt, string tendt,string manv ,string ghichu)
        {

            DT = new DoiTuong(madt, Chuanhoaxau(tendt),manv,Chuanhoaxau(ghichu));
            DTDAL.Suadoituong(DT);
        }

        public DataTable Load()
        {
            DataTable dt = new DataTable();
            dt = DTDAL.Load();
            return dt;
        }
        public void XoaDoiTuong(string MaDT)
        {

            DT = new DoiTuong(MaDT, "", "","");
            DTDAL.Xoadoituong(DT);
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
            dt = DTDAL.TimKiem(chon, tim);
            return dt;
        }
        public int Dembanghi(string MaDT)
        {
            return DTDAL.DemBanGhi(MaDT);
        }
        public DoiTuong Laynhanvientheoma(string maDT)
        {

            DataTable dt = DTDAL.LayDTTheoMa(maDT);
            DoiTuong dtg = new DoiTuong();
            dtg.Madoituong = dt.Rows[0][0].ToString();
            dtg.Tendoituong = dt.Rows[0][1].ToString();
            dtg.Manhanvien = dt.Rows[0][2].ToString();
            dtg.Ghichu = dt.Rows[0][3].ToString();
            return dtg;
        }
    }
}
