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
    class TaiSanBLL
    {
        TaiSan TS = new TaiSan();
        TaiSanDAL TSDAL = new TaiSanDAL();
        public void ThemTaiSan(string mats, string tents,string maphong, string soluong, string manv, string hientrang)
        {
                TS = new TaiSan(mats, Chuanhoaxau(tents), maphong, soluong,manv, Chuanhoaxau(hientrang));
                TSDAL.Themtaisan(TS);
        }

        public void SuaTaiSan(string mats, string tents, string maphong, string soluong, string manv, string hientrang)
        {

            TS = new TaiSan(mats, Chuanhoaxau(tents), maphong,soluong,manv, Chuanhoaxau(hientrang));
            TSDAL.Suataisan(TS);
        }

        public DataTable Load()
        {
            DataTable dt = new DataTable();
            dt = TSDAL.Load();
            return dt;
        }
        public void XoaTaiSan(string MaTS)
        {

            TS = new TaiSan(MaTS, "", "", "", "","");
            TSDAL.Xoataisan(TS);
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
            dt = TSDAL.TimKiem(chon, tim);
            return dt;
        }
        public int Dembanghi(string MaTS)
        {
            return TSDAL.DemBanGhi(MaTS);
        }
        public TaiSan Laytaisantheoma(string maTS)
        {

            DataTable dt = TSDAL.LayTSTheoMa(maTS);
            TaiSan ts = new TaiSan();
            ts.Mantaisan = dt.Rows[0][0].ToString();
            ts.Tentaisan = dt.Rows[0][1].ToString();
            ts.Maphong = dt.Rows[0][2].ToString();
            ts.Soluong= dt.Rows[0][3].ToString();
            ts.Manhanvien = dt.Rows[0][4].ToString();
            ts.Hientrang = dt.Rows[0][5].ToString();
            return ts;
        }
    }
}
