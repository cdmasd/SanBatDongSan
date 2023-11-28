using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyBDS
{
    public class BaiDangDTO
    {
        public string _id { get; set; }
        public string Tieude { get; set; }
        public string Loainha { get; set; }
        public int Dientich { get; set; }
        public int Sophong { get; set; }
        public string Diachi { get; set; }
        public string Hinhanh { get; set; }
        public DateOnly Thoigiandang { get; set; }
        public string Trangthai { get; set; }
    }
}
