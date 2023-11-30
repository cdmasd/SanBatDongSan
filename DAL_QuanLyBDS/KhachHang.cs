using MongoDB.Bson;
using MongoDB.Driver;
using System.Net.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace DAL_QuanLyBDS
{
    public partial class KhachHang : Context
    {
        IMongoCollection<BsonDocument> Khachhang = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("Khachhang");
        IMongoCollection<BsonDocument> khachhangdangtin = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("KhachHangDangTin");
        IMongoCollection<BsonDocument> Ticket = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("Ticket");
        public string getidKh(string email)
        {
            var result = Khachhang.Find(new BsonDocument
            {
                { "Email", email }
            }).ToList();
            return result[0]["_id"].ToString();
        }
        public void UpdateSodu(string email)
        {
            var result = Khachhang.Find(new BsonDocument
            {
                { "Email", email }
            }).ToList();
            var filter = Builders<BsonDocument>.Filter.Eq("Email", email);
            var sodu = result[0]["Sodu"];
            var update = Builders<BsonDocument>.Update.Set("Sodu",(double.Parse(sodu.ToString()) -  20000));
            Khachhang.UpdateOne(filter, update);
        }
        public double getSodu(string email)
        {
            var result = Khachhang.Find(new BsonDocument
            {
                { "Email", email }
            }).ToList();
            var filter = Builders<BsonDocument>.Filter.Eq("Email", email);
            return result[0]["Sodu"].ToDouble();
        }
        public bool DangTin(string tieuDe, string loaiNha, double dienTich, int soPhong, double gia, string diaChi, string hinhAnh,string email)
        {
            try
            {

                string nextMaNV = getNextMaNV();
                var dangtinDocument = new BsonDocument
                {
                    {"_id", nextMaNV},
                    {"Tieude", tieuDe},
                    {"Loainha", loaiNha},
                    {"Dientich", dienTich},
                    {"Sophong", soPhong},
                    {"Gia", gia},
                    {"Diachi", diaChi},
                    {"Hinhanh", hinhAnh},
                    {"_idnguoidang",getidKh(email) },
                    {"Thoigiandang", DateTime.Now.ToString("dd-MM-yyyy")},
                    {"Trangthai", "Chưa duyệt"}
                };

                khachhangdangtin.InsertOne(dangtinDocument);
                UpdateSodu(email);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        string getNextMaNV()
        {
            var filter = Builders<BsonDocument>.Sort.Descending("_id");
            var lastDocument = khachhangdangtin.Find(new BsonDocument()).Sort(filter).Limit(1).ToList();
            var lastMaNV = lastDocument.Count > 0 ? lastDocument[0]["_id"].ToString() : null;

            if (lastMaNV != null)
            {
                var lastNumber = int.Parse(lastMaNV.Replace("DB", ""));
                return $"DB{lastNumber + 1:00}";
            }
            else
            {
                return "DB01";
            }
        }
        public List<BsonDocument> Daduyet(string makh)
        {
            var filter = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("_idnguoidang", makh),
                Builders<BsonDocument>.Filter.Eq("Trangthai", "Đã duyệt")
                );
            var DangtinData = khachhangdangtin.Find(filter).ToList();
            return DangtinData;
        }
        public List<BsonDocument> Chuaduyet(string makh)
        {
            var filter = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("_idnguoidang", makh),
                Builders<BsonDocument>.Filter.Eq("Trangthai", "Chưa duyệt")
                );
            var DangtinData = khachhangdangtin.Find(filter).ToList();
            return DangtinData;
        }
        public List<BsonDocument> Bituchoi(string makh)
        {
            var filter = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("_idnguoidang", makh),
                Builders<BsonDocument>.Filter.Eq("Trangthai", "Bị từ chối")
                );
            var DangtinData = khachhangdangtin.Find(filter).ToList();
            return DangtinData;
        }
        public bool UpdateBaidang(string id, string tieuDe, string loaiNha, double dienTich, int soPhong, double gia, string diaChi, string hinhAnh)
        {
            try
            {

                // Tạo bộ lọc sử dụng id của bản ghi cần cập nhật
                var filterBuilder = Builders<BsonDocument>.Filter;
                var filter = filterBuilder.Eq("_id", id);

                // Tạo bộ cập nhật để thiết lập các giá trị mới cho các trường trong bản ghi
                var updateBuilder = Builders<BsonDocument>.Update;
                var update = updateBuilder
                    .Set("Tieude", tieuDe)
                    .Set("Loainha", loaiNha)
                    .Set("Dientich", dienTich)
                    .Set("Sophong", soPhong)
                    .Set("Gia", gia)
                    .Set("Diachi", diaChi)
                    .Set("Hinhanh", hinhAnh)
                    .Set("Trangthai", "Chưa duyệt");

                // Thực hiện hoạt động cập nhật với bộ lọc và cập nhật đã xác định
                var result = khachhangdangtin.UpdateOne(filter, update);

                // Kiểm tra xem có ít nhất một bản ghi đã được chỉnh sửa không
                return result.ModifiedCount > 0;
            }
            catch (Exception ex)
            {
                // Xử lý bất kỳ ngoại lệ nào xảy ra trong quá trình cập nhật
                return false;
            }
        }
        public bool DeleteBaiDang(string id)
        {
            try
            {

                // Tạo bộ lọc sử dụng id của bản ghi cần cập nhật
                var filterBuilder = Builders<BsonDocument>.Filter;
                var filter = filterBuilder.Eq("_id", id);
                var result = khachhangdangtin.DeleteOne(filter);
                // Kiểm tra xem có ít nhất một bản ghi đã được chỉnh sửa không
                return true;
            }
            catch (Exception ex)
            {
                // Xử lý bất kỳ ngoại lệ nào xảy ra trong quá trình cập nhật
                return false;
            }
        }
        public bool UpdataKhachhang(string email, string hoten, string sdt, string sodu)
        {
            try
            {
                var filterBuilder = Builders<BsonDocument>.Filter;
                var filter = filterBuilder.Empty;
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
        public bool DeleteKhachhang(string email)
        {
            try
            {
                var filterBuilder = Builders<BsonDocument>.Filter;
                var filter = filterBuilder.Eq("Email", email);
                var result = Khachhang.DeleteOne(filter);
                return result.DeletedCount > 0;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public List<BsonDocument> showInfo(string Email)
        {
            return Khachhang.Find(new BsonDocument("Email", Email)).ToList();
        }
        public bool UpdateThongTinKH(string Email, string HoTen, string Sodienthoai)
        {
            try
            {
                var filterBuilder = Builders<BsonDocument>.Filter;
                var filter = filterBuilder.Eq("Email", Email);
                var updateBuilder = Builders<BsonDocument>.Update;
                var update = updateBuilder
                    .Set("Hoten", HoTen)
                    .Set("Sodienthoai", Sodienthoai);
                var result = Khachhang.UpdateOne(filter, update);
                return result.ModifiedCount > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #region ticket

        public bool insertTicket(string Sdt, string Vande, string Chitiet)
        {
            try
            {
                string nextTK = getIDticket();
                var ticketDocument = new BsonDocument
                {
                    { "_id", nextTK },
                    { "Sodienthoai", Sdt },
                    { "Vande", Vande },
                    { "Chitiet", Chitiet },
                    { "Trangthai", false },
                    { "Nguoihotro", ""},
                    {"Ngaydang",DateTime.Now.ToString("dd-MM-yyyy") }
                };
                Ticket.InsertOne(ticketDocument);
                Console.WriteLine("Thành Công");
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Lỗi khi cập nhật bài đăng: {ex.Message}");
                return false;
            }

        }
        string getIDticket()
        {
            var filter = Builders<BsonDocument>.Sort.Descending("_id");
            // Lấy ra đối tượng có mã nhân viên cao nhất
            var lastDocument = Ticket.Find(new BsonDocument()).Sort(filter).Limit(1).ToList();
            // Nếu trong đối tượng lastDocument không tìm được đối tượng nào thì trả về null
            // Ngược lại gán mã nhân viên cho lastMaNV
            var lastMaNV = lastDocument.Count > 0 ? lastDocument[0]["_id"].ToString() : null;

            if (lastMaNV != null)
            {
                // Lấy số từ chuỗi và tăng giá trị lên 1
                var lastNumber = int.Parse(lastMaNV.Replace("TK", ""));
                return $"TK{lastNumber + 1:00}";
            }
            else
            {
                return "TK01";
            }
        }
        public List<BsonDocument> getThongTin()
        {
            var filter = Builders<BsonDocument>.Filter.Empty;
            var Thongtin = Khachhang.Find(filter).ToList();
            return Thongtin;
        }
        #endregion
    }
}
