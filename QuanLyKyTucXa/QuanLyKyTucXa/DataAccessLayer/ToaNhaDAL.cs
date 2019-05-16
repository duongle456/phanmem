using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyKiTucXa.BusinessLogicLayer.Entities;

namespace QuanLyKiTucXa.DataAccessLayer
{
    class ToaNhaDAL
    {
        string strSQL;
        ToaNha tn = new ToaNha();
        DataAccessHelper helper = new DataAccessHelper();
        public void Themtoanha(ToaNha tn)
        {
            strSQL = "Insert into ToaNha values('" + tn.Mantoanha + "',N'" + tn.Tentoanha + "','" + tn.Sophong + "','" + tn.Tienphong + "','" + tn.Manhanvien + "',N'" + tn.Ghichu + "')";
            helper.ThucThiKN(strSQL);
        }

        public void Suatoanha(ToaNha tn)
        {

            strSQL = "Update ToaNha set TenTN=N'" + tn.Tentoanha + "',SoPhong='" + tn.Sophong + "',TienPhong='" + tn.Tienphong + "',MaNV='" + tn.Manhanvien + "',GhiChu=N'" + tn.Ghichu + "' where MaTN='" + tn.Mantoanha + "'";
            helper.ThucThiKN(strSQL);
        }
        public void Xoatoanha(ToaNha tn)
        {
            strSQL = "Delete ToaNha where MaTN='" + tn.Mantoanha + "'";
            helper.ThucThiKN(strSQL);
        }
        public DataTable Load()
        {
            DataTable dt = new DataTable();
            dt = helper.GetDataTable("Select * from ToaNha");
            return dt;
        }
        public int DemBanGhi(string MaTN)
        {
            int banghi;
            banghi = helper.DemBanGhi("select count(MaTN) from ToaNha where MaTN='" + MaTN + "' ");
            return banghi;
        }
        public DataTable TimKiem(string chon, string tim)
        {
            DataTable dt = new DataTable();
            if (chon == "Mã tòa nhà")
            {
                dt = helper.GetDataTable("Select * from ToaNha where MaTN like'%" + tim + "%'");
            }
            else
            {
                if (chon == "Tên tòa nhà")
                {
                    dt = helper.GetDataTable("Select * from ToaNha where TenTN like N'%" + tim + "%'");
                }
            }
            return dt;
        }
        public DataTable LayTNTheoMa(string MaTN)
        {
            return TimKiem("Mã tòa nhà", MaTN);
        }
    }
}
