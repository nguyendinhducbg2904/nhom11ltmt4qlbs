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
    public class BUS_HoaDon             
    {
        DAL_HoaDon hd1 = new DAL_HoaDon();
        public void Insert(HoaDon hd)
        {
            hd1.Insert(hd);
        }
        public void Update(HoaDon hd)
        {
            hd1.Update(hd);
        }
        public void Delete(HoaDon hd)
        {
            hd1.Delete(hd);
        }
        public DataTable Load2(string sql)
        {
            return hd1.Load1(sql);
        }
    }
}
