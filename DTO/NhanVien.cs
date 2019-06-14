using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        string manv;
        string tennv;
        DateTime ngaysinh;
        DateTime ngaylamviec;
        string diachi;
        int dienthoai;
        float luongcoban;
        float phucap;
        public string MaNV
        {
            get { return manv; }
            set { manv = value; }
        }
        public string TenNV
        {
            get { return tennv; }
            set { tennv = value; }
        }
        public DateTime NgaySinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        public DateTime NgayLamViec
        {
            get { return ngaylamviec; }
            set { ngaylamviec = value; }
        }
        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public int DienThoai
        {
            get { return dienthoai; }
            set { dienthoai = value; }
        }
        public float LuongCoBan
        {
            get { return luongcoban; }
            set { luongcoban = value; }
        }
        public float PhuCap
        {
            get { return phucap; }
            set { phucap = value; }
        }
        public NhanVien() { }
        public NhanVien(string manv, string tennv, DateTime ngaysinh, DateTime ngaylamviec, string diachi, int dienthoai, float luongcoban, float phucap)
        {
            this.MaNV = manv;
            this.TenNV = tennv;
            this.NgaySinh = ngaysinh;
            this.NgayLamViec = ngaylamviec;
            this.DiaChi = diachi;
            this.DienThoai = dienthoai;
            this.LuongCoBan = luongcoban;
            this.PhuCap = phucap;
        }
    }
}
