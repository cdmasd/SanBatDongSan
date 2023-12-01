        using Sunny.UI;
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using BUS_QuanLyBDS;

namespace QuanLyBDS
{
    public partial class FrmDangNhap : UIForm
    {
        BUS_QuanLyBDS.DangNhap dn = new BUS_QuanLyBDS.DangNhap();
        string num;
        string newpass;
        public FrmDangNhap()
        {
            InitializeComponent();
            LoginView();
            settingsUI();
        }
        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.isSave)
            {
                txtEmail.Text = Properties.Settings.Default.email;
                txtPassword.Text = Properties.Settings.Default.matkhau;
                chkRemember.Checked = true;
            }
        }

        #region Giao diện
        public void settingsUI()
        {
            UIStyles.DPIScale = true;
            UIStyles.GlobalFont = true;
            UIStyles.GlobalFontName = "Tahoma";
            UIStyles.SetDPIScale();
            UILocalize.OK = "Ok";
            UILocalize.Cancel = "Cancel";
            UILocalize.SuccessTitle = "Success";
            UILocalize.ErrorTitle = "Error";
        }
        void ResetValues()
        {
            txtEmailre.Text = null;
            txtHoTenre.Text = null;
            txtSoDTre.Text = null;
            txtPasswordre.Text = null;
            txtXacthuc.Text = null;
        }
        void LoginView()
        {
            uiLabel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            txtEmail.Enabled = true;
            txtEmail.Visible = true;
            txtPassword.Enabled = true;
            txtPassword.Visible = true;
            chkRemember.Enabled = true;
            chkRemember.Visible = true;
            btnForgotPassword.Enabled = true;
            btnForgotPassword.Visible = true;
            btnLogin.Enabled = true;
            btnLogin.Visible = true;
            uiLabel2.Visible = true;
            btnTaoTaiKhoan.Enabled = true;
            btnTaoTaiKhoan.Visible = true;
            btnKhach.Enabled = true;
            btnKhach.Visible = true;
            // register
            lb1re.Visible = false;
            lb2re.Visible = false;
            lb3re.Visible = false;
            lb4re.Visible = false;
            lb5re.Visible = false;
            lb6re.Visible = false;
            txtEmailre.Enabled = false;
            txtEmailre.Visible = false;
            txtPasswordre.Enabled = false;
            txtPasswordre.Visible = false;
            txtHoTenre.Enabled = false;
            txtHoTenre.Visible = false;
            txtSoDTre.Enabled = false;
            txtSoDTre.Visible = false;
            btnRegister.Enabled = false;
            btnRegister.Visible = false;
            btnDangNhapre.Enabled = false;
            btnDangNhapre.Visible = false;
            txtXacthuc.Enabled = false;
            txtXacthuc.Visible = false;
            btnLayma.Enabled = false;
            btnLayma.Visible = false;
            label3.Visible = false;
        }
        // Mở giao diện của register
        void RegisterView()
        {
            lb1re.Visible = true;
            lb2re.Visible = true;
            lb3re.Visible = true;
            lb4re.Visible = true;
            lb5re.Visible = true;
            lb6re.Visible = true;
            txtEmailre.Enabled = true;
            txtEmailre.Visible = true;
            txtPasswordre.Enabled = true;
            txtPasswordre.Visible = true;
            txtHoTenre.Enabled = true;
            txtHoTenre.Visible = true;
            txtSoDTre.Enabled = true;
            txtSoDTre.Visible = true;
            btnRegister.Enabled = true;
            btnRegister.Visible = true;
            btnDangNhapre.Enabled = true;
            btnDangNhapre.Visible = true;
            txtXacthuc.Enabled = true;
            txtXacthuc.Visible = true;
            btnLayma.Enabled = true;
            btnLayma.Visible = true;
            label3.Visible = true;
            // Login
            uiLabel1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            txtEmail.Enabled = false;
            txtEmail.Visible = false;
            txtPassword.Enabled = false;
            txtPassword.Visible = false;
            chkRemember.Enabled = false;
            chkRemember.Visible = false;
            btnForgotPassword.Enabled = false;
            btnForgotPassword.Visible = false;
            btnLogin.Enabled = false;
            btnLogin.Visible = false;
            uiLabel2.Visible = false;
            btnTaoTaiKhoan.Enabled = false;
            btnTaoTaiKhoan.Visible = false;
            btnKhach.Enabled = false;
            btnKhach.Visible = false;
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmailEmpty.Visible = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPasswordEmpty.Visible = false;
        }
        private void txtEmailre_TextChanged(object sender, EventArgs e)
        {
            txtEmailreEmpty.Visible = false;
            txtEmailreInvalid.Visible = false;
        }

        private void txtSoDTre_TextChanged(object sender, EventArgs e)
        {
            txtSodtreEmpty.Visible = false;
            txtSodtreInvalid.Visible = false;
        }

        private void txtHoTenre_TextChanged(object sender, EventArgs e)
        {
            txtHotenreEmpty.Visible = false;
        }

        private void txtPasswordre_TextChanged(object sender, EventArgs e)
        {
            txtPasswordreEmpty.Visible = false;
        }

        private void txtXacthuc_TextChanged(object sender, EventArgs e)
        {
            txtXacnhanEmpty.Visible = false;
            txtXacthucsai.Visible = false;
        }
        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            RegisterView();
        }
        // Mở giao diện của đăng nhập
        private void btnDangNhapre_Click(object sender, EventArgs e)
        {
            LoginView();
        }
        #endregion
        #region chức năng
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!registerEmpty())
            {
                return;
            }
            if (dn.insertKhachhang(txtEmailre.Text, txtHoTenre.Text, txtSoDTre.Text, txtPasswordre.Text))
            {
                ShowSuccessTip("Đăng kí thành công");
                // Lưu thông tin tài khoản
                btnDangNhapre_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Dăng kí không thành công,email hoặc số điện thoại đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ResetValues();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!loginEmpty())
            {
                return;
            }
            try
            {
                if (dn.checkAccount(txtEmail.Text, txtPassword.Text))
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Gửi kết quả đăng nhập cho frmMain
                    FrmMain.mail = txtEmail.Text;
                    FrmMain.session = 1;
                    FrmMain.vaitro = dn.getRole(txtEmail.Text);
                    // Lưu thông tin tài khoản
                    Properties.Settings.Default.isSave = chkRemember.Checked;
                    if (chkRemember.Checked)
                    {
                        Properties.Settings.Default.email = txtEmail.Text;
                        Properties.Settings.Default.matkhau = txtPassword.Text;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        Properties.Settings.Default.email = "";
                        Properties.Settings.Default.matkhau = "";
                        Properties.Settings.Default.Save();
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công, email hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Text = "";
                    txtPassword.Text = "";
                    txtEmail.Focus();
                }
            } catch
            {
                MessageBox.Show("Máy chủ đang bận, vui lòng truy cập sau ít phút", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKhach_Click(object sender, EventArgs e)
        {
            FrmMain.mail = "Sàn bất động sản";
            FrmMain.session = 1;
            FrmMain.vaitro = "guest";
            this.Close();
        }
        private void btnLayma_Click(object sender, EventArgs e)
        {
            num = generateNum();
            MessageBox.Show(Mail.MailRegister(txtEmail.Text.Trim(), num), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            newpass = dn.RandomString();
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập email lấy lại mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dn.changePass(txtEmail.Text, newpass))
            {
                MessageBox.Show(Mail.MailRecovery(txtEmail.Text.Trim(), newpass), "Thông báo");
            } 
            else
            {
                MessageBox.Show("Email chưa được đăng kí", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        #endregion
        #region Xác thực
        public static bool isEmail(string inputEmail)
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
        public static bool isPhone(string phone)
        {
            string strRegex = @"^0\d{9}$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(phone))
                return (true);
            else
                return (false);
        }
        public string generateNum()
        {
            Random rd = new Random();
            return rd.Next(100000, 999999).ToString();
        }
        private void txtSoDTre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion
        #region Kiểm tra rỗng
        bool loginEmpty()
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmailEmpty.Visible = true;
                txtEmail.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPasswordEmpty.Visible = true;
                txtPassword.Focus();
                return false;
            }
            return true;
        }
        bool registerEmpty()
        {
            if (string.IsNullOrWhiteSpace(txtEmailre.Text))
            {
                txtEmailreEmpty.Visible = true;
                txtEmailre.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtHoTenre.Text))
            {
                txtHotenreEmpty.Visible = true;
                txtHoTenre.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSoDTre.Text))
            {
                txtSodtreEmpty.Visible = true;
                txtSoDTre.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtPasswordre.Text))
            {
                txtPasswordreEmpty.Visible = true;
                txtPasswordre.Focus();
                return false;
            }
            if (!isEmail(txtEmailre.Text.Trim()))
            {
                txtEmailreInvalid.Visible = true;
                txtEmailre.Focus();
                return false;
            }
            if (!isPhone(txtSoDTre.Text.Trim()))
            {
                txtSodtreInvalid.Visible = true;
                txtSoDTre.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtXacthuc.Text))
            {
                txtXacnhanEmpty.Visible = true;
                txtXacthuc.Focus();
                return false;
            }
            if (txtXacthuc.Text != num)
            {
                txtXacthucsai.Visible = true;
                txtXacthuc.Focus();
                return false;
            }
            return true;
        }

        #endregion
    }
}
