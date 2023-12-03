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

        public long GetTotalRecordsCuaKHDangTinBiTuChoi(string email)
        {
            return DAL_PhanTrang.GetTotalRecordsCuaKHDangTinBiTuChoi(email);
        }

        public DataTable GetDataPageCuaHKDangTinBiTuChoi(int page, int pageSize,string email)
        {
            return DAL_PhanTrang.GetDataPageCuaKHDangTinBiTuChoi(page, pageSize, email);
        }

        public long GetTotalRecordsCuaKHDangTinDaDuyet(string email)
        {
            return DAL_PhanTrang.GetTotalRecordsCuaKHDangTinDaDuyet(email);
        }

        public DataTable GetDataPageCuaKHDangTinDaDuyet(int page, int pageSize, string email)
        {
            return DAL_PhanTrang.GetDataPageCuaKHDangTinDaDuyet(page, pageSize, email);
        }

        public long GetTotalRecordsCuaKHDangTinChuaDuyet(string email)
        {
            return DAL_PhanTrang.GetTotalRecordsCuaKHDangTinChuaDuyet(email);
        }

        public DataTable GetDataPageCuaKHDangTinChuaDuyet(int page, int pageSize, string email)
        {
            return DAL_PhanTrang.GetDataPageCuaKHDangTinChuaDuyet(page, pageSize, email);
        }

        public long GetTotalRecordsDanhSach()
        {
            return DAL_PhanTrang.GetTotalRecordsDanhSach();
        }

        public DataTable Danhsach(int page, int pageSize)
        {
            return DAL_PhanTrang.Danhsach(page, pageSize);
        }

        public long GetTotalRecordsLocLoaiNha(string loainha)
        {
            return DAL_PhanTrang.GetTotalRecordsLocLoaiNha(loainha);
        }

        public DataTable LocLoaiNha(int page, int pageSize, string loainha)
        {
            return DAL_PhanTrang.LocLoaiNha(page, pageSize, loainha);
        }

        public long GetTotalRecordsLocKhuVuc(string quan)
        {
            return DAL_PhanTrang.GetTotalRecordsLocKhuVuc(quan);
        }

        public DataTable LocKhuVuc(int page, int pageSize, string quan)
        {
            return DAL_PhanTrang.LocKhuVuc(page, pageSize, quan);
        }

        public long GetTotalRecordsLocSoPhong(int sophong)
        {
            return DAL_PhanTrang.GetTotalRecordsLocSoPhong(sophong);
        }

        public DataTable LocSoPhong(int page, int pageSize, int sophong)
        {
            return DAL_PhanTrang.LocSoPhong(page, pageSize, sophong);
        }

        public long GetTotalRecordsLocDienTich(double start, double end)
        {
            return DAL_PhanTrang.GetTotalRecordsLocDienTich(start, end);
        }

        public DataTable LocDienTich(int page, int pageSize, double start, double end)
        {
            return DAL_PhanTrang.LocDienTich(page, pageSize, start, end);
        }

        public long GetTotalRecordsLocGia(double start, double end)
        {
            return DAL_PhanTrang.GetTotalRecordsLocGia(start, end);
        }

        public DataTable LocGia(int page, int pageSize, double start, double end)
        {
            return DAL_PhanTrang.LocGia(page, pageSize, start, end);
        }

        public DataTable TimKiemBaiDangCuaKHDangTin(string email, string idBaiDang)
        {
            return DAL_PhanTrang.TimKiemBaiDangCuaKHDangTin(email, idBaiDang);
        }

        public long GetTotalRecordsFindTicketChuaDuyet(string soDienThoai)
        {
            return DAL_PhanTrang.GetTotalRecordsFindTicketChuaDuyet(soDienThoai);
        }

        public DataTable GetDataPageFindTicketChuaDuyet(int page, int pageSize, string soDienThoai)
        {
            return DAL_PhanTrang.GetDataPageFindTicketChuaDuyet(page, pageSize, soDienThoai);
        }
    }
}
