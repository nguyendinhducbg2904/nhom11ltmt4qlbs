using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_NhanVien                      
    {
        DAL_NhanVien sv1 = new DAL_NhanVien();
        public void Insert(NhanVien sv)
        {
            sv1.Insert(sv);
        }
        public void Update(NhanVien sv)
        {
            sv1.Update(sv);
        }
        public void Delete(NhanVien sv)
        {
            sv1.Delete(sv);
        }
        public DataTable Load2(string sql)
        {
            return sv1.Load1(sql);
        }
    }
}
