using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyKiTucXa.BusinessLogicLayer.Entities
{
    class HopDongSVPhong
    {
        //Cac thanh phan du lieu
        private string MaHD;
        private string MaSV;
        private string MaPhong;
        private string NgayVao;
        private string NgayRa;
        private string NgayLap;
        private string MaNV;
        private string GhiChu;
        //Cac thuoc tinh
        public string Mahopdong
        {
            get { return MaHD; }
            set { MaHD = value; }
        }
        public string Masinhvien
        {
            get { return MaSV; }
            set { MaSV = value; }
        }
        public string Maphong
        {
            get { return MaPhong; }
            set { MaPhong = value; }
        }

        public string Ngayvao
        {
            get { return NgayVao; }
            set { NgayVao = value; }
        }

        public string Ngayra
        {
            get { return NgayRa; }
            set { NgayRa = value; }
        }

        public string Ngaylap
        {
            get { return NgayLap; }
            set { NgayLap = value; }
        }
        public string Manhanvien
        {
            get { return MaNV; }
            set {MaNV = value; }
        }
         public string Ghichu
        {
            get { return GhiChu; }
            set {GhiChu = value; }
        }
        //Phuong thuc truyen khong tham so
        public HopDongSVPhong()
        {
            this.MaHD = "";
            this.MaSV = "";
            this.MaPhong = "";
            this.NgayVao = "";
            this.NgayRa = "";
            this.NgayLap = "";
            this.MaNV = "";
            this.GhiChu = "";
        }
        //Phuong thuc truyen co tham so
        public HopDongSVPhong(string MaHD, string MaSV, string MaPhong, string NgayVao, string NgayRa, string NgayLap, string MaNV,string GhiChu)
        {
            this.MaHD = MaHD;
            this.MaSV = MaSV;
            this.MaPhong = MaPhong;
            this.NgayVao = NgayVao;
            this.NgayRa = NgayRa;
            this.NgayLap = NgayLap;
            this.MaNV = MaNV;
            this.GhiChu = GhiChu;
        }
    }
}

