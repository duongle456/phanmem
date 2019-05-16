using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKiTucXa.DataAccessLayer
{
   public class DataAccessHelper
    {
        static string strChuoiKN = @"Data Source=DESKTOP-K0V87BG\SQLEXPRESS;Initial Catalog=QLKITUCXASV;Integrated Security=True";
        SqlDataAdapter sqlAdap;
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        SqlDataReader sqlRa;
        DataTable dt;
       void KetNoi()
        {
            //Phương thức 1:Kết nối
            sqlCon = new SqlConnection(strChuoiKN);
            if (sqlCon.State == System.Data.ConnectionState.Closed)
            {
                sqlCon.Open();
            }
        }
        //Phương thức 2: Ngắt kết nối CSDL
        void NgatKetNoi()
        {
            if (sqlCon.State == System.Data.ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }
        //Phương thức thực thi câu lệnh trong sql(thêm,sửa,xóa)
        public void ThucThiKN(string strSQL)
        {
            KetNoi();
            sqlCom = new SqlCommand(strSQL, sqlCon);
            sqlCom.ExecuteNonQuery();
            NgatKetNoi();

        }
       //Load dữ liệu
        public DataTable GetDataTable(string strSelect)
        {
            KetNoi();
            sqlCom = new SqlCommand(strSelect, sqlCon);
            sqlRa = sqlCom.ExecuteReader();
            dt = new DataTable();
            dt.Load(sqlRa);
            NgatKetNoi();
            return dt;
        }
       //Phương thức kiểm tra mã trùng
        public int DemBanGhi(String strSelect)
        {
            KetNoi();
            sqlCom = new SqlCommand(strSelect, sqlCon);
            int SBG = (int)sqlCom.ExecuteScalar();
            NgatKetNoi();
            return SBG;
        }
        public string Chuanhoaxau(string xau)
        {
            string s = "";
            if (xau != "")
            {
                s = xau.Trim();
                string[] a = s.Split(' ');
                s = "";
                for (int i = 0; i < a.Length; ++i)
                {
                    s = s + " " + a[i].Substring(0, 1).ToUpper() + a[i].Substring(1, a[i].Length - 1).ToLower();
                }
            }
            else
                s = "";
            return s.Trim();
        }
       //Phương thức load dữ liệu vào combobox
        public List<string> DataComBoBox(string strSelect)
        {
            List<string> list = new List<string>();
            KetNoi();
            sqlCom = new SqlCommand(strSelect, sqlCon);
            sqlRa = sqlCom.ExecuteReader();
            while (sqlRa.Read())
            {
                list.Add(sqlRa[0].ToString());
            }
            NgatKetNoi();
            return list;
        }
        public DataTable Layma(string str)
        {
            DataTable dt = new DataTable();
            dt = GetDataTable(str);
            return dt;
        }
    }
}
