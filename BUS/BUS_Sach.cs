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
    public class BUS_Sach
    {
        DAL_Sach sa = new DAL_Sach();
        public void Insert(Sach s)
        {
            sa.Insert(s);
        }
        public void Update(Sach s)
        {
            sa.Update(s);
        }
        public void Delete(Sach s)
        {
            sa.Delete(s);
        }
        public DataTable Load2(string sql)
        {
            return sa.Load1(sql);
        }
    }
}
