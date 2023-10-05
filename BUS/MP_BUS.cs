using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;

namespace BUS
{
    public class MP_BUS
    {
        MP_DAL mp = new MP_DAL();
        public DataTable Load_Bus()
        {
            return mp.Load_MaPhong();
        }
        public void Insert_Bus(MaPhong ob)
        {
            mp.Insert_MaPhong(ob);
        }
        public void Update_Bus(MaPhong ob)
        {
            mp.Update_MaPhong(ob);
        }
        public void Delete_Bus(string MaPhong)
        {
            mp.Delete_MaPhong(MaPhong);
        }

    }
}
