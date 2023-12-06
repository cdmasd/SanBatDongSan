using BUS_QuanLyBDS;
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

namespace QuanLyBDS.DangNhap
{
    public partial class QuenMatKhau : UIForm
    {
        BUS_QuanLyBDS.DangNhap dn = new BUS_QuanLyBDS.DangNhap();
        string newpass;
        public QuenMatKhau(string newpass)
        {
            this.newpass = newpass;
            InitializeComponent();
        }

        private void btKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập email lấy lại mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtCode.Text != uiVerificationCode1.Code)
            {
                MessageBox.Show("Mã xác minh không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // Thực hiện xử lý quên mật khẩu
                if (dn.changePass(txtEmail.Text, newpass))
                {
                    string noti = Mail.MailRecovery(txtEmail.Text.Trim(), newpass);
                    if(noti.Contains("Đã gửi"))
                    {
                        MessageBox.Show(noti, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearFields();
                        this.Close();
                    } else
                    {
                        MessageBox.Show(noti, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Email chưa được đăng kí", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        void clearFields()
        {
            txtCode.Text = "";
            txtEmail.Text = "";
        }
        private void uiVerificationCode1_Click(object sender, EventArgs e)
        {
            uiVerificationCode1.Refresh();
        }

        private void btnResetCode_Click(object sender, EventArgs e)
        {
            uiVerificationCode1_Click(uiVerificationCode1,EventArgs.Empty);
        }
    }
}
