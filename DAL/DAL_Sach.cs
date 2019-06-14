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
    public class DAL_Sach : DBConnect
    {
        public DataTable Load1(string sql)
        {
            return Load(sql);
        }
        public void Insert(Sach s1)
        {
            string sql = "Insert Into Sach Values('" + s1.MaS + "',N'" + s1.TieuDe + "',N'" + s1.TacGia + "',N'" + s1.NhaXB + "','" + s1.SoLuong + "','" + s1.GiaBan + "')";
            SqlDataAdapter da = new SqlDataAdapter(sql, _cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
        }
        public void Update(Sach s1)
        {
            string sql = "Update Sach Set TieuDe = N'" + s1.TieuDe + "', TacGia = N'" + s1.TacGia + "',NhaXB = N'" + s1.NhaXB + "',SoLuong = '" + s1.SoLuong + "',GiaBan = '" + s1.GiaBan + "' Where MaS='" + s1.MaS + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, _cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
        }
        public void Delete(Sach s1)
        {
            string sql = "Delete From Sach Where MaS='" + s1.MaS + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, _cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
        }
    }
}
