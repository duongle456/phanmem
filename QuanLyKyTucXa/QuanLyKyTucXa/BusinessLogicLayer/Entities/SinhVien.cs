using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyKiTucXa.BusinessLogicLayer.Entities
{
    class SinhVien
    {
        //Cac thanh phan du lieu
        private string MaSV;
        private string TenSV;
        private string NgaySinh;
        private string GioiTinh;
        private string QueQuan;
        private string MaDT;
        private string MaPhong;
        private string SoCMTND;
        private string GhiChu;
        //Cac thuoc tinh
        public string Masinhvien
        {
            get { return MaSV; }
            set { MaSV = value; }
        }
        public string Tensinhvien
        {
            get { return TenSV; }
            set { TenSV = value; }
        }
        public string Ngaysinh
        {
            get { return NgaySinh; }
            set { NgaySinh = value; }
        }

        public string Gioitinh
        {
            get { return GioiTinh; }
            set { GioiTinh = value; }
        }

        public string Quequan
        {
            get { return QueQuan; }
            set { QueQuan = value; }
        }

        public string Madoituong
        {
            get { return MaDT; }
            set { MaDT = value; }
        }
        public string Maphong
        {
            get { return MaPhong; }
            set { MaPhong = value; }
        }
        public string Socmtnd
        {
            get { return SoCMTND; }
            set { SoCMTND = value; }
        }
        public string Ghichu
        {
            get { return GhiChu; }
            set { GhiChu = value; }
        }
        //Phuong thuc truyen khong tham so
        public SinhVien()
        {
            this.MaSV = "";
            this.TenSV = "";
            this.NgaySinh = "";
            this.GioiTinh = "";
            this.QueQuan = "";
            this.MaDT = "";
            this.MaPhong = "";
            this.SoCMTND = "";
            this.GhiChu = "";
        }
        //Phuong thuc truyen co tham so
        public SinhVien(string MaSV, string TenSV, string NgaySinh, string GioiTinh, string QueQuan, string MaDT, string MaPhong, string SoCMTND, string GhiChu)
        {
            this.MaSV = MaSV;
            this.TenSV = TenSV;
            this.NgaySinh = NgaySinh;
            this.GioiTinh = GioiTinh;
            this.QueQuan = QueQuan;
            this.MaDT = MaDT;
            this.MaPhong = MaPhong;
            this.SoCMTND = SoCMTND;
            this.GhiChu = GhiChu;
        }
    }
}
