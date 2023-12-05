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
        string reason;
        public Lydo(string id,string cause)
        {
            InitializeComponent();
            this.idbai = id;
            this.reason = cause;
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            string email = nv.getEmailKh(idbai);
            if(reason == "từ chối")
            {
                if (nv.TuchoiBaiDang(idbai))
                {
                    Mail.MailRejected(email, idbai, txtLydo.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Từ chối thất bại, Không tìm thấy đối tượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                if (nv.DeleteBaiDang(idbai))
                {
                    Mail.MailDelete(email, idbai, txtLydo.Text); this.Close();
                }
                else
                {
                    MessageBox.Show("Xoá thất bại, Không tìm thấy đối tượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
