using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyKiTucXa.BusinessLogicLayer.Entities;

namespace QuanLyKiTucXa.DataAccessLayer
{
    class TaiSanDAL
    {
        string strSQL;
        TaiSan ts = new TaiSan();
        DataAccessHelper helper = new DataAccessHelper();
        public void Themtaisan(TaiSan ts)
        {
            strSQL = "Insert into TaiSan values('" + ts.Mantaisan + "',N'" + ts.Tentaisan + "','" + ts.Maphong + "','" + ts.Soluong + "','" + ts.Manhanvien + "',N'" + ts.Hientrang + "')";
            helper.ThucThiKN(strSQL);
        }

        public void Suataisan(TaiSan ts)
        {

            strSQL = "Update TaiSan set TenTS=N'" + ts.Tentaisan + "',MaPhong='" + ts.Maphong + "',SoLuong='" + ts.Soluong + "',MaNV='" + ts.Manhanvien + "',HienTrang=N'" + ts.Hientrang + "' where MaTS='" +ts.Mantaisan + "'";
            helper.ThucThiKN(strSQL);
        }
        public void Xoataisan(TaiSan ts)
        {
           strSQL = "Delete TaiSan where MaTS='" + ts.Mantaisan + "'";
            helper.ThucThiKN(strSQL);
        }
        public DataTable Load()
        {
            DataTable dt = new DataTable();
            dt = helper.GetDataTable("Select * from TaiSan");
            return dt;
        }
        public int DemBanGhi(string MaTS)
        {
            int banghi;
            banghi = helper.DemBanGhi("select count(MaTS) from TaiSan where MaTS='" + MaTS + "' ");
            return banghi;
        }
        public DataTable TimKiem(string chon, string tim)
        {
            DataTable dt = new DataTable();
            if (chon == "Mã tài sản")
            {
                dt = helper.GetDataTable("Select * from TaiSan where MaTS like'%" + tim + "%'");
            }
            else
            {
                if (chon == "Tên tài sản")
                {
                    dt = helper.GetDataTable("Select * from TaiSan where TenTS like N'%" + tim + "%'");
                }
            }
            return dt;
        }
        public DataTable LayTSTheoMa(string MaTS)
        {
            return TimKiem("Mã tài sản", MaTS);
        }
    }
}
