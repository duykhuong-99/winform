using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1711548580_NguyenDuyKhuong_DACS_QLQuanAn.DTO
{
    class DanhSachBan
    {
        public DanhSachBan(int id, string name, string status)
        {
            this.ID = id;
            this.Name = name;
            this.Status = status;
        }
        public DanhSachBan(DataRow row)
        {
            this.ID = (int)row["idban"];
            this.Name = row["tenban"].ToString();
            this.Status = row["trangthai"].ToString();
        }
        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

       
    }
}
