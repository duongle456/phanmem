using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyKiTucXa.BusinessLogicLayer.Entities
{
    class KhenThuongKyLuat
    {
         //Cac thanh phan du lieu
        private string MaPH;
        private string TenPhieu;
        private string MaSV;
        private string NoiDung;
        private string HinhThuc;
        private string NgayLap;
        private string MaNV;
        private string GhiChu;
        //Cac thuoc tinh
        public string Manphieu
        {
            get { return MaPH; }
            set { MaPH = value; }
        }
        public string Tenphieu
        {
            get { return TenPhieu; }
            set { TenPhieu = value; }
        }
        public string Masinhvien
        {
            get { return MaSV; }
            set { MaSV = value; }
        }

        public string Noidung
        {
            get { return NoiDung; }
            set { NoiDung = value; }
        }

        public string Hinhthuc
        {
            get { return HinhThuc; }
            set { HinhThuc = value; }
        }
        public string Ngaylap
        {
            get { return NgayLap; }
            set { NgayLap = value; }
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
        public KhenThuongKyLuat()
        {
            this.MaPH = "";
            this.TenPhieu = "";
            this.MaSV= "";
            this.NoiDung = "";
            this.HinhThuc = "";
            this.NgayLap="";
            this.MaNV = "";
            this.GhiChu="";
        }
        //Phuong thuc truyen co tham so
        public KhenThuongKyLuat(string MaPH, string TenPhieu, string MaSV, string NoiDung, string HinhThuc, string NgayLap, string MaNV, string GhiChu)
        {
            this.MaPH=MaPH;
            this.TenPhieu = TenPhieu;
            this.MaSV = MaSV;
            this.NoiDung= NoiDung;
            this.HinhThuc =HinhThuc;
            this.NgayLap = NgayLap;
            this.MaNV = MaNV;
            this.GhiChu = GhiChu;
        }
    }
}
