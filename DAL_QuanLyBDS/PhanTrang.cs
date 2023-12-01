﻿using MongoDB.Bson;
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
            var filter = Builders<BsonDocument>.Filter.Eq("Trangthai", "Đã duyệt");
            return dangtin.CountDocuments(filter);
        }

        public DataTable GetDataPageDangTinDaDuyet(int page, int pageSize)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Trangthai", "Đã duyệt");
            var skip = (page - 1) * pageSize;
            return ConvertFindFluentToDataTable(dangtin.Find(filter).Skip(skip).Limit(pageSize));
        }
        #endregion

        #region Nhân Viên
        public long GetTotalRecordNhanVien()
        {
            var filter = Builders<BsonDocument>.Filter.Empty;
            return nhanvien.CountDocuments(filter);
        }

        public DataTable GetDataPageNhanVien(int page, int pageSize)
        {
            var filter = Builders<BsonDocument>.Filter.Empty;
            var skip = (page - 1) * pageSize;
            return ConvertFindFluentToDataTable(nhanvien.Find(filter).Skip(skip).Limit(pageSize));
        }
        #endregion

        #region Ticket Hỗ Trợ

        public long GetTotalRecordsTicketChuaDuyet()
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Trangthai", false);
            return ticket.CountDocuments(filter);
        }

        public DataTable GetDataPageTicketChuaDuyet(int page, int pageSize)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Trangthai", false);
            var skip = (page - 1) * pageSize;
            return ConvertFindFluentToDataTable(dangtin.Find(filter).Skip(skip).Limit(pageSize));
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
