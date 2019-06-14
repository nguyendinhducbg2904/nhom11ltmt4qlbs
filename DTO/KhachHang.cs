using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang
    {
        string makh;
        string tenkh;
        int dienthoai;
        string diachi;
        string tinhtrang;
        public string MaKH
        {
            get { return makh; }
            set { makh = value; }
        }
        public string TenKH
        {
            get { return tenkh; }
            set { tenkh = value; }
        }
        public int DienThoai
        {
            get { return dienthoai; }
            set { dienthoai = value; }
        }
        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public string TinhTrang
        {
            get { return tinhtrang; }
            set { tinhtrang = value; }
        }
        public KhachHang() { }
        public KhachHang(string makh, string tenkh, int dienthoai, string diachi, string tinhtrang)
        {
            this.MaKH = makh;
            this.TenKH = tenkh;
            this.DienThoai = dienthoai;
            this.DiaChi = diachi;
            this.TinhTrang = tinhtrang;
        }
    }
}
