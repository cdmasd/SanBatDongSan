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

        public long GetTotalRecordsDangTinDaDuyet()
        {
            return DAL_PhanTrang.GetTotalRecordsDangTinDaDuyet();
        }

        public DataTable GetDataPageDangTinDaDuyet(int page, int pageSize)
        {
            return DAL_PhanTrang.GetDataPageDangTinDaDuyet(page, pageSize);
        }

        public long GetTotalRecordNhanVien()
        {
            return DAL_PhanTrang.GetTotalRecordNhanVien();
        }

        public DataTable GetDataPageNhanVien(int page, int pageSize)
        {
            return DAL_PhanTrang.GetDataPageNhanVien(page, pageSize);
        }

        public long GetTotalRecordsTicketChuaDuyet()
        {
            return DAL_PhanTrang.GetTotalRecordsTicketChuaDuyet();
        }

        public DataTable GetDataPageTicketChuaDuyet(int page, int pageSize)
        {
            return DAL_PhanTrang.GetDataPageTicketChuaDuyet(page, pageSize);
        }

        public long GetTotalRecordsKhachHang()
        {
            return DAL_PhanTrang.GetTotalRecordsKhachHang();
        }

        public DataTable GetDataPageKhachHang(int page, int pageSize)
        {
            return DAL_PhanTrang.GetDataPageKhachHang(page, pageSize);
        }
    }
}
