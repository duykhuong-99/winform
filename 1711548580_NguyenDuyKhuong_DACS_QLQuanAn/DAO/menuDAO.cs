using _1711548580_NguyenDuyKhuong_DACS_QLQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1711548580_NguyenDuyKhuong_DACS_QLQuanAn.DAO
{
    class menuDAO
    {
        database db = new database();
        HoaDonDAO hd = new HoaDonDAO();
        public DataTable LayDsMonAn()
        {
            string query = "select idmon as N'ID', ten as N'Tên món', dongia as N'Đơn giá' from menu where madanhmuc='mon'";
            DataTable dt = db.Execute(query);
            return dt;
        }
        public int LayMa(string ten)
        {
            string query = string.Format("select idmon from menu where ten = N'{0}'", ten);
            DataTable dt = db.Execute(query);
            if (dt.Rows.Count > 0)
            {
                mamon id = new mamon(dt.Rows[0]);
                return id.ID;
            }
            return -1;
        }
        public DataTable LayDsNuoc()
        {
            string query = "select idmon as N'ID', ten as N'Tên nước', dongia as N'Đơn giá' from menu where madanhmuc='nuoc'";
            DataTable dt = db.Execute(query);
            return dt;
        }
        public DataTable LayCtMenu()
        {
            string query = "select m.idmon as N'Id', dm.tendanhmuc as N'Danh mục', m.ten as N'Tên', m.dongia as N'Đơn giá' from danhmuc dm, menu m where dm.madanhmuc = m .madanhmuc";
            DataTable dt = db.Execute(query);
            return dt;
        }
        public bool ThemMon(string madm, string ten, int dongia)
        {
            string query = string.Format("INSERT INTO MENU(MADANHMUC, TEN, DONGIA) VALUES('{0}', N'{1}', {2})",madm, ten, dongia);
            int result = db.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool XoaMon(int idmon)
        {
            hd.XoaMonTheoID(idmon);
            string query = "delete menu where idmon = "+ idmon;
            int result = db.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool CapNhatMon(int ma,string ten, int donGia)
        {
            string query = string.Format("update menu set ten =N'{0}', dongia = {1} where idmon = {2} and madanhmuc = 'mon'",ten, donGia, ma);
            int result = db.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool CapNhatNuoc(int ma, string ten, int donGia)
        {
            string query = string.Format("update menu set ten =N'{0}', dongia = {1} where idmon = {2} and madanhmuc = 'nuoc'", ten, donGia, ma);
            int result = db.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
