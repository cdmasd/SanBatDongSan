using DAL_QuanLyBDS;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLyBDS
{
    public class PhanTrang
    {
        private DAL_QuanLyBDS.PhanTrang DAL_PhanTrang;

        public PhanTrang()
        {
            DAL_PhanTrang = new DAL_QuanLyBDS.PhanTrang();
        }

        public long GetTotalRecordsDangTinChuaDuyet()
        {
            return DAL_PhanTrang.GetTotalRecordsDangTinChuaDuyet();
        }

        public DataTable GetDataPageDangTinChuaDuyet(int page, int pageSize)
        {
            return DAL_PhanTrang.GetDataPageDangTinChuaDuyet(page, pageSize);
        }
    }
}
