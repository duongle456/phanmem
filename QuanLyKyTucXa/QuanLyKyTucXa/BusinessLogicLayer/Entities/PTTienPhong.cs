using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyKiTucXa.BusinessLogicLayer.Entities
{
    class PTTienPhong
    {
        //Cac thanh phan du lieu
        private string MaPT;
        private string MaPhong;
        private string TienPhong;
        private string ThangThu;
        private string MaSV;
        private string MaNV;
        private string GhiChu;
        //Cac thuoc tinh
        public string Manphieuthu
        {
            get { return MaPT; }
            set { MaPT = value; }
        }
        public string Maphong
        {
            get { return MaPhong; }
            set { MaPhong = value; }
        }
        public string Tienphong
        {
            get { return TienPhong; }
            set { TienPhong = value; }
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
        public PTTienPhong()
        {
            this.MaPT = "";
            this.MaPhong = "";
            this.TienPhong= "";
            this.ThangThu = "";
            this.MaSV = "";
            this.MaNV = "";
            this.GhiChu="";
        }
        //Phuong thuc truyen co tham so
        public PTTienPhong(string MaPT, string MaPhong, string TienPhong, string ThangThu, string MaSV, string MaNV,string GhiChu)
        {
            this.MaPT=MaPT;
            this.MaPhong = MaPhong;
            this.TienPhong = TienPhong;
            this.ThangThu= ThangThu;
            this.MaSV = MaSV;
            this.MaNV = MaNV;
            this.GhiChu = GhiChu;
        }
    }
 }

