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


                bool result = kh.UpdateThongTinKH(Email, HoTen, Sodienthoai);
                if (result)
                {
                    MessageBox.Show("Cập nhật thành công");
                    loadData();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng sửa thông tin mới ấn cập nhật");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void FrmThongTin_Load(object sender, EventArgs e)
        {
            loadData();
            txtEmail.ReadOnly = true;
        }
    }
}
