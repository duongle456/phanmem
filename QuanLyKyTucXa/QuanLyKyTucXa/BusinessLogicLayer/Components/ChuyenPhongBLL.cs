using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyKiTucXa.BusinessLogicLayer.Entities;
using System.Windows.Forms;
using QuanLyKiTucXa.DataAccessLayer;

namespace QuanLyKiTucXa.BusinessLogicLayer.Components
{
    class ChuyenPhongBLL
    {
        ChuyenPhong CP = new ChuyenPhong();
        ChuyenPhongDAL CPDAL = new ChuyenPhongDAL();
        public void ThemPhieuChuyen(string mapc, string masv, string maphongcu, string maphongmoi,string loaiphong, string ngaychuyen, string manhanvien, string ghichu)
        {
            CP = new ChuyenPhong(mapc, masv, maphongcu, maphongmoi, Chuanhoaxau(loaiphong), ngaychuyen, manhanvien, Chuanhoaxau(ghichu));
                CPDAL.Themphieuchuyen(CP);
        }

        public void SuaPhieuChuyen(string mapc, string masv, string maphongcu, string maphongmoi, string loaiphong, string ngaychuyen, string manhanvien, string ghichu)
        {
            CP = new ChuyenPhong(mapc, masv, maphongcu, maphongmoi, Chuanhoaxau(loaiphong), ngaychuyen, manhanvien, Chuanhoaxau(ghichu));
            CPDAL.Suaphieuchuyen(CP);
        }

        public DataTable Load()
        {
            DataTable dt = new DataTable();
            dt = CPDAL.Load();
            return dt;
        }
        public void XoaPhieuChuyen(string MaPC)
        {

            CP = new ChuyenPhong(MaPC, "", "", "", "", "", "", "");
            CPDAL.Xoaphieuchuyen(CP);
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
            dt = CPDAL.TimKiem(chon, tim);
            return dt;
        }
        public int Dembanghi(string MaPC)
        {
            return CPDAL.DemBanGhi(MaPC);
        }
        public ChuyenPhong Layphieuchuyentheoma(string maPC)
        {

            DataTable dt = CPDAL.LayPCTheoMa(maPC);
            ChuyenPhong cp = new ChuyenPhong();
            cp.Maphieuchuyen = dt.Rows[0][0].ToString();
            cp.Masinhvien = dt.Rows[0][1].ToString();
            cp.Maphongcu = dt.Rows[0][2].ToString();
            cp.Maphongmoi = dt.Rows[0][3].ToString();
            cp.Loaiphong = dt.Rows[0][4].ToString();
            cp.Ngaychuyen = dt.Rows[0][5].ToString();
            cp.Manhanvien = dt.Rows[0][6].ToString();
            cp.Ghichu = dt.Rows[0][7].ToString();
            return cp;
        }
    }
}
