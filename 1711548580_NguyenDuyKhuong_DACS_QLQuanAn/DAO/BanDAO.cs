using _1711548580_NguyenDuyKhuong_DACS_QLQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _1711548580_NguyenDuyKhuong_DACS_QLQuanAn.DAO
{
    class BanDAO
    {
        database db = new database();
        //Lấy danh sách bàn
        public List<DanhSachBan> loadDSB()
        {
            List<DanhSachBan> table = new List<DanhSachBan>();
            string query = "select * from ban";
            DataTable data = db.Execute(query);
            foreach (DataRow item in data.Rows)
            {
                DanhSachBan dsb = new DanhSachBan(item);
                table.Add(dsb);
            }
            return table;
        }
        public bool datBan(int idBan)
        {
            string query = "update ban set trangthai = N'Đã đặt' where idban = " + idBan;
            int result = db.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool huyDat(int idBan)
        {
            string query = "update ban set trangthai = N'Trống' where idban = " + idBan;
            int result = db.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
