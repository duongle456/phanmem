using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyKiTucXa.BusinessLogicLayer.Entities;

namespace QuanLyKiTucXa.DataAccessLayer
{
    class SinhVienDAL
    {
        string strSQL;
        SinhVien sv = new SinhVien();
        DataAccessHelper helper = new DataAccessHelper();
        public void Themsinhvien(SinhVien sv)
        {
            strSQL = "Insert into SinhVien values('" + sv.Masinhvien + "',N'" + sv.Tensinhvien + "','" + sv.Ngaysinh + "',N'" + sv.Gioitinh + "',N'" + sv.Quequan + "','" + sv.Madoituong + "','" + sv.Maphong+ "','" + sv.Socmtnd + "',N'" + sv.Ghichu+ "' )";
            helper.ThucThiKN(strSQL);
        }

        public void Suasinhvien(SinhVien sv)
        {

            strSQL = "Update SinhVien set TenSV=N'" + sv.Tensinhvien + "',NgaySinh='" + sv.Ngaysinh + "',GioiTinh=N'" + sv.Gioitinh + "',QueQuan=N'" + sv.Quequan + "',MaDT='" + sv.Madoituong + "',MaPhong='" + sv.Maphong + "',SoCMTND='" + sv.Socmtnd + "',GhiChu=N'" + sv.Ghichu + "' where MaSV='" + sv.Masinhvien + "'";
            helper.ThucThiKN(strSQL);
        }
        public void Xoasinhvien(SinhVien sv)
        {
            strSQL = "Delete SinhVien where MaSV='" + sv.Masinhvien + "'";
            helper.ThucThiKN(strSQL);
        }
        public DataTable Load()
        {
            DataTable dt = new DataTable();
            dt = helper.GetDataTable("Select * from SinhVien");
            return dt;
        }
        public int DemBanGhi(string MaSV)
        {
            int banghi;
            banghi = helper.DemBanGhi("select count(MaSV) from SinhVien where MaSV='" + MaSV + "' ");
            return banghi;
        }
        public DataTable TimKiem(string chon, string tim)
        {
            DataTable dt = new DataTable();
            if (chon == "Mã sinh viên")
            {
                dt = helper.GetDataTable("Select * from SinhVien where MaSV like'%" + tim + "%'");
            }
            else
            {
                if (chon == "Tên sinh viên")
                {
                    dt = helper.GetDataTable("Select * from SinhVien where TenSV like N'%" + tim + "%'");
                }
            }
            return dt;
        }
        public DataTable LaySVTheoMa(string MaNV)
        {
            return TimKiem("Mã sinh viên", MaNV);
        }
    }
 }

