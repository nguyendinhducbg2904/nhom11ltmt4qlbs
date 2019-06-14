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
    public class DAL_KhachHang : DBConnect
    {
        public DataTable Load1(string sql)
        {
            return Load(sql);
        }
        public void Insert(KhachHang kh1)
        {
            string sql = "Insert Into KhachHang Values('" + kh1.MaKH + "',N'" + kh1.TenKH + "','" + kh1.DienThoai + "',N'" + kh1.DiaChi + "',N'" + kh1.TinhTrang + "')";
            SqlDataAdapter da = new SqlDataAdapter(sql, _cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
        }
        public void Update(KhachHang kh1)
        {
            string sql = "Update KhachHang Set TenKH = N'" + kh1.TenKH + "',DienThoai = '" + kh1.DienThoai + "',DiaChi = N'" + kh1.DiaChi + "',TinhTrang = N'" + kh1.TinhTrang + "'  Where MaKH='" + kh1.MaKH + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, _cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
        }
        public void Delete(KhachHang kh1)
        {
            string sql = "Delete From KhachHang Where MaKH='" + kh1.MaKH + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, _cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
        }
    }
}
