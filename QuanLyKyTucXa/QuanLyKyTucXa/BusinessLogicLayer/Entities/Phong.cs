using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyKiTucXa.BusinessLogicLayer.Entities
{
    class Phong
    {
        //Cac thanh phan du lieu
        private string MaPhong;
        private string TenPhong;
        private string MaTN;
        private string LoaiPhong;
        private string SoLuongNguoi;
        private string TinhTrang;
        //Cac thuoc tinh
        public string Manphong
        {
            get { return MaPhong; }
            set { MaPhong = value; }
        }
        public string Tenphong
        {
            get { return TenPhong; }
            set { TenPhong = value; }
        }
        public string Matoanha
        {
            get { return MaTN; }
            set { MaTN = value; }
        }

        public string Loaiphong
        {
            get { return LoaiPhong; }
            set { LoaiPhong = value; }
        }

        public string Soluongnguoi
        {
            get { return SoLuongNguoi; }
            set { SoLuongNguoi = value; }
        }

        public string Tinhtrang
        {
            get { return TinhTrang; }
            set { TinhTrang = value; }
        }
        //Phuong thuc truyen khong tham so
        public Phong()
        {
            this.MaPhong = "";
            this.TenPhong = "";
            this.MaTN = "";
            this.LoaiPhong = "";
            this.SoLuongNguoi = "";
            this.TinhTrang = "";
        }
        //Phuong thuc truyen co tham so
        public Phong(string MaPhong, string TenPhong, string MaTN, string LoaiPhong, string SoLuongNguoi, string TinhTrang)
        {
            this.MaPhong = MaPhong;
            this.TenPhong = TenPhong;
            this.MaTN= MaTN;
            this.LoaiPhong = LoaiPhong;
            this.SoLuongNguoi = SoLuongNguoi;
            this.TinhTrang = TinhTrang;
        }
    }
}
