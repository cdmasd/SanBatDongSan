using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLyBDS
{
    public partial class NhanVien : Context
    {
        IMongoCollection<BsonDocument> dangtin = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("KhachHangDangTin");
        IMongoCollection<BsonDocument> nhanvien = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("NhanVien");
        IMongoCollection<BsonDocument> ticket = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("Ticket");
        IMongoCollection<BsonDocument> Khachhang = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("Khachhang");
        IMongoCollection<BsonDocument> taikhoan = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("TaiKhoan");
        public List<BsonDocument> Chuaduyet()
        {
            return dangtin.Find(new BsonDocument
            {
                { "Trangthai", false }
            }).ToList();
        }
        public List<BsonDocument> Daduyet()
        {
            return dangtin.Find(new BsonDocument
            {
                { "Trangthai", true }
            }).ToList();
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
                var update = Builders<BsonDocument>.Update.Set("TrangThai", true).Set("NguoiDuyet", getNameNv(email));
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
        public List<BsonDocument> Chuahotro()
        {
            return ticket.Find(new BsonDocument
            {
                { "TrangThai", false }
            }).ToList();
        }
        public bool Hotro(string id, string email)
        {
            try
            {
                var filter = Builders<BsonDocument>.Filter.Eq("_id", id);
                var update = Builders<BsonDocument>.Update.Set("TrangThai", true).Set("NguoiHoTro", getNameNv(email));
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
        public List<BsonDocument> Getkhachhang()
        {
            var filter = Builders<BsonDocument>.Filter.Empty;
            var KhachhangData = Khachhang.Find(filter).ToList();
            return KhachhangData;
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
            catch (Exception ex)
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

    }
}
