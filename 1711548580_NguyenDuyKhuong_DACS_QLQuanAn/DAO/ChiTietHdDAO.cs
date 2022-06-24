using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1711548580_NguyenDuyKhuong_DACS_QLQuanAn.DAO
{
    class ChiTietHdDAO
    {
        database db = new database();
        // thêm vào bàn đã có ng món đã có
        public void ThemMon(int mahd, int mamon, int soluong)
        {
            string query = string.Format("exec themmon {0}, {1}, {2} ", mahd, mamon, soluong);
            db.ExecuteNonQuery(query);
        }
    }
}
