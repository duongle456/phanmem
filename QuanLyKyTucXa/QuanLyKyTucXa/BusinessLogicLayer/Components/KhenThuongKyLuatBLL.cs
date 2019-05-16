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
    class KhenThuongKyLuatBLL
    {
        KhenThuongKyLuat KT = new KhenThuongKyLuat();
        KhenThuongKyLuatDAL KTDAL = new KhenThuongKyLuatDAL();
        public void ThemKTKL(string maphieu, string tenphieu, string masv, string noidung, string hinhthuc,string ngaylap, string manv, string ghichu)
        {
            KT = new KhenThuongKyLuat(maphieu,tenphieu,masv,noidung, hinhthuc,ngaylap, manv, ghichu);
            KTDAL.Themktkl(KT);
        }

        public void SuaKTKL(string maphieu, string tenphieu, string masv, string noidung, string hinhthuc, string ngaylap, string manv, string ghichu)
        {

            KT = new KhenThuongKyLuat(maphieu, tenphieu, masv, noidung, hinhthuc, ngaylap, manv, ghichu);
            KTDAL.Suaktkl(KT);
        }

        public DataTable Load()
        {
            DataTable dt = new DataTable();
            dt = KTDAL.Load();
            return dt;
        }
        public void XoaKTKL(string MaPH)
        {

            KT = new KhenThuongKyLuat(MaPH, "", "", "", "", "", "","");
            KTDAL.Xoaktkl(KT);
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
            dt = KTDAL.TimKiem(chon, tim);
            return dt;
        }
        public int Dembanghi(string MaPH)
        {
            return KTDAL.DemBanGhi(MaPH);
        }
        public KhenThuongKyLuat Layktkltheoma(string MaPH)
        {

            DataTable dt = KTDAL.LayKTKLTheoMa(MaPH);
            KhenThuongKyLuat kt = new KhenThuongKyLuat();
            kt.Manphieu = dt.Rows[0][0].ToString();
            kt.Tenphieu = dt.Rows[0][1].ToString();
            kt.Masinhvien = dt.Rows[0][2].ToString();
            kt.Noidung = dt.Rows[0][3].ToString();
            kt.Hinhthuc = dt.Rows[0][4].ToString();
            kt.Ngaylap = dt.Rows[0][5].ToString();
            kt.Manhanvien = dt.Rows[0][6].ToString();
            kt.Ghichu = dt.Rows[0][7].ToString();
            return kt;
        }
    }
}
