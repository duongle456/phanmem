using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyKiTucXa.BusinessLogicLayer.Entities
{
    class TaiSan
    {
        //Cac thanh phan du lieu
        private string MaTS;
        private string TenTS;
        private string MaPhong;
        private string SoLuong;
        private string MaNV;
        private string HienTrang;
        //Cac thuoc tinh
        public string Mantaisan
        {
            get { return MaTS; }
            set { MaTS = value; }
        }
        public string Tentaisan
        {
            get { return TenTS; }
            set { TenTS = value; }
        }
        public string Maphong
        {
            get { return MaPhong; }
            set { MaPhong = value; }
        }

        public string Soluong
        {
            get { return SoLuong; }
            set { SoLuong = value; }
        }

        public string Manhanvien
        {
            get { return MaNV; }
            set { MaNV = value; }
        }

        public string Hientrang
        {
            get { return HienTrang; }
            set { HienTrang = value; }
        }
        //Phuong thuc truyen khong tham so
        public TaiSan()
        {
            this.MaTS = "";
            this.TenTS = "";
            this.MaPhong = "";
            this.SoLuong = "";
            this.MaNV = "";
            this.HienTrang = "";
        }
        //Phuong thuc truyen co tham so
        public TaiSan(string MaTS, string TenTS, string MaPhong, string SoLuong, string MaNV, string HienTrang)
        {
            this.MaTS = MaTS;
            this.TenTS = TenTS;
            this.MaPhong = MaPhong;
            this.SoLuong = SoLuong;
            this.MaNV = MaNV;
            this.HienTrang = HienTrang;
        }
    }
}
