using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1711548580_NguyenDuyKhuong_DACS_QLQuanAn.DTO
{
    class idHoaDon
    {
        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        public idHoaDon(int id)
        {
            this.ID = id;
        }
        public idHoaDon(DataRow row)
        {
            this.ID = (int)row["idhoadon"];
        }
    }
}
