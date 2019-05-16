using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyKiTucXa.BusinessLogicLayer.Entities;

namespace QuanLyKiTucXa.DataAccessLayer
{
    class ChuyenPhongDAL
    {
        string strSQL;
        ChuyenPhong cp = new ChuyenPhong();
        DataAccessHelper helper = new DataAccessHelper();
        public void Themphieuchuyen(ChuyenPhong cp)
        {
            strSQL = "Insert into ChuyenPhong values('" + cp.Maphieuchuyen + "','" + cp.Masinhvien + "','" + cp.Maphongcu + "','" + cp.Maphongmoi + "',N'" + cp.Loaiphong + "','" + cp.Ngaychuyen + "','" + cp.Manhanvien + "',N'" + cp.Ghichu + "')";
            helper.ThucThiKN(strSQL);
        }

        public void Suaphieuchuyen(ChuyenPhong cp)
        {

            strSQL = "Update ChuyenPhong set MaSV='" + cp.Masinhvien + "',MaPhongCu='" + cp.Maphongcu + "',MaPhongMoi='" + cp.Maphongmoi + "',LoaiPhong=N'" + cp.Loaiphong + "',NgayChuyen='" + cp.Ngaychuyen + "',MaNV='" + cp.Manhanvien + "',GhiChu=N'" + cp.Ghichu + "'where MaPC='" + cp.Maphieuchuyen + "'";
            helper.ThucThiKN(strSQL);
        }
        public void Xoaphieuchuyen(ChuyenPhong cp)
        {
            strSQL = "Delete ChuyenPhong where MaPC='" + cp.Maphieuchuyen + "'";
            helper.ThucThiKN(strSQL);
        }
        public DataTable Load()
        {
            DataTable dt = new DataTable();
            dt = helper.GetDataTable("Select * from ChuyenPhong");
            return dt;
        }
        public int DemBanGhi(string MaPC)
        {
            int banghi;
            banghi = helper.DemBanGhi("select count(MaPC) from ChuyenPhong where MaPC='" + MaPC + "' ");
            return banghi;
        }
        public DataTable TimKiem(string chon, string tim)
        {
            DataTable dt = new DataTable();
            if (chon == "Mã phiếu chuyển")
            {
                dt = helper.GetDataTable("Select * from ChuyenPhong where MaPC like'%" + tim + "%'");
            }
            else
            {
                if (chon == "Mã sinh viên")
                {
                    dt = helper.GetDataTable("Select * from ChuyenPhong where MaSV like '%" + tim + "%'");
                }
            }
            return dt;
        }
        public DataTable LayPCTheoMa(string MaPC)
        {
            return TimKiem("Mã phiếu chuyển", MaPC);
        }
    }
}
