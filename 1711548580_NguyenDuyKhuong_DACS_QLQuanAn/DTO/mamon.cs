using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1711548580_NguyenDuyKhuong_DACS_QLQuanAn.DTO
{
    class mamon
    {
        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        public mamon(int id)
        {
            this.ID = id;
        }
        public mamon(DataRow row)
        {
            this.ID = (int)row["idmon"];
        }
    }
}
