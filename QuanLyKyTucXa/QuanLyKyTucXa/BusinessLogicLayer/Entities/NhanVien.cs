using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyKiTucXa.BusinessLogicLayer.Entities
{
    class NhanVien
    {
        //Cac thanh phan du lieu
        private string MaNV;
        private string TenNV;
        private string GioiTinh;
        private string NgaySinh;
        private string QueQuan;
        private string ChucVu;
        private string SoDienThoai;
        private string NgayVaoLam;
        private int LuongCoBan;
        private double HeSoLuong;
        private int HeSoPhuCap;
        private double Luong;
        //Cac thuoc tinh
        public string Manhanvien
        {
            get { return MaNV; }
            set { MaNV = value; }
        }
        public string Tennhanvien
        {
            get { return TenNV; }
            set { TenNV = value; }
        }
        public string Gioitinh
        {
            get { return GioiTinh; }
            set { GioiTinh = value; }
        }

        public string Ngaysinh
        {
            get { return NgaySinh; }
            set { NgaySinh = value; }
        }

        public string Quequan
        {
            get { return QueQuan; }
            set { QueQuan = value; }
        }

        public string Chuvu
        {
            get { return ChucVu; }
            set { ChucVu = value; }
        }
        public string Sodienthoai
        {
            get { return SoDienThoai; }
            set { SoDienThoai = value; }
        }
        public string Ngayvaolam
        {
            get { return NgayVaoLam; }
            set { NgayVaoLam = value; }
        }
        public int Luongcoban
        {
            get { return LuongCoBan; }
            set { LuongCoBan = value; }
        }
        public double  Hesoluong
        {
            get { return HeSoLuong; }
            set { HeSoLuong = value; }
        }
        public int Hesophucap
        {
            get { return HeSoPhuCap; }
            set { HeSoPhuCap = value; }
        }
        public double luong
        {
            get { return Luong; }
            set { Luong = value; }
        }
        //Phuong thuc truyen khong tham so
        public NhanVien()
        {
            this.MaNV = "";
            this.TenNV = "";
            this.GioiTinh = "";
            this.NgaySinh = "";
            this.QueQuan = "";
            this.ChucVu = "";
            this.SoDienThoai = "";
            this.NgayVaoLam = "";
            this.LuongCoBan = 0;
            this.HeSoLuong = 0;
            this.HeSoPhuCap = 0;
            this.Luong = 0;
        }
        //Phuong thuc truyen co tham so
        public NhanVien(string MaNV, string TenNV, string GioiTinh, string NgaySinh, string QueQuan, string ChucVu, string SoDienThoai,string NgayVaoLam,int lcb,double hsl,int pc,double luong)
        {
            this.MaNV = MaNV;
            this.TenNV = TenNV;
            this.GioiTinh = GioiTinh;
            this.NgaySinh = NgaySinh;
            this.QueQuan = QueQuan;
            this.ChucVu = ChucVu;
            this.SoDienThoai = SoDienThoai;
            this.NgayVaoLam = NgayVaoLam;
            this.LuongCoBan = lcb;
            this.HeSoLuong = hsl;
            this.HeSoPhuCap = pc;
            this.Luong = luong;
        }
    }
}
