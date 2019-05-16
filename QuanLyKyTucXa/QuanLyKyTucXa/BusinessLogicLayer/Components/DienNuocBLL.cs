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
    class DienNuocBLL
    {
        DienNuoc DN = new DienNuoc();
        DienNuocDAL DNDAL = new DienNuocDAL();
        public void ThemDienNuoc(string maptdn, string maphong,string sdtruoc,string sntruoc,string sdien,string snuoc,string dgdien,string dgnuoc,string tdien,string tnuoc,string thangthu,string masv,string manv,string ghichu)
        {
            int SDT = int.Parse(sdtruoc);
            int SNT = int.Parse(sntruoc);
            int SD = int.Parse(sdien);
            int SN = int.Parse(snuoc);
            double DGD = double.Parse(dgdien);
            double DGN = double.Parse(dgnuoc);
            double TD = double.Parse(tdien);
            TD = (SD - SDT) * DGD;
            double TN = double.Parse(tnuoc);
            TN = (SN - SNT) * DGN;
                DN = new DienNuoc(maptdn,maphong,SDT,SNT,SD,SN,DGD,DGN,TD,TN,thangthu,masv,manv,ghichu);
                DNDAL.Themdiennuoc(DN);
        }

        public void SuaDienNuoc(string maptdn, string maphong, string sdtruoc, string sntruoc, string sdien, string snuoc, string dgdien, string dgnuoc, string tdien, string tnuoc, string thangthu, string masv, string manv, string ghichu)
        {
            int SDT = int.Parse(sdtruoc);
            int SNT = int.Parse(sntruoc);
            int SD = int.Parse(sdien);
            int SN = int.Parse(snuoc);
            double DGD = double.Parse(dgdien);
            double DGN = double.Parse(dgnuoc);
            double TD = double.Parse(tdien);
            TD = (SD - SDT) * DGD;
            double TN = double.Parse(tnuoc);
            TN = (SN - SNT) * DGN;
            DN = new DienNuoc(maptdn, maphong, SDT, SNT, SD, SN, DGD, DGN, TD, TN, thangthu, masv, manv, ghichu);
            DNDAL.Suadiennuoc(DN);
        }

        public DataTable Load()
        {
            DataTable dt = new DataTable();
            dt = DNDAL.Load();
            return dt;
        }
        public void XoaDienNuoc(string MaPTDN)
        {
            
            DN = new DienNuoc(MaPTDN, "",'0','0','0','0','0','0','0','0',"","","","");
            DNDAL.Xoadiennuoc(DN);
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
            dt = DNDAL.TimKiem(chon, tim);
            return dt;
        }
        public int Dembanghi(string MaPTDN)
        {
            return DNDAL.DemBanGhi(MaPTDN);
        }
        public DienNuoc Laydiennuoctheoma(string MaPTDN)
        {

            DataTable dt = DNDAL.LayDNTheoMa(MaPTDN);
            DienNuoc dn = new DienNuoc();
            dn.Maptdn = dt.Rows[0][0].ToString();
            dn.Maphong = dt.Rows[0][1].ToString();
            dn.Sodientruoc =int.Parse(dt.Rows[0][2].ToString());
            dn.Sonuoctruoc =int.Parse(dt.Rows[0][3].ToString());
            dn.Sodien = int.Parse(dt.Rows[0][4].ToString());
            dn.Sonuoc = int.Parse(dt.Rows[0][5].ToString());
            dn.Dongiadien =double.Parse(dt.Rows[0][6].ToString());
            dn.Dongianuoc =double.Parse(dt.Rows[0][7].ToString());
            dn.Tiendien = double.Parse(dt.Rows[0][8].ToString());
            dn.Tiennuoc = double.Parse(dt.Rows[0][9].ToString());
            dn.Thangthu = dt.Rows[0][10].ToString();
            dn.Masinhvien = dt.Rows[0][11].ToString();
            dn.Manhanvien = dt.Rows[0][12].ToString();
            dn.Ghichu = dt.Rows[0][13].ToString();
            return dn;
        }
    }
 }

