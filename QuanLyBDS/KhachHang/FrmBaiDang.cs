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
using CloudinaryDotNet.Actions;
using CloudinaryDotNet;
namespace QuanLyBDS.KhachHang
{
    public partial class FrmBaiDang : UIForm
    {
        BUS_QuanLyBDS.KhachHang kh = new BUS_QuanLyBDS.KhachHang();
        private const string CloudName = "dzhievecr";
        private const string ApiKey = "155172834399586";
        private const string ApiSecret = "a4qvVx8GHsPG8xZYTaedG5XJVc8";
        private Cloudinary cloudinary;
        private string imagePath;
        public FrmBaiDang()
        {
            InitializeComponent();
            cbLoainha.DropDownStyle = UIDropDownStyle.DropDownList;
            InitializeCloudinary();
            cbLoainha.SelectedIndex = 0;
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (kh.getSodu(FrmMain.mail) < 20000)
                {
                    MessageBox.Show("", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Kiểm tra nếu có dữ liệu bị bỏ trống
                if (!checkNull())
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin và chọn ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Đăng ảnh lên Cloudinary
                string cloudinaryUrl = UploadImageToCloudinary(imagePath);

                if (cloudinaryUrl != null)
                {
                    // Cập nhật hình ảnh với link từ Cloudinary
                    string hinhAnh = cloudinaryUrl;
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if(result == DialogResult.OK)
                    {
                        bool thongbao = kh.DangTin(txtTieude.Text, cbLoainha.SelectedText, double.Parse(txtDientich.Text), int.Parse(txtSophong.Text), double.Parse(txtGia.Text), txtDiachi.Text, hinhAnh, FrmMain.mail);
                        if (thongbao)
                        {
                            ResetValue();
                            MessageBox.Show("Vui lòng chờ nhân viên duyệt", "Thông báo", MessageBoxButtons.OK);
                        }
                    } else
                    {
                        return;
                    }  
                }
                else
                {
                    MessageBox.Show("Lỗi khi tải lên ảnh lên thư viện. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi phát sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dl = new OpenFileDialog();
            dl.Filter = "Image | *.jpg;*.png;*.jpeg";
            DialogResult result = dl.ShowDialog();

            if (result == DialogResult.OK)
            {
                picHinhAnh.Image = new Bitmap(dl.FileName);
                txtHinhanh.Text = dl.FileName;
                imagePath = dl.FileName;
            }
        }
        private string UploadImageToCloudinary(string path)
        {
            try
            {
                var uploadParams = new ImageUploadParams
                {
                    File = new FileDescription(path),
                };

                var uploadResult = cloudinary.Upload(uploadParams);
                return uploadResult.Uri.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải ảnh lên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private void InitializeCloudinary()
        {
            try
            {
                Account account = new Account(CloudName, ApiKey, ApiSecret);
                cloudinary = new Cloudinary(account);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi tạo thư viện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region check valid
        private void txtDientich_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSophong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FrmBaiDang_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            UploadImageToCloudinary(imagePath);
        }
        bool checkNull()
        {
            if (string.IsNullOrEmpty(txtTieude.Text))
            {
                txtTieude.Focus();
                return false;
            }
         
            if (string.IsNullOrEmpty(txtDientich.Text))
            {
                txtDientich.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtGia.Text))
            {
                txtGia.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDiachi.Text))
            {
                txtDiachi.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtHinhanh.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(txtSophong.Text))
            {
                txtSophong.Focus();
                return false;
            }
            return true; 

        }
        void ResetValue()
        {
            txtTieude.Text = "";
            txtDiachi.Text = "";
            txtSophong.Text = "";
            txtGia.Text = "";
            txtDientich.Text = "";
            txtHinhanh.Text = "";
            picHinhAnh.Image = null; 
        }
        #endregion
    }
}
