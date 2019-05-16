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
    class PTTienPhongBLL
    {
        PTTienPhong PT = new PTTienPhong();
        PTTienPhongDAL PTDAL = new PTTienPhongDAL();
        public void ThemPhieuThu(string maphieuthu, string maphong, string tienphong, string thangthu, string masv, string manv,string ghichu)
        {
            PT = new PTTienPhong(maphieuthu, maphong, tienphong, thangthu, masv, manv, Chuanhoaxau(ghichu));
                PTDAL.Themphieuthu(PT);
        }

        public void SuaPhieuThu(string maphieuthu, string maphong, string tienphong, string thangthu, string masv, string manv,string ghichu)
        {

            PT = new PTTienPhong(maphieuthu, maphong, tienphong, thangthu, masv, manv, Chuanhoaxau(ghichu));
            PTDAL.Suaphieuthu(PT);
        }

        public DataTable Load()
        {
            DataTable dt = new DataTable();
            dt = PTDAL.Load();
            return dt;
        }
        public void XoaPhieuThu(string MaPT)
        {

            PT = new PTTienPhong(MaPT, "", "", "", "", "","");
            PTDAL.Xoaphieuthu(PT);
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
            dt = PTDAL.TimKiem(chon, tim);
            return dt;
        }
        public int Dembanghi(string MaPT)
        {
            return PTDAL.DemBanGhi(MaPT);
        }
        public PTTienPhong Layphieuthutheoma(string MaPT)
        {

            DataTable dt = PTDAL.LayPTTheoMa(MaPT);
            PTTienPhong pt = new PTTienPhong();
            pt.Manphieuthu = dt.Rows[0][0].ToString();
            pt.Maphong = dt.Rows[0][1].ToString();
            pt.Tienphong = dt.Rows[0][2].ToString();
            pt.Thangthu = dt.Rows[0][3].ToString();
            pt.Masinhvien = dt.Rows[0][4].ToString();
            pt.Manhanvien = dt.Rows[0][5].ToString();
            pt.Ghichu = dt.Rows[0][6].ToString();
            return pt;
        }
    }
 }

