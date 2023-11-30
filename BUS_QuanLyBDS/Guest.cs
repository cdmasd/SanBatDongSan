using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLyBDS
{
    public class Guest
    {
        DAL_QuanLyBDS.Guest kh = new DAL_QuanLyBDS.Guest();

        public List<BsonDocument> Thongtinnguoidang(string _id)
        {
            return kh.Thongtinnguoidang(_id);
        }
        public DataTable DanhSach()
        {
            return kh.Danhsach();
        }
        public DataTable locLoaiNha(string loainha)
        {
            return kh.locLoaiNha(loainha);
        }

        public DataTable locKhuVuc(string quan)
        {
            return kh.locKhuVuc(quan);
        }
        public DataTable locsophong(int sophong)
        {
            return kh.locsophong(sophong);
        }
        public DataTable locdientich(double start, double end)
        {
            return kh.locdientich(start, end);
        }
        public DataTable locGia(double start, double end)
        {
            return kh.locGia(start, end);
        }
    }
}
