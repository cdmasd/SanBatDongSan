using DAL_QuanLyBDS;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLyBDS
{
    public partial class KhachHang
    {
        DAL_QuanLyBDS.KhachHang kh = new DAL_QuanLyBDS.KhachHang();
        // phần khách hàng đăng bài 
        public bool DangTin(string tieuDe, string loaiNha, double dienTich, int soPhong, double gia, string diaChi, string hinhAnh,string email)
        {
            return kh.DangTin(tieuDe, loaiNha, dienTich, soPhong, gia, diaChi, hinhAnh,email);
        }
        public List<BsonDocument> Daduyet(string makh)
        {
            return kh.Daduyet(makh);
        }
        public List<BsonDocument> Chuaduyet(string makh)
        {
            return kh.Chuaduyet(makh);
        }
        public List<BsonDocument> Bituchoi(string makh)
        {
            return kh.Bituchoi(makh);
        }
        public string getidKh(string email)
        {
            return kh.getidKh(email);
        }
        public bool UpdateBaidang(string id, string tieuDe, string loaiNha, double dienTich, int soPhong, double gia, string diaChi, string hinhAnh)
        {
            return kh.UpdateBaidang(id, tieuDe, loaiNha, dienTich, soPhong, gia, diaChi, hinhAnh);
        }
        public double getSodu(string email)
        {
            return kh.getSodu(email);
        }

        public bool DeleteBaiDang(string id)
        {
            return kh.DeleteBaiDang(id);
        }
        public bool insertTicket(string Sdt, string Vande, string Chitiet)
        {
            return kh.insertTicket(Sdt, Vande, Chitiet);
        }
        public bool UpdateThongTinKH(string Email, string HoTen, string Sodienthoai)
        {
            return kh.UpdateThongTinKH(Email, HoTen, Sodienthoai);
        }
        public List<BsonDocument> GetThongTin()
        {
            try
            {
                return kh.getThongTin();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lấy dữ liệu: {ex.Message}");
                return null;
            }
        }
        public List<BsonDocument> showInfo(string email)
        {
            return kh.showInfo(email);
        }
    }
}
