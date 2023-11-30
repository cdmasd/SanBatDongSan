using QuanLyBDS.Admin;
using QuanLyBDS.Guest;
using QuanLyBDS.KhachHang;
using QuanLyBDS.NhanVien;
using Sunny.UI;

namespace QuanLyBDS
{
    public partial class FrmMain : UIForm
    {
        public static int session = 0; // kiểm tra đăng nhập chưa
        public static string mail;
        public static string vaitro;
        FrmDangNhap dn = new FrmDangNhap();
        public FrmMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            dn.TopLevel = false;
            PanelMain.Controls.Add(dn);
            dn.Show();
            dn.FormClosed += new FormClosedEventHandler(FrmDangNhap_FormClosed);
        }
        void DangNhap()
        {
            FrmDangNhap newdangnhap = new FrmDangNhap();
            newdangnhap.TopLevel = false;
            PanelMain.Controls.Add(newdangnhap);
            newdangnhap.Show();
            newdangnhap.FormClosed += new FormClosedEventHandler(FrmDangNhap_FormClosed);
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            OpenVaitro();
            if (session == 0)
            {
                this.Text = mail;
                DangNhap();
            }
        }
        public void OpenVaitro()
        {
            if (session == 1)
            {
                this.Text = mail;
                if (vaitro == "admin")
                {
                    FrmMainnAdmin ad = new FrmMainnAdmin();
                    ad.TopLevel = false;
                    PanelMain.Controls.Add(ad);
                    ad.Show();
                    ad.FormClosed += new FormClosedEventHandler(FrmMainAdmin_FormClosed);
                }
                else if (vaitro == "khachhang")
                {
                    FrmMainnKhachHang kh = new FrmMainnKhachHang();
                    kh.TopLevel = false;
                    PanelMain.Controls.Add(kh);
                    kh.Show();
                    kh.FormClosed += new FormClosedEventHandler(FrmMainKhachHang_FormClosed);
                }
                else if (vaitro == "nhanvien")
                {
                    FrmMainnNhanVien nv = new FrmMainnNhanVien();
                    nv.TopLevel = false;
                    PanelMain.Controls.Add(nv);
                    nv.Show();
                    nv.FormClosed += new FormClosedEventHandler(FrmMainNhanVien_FormClosed);
                }
                if (vaitro == "guest")
                {
                    FrmMainGuest guest = new FrmMainGuest();
                    guest.TopLevel = false;
                    PanelMain.Controls.Add(guest);
                    guest.Show();
                    guest.FormClosed += new FormClosedEventHandler(FrmMainGuest_FormClosed);
                }
            }
        }
        void FrmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            FrmMain_Load(sender, e);
        }
        void FrmMainAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            FrmMain_Load(sender, e);
        }
        void FrmMainKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            FrmMain_Load(sender, e);
        }
        void FrmMainNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            FrmMain_Load(sender, e);
        }
        void FrmMainGuest_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            FrmMain_Load(sender, e);
        }
    }
}
