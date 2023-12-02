using MongoDB.Bson;
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
    public partial class FrmHoTro : UIForm
    {
        BUS_QuanLyBDS.KhachHang kh = new BUS_QuanLyBDS.KhachHang();
        public FrmHoTro()
        {
            InitializeComponent();
        }
        private void load()
        {
            try
            {
                List<BsonDocument> tt = kh.showInfo(FrmMain.mail);
                if (tt.Count > 0)
                {
                    txtSodt.Text = tt[0]["Sodienthoai"].AsString;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }
        private void btnGuiyeucau_Click(object sender, EventArgs e)
        {
            string Sdt = txtSodt.Text;
            string Chitiet = txtChitiethotro.Text;
            string Vande = txtHotro.Text;

            bool result = kh.insertTicket(Sdt, Vande, Chitiet);
            if (!checkNull())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi gửi ticket", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (result)
            {
                MessageBox.Show("Gửi phản hồi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtChitiethotro.Text = null;
                txtHotro.Text = null;
            }
            else
            {
                MessageBox.Show("Gửi phản hồi thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmHoTro_Load(object sender, EventArgs e)
        {
            load();
            txtSodt.ReadOnly = true;
        }
        #region check null
        bool checkNull()
        {
            if (string.IsNullOrEmpty(txtChitiethotro.Text))
            {
                txtChitiethotro.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtHotro.Text))
            {
                txtHotro.Focus();
                return false;
            }
            return true;
        }
        #endregion
    }
}
