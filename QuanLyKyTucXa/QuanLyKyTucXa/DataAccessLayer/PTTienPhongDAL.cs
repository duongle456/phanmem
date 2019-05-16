using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyKiTucXa.BusinessLogicLayer.Entities;

namespace QuanLyKiTucXa.DataAccessLayer
{
    class PTTienPhongDAL
    {
        string strSQL;
        PTTienPhong pt = new PTTienPhong();
        DataAccessHelper helper = new DataAccessHelper();
        public void Themphieuthu(PTTienPhong pt)
        {
            strSQL = "Insert into PTTienPhong values('" + pt.Manphieuthu + "','" + pt.Maphong + "','" + pt.Tienphong + "','" + pt.Thangthu + "','" + pt.Masinhvien + "','" + pt.Manhanvien + "',N'" + pt.Ghichu + "' )";
            helper.ThucThiKN(strSQL);
        }

        public void Suaphieuthu(PTTienPhong pt)
        {

            strSQL = "Update PTTienPhong set MaPhong='" + pt.Maphong + "',TienPhong='" + pt.Tienphong + "',ThangThu='" + pt.Thangthu + "',MaSV='" + pt.Masinhvien + "',MaNV='" + pt.Manhanvien + "',GhiChu=N'" + pt.Ghichu + "' where MaPT='" + pt.Manphieuthu + "'";
            helper.ThucThiKN(strSQL);
        }
        public void Xoaphieuthu(PTTienPhong pt)
        {
            strSQL = "Delete PTTienPhong where MaPT='" + pt.Manphieuthu + "'";
            helper.ThucThiKN(strSQL);
        }
        public DataTable Load()
        {
            DataTable dt = new DataTable();
            dt = helper.GetDataTable("Select * from PTTienPhong");
            return dt;
        }
        public int DemBanGhi(string MaPT)
        {
            int banghi;
            banghi = helper.DemBanGhi("select count(MaPT) from PTTienPhong where MaPT='" + MaPT + "' ");
            return banghi;
        }
        public DataTable TimKiem(string chon, string tim)
        {
            DataTable dt = new DataTable();
            if (chon == "Mã phiếu thu")
            {
                dt = helper.GetDataTable("Select * from PTTienPhong where MaPT like'%" + tim + "%'");
            }
            else
            {
                if (chon == "Mã phòng")
                {
                    dt = helper.GetDataTable("Select * from PTTienPhong where MaPhong like '%" + tim + "%'");
                }
            }
            return dt;
        }
        public DataTable LayPTTheoMa(string MaPT)
        {
            return TimKiem("Mã phiếu thu", MaPT);
        }
    }
 }

