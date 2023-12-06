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
    public class Guest : Context
    {
        IMongoCollection<BsonDocument> baidang = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("KhachHangDangTin");
        IMongoCollection<BsonDocument> Khachhang = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("Khachhang");


        public List<BsonDocument> Thongtinnguoidang(string _id)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", _id);
            var Tindang = baidang.Find(filter).FirstOrDefault();

            if (Tindang != null)
            {
                string _idKH = Tindang.GetValue("_idnguoidang").AsString;
                var Khachhangdata = Khachhang.Find(Builders<BsonDocument>.Filter.Eq("_id", _idKH)).ToList();
                return Khachhangdata;
            }
            else
            {
                return null;
            }
        }
        public DataTable Danhsach()
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Trangthai", "Đã duyệt");
            var KhachthamData = baidang.Find(filter);
            return ConvertFindFluentToDataTable(KhachthamData);
        }
        public DataTable locLoaiNha(string loainha)
        {
            var filter = Builders<BsonDocument>.Filter.And(
            Builders<BsonDocument>.Filter.Eq("Loainha", loainha),
            Builders<BsonDocument>.Filter.Eq("Trangthai", "Đã duyệt"));
            var locnha = baidang.Find(filter);
            return ConvertFindFluentToDataTable(locnha);
        }
        public DataTable locsophong(int sophong)
        {
            var filter = Builders<BsonDocument>.Filter.And(
            Builders<BsonDocument>.Filter.Eq("Sophong", sophong),
            Builders<BsonDocument>.Filter.Eq("Trangthai", "Đã duyệt"));
            var locphong = baidang.Find(filter);
            return ConvertFindFluentToDataTable(locphong);
        }
        public DataTable locdientich(double start, double end)
        {
            var filter = Builders<BsonDocument>.Filter.And(
            Builders<BsonDocument>.Filter.Gte("Dientich", start),
            Builders<BsonDocument>.Filter.Lte("Dientich", end),
            Builders<BsonDocument>.Filter.Eq("Trangthai", "Đã duyệt"));
            var locdientich = baidang.Find(filter);
            return ConvertFindFluentToDataTable(locdientich);
        }

        public DataTable locGia(double start, double end)
        {
            var filter = Builders<BsonDocument>.Filter.And(
            Builders<BsonDocument>.Filter.Gte("Gia", start),
            Builders<BsonDocument>.Filter.Lte("Gia", end),
            Builders<BsonDocument>.Filter.Eq("Trangthai", "Đã duyệt"));
            var locGia = baidang.Find(filter);
            return ConvertFindFluentToDataTable(locGia);
        }
        public DataTable SearchArea(string area)
        {
            var khuvuc = baidang.Find(new BsonDocument("Diachi", new BsonDocument("$regex", area)));
            return ConvertFindFluentToDataTable(khuvuc);
        }
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
