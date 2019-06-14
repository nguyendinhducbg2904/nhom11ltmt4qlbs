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
    public class BUS_KhachHang
    {
        DAL_KhachHang kh1 = new DAL_KhachHang();
        public void Insert(KhachHang kh)
        {
            kh1.Insert(kh);
        }
        public void Update(KhachHang kh)
        {
            kh1.Update(kh);
        }
        public void Delete(KhachHang kh)
        {
            kh1.Delete(kh);
        }
        public DataTable Load2(string sql)
        {
            return kh1.Load1(sql);
        }
    }
}
