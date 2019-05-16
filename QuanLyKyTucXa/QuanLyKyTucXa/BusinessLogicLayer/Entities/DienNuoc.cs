using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyKiTucXa.BusinessLogicLayer.Entities
{
    class DienNuoc
    {
         //Cac thanh phan du lieu
        private string MaPTDN;
        private string MaPhong;
        private int SoDienTruoc;
        private int SoNuocTruoc;
        private int SoDien;
        private int SoNuoc;
        private double DonGiaDien;
        private double DonGiaNuoc;
        private double TienDien;
        private double TienNuoc;
        private string ThangThu;
        private string MaSV;
        private string MaNV;
        private string GhiChu;
        //Cac thuoc tinh
        public string Maptdn
        {
            get { return MaPTDN; }
            set { MaPTDN = value; }
        }
        public string Maphong
        {
            get { return MaPhong; }
            set { MaPhong = value; }
        }
        public int Sodientruoc
        {
            get { return SoDienTruoc; }
            set { SoDienTruoc = value; }
        }
        public int Sonuoctruoc
        {
            get { return SoNuocTruoc; }
            set { SoNuocTruoc = value; }
        }
        public int Sodien
        {
            get { return SoDien; }
            set { SoDien = value; }
        }
        public int Sonuoc
        {
            get { return SoNuoc; }
            set { SoNuoc = value; }
        }
        public double Dongiadien
        {
            get { return DonGiaDien; }
            set { DonGiaDien = value; }
        }
        public double Dongianuoc
        {
            get { return DonGiaNuoc; }
            set { DonGiaNuoc = value; }
        }
        public double Tiendien
        {
            get { return TienDien; }
            set { TienDien = value; }
        }
        public double Tiennuoc
        {
            get { return TienNuoc; }
            set { TienNuoc = value; }
        }
        public string Thangthu
        {
            get { return ThangThu; }
            set { ThangThu = value; }
        }

        public string Masinhvien
        {
            get { return MaSV; }
            set { MaSV = value; }
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
        public DienNuoc()
        {
            this.MaPTDN = "";
            this.MaPhong = "";
            this.SoDienTruoc=0;
            this.SoNuocTruoc=0;
            this.SoDien=0;
            this.SoNuoc=0;
            this.DonGiaDien=0;
            this.DonGiaNuoc=0;
            this.TienDien = 0;
            this.TienNuoc = 0;
            this.ThangThu="";
            this.MaSV = "";
            this.MaNV = "";
            this.GhiChu = "";
        }
        //Phuong thuc truyen co tham so
        public DienNuoc(string MaPTDN, string MaPhong,int sodientruoc,int sonuoctruoc,int sodien,int sonuoc,double dongiadien,double dongianuoc,double tiendien,double tiennuoc, string ThangThu,string MaSV,string MaNV,string GhiChu)
        {
            this.MaSV = MaSV;
            this.MaPhong= MaPhong;
            this.SoDienTruoc = sodientruoc;
            this.SoNuocTruoc = sonuoctruoc;
            this.SoDien = sodien;
            this.SoNuoc = sonuoc;
            this.DonGiaDien = dongiadien;
            this.DonGiaNuoc = dongianuoc;
            this.TienDien = tiendien;
            this.TienNuoc = tiennuoc;
            this.ThangThu = ThangThu;
            this.MaSV=MaSV;
            this.MaNV=MaNV;
            this.GhiChu = GhiChu;
        }
    }
 }

