using DTO_QuanLyBDS;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL_QuanLyBDS
{
    public class Admin : Context
    {
        IMongoCollection<BsonDocument> baiDangColl = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("KhachHangDangTin");

        IMongoCollection<BsonDocument> khachHangColl = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("Khachhang");

        IMongoCollection<BsonDocument> ticketColl = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("Ticket");

        private IMongoCollection<NhanVienDTO> NhanVienCollection()
        {
            var db = client.GetDatabase("QLBatDongSan");
            return db.GetCollection<NhanVienDTO>("NhanVien");
        }

        private IMongoCollection<TaiKhoanDTO> TaiKhoanCollection()
        {
            var db = client.GetDatabase("QLBatDongSan");
            return db.GetCollection<TaiKhoanDTO>("TaiKhoan");
        }

        private IMongoCollection<LogNapTien> LogNapTienCollection()
        {
            var db = client.GetDatabase("QLBatDongSan");
            return db.GetCollection<LogNapTien>("LogNapTien");
        }

        public List<NhanVienDTO> DanhSachNhanVien()
        {
            try
            {
                return NhanVienCollection().Find(new BsonDocument()).ToList();
            }
            catch
            {
                return new List<NhanVienDTO>();
            }
        }

        public List<int> DanhSachSoId()
        {
            try
            {
                var coll = NhanVienCollection();
                var filter = Builders<NhanVienDTO>.Filter.Regex("_id", new BsonRegularExpression("NV"));
                var projection = Builders<NhanVienDTO>.Projection.Include("_id");

                var idList = coll.Find(filter).Project(projection).ToList().Select(doc => doc["_id"].AsString);

                return idList.Select(id => int.Parse(id.Substring(2))).ToList();
            }
            catch
            {
                return null;
            }
        }

        public string ThemNhanVien(NhanVienDTO nhanVien, TaiKhoanDTO taiKhoan)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nhanVien.Email) || string.IsNullOrWhiteSpace(nhanVien.Hoten) || string.IsNullOrWhiteSpace(nhanVien.Diachi) || string.IsNullOrWhiteSpace(nhanVien.Sodienthoai))
                {
                    return "Không thể thêm nhân viên xin hãy kiểm tra lại";
                }
                var nvColl = NhanVienCollection();
                var tkColl = TaiKhoanCollection();
                nvColl.InsertOne(nhanVien);
                tkColl.InsertOne(new TaiKhoanDTO
                {
                    Email = taiKhoan.Email,
                    Matkhau = taiKhoan.Matkhau,
                    Vaitro = "nhanvien"
                });
                return "Thêm nhân viên thành công";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string CapNhatNhanVien(NhanVienDTO nhanVien)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nhanVien.Email) || string.IsNullOrWhiteSpace(nhanVien.Hoten) || string.IsNullOrWhiteSpace(nhanVien.Diachi) || string.IsNullOrWhiteSpace(nhanVien.Sodienthoai))
                {
                    return "Không thể cập nhật nhân viên xin hãy kiểm tra lại";
                }
                var nvcol = NhanVienCollection();
                var filter = Builders<NhanVienDTO>.Filter.Eq("Email", nhanVien.Email); // Thay "_id" bằng tên trường ID thực tế của bạn
                var update = Builders<NhanVienDTO>.Update
                    .Set("Hoten", nhanVien.Hoten)
                    .Set("Diachi", nhanVien.Diachi)
                    .Set("Sodienthoai", nhanVien.Sodienthoai)
                    .Set("Ngaybatbau", nhanVien.Ngaybatdau);

                NhanVienCollection().UpdateOne(filter, update);
                return "Cập nhật nhân viên thành công";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string XoaNhanVien(string Email)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Email))
                {
                    return "Xoá Nhân Viên Không Thành Công Hãy Kiểm Tra Lại";
                }
                var nvColl = NhanVienCollection();
                var tkColl = TaiKhoanCollection();
                var nvfilter = Builders<NhanVienDTO>.Filter.Eq("Email", Email);
                var tkfilter = Builders<TaiKhoanDTO>.Filter.Eq("Email", Email);
                nvColl.DeleteOne(nvfilter);
                tkColl.DeleteOne(tkfilter);
                return "Xóa Nhân Viên Thành Công";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<NhanVienDTO> TimKiemNhanVienTheoId(string Id)
        {
            try
            {
                var filter = Builders<NhanVienDTO>.Filter.Eq("_id", Id);
                return NhanVienCollection().Find(filter).ToList();
            }
            catch
            {
                return new List<NhanVienDTO>();
            }
        }

        public string DoiMatKhau(string email, string matkhauhientai, string matkhaumoi)
        {
            try
            {
                var tkColl = TaiKhoanCollection();
                var tkTonTai = tkColl.Find(new BsonDocument
                {
                    { "Email", email },
                    { "Matkhau", matkhauhientai }
                }).ToList();

                if (tkTonTai != null)
                {
                    var updateFilter = Builders<TaiKhoanDTO>.Filter.Eq("Email", email);
                    var update = Builders<TaiKhoanDTO>.Update.Set("Matkhau", matkhaumoi);

                    var result = tkColl.UpdateOne(updateFilter, update);

                    if (result.IsAcknowledged && result.ModifiedCount > 0)
                    {
                        return "Đổi mật khẩu thành công";
                    }
                    else
                    {
                        return "Có lỗi xảy ra khi cập nhật mật khẩu mới.";
                    }
                }
                else
                {
                    return "Sai mật khẩu hiện tại";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public long TongKhachHang()
        {
            try
            {
                IMongoDatabase db = client.GetDatabase("QLBatDongSan");
                IMongoCollection<BsonDocument> coll = db.GetCollection<BsonDocument>("Khachhang");
                long count = coll.CountDocuments(new BsonDocument());
                return count;
            }
            catch
            {
                return 0;
            }
        }

        public long TongSoLuongBaiDang()
        {
            try
            {
                IMongoDatabase db = client.GetDatabase("QLBatDongSan");
                IMongoCollection<BsonDocument> coll = db.GetCollection<BsonDocument>("KhachHangDangTin");
                long count = coll.CountDocuments(new BsonDocument());
                return count;
            }
            catch
            {
                return 0;
            }
        }

        public double TongGiaTriBDS()
        {
            try
            {
                var aggregate = baiDangColl.Aggregate().Group(new BsonDocument
                {
                    {"_id", "$null" },
                    {"totalPrice", new BsonDocument("$sum", "$Gia") }
                }).FirstOrDefault();

                double tongGia = 0;
                if (aggregate != null)
                {
                    tongGia = aggregate["totalPrice"].AsDouble;
                }
                return tongGia;
            }
            catch
            {
                return 0;
            }
        }

        public double TongDoanhThu()
        {
            var aggregate = khachHangColl.Aggregate().Group(new BsonDocument
                {
                    {"_id","_null" },
                    {"doanhThu", new BsonDocument("$sum", "$Sodu") }
                }).FirstOrDefault();

            double doanhThu = 0;
            if (aggregate != null)
            {
                doanhThu = aggregate["doanhThu"].AsDouble;
            }
            return doanhThu;
        }

        public List<ThongKeDTO> ThongKeBaiDang()
        {
            try
            {
                IMongoDatabase database = client.GetDatabase("QLBatDongSan"); // Thay "TenCSDL" bằng tên của CSDL MongoDB của bạn
                IMongoCollection<BaiDangDTO> collection = database.GetCollection<BaiDangDTO>("KhachHangDangTin");

                var group = new BsonDocument
                {
                    {
                        "$group",
                        new BsonDocument
                        {
                            {"_id", new BsonDocument("$dateFromString", new BsonDocument("dateString", "$Thoigiandang").Add("format", "%d-%m-%Y"))},
                            {"Soluongbaidang", new BsonDocument("$sum", 1)}
                        }
                    }
                };

                var project = new BsonDocument
                {
                    {
                        "$project",
                        new BsonDocument
                        {
                            {"_id", 0},
                            {"Thoigiandang", "$_id"},
                            {"Soluongbaidang", 1}
                        }
                    }
                };

                var pipeline = new[] { BsonDocument.Parse(group.ToJson()), BsonDocument.Parse(project.ToJson()) };
                var result = collection.Aggregate<ThongKeDTO>(pipeline).ToList();
                return result;
            }
            catch
            {
                return new List<ThongKeDTO>();
            }
        }

        public List<ThongKeDTO> ThongKeTop5()
        {
            try
            {
                IMongoDatabase database = client.GetDatabase("QLBatDongSan");
                IMongoCollection<BaiDangDTO> collection = database.GetCollection<BaiDangDTO>("KhachHangDangTin");

                var group = new BsonDocument
                {
                    {
                        "$group",
                        new BsonDocument
                        {
                            {"_id", "$Loainha"},
                            {"Soluongbaidang", new BsonDocument("$sum", 1)}
                        }
                    }
                };

                var project = new BsonDocument
                {
                    {
                        "$project",
                        new BsonDocument
                        {
                            {"_id", 0},
                            {"Loainha", "$_id"},
                            {"Soluongbaidang", 1}
                        }
                    }
                };

                var sort = new BsonDocument("$sort", new BsonDocument("Soluongbaidang", -1));

                var limit = new BsonDocument("$limit", 5);

                var pipeline = new[] { BsonDocument.Parse(sort.ToJson()), BsonDocument.Parse(limit.ToJson()), BsonDocument.Parse(group.ToJson()), BsonDocument.Parse(project.ToJson()) };

                var result = collection.Aggregate<ThongKeDTO>(pipeline).ToList();

                return collection.Aggregate<ThongKeDTO>(pipeline).ToList();
            }
            catch
            {
                return new List<ThongKeDTO>();
            }
        }

        public List<ThongKeDoanhThuDTO> ThongKeDoanhThu()
        {
            try
            {
                var lognaptienCollection = LogNapTienCollection();
                var groupStage = new BsonDocument
                {
                    {
                        "$group", new BsonDocument
                        {
                            { "_id", "$Ngaynap" },
                            { "Tongtiennap", new BsonDocument("$sum", "$Tiennap") }
                        }
                    }
                };

                        var projectStage = new BsonDocument
                {
                    {
                        "$project", new BsonDocument
                        {
                            { "_id", 0 },
                            { "Ngaynap", "$_id" },
                            { "Tongtiennap", 1 }
                        }
                    }
                };

                var sortStage = new BsonDocument("$sort", new BsonDocument("Ngaynap", 1));

                var pipeline = new[] { groupStage, projectStage, sortStage };

                var result = lognaptienCollection.Aggregate<ThongKeDoanhThuDTO>(pipeline).ToList();

                return result;
            }
            catch
            {
                return new List<ThongKeDoanhThuDTO>();
            }

        }

        public long TicketChuaDuyet()
        {
            var filterFalse = Builders<BsonDocument>.Filter.Eq("Trangthai", false);
            var countFalse = ticketColl.CountDocuments(filterFalse);
            return countFalse;
        }

        public long TicketDaDuyet()
        {
            var filterTrue = Builders<BsonDocument>.Filter.Eq("Trangthai", true);
            var countTrue = ticketColl.CountDocuments(filterTrue);
            return countTrue;
        }

        public long BaiDangDaDuyet()
        {
            var filterTrue = Builders<BsonDocument>.Filter.Eq("Trangthai", true);
            var countTrue = baiDangColl.CountDocuments(filterTrue);
            return countTrue;
        }

        public long BaiDangChuaDuyet()
        {
            var filterFalse = Builders<BsonDocument>.Filter.Eq("Trangthai", false);
            var countFalse = baiDangColl.CountDocuments(filterFalse);
            return countFalse;
        }

        /*public List<> ThongKeNgayHomNay()
        {

        }*/
    }
}
