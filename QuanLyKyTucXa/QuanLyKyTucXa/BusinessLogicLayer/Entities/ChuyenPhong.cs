using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyKiTucXa.BusinessLogicLayer.Entities
{
    class ChuyenPhong
    {
         //Cac thanh phan du lieu
        private string MaPC;
        private string MaSV;
        private string MaPhongCu;
        private string MaPhongMoi;
        private string LoaiPhong;
        private string NgayChuyen;
        private string MaNV;
        private string GhiChu;
        //Cac thuoc tinh
        public string Maphieuchuyen
        {
            get { return MaPC; }
            set { MaPC = value; }
        }
        public string Masinhvien
        {
            get { return MaSV; }
            set { MaSV = value; }
        }
        public string Maphongcu
        {
            get { return MaPhongCu; }
            set { MaPhongCu = value; }
        }

        public string Maphongmoi
        {
            get { return MaPhongMoi; }
            set { MaPhongMoi = value; }
        }

        public string Loaiphong
        {
            get { return LoaiPhong; }
            set { LoaiPhong = value; }
        }

        public string Ngaychuyen
        {
            get { return NgayChuyen;}
            set { NgayChuyen = value; }
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
        public ChuyenPhong()
        {
            this.MaPC = "";
            this.MaSV = "";
            this.MaPhongCu = "";
            this.MaPhongMoi = "";
            this.LoaiPhong = "";
            this.NgayChuyen = "";
            this.MaNV = "";
            this.GhiChu = "";
        }
        //Phuong thuc truyen co tham so
        public ChuyenPhong(string MaPC, string MaSV, string MaPhongCu, string MaPhongMoi, string LoaiPhong,string NgayChuyen, string MaNV, string GhiChu)
        {
            this.MaNV = MaNV;
            this.MaSV = MaSV;
            this.MaPhongCu = MaPhongCu;
            this.MaPhongMoi = MaPhongMoi;
            this.LoaiPhong =LoaiPhong;
            this.NgayChuyen = NgayChuyen;
            this.MaNV = MaNV;
            this.GhiChu = GhiChu;
        }
    }
}
