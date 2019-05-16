using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyKiTucXa.BusinessLogicLayer.Entities;

namespace QuanLyKiTucXa.DataAccessLayer
{
    class NhanVienDAL
    {
        string strSQL;
        NhanVien nv = new NhanVien();
        DataAccessHelper helper = new DataAccessHelper();
        public void Themnhanvien(NhanVien nv)
        {
            strSQL = "Insert into NhanVien values('" + nv.Manhanvien + "',N'" + nv.Tennhanvien + "',N'" + nv.Gioitinh + "','" + nv.Ngaysinh + "',N'" + nv.Quequan + "',N'" + nv.Chuvu + "','" + nv.Sodienthoai + "','" + nv.Ngayvaolam + "','" + nv.Luongcoban + "','" + nv.Hesoluong + "','" + nv.luong + "' )";
            helper.ThucThiKN(strSQL);
        }

        public void Suanhanvien(NhanVien nv)
        {

            strSQL = "Update NhanVien set TenNV=N'" + nv.Tennhanvien + "',Gioitinh=N'" + nv.Gioitinh + "',Ngaysinh='" + nv.Ngaysinh + "',QueQuan=N'" + nv.Quequan + "',Chucvu=N'" + nv.Chuvu + "',SoDT='" + nv.Sodienthoai + "',NgayVaoLam='" + nv.Ngayvaolam + "' ,LuongCoBan='" + nv.Luongcoban + "',HeSoLuong='" + nv.Hesoluong + "',HeSoPhuCap='" + nv.Hesophucap + "',Luong='" + nv.luong + "'where MaNV='" + nv.Manhanvien + "'";
            helper.ThucThiKN(strSQL);
        }
        public void Xoanhanvien(NhanVien nv)
        {
            strSQL = "Delete NhanVien where MaNV='" + nv.Manhanvien + "'";
            helper.ThucThiKN(strSQL);
        }
        public DataTable Load()
        {
            DataTable dt = new DataTable();
            dt = helper.GetDataTable("Select * from NhanVien");
            return dt;
        }
        public int DemBanGhi(string MaNV)
        {
            int banghi;
            banghi = helper.DemBanGhi("select count(MaNV) from NhanVien where MaNV='" + MaNV + "' ");
            return banghi;
        }
        public DataTable TimKiem(string chon, string tim)
        {
            DataTable dt = new DataTable();
            if (chon == "Mã nhân viên")
            {
                dt = helper.GetDataTable("Select * from NhanVien where MaNV like'%" + tim + "%'");
            }
            else
            {
                if (chon == "Tên nhân viên")
                {
                    dt = helper.GetDataTable("Select * from NhanVien where TenNV like N'%" + tim + "%'");
                }
            }
            return dt;
        }
        public DataTable LayNVTheoMa(string MaNV)
        {
            return TimKiem("Mã nhân viên", MaNV);
        }
    }
}
