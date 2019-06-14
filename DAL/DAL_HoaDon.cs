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
    public class DAL_HoaDon : DBConnect
    {
        public DataTable Load1(string sql)
        {
            return Load(sql);
        }
        public void Insert(HoaDon hd1)
        {
            string sql = "Insert Into HoaDon Values('" + hd1.SoHD + "','" + hd1.NgayMua + "','" + hd1.NgayHetHanBaoHanh + "','" + hd1.MaS + "','" + hd1.MaKH + "','" + hd1.MaNV + "', '" + hd1.MucGiamGia + "','" + hd1.GiaBan + "','" + hd1.SoLuong + "')";
            SqlDataAdapter da = new SqlDataAdapter(sql, _cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
        }
        public void Update(HoaDon hd1)
        {
            string sql = "Update Sach Set NgayMua = '" + hd1.NgayMua + "', NgayHetHanBaoHanh = '" + hd1.NgayHetHanBaoHanh + "', MaS = '" + hd1.MaS + "',MaKH = '" + hd1.MaKH + "', MaNV = '" + hd1.MaNV + "', MucGiamGia = '" + hd1.MucGiamGia + "',GiaBan = '" + hd1.GiaBan + "', SoLuong = '" + hd1.SoLuong + "' Where SoHD='" + hd1.SoHD + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, _cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
        }
        public void Delete(HoaDon hd1)
        {
            string sql = "Delete From HoaDon Where SoHD='" + hd1.SoHD + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, _cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
        }
    }
}
