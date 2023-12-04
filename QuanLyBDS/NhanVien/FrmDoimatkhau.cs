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
        BUS_QuanLyBDS.DangNhap dn = new BUS_QuanLyBDS.DangNhap();
        public FrmDoimatkhau()
        {
            InitializeComponent();
            txtEmail.Text = FrmMain.mail;
        }
        void ResetValues(){
            txtMatkhauhientai.Text = "";
            txtMatkhaumoi.Text = "";
            txtVerify.Text = "";
        }
        private void btnDoimatkhau_Click(object sender, EventArgs e)
        {
            string OldPass = txtMatkhauhientai.Text;
            string NewPass = txtMatkhaumoi.Text;
            string verifyPass = txtVerify.Text;

            if(OldPass == "" || NewPass == "" || verifyPass == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValues();
                return;
            }
            if (NewPass != verifyPass)
            {
                MessageBox.Show("Mật khẩu nhập lại không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVerify.Focus();
                return;
            }
            try
            {
                if (dn.checkAccount(FrmMain.mail, OldPass))
                {
                    dn.changePass(FrmMain.mail, NewPass);
                    MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Mật khẩu hiện tại không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi không tìm thấy email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ResetValues();
        }
    }
}
