using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyKiTucXa.BusinessLogicLayer.Entities
{
    class DoiTuong
    {
         //Cac thanh phan du lieu
        private string MaDT;
        private string TenDT;
        private string MaNV;
        private string GhiChu;
        //Cac thuoc tinh
        public string Madoituong
        {
            get { return MaDT; }
            set { MaDT = value; }
        }
        public string Tendoituong
        {
            get { return TenDT; }
            set { TenDT = value; }
        }
        public string Manhanvien
        {
            get { return MaNV; }
            set { MaNV = value; }
        }
        public string Ghichu
        {
            get { return GhiChu; }
            set { GhiChu = value; }
        }
        //Phuong thuc truyen khong tham so
        public DoiTuong()
        {
            this.MaDT = "";
            this.TenDT = "";
            this.MaNV = "";
            this.GhiChu = "";
        }
        //Phuong thuc truyen co tham so
        public DoiTuong(string MaDT, string TenDT,string MaNV, string GhiChu)
        {
            this.MaDT = MaDT;
            this.TenDT = TenDT;
            this.MaNV = MaNV;
            this.GhiChu = GhiChu;
        }
    }
}
