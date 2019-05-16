using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyKiTucXa.BusinessLogicLayer.Entities;

namespace QuanLyKiTucXa.DataAccessLayer
{
    class DoiTuongDAL
    {
        string strSQL;
        DoiTuong dt = new DoiTuong();
        DataAccessHelper helper = new DataAccessHelper();
        public void Themdoituong(DoiTuong dt)
        {
            strSQL = "Insert into DoiTuong values('" + dt.Madoituong + "',N'" + dt.Tendoituong + "','" + dt.Manhanvien + "',N'" + dt.Ghichu + "')";
            helper.ThucThiKN(strSQL);
        }

        public void Suadoituong(DoiTuong dt)
        {

            strSQL = "Update DoiTuong set TenDT=N'" + dt.Tendoituong + "',MaNV='" + dt.Manhanvien + "',GhiChu=N'" + dt.Ghichu + "' where MaDT='" + dt.Madoituong + "'";
            helper.ThucThiKN(strSQL);
        }
        public void Xoadoituong(DoiTuong dt)
        {
            strSQL = "Delete DoiTuong where MaDT='" + dt.Madoituong + "'";
            helper.ThucThiKN(strSQL);
        }
        public DataTable Load()
        {
            DataTable dt = new DataTable();
            dt = helper.GetDataTable("Select * from DoiTuong");
            return dt;
        }
        public int DemBanGhi(string MaDT)
        {
            int banghi;
            banghi = helper.DemBanGhi("select count(MaDT) from DoiTuong where MaDT='" + MaDT + "' ");
            return banghi;
        }
        public DataTable TimKiem(string chon, string tim)
        {
            DataTable dt = new DataTable();
            if (chon == "Mã đối tượng")
            {
                dt = helper.GetDataTable("Select * from DoiTuong where MaDT like'%" + tim + "%'");
            }
            else
            {
                if (chon == "Tên đối tượng")
                {
                    dt = helper.GetDataTable("Select * from DoiTuong where TenDT like N'%" + tim + "%'");
                }
            }
            return dt;
        }
        public DataTable LayDTTheoMa(string MaDT)
        {
            return TimKiem("Mã đối tượng", MaDT);
        }
    }
}
