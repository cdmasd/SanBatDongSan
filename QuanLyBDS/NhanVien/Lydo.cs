using BUS_QuanLyBDS;
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
    public partial class Lydo : Form
    {
        BUS_QuanLyBDS.NhanVien nv = new BUS_QuanLyBDS.NhanVien();
        string idbai;
        public Lydo(string id)
        {
            InitializeComponent();
            this.idbai = id;
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            string email = nv.getEmailKh(idbai);
            if (nv.TuchoiBaiDang(idbai))
            {
                Mail.MailRejected(email, idbai, txtLydo.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Không tìm được bài đăng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
