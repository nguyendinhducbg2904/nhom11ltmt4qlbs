using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        string sohd;
        DateTime ngaymua;
        DateTime ngayhethanbaohanh;
        string mas;
        string makh;
        string manv;
        float mucgiamgia;
        float giaban;
        int soluong;
        public string SoHD
        {
            get { return sohd; }
            set { sohd = value; }
        }
        public DateTime NgayMua
        {
            get { return ngaymua; }
            set { ngaymua = value; }
        }
        public DateTime NgayHetHanBaoHanh
        {
            get { return ngayhethanbaohanh; }
            set { ngayhethanbaohanh = value; }
        }
        public string MaS
        {
            get { return mas; }
            set { mas = value; }
        }
        public string MaKH
        {
            get { return makh; }
            set { makh = value; }
        }
        public string MaNV
        {
            get { return manv; }
            set { manv = value; }
        }
        public float MucGiamGia
        {
            get { return mucgiamgia; }
            set { mucgiamgia = value; }
        }
        public float GiaBan
        {
            get { return giaban; }
            set { giaban = value; }
        }
        public int SoLuong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        public HoaDon() { }
        public HoaDon(string sohd, DateTime ngaymua, DateTime ngayhethanbaohanh,
            string mas, string makh, string manv, float mucgiamgia, float giaban, int soluong)
        {
            this.SoHD = sohd;
            this.NgayMua = ngaymua;
            this.NgayHetHanBaoHanh = ngayhethanbaohanh;
            this.mas = mas;
            this.MaKH = makh;
            this.MaNV = manv;
            this.GiaBan = giaban;
            this.SoLuong = soluong;
        }
    }
}
