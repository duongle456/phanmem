using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLyKiTucXa.DataAccessLayer
{
    class DangNhapDAL
    {
        DataAccessHelper dt = new DataAccessHelper();
        public DataTable Taikhoan(string TK, string MK, string QH)
        {
            DataTable Us = new DataTable();
            Us = dt.GetDataTable("Select QuyenHan from DangNhap where TenDN=N'" + TK + "' and MatKhau=N'" + MK + "' and QuyenHan=N'" + QH + "'");
            return Us;
        }
    }
}
