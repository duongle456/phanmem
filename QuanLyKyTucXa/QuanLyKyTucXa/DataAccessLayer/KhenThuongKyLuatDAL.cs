using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyKiTucXa.BusinessLogicLayer.Entities;

namespace QuanLyKiTucXa.DataAccessLayer
{
    class KhenThuongKyLuatDAL
    {
        string strSQL;
        KhenThuongKyLuat kt = new KhenThuongKyLuat();
        DataAccessHelper helper = new DataAccessHelper();
        public void Themktkl(KhenThuongKyLuat kt)
        {
            strSQL = "Insert into KhenThuongKyLuat values('" + kt.Manphieu + "',N'" + kt.Tenphieu + "','" + kt.Masinhvien + "',N'" + kt.Noidung + "',N'" + kt.Hinhthuc + "','" + kt.Ngaylap + "','" + kt.Manhanvien + "',N'" + kt.Ghichu + "' )";
            helper.ThucThiKN(strSQL);
        }

        public void Suaktkl(KhenThuongKyLuat kt)
        {

            strSQL = "Update KhenThuongKyLuat set MaPhieu='" +kt.Manphieu + "',TenPhieu=N'" + kt.Tenphieu + "',MaSV='" + kt.Masinhvien + "',NoiDung=N'" +kt.Noidung + "',HinhThuc=N'" + kt.Hinhthuc + "',MaNV='" + kt.Manhanvien + "',GhiChu=N'" + kt.Ghichu + "' where MaPhieu='" + kt.Manphieu + "'";
            helper.ThucThiKN(strSQL);
        }
        public void Xoaktkl(KhenThuongKyLuat kt)
        {
            strSQL = "Delete KhenThuongKyLuat where MaPhieu='" + kt.Manphieu + "'";
            helper.ThucThiKN(strSQL);
        }
        public DataTable Load()
        {
            DataTable dt = new DataTable();
            dt = helper.GetDataTable("Select * from KhenThuongKyLuat");
            return dt;
        }
        public int DemBanGhi(string MaPH)
        {
            int banghi;
            banghi = helper.DemBanGhi("select count(MaPhieu) from KhenThuongKyLuat where MaPhieu='" + MaPH + "' ");
            return banghi;
        }
        public DataTable TimKiem(string chon, string tim)
        {
            DataTable dt = new DataTable();
            if (chon == "Mã phiếu")
            {
                dt = helper.GetDataTable("Select * from KhenThuongKyLuat where MaPhieu like'%" + tim + "%'");
            }
            else
            {
                if (chon == "Tên phiếu")
                {
                    dt = helper.GetDataTable("Select * from KhenThuongKyLuat where TenPhieu like N'%" + tim + "%'");
                }
            }
            return dt;
        }
        public DataTable LayKTKLTheoMa(string MaPH)
        {
            return TimKiem("Mã phiếu", MaPH);
        }
    }
 }

