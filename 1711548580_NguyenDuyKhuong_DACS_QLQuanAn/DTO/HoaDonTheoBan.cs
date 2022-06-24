using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1711548580_NguyenDuyKhuong_DACS_QLQuanAn.DTO
{
    class HoaDonTheoBan
    {
        
        private string ten;

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        private int donGia;

        public int DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
        private int tongTien;

        public int TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }

        public HoaDonTheoBan(string ten, int soluong, int dongia, int tongtien)
        {
            this.Ten = ten;
            this.SoLuong = soluong;
            this.DonGia = dongia;
            this.TongTien = tongtien;
        }
        public HoaDonTheoBan(DataRow row)
        {
            this.Ten = row["ten"].ToString();
            this.SoLuong = (int)row["soluong"];
            this.DonGia = (int)row["dongia"];
            this.TongTien = (int)row["tongtien"];
        }
    }
}
