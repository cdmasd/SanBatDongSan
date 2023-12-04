using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Data;

namespace DAL_QuanLyBDS
{
    public partial class NhanVien : Context
    {
        IMongoCollection<BsonDocument> dangtin = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("KhachHangDangTin");
        IMongoCollection<BsonDocument> nhanvien = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("NhanVien");
        IMongoCollection<BsonDocument> ticket = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("Ticket");
        IMongoCollection<BsonDocument> Khachhang = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("Khachhang");
        IMongoCollection<BsonDocument> taikhoan = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("TaiKhoan");
        public DataTable Chuaduyet()
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Trangthai", "Chưa duyệt");
            var result = dangtin.Find(filter);
            return ConvertFindFluentToDataTable(result);
        }
        public DataTable Daduyet()
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Trangthai", "Đã duyệt");
            var result = dangtin.Find(filter);
            return ConvertFindFluentToDataTable(result);
        }
        public bool DeleteBaiDang(string id)
        {
            try
            {
                    dangtin.DeleteOne(new BsonDocument
                    {
                        { "_id", id }
                    });
                return true;
            }
            catch
            {
                return false;
            }
        }
        public string getNameNv(string email)
        {
            var result = nhanvien.Find(new BsonDocument
            {
                { "Email", email }
            }).ToList();
            return result[0]["Hoten"].ToString();
        }
        public bool Duyetbai(string id,string email)
        {
            try
            {
                var filter = Builders<BsonDocument>.Filter.Eq("_id", id);
                var update = Builders<BsonDocument>.Update.Set("Trangthai", "Đã duyệt").Set("Nguoiduyet", getNameNv(email));
                var result = dangtin.UpdateOne(filter, update);
                if (result.ModifiedCount > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public DataTable Chuahotro()
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Trangthai", false);
            var result = ticket.Find(filter);
            return ConvertFindFluentToDataTable(result);
        }
        public bool Hotro(string id, string email)
        {
            try
            {
                var filter = Builders<BsonDocument>.Filter.Eq("_id", id);
                var update = Builders<BsonDocument>.Update.Set("Trangthai", true).Set("Nguoihotro", getNameNv(email));
                var result = ticket.UpdateOne(filter, update);
                if (result.ModifiedCount > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public DataTable Getkhachhang()
        {
            var filter = Builders<BsonDocument>.Filter.Empty;
            var result = Khachhang.Find(filter);
            return ConvertFindFluentToDataTable(result);
        }
        public bool UpdataKhachhang(string id, string email, string hoten, string sdt, double sodu)
        {
            try
            {
                var filter = Builders<BsonDocument>.Filter.Eq("_id", id);
                var updateBuilder = Builders<BsonDocument>.Update;
                var update = updateBuilder
                    .Set("Email", email)
                    .Set("Hoten", hoten)
                    .Set("Sodienthoai", sdt)
                    .Set("Sodu", sodu);
                var result = Khachhang.UpdateOne(filter, update);
                return result.ModifiedCount > 0;
            }
            catch
            {

                return false;
            }
        }
        public bool DeleteKhachhang(string id)
        {
            try
            {
                var filterBuilder = Builders<BsonDocument>.Filter.Eq("_id", id);
                 
                 Khachhang.DeleteOne(filterBuilder);
                return true;  
            }
            catch
            {
                return false; 
            }
        }
        public bool DeleteTaikhoanKH(string email, string id)
        {

            if (DeleteKhachhang(id))
            {
                var filter = Builders<BsonDocument>.Filter.Eq("Email", email);
                taikhoan.DeleteOne(filter);
                return true; 
            }
            else
            {
                return false; 
            }

        }

        public DataTable TimKiemBaiDang(string id)
        {
                var filter = Builders<BsonDocument>.Filter.And(
                    Builders<BsonDocument>.Filter.Eq("_id", id),
                    Builders<BsonDocument>.Filter.Eq("Trangthai", "Chưa duyệt")
                    );
                var result =  dangtin.Find(filter);
                return ConvertFindFluentToDataTable(result);
        }
        public DataTable TimKiemBaiDangDaDuyet(string id)
        {
            var filter = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("_id", id),
                Builders<BsonDocument>.Filter.Eq("Trangthai", "Đã duyệt")
                );
            var result = dangtin.Find(filter);
            return ConvertFindFluentToDataTable(result);
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

        public DataTable TimKiemTicket(string Sdt)
        {
            var filter = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("Sodienthoai", Sdt),
                Builders<BsonDocument>.Filter.Eq("Trangthai", false)
                );
            var result = ticket.Find(filter);
            return ConvertFindFluentToDataTable(result);
        }

        public DataTable TimKiemKH(string id)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", id);
            var result = Khachhang.Find(filter);
            return ConvertFindFluentToDataTable(result);
        }
        #region bài đăng
        public string getEmailKh(string id)
        {
            // tìm người đăng bằng id
            var filter = Builders<BsonDocument>.Filter.Eq("_id", getIdNguoiDang(id));
            var result = Khachhang.Find(filter).ToList();
            return result[0]["Email"].ToString();
        }
        public string getSodu(string id)
        {
            // tìm người đăng bằng id
            var filter = Builders<BsonDocument>.Filter.Eq("_id", getIdNguoiDang(id));
            var result = Khachhang.Find(filter).ToList();
            return result[0]["Sodu"].ToString();
        }
        public string getIdNguoiDang(string id)
        {
            // tìm bài đăng
            var filter = Builders<BsonDocument>.Filter.Eq("_id", id);
            // chọn vào bài đăng
            var baidang = dangtin.Find(filter).ToList();
            // lấy id của khách đăng bài đó
            var idkhach = baidang[0]["_idnguoidang"];
            // tìm khách hàng dựa trên id của khách hàng
            var khach = Khachhang.Find(new BsonDocument { { "_id", idkhach } }).ToList();
            return khach[0]["_id"].ToString();
        }
        public bool TuchoiBaiDang(string id)
        {
            try
            {
                // tìm bài đăng
                var filter = Builders<BsonDocument>.Filter.Eq("_id", id);
                // update bài đăng
                var update = Builders<BsonDocument>.Update.Set("Trangthai", "Bị từ chối");
                // tìm người đăng bằng id
                var soDu = getSodu(id);
                var nguoidang = Builders<BsonDocument>.Filter.Eq("_id", getIdNguoiDang(id));
                var updateSodu = Builders<BsonDocument>.Update.Set("Sodu", double.Parse(soDu) + 20000);
                // Cập nhật trạng thái
                dangtin.UpdateOne(filter, update);
                // Cập nhật số dư
                Khachhang.UpdateOne(nguoidang, updateSodu);
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}
