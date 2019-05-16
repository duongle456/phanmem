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
    class PhongBLL
    {
        Phong PH = new Phong();
        PhongDAL PHDAL = new PhongDAL();
        public void ThemPhong(string maphong, string tenphong, string matoanha, string loaiphong, string soluongngoi, string tinhtrang)
        {
                PH = new Phong(maphong, Chuanhoaxau(tenphong), matoanha, Chuanhoaxau(loaiphong), soluongngoi, tinhtrang);
                PHDAL.Themphong(PH);
        }

        public void SuaPhong(string maphong, string tenphong, string matoanha, string loaiphong, string soluongngoi, string tinhtrang)
        {

            PH = new Phong(maphong, Chuanhoaxau(tenphong), matoanha, Chuanhoaxau(loaiphong), soluongngoi, tinhtrang);
            PHDAL.Suaphong(PH);
        }

        public DataTable Load()
        {
            DataTable dt = new DataTable();
            dt = PHDAL.Load();
            return dt;
        }
        public void XoaPhong(string MaPhong)
        {

            PH = new Phong(MaPhong, "", "", "", "", "");
            PHDAL.Xoaphong(PH);
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
            dt = PHDAL.TimKiem(chon, tim);
            return dt;
        }
        public int Dembanghi(string MaNV)
        {
            return PHDAL.DemBanGhi(MaNV);
        }
        public Phong Layphongtheoma(string Maphong)
        {

            DataTable dt = PHDAL.LayPhongTheoMa(Maphong);
            Phong ph = new Phong();
            ph.Manphong = dt.Rows[0][0].ToString();
            ph.Tenphong = dt.Rows[0][1].ToString();
            ph.Matoanha = dt.Rows[0][2].ToString();
            ph.Loaiphong = dt.Rows[0][3].ToString();
            ph.Soluongnguoi = dt.Rows[0][4].ToString();
            ph.Tinhtrang = dt.Rows[0][5].ToString();
            return ph;
        }
    }
}
