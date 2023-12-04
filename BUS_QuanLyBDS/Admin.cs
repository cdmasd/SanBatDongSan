using DTO_QuanLyBDS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Security.Cryptography;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

namespace BUS_QuanLyBDS
{
    public class Admin
    {
        private readonly DAL_QuanLyBDS.Admin dal_Admin;
        private const string apiKey = "c9edb9285c810b4fae2b8829e8586f4976b45e55";
        public Admin()
        {
            dal_Admin = new DAL_QuanLyBDS.Admin();
        }

        public List<NhanVienDTO> DanhSachNhanVien()
        {
            return dal_Admin.DanhSachNhanVien();
        }

        public string MaNhanVien()
        {
            int soLuongNV = dal_Admin.DanhSachNhanVien().Count();
            List<int> listId = dal_Admin.DanhSachSoId();
            if (dal_Admin.DanhSachNhanVien().Count > 0)
            {
                int maxId = listId.Max() + 1;
                if (soLuongNV > 0)
                {
                    if (maxId < 10)
                    {
                        return "NV000" + maxId;
                    }
                    else if (maxId < 100)
                    {
                        return "NV" + "00" + maxId;
                    }
                    else if (maxId < 1000)
                    {
                        return "NV" + "0" + maxId;
                    }
                    else
                    {
                        return "NV" + maxId;
                    }
                }
            }
            return "NV0001";
        }

        public string ThemNhanVien(NhanVienDTO nhanVien, TaiKhoanDTO taiKhoan)
        {
            return dal_Admin.ThemNhanVien(nhanVien, taiKhoan);
        }

        public string CapNhatNhanVien(NhanVienDTO nhanVien, TaiKhoanDTO taiKhoan)
        {
            return dal_Admin.CapNhatNhanVien(nhanVien, taiKhoan);
        }

        public string Encrytion(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder builder = new StringBuilder();
            foreach (var item in encrypt)
            {
                builder.Append(item.ToString());
            }
            return builder.ToString();
        }

        public bool KiemTraEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }

        public async Task<string> KiemTraEmailTonTai(string email)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string apiUrl = $"https://api.hunter.io/v2/email-verifier?email={email}&api_key={apiKey}";
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        // phân tích JSON response
                        var data = JObject.Parse(jsonResponse);
                        string status = data["data"]["result"].ToString();

                        if (status.Equals("deliverable", StringComparison.OrdinalIgnoreCase))
                        {
                            return "Email hợp lệ";
                        }
                        else if (status.Equals("undeliverable", StringComparison.OrdinalIgnoreCase))
                        {
                            return "Không thể gửi mail cho địa chỉ email này\n hãy kiểm tra lại địa chỉ email";
                        }
                        else
                        {
                            return "Trạng thái email không xác định \n hãy kiểm tra lại email";
                        }
                    }
                    else
                    {
                        return "Địa chỉ email không hợp lệ";
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<NhanVienDTO> TimKiemNhanVienTheoId(string Id)
        {
            return dal_Admin.TimKiemNhanVienTheoId(Id);
        }

        public long TongKhachHang()
        {
            return dal_Admin.TongKhachHang();
        }

        public long TongSoLuongBaiDang()
        {
            return dal_Admin.TongSoLuongBaiDang();
        }

        public double TongGiaTriBDS()
        {
            return dal_Admin.TongGiaTriBDS();
        }

        public List<ThongKeDTO> ThongKeBaiDang()
        {
            return dal_Admin.ThongKeBaiDang();
        }

        public List<ThongKeDTO> ThongKeTop5()
        {
            return dal_Admin.ThongKeTop5();
        }

        public double TongDoanhThu()
        {
            return dal_Admin.TongDoanhThu();
        }

        public List<ThongKeDoanhThuDTO> ThongKeDoanhThu()
        {
            return dal_Admin.ThongKeDoanhThu();
        }

        public long TicketDaDuyet()
        {
            return dal_Admin.TicketDaDuyet();
        }

        public long TicketChuaDuyet()
        {
            return dal_Admin.TicketChuaDuyet();
        }

        public long BaiDangDaDuyet()
        {
            return dal_Admin.BaiDangDaDuyet();
        }

        public long BaiDangChuaDuyet()
        {
            return dal_Admin.BaiDangChuaDuyet();
        }

        public int ThongKeNgayTrongThang()
        {
            return dal_Admin.ThongKeBaiDangTrongThang();
        }

        public int ThongKeKhachHangTrongThang()
        {
            return dal_Admin.ThongKeKhachHangTrongThang();
        }

        public double ThongKeTongGiaTriBDS()
        {
            return dal_Admin.ThongKeTongGiaTriBDS();
        }

        public double ThongKeDoanhThuTrongThang()
        {
            return dal_Admin.ThongKeDoanhThuTrongThang();
        }

        public List<ThongKeDTO> ThongKeBaiDangTrongThangChart()
        {
            return dal_Admin.ThongKeBaiDangTrongThangChart();
        }

        public List<ThongKeDTO> ThongKeLoaiNhaTrongThangChart()
        {
            return dal_Admin.ThongKeLoaiNhaTrongThangChart();
        }

        public List<ThongKeDoanhThuDTO> ThongKeDoanThuTrongThang()
        {
            return dal_Admin.ThongKeDoanThuTrongThang();
        }

        public int SoBaiDangTheoNgay(DateTime ngay)
        {
            return dal_Admin.SoBaiDangTheoNgay(ngay);
        }

        public int SoKhachHangTheoNgay(DateTime ngay)
        {
            return dal_Admin.SoKhachHangTheoNgay(ngay);
        }

        public double TongGiaTriBDSTheoNgay(DateTime ngay)
        {
            return dal_Admin.TongGiaTriBDSTheoNgay(ngay);
        }

        public double TongDoangThuTheoNgay(DateTime ngay)
        {
            return dal_Admin.TongDoangThuTheoNgay(ngay);
        }

        public List<ThongKeDTO> ThongKeLoaiNhaTheoNgay(DateTime ngay)
        {
            return dal_Admin.ThongKeLoaiNhaTheoNgay(ngay);
        }
    }
}
