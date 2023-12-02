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
    public partial class FrmThongTin : UIForm
    {
        BUS_QuanLyBDS.KhachHang kh = new BUS_QuanLyBDS.KhachHang();
        public FrmThongTin()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            try
            {
                List<BsonDocument> tt = kh.showInfo(FrmMain.mail);
                if (tt.Count > 0)
                {
                    txtEmail.Text = tt[0]["Email"].ToString();
                    txtHoten.Text = tt[0]["Hoten"].ToString();
                    txtSdt.Text = tt[0]["Sodienthoai"].ToString();
                    txtSodu.Text = tt[0]["Sodu"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string Email = txtEmail.Text;
                string HoTen = txtHoten.Text;
                string Sodienthoai = txtSdt.Text;
                // Kiểm tra nếu có dữ liệu bị bỏ trống
                if (!checknull())
                {
                    MessageBox.Show("Không được để trống thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loadData();
                    return;
                }
                bool result = kh.UpdateThongTinKH(Email, HoTen, Sodienthoai);

                if (result)
                {
                    MessageBox.Show("Cập nhật thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
                else
                {
                    MessageBox.Show("bạn chưa thay đổi thông tin", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Có lỗi trong quá trình cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmThongTin_Load(object sender, EventArgs e)
        {
            loadData();
            txtEmail.ReadOnly = true;
        }
        #region 
        bool checknull()
        {
            if (string.IsNullOrEmpty(txtHoten.Text))
            {
                txtHoten.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSdt.Text))
            {
                txtSdt.Focus();
                return false;
            }
            return true;
        }
        #endregion
    }
}
