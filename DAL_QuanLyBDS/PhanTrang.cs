using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLyBDS
{
    public class PhanTrang : Context
    {
        IMongoCollection<BsonDocument> dangtin = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("KhachHangDangTin");
        IMongoCollection<BsonDocument> nhanvien = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("NhanVien");
        IMongoCollection<BsonDocument> ticket = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("Ticket");
        IMongoCollection<BsonDocument> khachhang = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("Khachhang");
        IMongoCollection<BsonDocument> baidang = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("KhachHangDangTin");

        #region Tìm kiếm bài đăng của khách hàng

        public DataTable TimKiemBaiDangCuaKHDangTin(string email, string idBaiDang)
        {
            var result = khachhang.Find(new BsonDocument
            {
                { "Email", email }
            }).ToList();
            string id = result[0]["_id"].ToString();
            var filter = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("_id", idBaiDang),
                Builders<BsonDocument>.Filter.Eq("_idnguoidang", id));
            return ConvertFindFluentToDataTable(dangtin.Find(filter));
        }

        #endregion

        #region Đăng tin chưa duyệt
        public long GetTotalRecordsDangTinChuaDuyet()
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Trangthai", "Chưa duyệt");
            return dangtin.CountDocuments(filter);
        }

        public DataTable GetDataPageDangTinChuaDuyet(int page, int pageSize)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Trangthai", "Chưa duyệt");
            var skip = (page - 1) * pageSize;
            return ConvertFindFluentToDataTable(dangtin.Find(filter).Skip(skip).Limit(pageSize));
        }
        #endregion

        #region Đăng tin Đã duyệt
        public long GetTotalRecordsDangTinDaDuyet()
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Trangthai", "Đã duyệt");
            return dangtin.CountDocuments(filter);
        }

        public DataTable GetDataPageDangTinDaDuyet(int page, int pageSize)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Trangthai", "Đã duyệt");
            var skip = (page - 1) * pageSize;
            return ConvertFindFluentToDataTable(dangtin.Find(filter).Skip(skip).Limit(pageSize));
        }
        #endregion

        #region Nhân Viên
        public long GetTotalRecordNhanVien()
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Trangthai", "Hoạt động");
            return nhanvien.CountDocuments(filter);
        }

        public DataTable GetDataPageNhanVien(int page, int pageSize)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Trangthai", "Hoạt động");
            var skip = (page - 1) * pageSize;
            return ConvertFindFluentToDataTable(nhanvien.Find(filter).Skip(skip).Limit(pageSize));
        }
        public long GetTotalRecordNhanVienNgungHoatDong()
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Trangthai", "Ngưng hoạt động");
            return nhanvien.CountDocuments(filter);
        }

        public DataTable GetDataPageNhanVienNgungHoatDong(int page, int pageSize)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Trangthai", "Ngưng hoạt động");
            var skip = (page - 1) * pageSize;
            return ConvertFindFluentToDataTable(nhanvien.Find(filter).Skip(skip).Limit(pageSize));
        }
        #endregion

        #region Ticket Hỗ Trợ

        public long GetTotalRecordsTicketChuaDuyet()
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Trangthai", "Chưa hỗ trợ");
            return ticket.CountDocuments(filter);
        }

        public DataTable GetDataPageTicketChuaDuyet(int page, int pageSize)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Trangthai", "Chưa hỗ trợ");
            var skip = (page - 1) * pageSize;
            return ConvertFindFluentToDataTable(ticket.Find(filter).Skip(skip).Limit(pageSize));
        }

        public long GetTotalRecordsFindTicketChuaDuyet(string soDienThoai)
        {
            var filter = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("Trangthai", "Chưa hỗ trợ"),
                Builders<BsonDocument>.Filter.Eq("Sodienthoai", soDienThoai));
            return ticket.CountDocuments(filter);
        }

        public DataTable GetDataPageFindTicketChuaDuyet(int page, int pageSize, string soDienThoai)
        {
            var filter = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("Trangthai", "Chưa hỗ trợ"),
                Builders<BsonDocument>.Filter.Eq("Sodienthoai", soDienThoai));
            var skip = (page - 1) * pageSize;
            return ConvertFindFluentToDataTable(ticket.Find(filter).Skip(skip).Limit(pageSize));
        }

        #endregion

        #region Bài đăng bị từ chối của khách hàng

        public long GetTotalRecordsCuaKHDangTinBiTuChoi(string email)
        {
            var result = khachhang.Find(new BsonDocument
            {
                { "Email", email }
            }).ToList();
            string id = result[0]["_id"].ToString();
            var filter = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("Trangthai", "Bị từ chối"),
                Builders<BsonDocument>.Filter.Eq("_idnguoidang", id));
            return dangtin.CountDocuments(filter);
        }

        public DataTable GetDataPageCuaKHDangTinBiTuChoi(int page, int pageSize, string email)
        {
            var result = khachhang.Find(new BsonDocument
            {
                { "Email", email }
            }).ToList();
            string id = result[0]["_id"].ToString();
            var filter = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("Trangthai", "Bị từ chối"),
                Builders<BsonDocument>.Filter.Eq("_idnguoidang", id));
            var skip = (page - 1) * pageSize;
            return ConvertFindFluentToDataTable(dangtin.Find(filter).Skip(skip).Limit(pageSize));
        }

        #endregion

        #region Bài đăng đã được duyệt của khách hàng

        public long GetTotalRecordsCuaKHDangTinDaDuyet(string email)
        {
            var result = khachhang.Find(new BsonDocument
            {
                { "Email", email }
            }).ToList();
            string id = result[0]["_id"].ToString();
            var filter = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("Trangthai", "Đã duyệt"),
                Builders<BsonDocument>.Filter.Eq("_idnguoidang", id));
            return dangtin.CountDocuments(filter);
        }

        public DataTable GetDataPageCuaKHDangTinDaDuyet(int page, int pageSize, string email)
        {
            var result = khachhang.Find(new BsonDocument
            {
                { "Email", email }
            }).ToList();
            string id = result[0]["_id"].ToString();
            var filter = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("Trangthai", "Đã duyệt"),
                Builders<BsonDocument>.Filter.Eq("_idnguoidang", id));
            var skip = (page - 1) * pageSize;
            return ConvertFindFluentToDataTable(dangtin.Find(filter).Skip(skip).Limit(pageSize));
        }

        #endregion

        #region Bài đăng chưa duyệt của khách hàng

        public long GetTotalRecordsCuaKHDangTinChuaDuyet(string email)
        {
            var result = khachhang.Find(new BsonDocument
            {
                { "Email", email }
            }).ToList();
            string id = result[0]["_id"].ToString();
            var filter = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("Trangthai", "Chưa duyệt"),
                Builders<BsonDocument>.Filter.Eq("_idnguoidang", id));
            return dangtin.CountDocuments(filter);
        }

        public DataTable GetDataPageCuaKHDangTinChuaDuyet(int page, int pageSize, string email)
        {
            var result = khachhang.Find(new BsonDocument
            {
                { "Email", email }
            }).ToList();
            string id = result[0]["_id"].ToString();
            var filter = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("Trangthai", "Chưa duyệt"),
                Builders<BsonDocument>.Filter.Eq("_idnguoidang", id));
            var skip = (page - 1) * pageSize;
            return ConvertFindFluentToDataTable(dangtin.Find(filter).Skip(skip).Limit(pageSize));
        }

        #endregion

        #region Khách hàng
        public long GetTotalRecordsKhachHang()
        {
            var filter = Builders<BsonDocument>.Filter.Empty;
            return khachhang.CountDocuments(filter);
        }

        public DataTable GetDataPageKhachHang(int page, int pageSize)
        {
            var filter = Builders<BsonDocument>.Filter.Empty;
            var skip = (page - 1) * pageSize;
            return ConvertFindFluentToDataTable(khachhang.Find(filter).Skip(skip).Limit(pageSize));
        }

        #endregion

        #region Khách Thăm

        public long GetTotalRecordsDanhSach() 
        {
            var filter = Builders<BsonDocument>.Filter.Empty;
            return baidang.CountDocuments(filter);
        }

        public DataTable Danhsach(int page, int pageSize)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Trangthai", "Đã duyệt");
            /*var KhachthamData = baidang.Find(filter);*/
            var skip = (page - 1) * pageSize;
            return ConvertFindFluentToDataTable(baidang.Find(filter).Skip(skip).Limit(pageSize));
        }

        public long GetTotalRecordsLocLoaiNha(string loainha)
        {
            var filter = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("Loainha", loainha),
                Builders<BsonDocument>.Filter.Eq("Trangthai", "Đã duyệt")
                );
            return baidang.CountDocuments(filter);
        }

        public DataTable LocLoaiNha(int page, int pageSize, string loainha)
        {
            var filter = Builders<BsonDocument>.Filter.And(
            Builders<BsonDocument>.Filter.Eq("Loainha", loainha),
            Builders<BsonDocument>.Filter.Eq("Trangthai", "Đã duyệt"));
            var locnha = baidang.Find(filter);
            var skip = (page - 1) * pageSize;
            return ConvertFindFluentToDataTable(locnha.Skip(skip).Limit(pageSize));
        }

        public long GetTotalRecordsLocKhuVuc(string area)
        {
            var khuvuc = new BsonDocument
            {
                { "Diachi", new BsonDocument("$regex", area) },
                { "Trangthai", "Đã duyệt" }
            };
            return baidang.CountDocuments(khuvuc);
        }

        public DataTable LocKhuVuc(int page, int pageSize, string area)
        {
            var khuvuc = new BsonDocument
            {
                { "Diachi", new BsonDocument("$regex", area) },
                { "Trangthai", "Đã duyệt" }
            };
            var lockv = baidang.Find(khuvuc);
            var skip = (page - 1) * pageSize;
            return ConvertFindFluentToDataTable(lockv.Skip(skip).Limit(pageSize));
        }

        public long GetTotalRecordsLocSoPhong(int sophong)
        {
            var filter = Builders<BsonDocument>.Filter.And(
            Builders<BsonDocument>.Filter.Eq("Sophong", sophong),
            Builders<BsonDocument>.Filter.Eq("Trangthai", "Đã duyệt")
                );
            return baidang.CountDocuments(filter);
        }

        public DataTable LocSoPhong(int page, int pageSize, int sophong)
        {
            var filter = Builders<BsonDocument>.Filter.And(
            Builders<BsonDocument>.Filter.Eq("Sophong", sophong),
            Builders<BsonDocument>.Filter.Eq("Trangthai", "Đã duyệt"));
            var locphong = baidang.Find(filter);
            var skip = (page - 1) * pageSize;
            return ConvertFindFluentToDataTable(locphong.Skip(skip).Limit(pageSize));
        }

        public long GetTotalRecordsLocDienTich(double start, double end)
        {
            var filter = Builders<BsonDocument>.Filter.And(
            Builders<BsonDocument>.Filter.Gte("Dientich", start),
            Builders<BsonDocument>.Filter.Lte("Dientich", end),
            Builders<BsonDocument>.Filter.Eq("Trangthai", "Đã duyệt"));
            return baidang.CountDocuments(filter);
        }

        public DataTable LocDienTich(int page, int pageSize, double start, double end)
        {
            var filter = Builders<BsonDocument>.Filter.And(
            Builders<BsonDocument>.Filter.Gte("Dientich", start),
            Builders<BsonDocument>.Filter.Lte("Dientich", end),
            Builders<BsonDocument>.Filter.Eq("Trangthai", "Đã duyệt"));
            var locdientich = baidang.Find(filter);
            var skip = (page - 1) * pageSize;
            return ConvertFindFluentToDataTable(locdientich.Skip(skip).Limit(pageSize));
        }

        public long GetTotalRecordsLocGia(double start, double end)
        {
            var filter = Builders<BsonDocument>.Filter.And(
            Builders<BsonDocument>.Filter.Gte("Gia", start),
            Builders<BsonDocument>.Filter.Lte("Gia", end),
            Builders<BsonDocument>.Filter.Eq("Trangthai", "Đã duyệt"));
            return baidang.CountDocuments(filter);
        }

        public DataTable LocGia(int page, int pageSize, double start, double end)
        {
            var filter = Builders<BsonDocument>.Filter.And(
            Builders<BsonDocument>.Filter.Gte("Gia", start),
            Builders<BsonDocument>.Filter.Lte("Gia", end),
            Builders<BsonDocument>.Filter.Eq("Trangthai", "Đã duyệt"));
            var locGia = baidang.Find(filter);
            var skip = (page - 1) * pageSize;
            return ConvertFindFluentToDataTable(locGia.Skip(skip).Limit(pageSize));
        }

        #endregion


        static DataTable ConvertFindFluentToDataTable(IFindFluent<BsonDocument, BsonDocument> findFluent)
        {
            DataTable dataTable = new DataTable();
            // Lấy danh sách cột từ documents, nếu có
            foreach (var document in findFluent.ToEnumerable())
            {
                if (dataTable.Columns.Count == 0)
                {
                    // Thêm cột vào DataTable với tên là tên của các trường trong BsonDocument
                    foreach (var element in document.Elements)
                    {
                        dataTable.Columns.Add(element.Name, typeof(object));
                    }
                }

                // Thêm dữ liệu vào từ BsonDocument
                DataRow dataRow = dataTable.NewRow();
                foreach (var element in document.Elements)
                {
                    dataRow[element.Name] = BsonTypeMapper.MapToDotNetValue(element.Value);
                }
                dataTable.Rows.Add(dataRow);
            }

            return dataTable;
        }
    }
}
