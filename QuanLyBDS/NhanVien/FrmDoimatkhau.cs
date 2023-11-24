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

namespace QuanLyBDS.NhanVien
{
    public partial class FrmDoimatkhau : UIForm
    {
        DAL_QuanLyBDS.DangNhap dn = new DAL_QuanLyBDS.DangNhap();
        public FrmDoimatkhau()
        {
            InitializeComponent();
            txtEmail.Text = FrmMain.mail;
        }

        private void btnDoimatkhau_Click(object sender, EventArgs e)
        {
            string OldPass = txtMatkhauhientai.Text;
            string NewPass = txtMatkhaumoi.Text;
            string verifyPass = txtVerify.Text;
            if (NewPass != verifyPass)
            {
                ShowErrorDialog("Mật khẩu nhập lại không chính xác");
                txtVerify.Focus();
                return;
            }
            try
            {
                if (dn.checkAccount(FrmMain.mail, OldPass))
                {
                    dn.changePass(FrmMain.mail, NewPass);
                    ShowSuccessDialog("Đổi mật khẩu thành công.");
                }
                else
                {
                    ShowErrorDialog("Mật khẩu cũ không đúng hoặc email không tồn tại.");
                }
            }
            catch (Exception ex)
            {
                ShowErrorDialog($"Đã xảy ra lỗi: {ex.Message}");
            }
        }
    }
}
