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
    class HDSinhVienPhongBLL
    {
        HopDongSVPhong HD = new HopDongSVPhong();
        HDSinhVienPhongDAL HDDAL = new HDSinhVienPhongDAL();
        public void ThemHopDong(string mahopdong, string masinhvien,string maphong,string ngayvao, string ngayra, string ngaylap, string manhanvien,string ghichu)
        {
              HD = new HopDongSVPhong(mahopdong, masinhvien, maphong, ngayvao,ngayra, ngaylap,manhanvien,Chuanhoaxau(ghichu));
              HDDAL.Themhopdong(HD);
        }

        public void SuaHopDong(string mahopdong, string masinhvien,string maphong,string ngayvao, string ngayra, string ngaylap, string manhanvien,string ghichu)
        {
            HD = new HopDongSVPhong(mahopdong, masinhvien, maphong, ngayvao,ngayra, ngaylap,manhanvien,Chuanhoaxau(ghichu));
            HDDAL.Suahopdong(HD);
        }

        public DataTable Load()
        {
            DataTable dt = new DataTable();
            dt = HDDAL.Load();
            return dt;
        }
        public void XoaHopDong(string MaHD)
        {
            
            HD = new HopDongSVPhong(MaHD, "", "","", "", "", "","");
            HDDAL.Xoahopdong(HD);
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
            dt = HDDAL.TimKiem(chon, tim);
            return dt;
        }
        public int Dembanghi(string MaHD)
        {
            return HDDAL.DemBanGhi(MaHD);
        }
        public HopDongSVPhong Layhopdongtheoma(string MaHD)
        {

            DataTable dt = HDDAL.LayHDTheoMa(MaHD);
            HopDongSVPhong hd = new HopDongSVPhong();
            hd.Mahopdong = dt.Rows[0][0].ToString();
            hd.Masinhvien = dt.Rows[0][1].ToString();
            hd.Maphong = dt.Rows[0][2].ToString();
            hd.Ngayvao = dt.Rows[0][3].ToString();
            hd.Ngayra = dt.Rows[0][4].ToString();
            hd.Ngaylap = dt.Rows[0][5].ToString();
            hd.Manhanvien = dt.Rows[0][6].ToString();
            hd.Ghichu = dt.Rows[0][7].ToString();
            return hd;
        }
    }
 }
