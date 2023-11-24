using QuanLyBDS.NhanVien;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBDS.KhachHang
{
    public partial class FrmDoiMatKhau : FrmDoimatkhau
    {
        DAL_QuanLyBDS.DangNhap dn = new DAL_QuanLyBDS.DangNhap();
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }
    }
}
