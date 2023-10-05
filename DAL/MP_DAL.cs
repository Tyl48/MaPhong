using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MP_DAL:Connect
    {
        public DataTable Load_MaPhong()
        {
            return Load_DL("select * from Ma_Phong ");
        }
        public void Insert_MaPhong(MaPhong ob)
        {
            string sql = "insert into Ma_phong values('" +
                ob.Ma_phong + "','" + ob.Ten_phong + "','"+ ob.Ten_truong_phong +"')";
            Excecute(sql);

        }
        public void Update_MaPhong(MaPhong ob)
        {
            string sql = "update Ma_phong set Ten_phong ='" + ob.Ten_phong + "', Ten_truong_phuong ='" + ob.Ten_truong_phong + "' " +
                "where Ma_phong ='" + ob.Ma_phong + "'";
            Excecute(sql);

        }
        public void Delete_MaPhong(string Ma_phong)
        {
            string sql = "delete from Ma_phong where Ma_phong ='" + Ma_phong + "'";
            Excecute(sql);

        }

    }
}
