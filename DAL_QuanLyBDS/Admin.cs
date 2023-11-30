using DTO_QuanLyBDS;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Globalization;

namespace DAL_QuanLyBDS
{
    public class Admin : Context
    {
        IMongoCollection<BsonDocument> baiDangColl = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("KhachHangDangTin");

        IMongoCollection<BsonDocument> khachHangColl = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("Khachhang");

        IMongoCollection<BsonDocument> ticketColl = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("Ticket");

        IMongoCollection<BsonDocument> logNapColl = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("LogNapTien");

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
                    .Set("Ngaybatdau", nhanVien.Ngaybatdau);

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
            var filterTrue = Builders<BsonDocument>.Filter.Eq("Trangthai", "Đã duyệt");
            var countTrue = baiDangColl.CountDocuments(filterTrue);
            return countTrue;
        }

        public long BaiDangChuaDuyet()
        {
            var filterFalse = Builders<BsonDocument>.Filter.Eq("Trangthai", "Chưa duyệt");
            var countFalse = baiDangColl.CountDocuments(filterFalse);
            return countFalse;
        }

        public int ThongKeBaiDangTrongThang()
        {
            try
            {
                var currentMonth = DateTime.Now.Month;
                var currentYear = DateTime.Now.Year;

                var firstDayOfMonth = new DateTime(currentYear, currentMonth, 1);
                var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

                var filter = Builders<BsonDocument>.Filter.And(
                    Builders<BsonDocument>.Filter.Gte("Thoigiandang", firstDayOfMonth.ToString("dd-MM-yyyy")),
                    Builders<BsonDocument>.Filter.Lte("Thoigiandang", lastDayOfMonth.ToString("dd-MM-yyyy"))
                );

                var documents = baiDangColl.Find(filter).ToList();

                var count = 0;

                foreach (var document in documents)
                {
                    if (DateTime.TryParseExact(document["Thoigiandang"].AsString, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
                    {
                        if (parsedDate.Month == currentMonth && parsedDate.Year == currentYear)
                        {
                            count++;
                        }
                    }
                }

                return count;
            }
            catch
            {
                return 0;
            }
        }

        public int ThongKeKhachHangTrongThang()
        {
            try
            {
                var currentMonth = DateTime.Now.Month;
                var currentYear = DateTime.Now.Year;

                var firstDayOfMonth = new DateTime(currentYear, currentMonth, 1);
                var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

                var filter = Builders<BsonDocument>.Filter.And(
                    Builders<BsonDocument>.Filter.Gte("Ngaydangki", firstDayOfMonth.ToString("dd-MM-yyyy")),
                    Builders<BsonDocument>.Filter.Lte("Ngaydangki", lastDayOfMonth.ToString("dd-MM-yyyy"))
                );

                var documents = khachHangColl.Find(filter).ToList();

                var count = 0;

                foreach (var document in documents)
                {
                    if (DateTime.TryParseExact(document["Ngaydangki"].AsString, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
                    {
                        if (parsedDate.Month == currentMonth && parsedDate.Year == currentYear)
                        {
                            count++;
                        }
                    }
                }

                return count;
            }
            catch
            {
                return 0;
            }
        }

        public double ThongKeTongGiaTriBDS()
        {
            try
            {
                var currentMonth = DateTime.Now.Month;
                var currentYear = DateTime.Now.Year;

                var firstDayOfMonth = new DateTime(currentYear, currentMonth, 1);
                var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

                var filter = Builders<BsonDocument>.Filter.And(
                    Builders<BsonDocument>.Filter.Gte("Thoigiandang", firstDayOfMonth.ToString("dd-MM-yyyy")),
                    Builders<BsonDocument>.Filter.Lte("Thoigiandang", lastDayOfMonth.ToString("dd-MM-yyyy"))
                );

                var documents = baiDangColl.Find(filter).ToList();

                double sum = 0;

                foreach (var document in documents)
                {
                    if (DateTime.TryParseExact(document["Thoigiandang"].AsString, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
                    {
                        if (parsedDate.Month == currentMonth && parsedDate.Year == currentYear)
                        {
                            sum += document["Gia"].AsDouble;
                        }
                    }
                }

                return sum;
            }
            catch
            {
                return 0;
            }
        }

        public double ThongKeDoanhThuTrongThang()
        {
            try
            {
                var currentMonth = DateTime.Now.Month;
                var currentYear = DateTime.Now.Year;

                var firstDayOfMonth = new DateTime(currentYear, currentMonth, 1);
                var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

                var filter = Builders<BsonDocument>.Filter.And(
                    Builders<BsonDocument>.Filter.Gte("Ngaynap", firstDayOfMonth.ToString("dd-MM-yyyy")),
                    Builders<BsonDocument>.Filter.Lte("Ngaynap", lastDayOfMonth.ToString("dd-MM-yyyy"))
                );

                var documents = logNapColl.Find(filter).ToList();

                double sum = 0;

                foreach (var document in documents)
                {
                    if (DateTime.TryParseExact(document["Ngaynap"].AsString, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
                    {
                        if (parsedDate.Month == currentMonth && parsedDate.Year == currentYear)
                        {
                            sum += document["Tiennap"].AsDouble;
                        }
                    }
                }

                return sum;
            }
            catch
            {
                return 0;
            }
        }

        public List<ThongKeDTO> ThongKeBaiDangTrongThangChart()
        {
            try
            {
                var currentMonth = DateTime.Now.Month;
                var currentYear = DateTime.Now.Year;

                var match = new BsonDocument
                {
                    {
                        "$match",
                        new BsonDocument
                        {
                            {"$expr", new BsonDocument
                                {
                                    {"$and", new BsonArray
                                        {
                                            new BsonDocument { {"$eq", new BsonArray {new BsonDocument("$month", new BsonDocument("$dateFromString", new BsonDocument { { "dateString", "$Thoigiandang" }, { "format", "%d-%m-%Y" } })), currentMonth}} },
                                            new BsonDocument { {"$eq", new BsonArray {new BsonDocument("$year", new BsonDocument("$dateFromString", new BsonDocument { { "dateString", "$Thoigiandang" }, { "format", "%d-%m-%Y" } })), currentYear}} }
                                        }
                                    }
                                }
                            }
                        }
                    }
                };

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

                var pipeline = new[] { BsonDocument.Parse(match.ToJson()), BsonDocument.Parse(group.ToJson()), BsonDocument.Parse(project.ToJson()) };
                var result = baiDangColl.Aggregate<ThongKeDTO>(pipeline).ToList();
                return result;
            }
            catch
            {
                return new List<ThongKeDTO>();
            }
        }

        public List<ThongKeDTO> ThongKeLoaiNhaTrongThangChart()
        {
            try
            {
                var currentMonth = DateTime.Now.Month;
                var currentYear = DateTime.Now.Year;

                var match = new BsonDocument
                {
                    {
                        "$match",
                        new BsonDocument
                        {
                            {"$expr", new BsonDocument
                                {
                                    {"$and", new BsonArray
                                        {
                                            new BsonDocument { {"$eq", new BsonArray {new BsonDocument("$month", new BsonDocument("$dateFromString", new BsonDocument { { "dateString", "$Thoigiandang" }, { "format", "%d-%m-%Y" } })), currentMonth}} },
                                            new BsonDocument { {"$eq", new BsonArray {new BsonDocument("$year", new BsonDocument("$dateFromString", new BsonDocument { { "dateString", "$Thoigiandang" }, { "format", "%d-%m-%Y" } })), currentYear}} }
                                        }
                                    }
                                }
                            }
                        }
                    }
                };

                var group = new BsonDocument
                {
                    {
                        "$group",
                        new BsonDocument
                        {
                            {"_id", new BsonDocument { { "date", new BsonDocument("$dateFromString", new BsonDocument("dateString", "$Thoigiandang").Add("format", "%d-%m-%Y")) }, { "loainha", "$Loainha" } }},
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
                            {"Thoigiandang", "$_id.date"},
                            {"Loainha", "$_id.loainha"},
                            {"Soluongbaidang", 1}
                        }
                    }
                };

                var pipeline = new[] { BsonDocument.Parse(match.ToJson()), BsonDocument.Parse(group.ToJson()), BsonDocument.Parse(project.ToJson()) };
                var result = baiDangColl.Aggregate<ThongKeDTO>(pipeline).ToList();
                return result;
            }
            catch
            {
                return new List<ThongKeDTO>();
            }
        }

        public List<ThongKeDoanhThuDTO> ThongKeDoanThuTrongThang()
        {
            try
            {
                var currentMonth = DateTime.Now.Month;
                var currentYear = DateTime.Now.Year;

                var matchStage = new BsonDocument
                {
                    {
                        "$match",
                        new BsonDocument
                        {
                            {"$expr", new BsonDocument
                                {
                                    {"$and", new BsonArray
                                        {
                                            new BsonDocument { {"$eq", new BsonArray {new BsonDocument("$month", new BsonDocument("$dateFromString", new BsonDocument { { "dateString", "$Ngaynap" }, { "format", "%d-%m-%Y" } })), currentMonth}} },
                                            new BsonDocument { {"$eq", new BsonArray {new BsonDocument("$year", new BsonDocument("$dateFromString", new BsonDocument { { "dateString", "$Ngaynap" }, { "format", "%d-%m-%Y" } })), currentYear}} }
                                        }
                                    }
                                }
                            }
                        }
                    }
                };

                var groupStage = new BsonDocument
                {
                    {
                        "$group",
                        new BsonDocument
                        {
                            {"_id", "$Ngaynap"},
                            {"Tongtiennap", new BsonDocument("$sum", "$Tiennap")}
                        }
                    }
                };

                var projectStage = new BsonDocument
                {
                    {
                        "$project",
                        new BsonDocument
                        {
                            {"_id", 0},
                            {"Ngaynap", "$_id"},
                            {"Tongtiennap", 1}
                        }
                    }
                };

                var sortStage = new BsonDocument("$sort", new BsonDocument("Ngaynap", 1));

                var pipeline = new[] { matchStage, groupStage, projectStage, sortStage };

                var result = logNapColl.Aggregate<ThongKeDoanhThuDTO>(pipeline).ToList();

                return result;
            }
            catch
            {
                return new List<ThongKeDoanhThuDTO>();
            }
        }

        public int SoBaiDangTheoNgay(DateTime ngay)
        {
            try
            {
                var filter = Builders<BsonDocument>.Filter.And(
                    Builders<BsonDocument>.Filter.Gte("Thoigiandang", ngay.ToString("dd-MM-yyyy")),
                    Builders<BsonDocument>.Filter.Lte("Thoigiandang", ngay.AddDays(1).ToString("dd-MM-yyyy"))
                );

                var documents = baiDangColl.Find(filter).ToList();

                var count = 0;

                foreach (var document in documents)
                {
                    if (DateTime.TryParseExact(document["Thoigiandang"].AsString, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
                    {
                        if (parsedDate.Date == ngay.Date)
                        {
                            count++;
                        }
                    }
                }

                return count;
            }
            catch
            {
                return 0;
            }
        }

        public int SoKhachHangTheoNgay(DateTime ngay)
        {
            try
            {
                var filter = Builders<BsonDocument>.Filter.And(
                             Builders<BsonDocument>.Filter.Gte("Ngaydangki", ngay.ToString("dd-MM-yyyy")),
                             Builders<BsonDocument>.Filter.Lte("Ngaydangki", ngay.AddDays(1).ToString("dd-MM-yyyy"))
                             );

                var documents = khachHangColl.Find(filter).ToList();

                var count = 0;

                foreach (var document in documents)
                {
                    if (DateTime.TryParseExact(document["Ngaydangki"].AsString, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
                    {
                        if (parsedDate.Date == ngay.Date)
                        {
                            count++;
                        }
                    }
                }
                return count;
            }
            catch
            {
                return 0;
            }
        }

        public double TongGiaTriBDSTheoNgay(DateTime ngay)
        {
            try
            {
                var filter = Builders<BsonDocument>.Filter.And(
                    Builders<BsonDocument>.Filter.Gte("Thoigiandang", ngay.ToString("dd-MM-yyyy")),
                    Builders<BsonDocument>.Filter.Lte("Thoigiandang", ngay.AddDays(1).ToString("dd-MM-yyyy"))
                );

                var documents = baiDangColl.Find(filter).ToList();

                double sum = 0;

                foreach (var document in documents)
                {
                    if (DateTime.TryParseExact(document["Thoigiandang"].AsString, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
                    {
                        if (parsedDate.Date == ngay.Date)
                        {
                            sum += document["Gia"].AsDouble;
                        }
                    }
                }

                return sum;
            }
            catch
            {
                return 0;
            }
        }

        public double TongDoangThuTheoNgay(DateTime ngay)
        {
            try
            {
                var filter = Builders<BsonDocument>.Filter.And(
                    Builders<BsonDocument>.Filter.Gte("Ngaynap", ngay.ToString("dd-MM-yyyy")),
                    Builders<BsonDocument>.Filter.Lte("Ngaynap", ngay.AddDays(1).ToString("dd-MM-yyyy"))
                );

                var documents = logNapColl.Find(filter).ToList();

                double sum = 0;

                foreach (var document in documents)
                {
                    if (DateTime.TryParseExact(document["Ngaynap"].AsString, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
                    {
                        if (parsedDate.Date == ngay.Date)
                        {
                            sum += document["Tiennap"].AsDouble;
                        }
                    }
                }
                return sum;
            }
            catch
            {
                return 0;
            }
        }

        public List<ThongKeDTO> ThongKeLoaiNhaTheoNgay(DateTime ngay)
        {
            try
            {
                var match = new BsonDocument
                {
                    {
                        "$match",
                        new BsonDocument
                        {
                            {"$expr", new BsonDocument
                                {
                                    {"$and", new BsonArray
                                        {
                                            new BsonDocument { {"$eq", new BsonArray {new BsonDocument("$dayOfMonth", new BsonDocument("$dateFromString", new BsonDocument { { "dateString", "$Thoigiandang" }, { "format", "%d-%m-%Y" } })), ngay.Day}} },
                                            new BsonDocument { {"$eq", new BsonArray {new BsonDocument("$month", new BsonDocument("$dateFromString", new BsonDocument { { "dateString", "$Thoigiandang" }, { "format", "%d-%m-%Y" } })), ngay.Month}} },
                                            new BsonDocument { {"$eq", new BsonArray {new BsonDocument("$year", new BsonDocument("$dateFromString", new BsonDocument { { "dateString", "$Thoigiandang" }, { "format", "%d-%m-%Y" } })), ngay.Year}} }
                                        }
                                    }
                                }
                            }
                        }
                    }
                };

                // Các bước khác giữ nguyên không đổi
                var group = new BsonDocument
                {
                    {
                        "$group",
                        new BsonDocument
                        {
                            {"_id", new BsonDocument { { "date", new BsonDocument("$dateFromString", new BsonDocument("dateString", "$Thoigiandang").Add("format", "%d-%m-%Y")) }, { "loainha", "$Loainha" } }},
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
                            {"Thoigiandang", "$_id.date"},
                            {"Loainha", "$_id.loainha"},
                            {"Soluongbaidang", 1}
                        }
                    }
                };

                var pipeline = new[] { BsonDocument.Parse(match.ToJson()), BsonDocument.Parse(group.ToJson()), BsonDocument.Parse(project.ToJson()) };
                var result = baiDangColl.Aggregate<ThongKeDTO>(pipeline).ToList();

                return result;
            }
            catch
            {
                return new List<ThongKeDTO>();
            }
        }
    }
}
