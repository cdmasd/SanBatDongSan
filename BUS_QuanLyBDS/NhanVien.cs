using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLyBDS
{
    public partial class NhanVien
    {
        DAL_QuanLyBDS.NhanVien nv = new DAL_QuanLyBDS.NhanVien();
        public DataTable Chuaduyet()
        {
            return nv.Chuaduyet();
        }
        public DataTable Daduyet()
        {
            return nv.Daduyet();
        }
        public bool Duyetbai(string id, string email)
        {
            return nv.Duyetbai(id, email);
        }
        public bool DeleteBaiDang(string id)
        {
            return nv.DeleteBaiDang(id);
        }
        public bool Hotro(string id, string email)
        {
            return nv.Hotro(id, email);
        }
        // khách hàng
        public DataTable Getkhachhang()
        {
            return nv.Getkhachhang();
        }
        public bool UpdateKhachhang(string id,string email, string hoten,double tiennap, double sodu)
        {
            return nv.UpdataKhachhang(id,email,hoten,tiennap, sodu);
        }
        public bool DeleteTaikhoanKH(string email, string id)
        {
            return nv.DeleteTaikhoanKH(email, id); 
        }
        public string getEmailKh(string id)
        {
            return nv.getEmailKh(id);
        }
        public bool TuchoiBaiDang(string id)
        {
            return nv.TuchoiBaiDang(id);
        }
        public DataTable TimKiemBaiDang(string id)
        {
            return nv.TimKiemBaiDang(id);
        }
        public DataTable TimKiemBaiDangDaDuyet(string id)
        {
            return nv.TimKiemBaiDangDaDuyet(id);
        }

        public DataTable TimKiemTicket(string Sdt)
        {
            return nv.TimKiemTicket(Sdt);
        }
        public DataTable TimKiemKH(string id)
        {
            return nv.TimKiemKH(id);
        }
    }

}
