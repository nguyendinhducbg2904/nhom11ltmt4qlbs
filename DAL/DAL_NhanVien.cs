using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_NhanVien : DBConnect
    {
        public DataTable Load1(string sql)
        {
            return Load(sql);
        }
        public void Insert(NhanVien nv1)
        {
            string sql = "Insert Into NhanVien Values('" + nv1.MaNV + "',N'" + nv1.TenNV + "','" + nv1.NgaySinh + "',N'" + nv1.NgayLamViec + "',N'" + nv1.DiaChi + "','" + nv1.DienThoai + "','" + nv1.LuongCoBan + "','" + nv1.PhuCap + "')";
            SqlDataAdapter da = new SqlDataAdapter(sql, _cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
        }
        public void Update(NhanVien nv1)
        {
            string sql = "Update NhanVien Set TenNV = N'" + nv1.TenNV + "',NgaySinh = '" + nv1.NgaySinh + "',NgayLamViec = '" + nv1.NgayLamViec + "',DiaChi = N'" + nv1.DiaChi + "',DienThoai = '" + nv1.DienThoai + "',LuongCoBan = '" + nv1.LuongCoBan + "',PhuCap = '" + nv1.PhuCap + "' Where MaNV='" + nv1.MaNV + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, _cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
        }
        public void Delete(NhanVien nv1)
        {
            string sql = "Delete From NhanVien Where MaNV = '" + nv1.MaNV + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, _cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
        }
    }
}
