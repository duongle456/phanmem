using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyKiTucXa.BusinessLogicLayer.Entities;

namespace QuanLyKiTucXa.DataAccessLayer
{
    class HDSinhVienPhongDAL
    {
        string strSQL;
        HopDongSVPhong hd = new HopDongSVPhong();
        DataAccessHelper helper = new DataAccessHelper();
        public void Themhopdong(HopDongSVPhong hd)
        {
            strSQL = "Insert into HDSinhVienPhong values('" + hd.Mahopdong + "','" +hd.Masinhvien + "','" + hd.Maphong + "','" + hd.Ngayvao + "','" + hd.Ngayra + "','" +hd.Ngaylap + "','" + hd.Masinhvien + "',N'" + hd.Ghichu + "' )";
            helper.ThucThiKN(strSQL);
        }
    
        public void Suahopdong(HopDongSVPhong hd)
        {

            strSQL = "Update HDSinhVienPhong set MaSV='" + hd.Masinhvien + "',MaPhong='" + hd.Maphong + "',NgayVao='" + hd.Ngayvao + "',NgayRa='" + hd.Ngayra + "',NgayLap='" + hd.Ngaylap + "',MaNV='" + hd.Manhanvien + "',GhiChu=N'" + hd.Ghichu + "' where MaHD='" + hd.Mahopdong + "'";
            helper.ThucThiKN(strSQL);
        }
        public void Xoahopdong(HopDongSVPhong hd)
        {
            strSQL = "Delete HDSinhVienPhong where MaHD='" + hd.Mahopdong + "'";
            helper.ThucThiKN(strSQL);
        }
        public DataTable Load()
        {
            DataTable dt = new DataTable();
            dt = helper.GetDataTable("Select * from HDSinhVienPhong");
            return dt;
        }
        public int DemBanGhi(string MaHD)
        {
            int banghi;
            banghi = helper.DemBanGhi("select count(MaHD) from HDSinhVienPhong where MaHD='" + MaHD + "' ");
            return banghi;
        }
        public DataTable TimKiem(string chon, string tim)
        {
            DataTable dt = new DataTable();
            if (chon == "Mã hợp đồng")
            {
                dt = helper.GetDataTable("Select * from HDSinhVienPhong where MaHD like'%" + tim + "%'");
            }
            else
            {
                if (chon == "Mã phòng")
                {
                    dt = helper.GetDataTable("Select * from HDSinhVienPhong where MaPhong like N'%" + tim + "%'");
                }
            }
            return dt;
        }
        public DataTable LayHDTheoMa(string MaHD)
        {
            return TimKiem("Mã hợp đồng", MaHD);
        }
    }
 }

