using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyKiTucXa.BusinessLogicLayer.Entities
{
    class ToaNha
    {
        //Cac thanh phan du lieu
        private string MaTN;
        private string TenTN;
        private string SoPhong;
        private string TienPhong;
        private string MaNV;
        private string GhiChu;
        //Cac thuoc tinh
        public string Mantoanha
        {
            get { return MaTN; }
            set { MaTN = value; }
        }
        public string Tentoanha
        {
            get { return TenTN; }
            set { TenTN = value; }
        }
        public string Sophong
        {
            get { return SoPhong; }
            set { SoPhong = value; }
        }

        public string Tienphong
        {
            get { return TienPhong; }
            set { TienPhong = value; }
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
        public ToaNha()
        {
            this.MaTN = "";
            this.TenTN = "";
            this.SoPhong = "";
            this.TienPhong = "";
            this.MaNV = "";
            this.GhiChu = "";
        }
        //Phuong thuc truyen co tham so
        public ToaNha(string MaTN, string TenTN, string SoPhong, string TienPhong, string MaNV, string GhiChu)
        {
            this.MaTN = MaTN;
            this.TenTN = TenTN;
            this.SoPhong = SoPhong;
            this.TienPhong = TienPhong;
            this.MaNV = MaNV;
            this.GhiChu = GhiChu;
        }
    }
}
