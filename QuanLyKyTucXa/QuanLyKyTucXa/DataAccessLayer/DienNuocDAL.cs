using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyKiTucXa.BusinessLogicLayer.Entities;

namespace QuanLyKiTucXa.DataAccessLayer
{
    class DienNuocDAL
    {
        string strSQL;
        DienNuoc dn = new DienNuoc();
        DataAccessHelper helper = new DataAccessHelper();
        public void Themdiennuoc(DienNuoc dn)
        {
            strSQL = "Insert into DienNuoc values('" + dn.Maptdn + "','" + dn.Maphong + "','" + dn.Sodientruoc + "','" + dn.Sonuoctruoc + "','" + dn.Sodien + "','" + dn.Sonuoc + "','" + dn.Dongiadien + "','" + dn.Dongianuoc + "','" + dn.Tiendien + "','" + dn.Tiennuoc + "','" + dn.Thangthu + "','" + dn.Masinhvien + "','" + dn.Manhanvien + "',N'" + dn.Ghichu + "' )";
            helper.ThucThiKN(strSQL);
        }

        public void Suadiennuoc(DienNuoc dn)
        {

            strSQL = "Update DienNuoc set MaPhong='" + dn.Maphong + "',SoDienTruoc='" + dn.Sodientruoc + "',SoNuocTruoc='" + dn.Sonuoctruoc + "',SoDien='" + dn.Sodien + "',SoNuoc='" + dn.Sonuoc + "',DonGiaDien='" + dn.Dongiadien + "',DonGiaNuoc='" + dn.Dongianuoc + "',ThanhTienDien='" + dn.Tiendien + "',ThanhTienNuoc='" + dn.Tiennuoc + "',ThangThu='" + dn.Thangthu + "',MaSV='" + dn.Masinhvien + "',MaNV='" + dn.Manhanvien + "',GhiChu=N'" + dn.Ghichu + "' where MaPTDN='" + dn.Maptdn + "'";
            helper.ThucThiKN(strSQL);
        }
        public void Xoadiennuoc(DienNuoc dn)
        {
            strSQL = "Delete DienNuoc where MaPTDN='" + dn.Maptdn + "'";
            helper.ThucThiKN(strSQL);
        }
        public DataTable Load()
        {
            DataTable dt = new DataTable();
            dt = helper.GetDataTable("Select * from DienNuoc");
            return dt;
        }
        public int DemBanGhi(string MaPTDN)
        {
            int banghi;
            banghi = helper.DemBanGhi("select count(MaPTDN) from DienNuoc where MaPTDN='" + MaPTDN + "' ");
            return banghi;
        }
        public DataTable TimKiem(string chon, string tim)
        {
            DataTable dt = new DataTable();
            if (chon == "Mã phiếu thu điện nước")
            {
                dt = helper.GetDataTable("Select * from DienNuoc where MaPTDN like'%" + tim + "%'");
            }
            else
            {
                if (chon == "Mã phòng")
                {
                    dt = helper.GetDataTable("Select * from DienNuoc where MaPhong like N'%" + tim + "%'");
                }
            }
            return dt;
        }
        public DataTable LayDNTheoMa(string MaPTDN)
        {
            return TimKiem("Mã phiếu thu điện nước", MaPTDN);
        }
    }
 }

