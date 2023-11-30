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
        IMongoCollection<BsonDocument> Khachhang = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("Khachhang");
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
        /*public long GetTotalRecordsDangTinDaDuyet()
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Trangthai", "Đã duyệt");
            return dangtin.CountDocuments(filter);
        }

        public List<BsonDocument> GetDataPageDangTinDaDuyet(int page, int pageSize)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Trangthai", "Đã duyệt");
            var skip = (page - 1) * pageSize;
            return dangtin.Find(filter).Skip(skip).Limit(pageSize).ToList();
        }*/
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
