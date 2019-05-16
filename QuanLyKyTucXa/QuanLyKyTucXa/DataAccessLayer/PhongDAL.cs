using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyKiTucXa.BusinessLogicLayer.Entities;

namespace QuanLyKiTucXa.DataAccessLayer
{
    class PhongDAL
    {
        string strSQL;
        Phong ph = new Phong();
        DataAccessHelper helper = new DataAccessHelper();
        public void Themphong(Phong ph)
        {
            strSQL = "Insert into Phong values('" + ph.Manphong + "',N'" + ph.Tenphong + "','" + ph.Matoanha + "',N'" + ph.Loaiphong + "','" + ph.Soluongnguoi + "',N'" + ph.Tinhtrang + "' )";
            helper.ThucThiKN(strSQL);
        }

        public void Suaphong(Phong ph)
        {

            strSQL = "Update Phong set TenPhong=N'" + ph.Tenphong + "',MaTN='" + ph.Matoanha + "',LoaiPhong=N'" + ph.Loaiphong + "',SoLuongNguoi='" + ph.Soluongnguoi + "',TinhTrang=N'" + ph.Tinhtrang + "' where MaPhong='" + ph.Manphong + "'";
            helper.ThucThiKN(strSQL);
        }
        public void Xoaphong(Phong ph)
        {
            strSQL = "Delete Phong where MaPhong='" + ph.Manphong + "'";
            helper.ThucThiKN(strSQL);
        }
        public DataTable Load()
        {
            DataTable dt = new DataTable();
            dt = helper.GetDataTable("Select * from Phong");
            return dt;
        }
        public int DemBanGhi(string MaPhong)
        {
            int banghi;
            banghi = helper.DemBanGhi("select count(MaPhong) from Phong where MaPhong='" + MaPhong + "' ");
            return banghi;
        }
        public DataTable TimKiem(string chon, string tim)
        {
            DataTable dt = new DataTable();
            if (chon == "Mã phòng")
            {
                dt = helper.GetDataTable("Select * from Phong where MaPhong like'%" + tim + "%'");
            }
            else
            {
                if (chon == "Tên phòng")
                {
                    dt = helper.GetDataTable("Select * from Phong where TenPhong like N'%" + tim + "%'");
                }
            }
            return dt;
        }
        public DataTable LayPhongTheoMa(string MaPhong)
        {
            return TimKiem("Mã phòng", MaPhong);
        }
    }
}
