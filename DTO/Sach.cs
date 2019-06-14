using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Sach
    {
        string mas;
        string tieude;
        string tacgia;
        string nhaxb;
        int soluong;
        float giaban;
        public string MaS
        {
            get { return mas; }
            set { mas = value; }
        }
        public string TieuDe
        {
            get { return tieude; }
            set { tieude = value; }
        }
        public string TacGia
        {
            get { return tacgia; }
            set { tacgia = value; }
        }
        public string NhaXB
        {
            get { return nhaxb; }
            set { nhaxb = value; }
        }
        public int SoLuong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        public float GiaBan
        {
            get { return giaban; }
            set { giaban = value; }
        }
        public Sach() { }
        public Sach(string mas, string tieude, string tacgia, string nhaxb, int soluong, float giaban)
        {
            this.MaS = mas;
            this.TieuDe = tieude;
            this.TacGia = tacgia;
            this.NhaXB = nhaxb;
            this.SoLuong = soluong;
            this.GiaBan = giaban;
        }
    }
}
