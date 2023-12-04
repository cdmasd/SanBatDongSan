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
    public partial class HinhAnh : UIForm
    {
        private string imageUrl;
        public HinhAnh(string imgAddress)
        {
            InitializeComponent();
            this.imageUrl = imgAddress;

        }

        private void HinhAnh_Load(object sender, EventArgs e)
        {
            DisplayImage();
        }
        private void DisplayImage()
        {
            if (!string.IsNullOrEmpty(imageUrl))
            {
                try
                {
                    pic.ImageLocation = imageUrl;
                }
                catch
                {
                    // Handle the exception (e.g., log, show error message)
                    MessageBox.Show("Lỗi khi tải ảnh lên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không có đường dẫn hình ảnh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
