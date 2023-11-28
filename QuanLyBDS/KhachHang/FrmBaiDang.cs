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
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu email đã được xác thực (đã đăng nhập)
                string tieuDe = txtTieude.Text;
                string loaiNha = cbLoainha.Text;
                // Convert string inputs to appropriate numeric types
                if (!double.TryParse(txtDientich.Text, out double dientich))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng cho diện tích.");
                    return;
                }

                if (!int.TryParse(txtSophong.Text, out int sophong))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng cho số phòng.");
                    return;
                }

                if (!double.TryParse(txtGia.Text, out double gia))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng cho giá.");
                    return;
                }

                string diaChi = txtDiachi.Text;

                // Kiểm tra nếu có dữ liệu bị bỏ trống
                if (string.IsNullOrEmpty(tieuDe) || string.IsNullOrEmpty(loaiNha) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(imagePath))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin và chọn ảnh.");
                    return;
                }

                // Đăng ảnh lên Cloudinary
                string cloudinaryUrl = UploadImageToCloudinary(imagePath);

                if (cloudinaryUrl != null)
                {
                    // Cập nhật hình ảnh với link từ Cloudinary
                    string hinhAnh = cloudinaryUrl;

                    // Gọi phương thức DangTin từ lớp BUS và truyền địa chỉ email và URL của ảnh
                    bool result = kh.DangTin(tieuDe, loaiNha, dientich, sophong, gia, diaChi, hinhAnh, FrmMain.mail);

                    if (result)
                    {
                        MessageBox.Show("Đăng tin thành công. Vui lòng chờ duyệt từ phía nhân viên.");
                    }
                    else
                    {
                        MessageBox.Show("Đăng tin thất bại. Vui lòng kiểm tra lại thông tin.");
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi khi tải lên ảnh lên Cloudinary. Vui lòng thử lại.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng cho các trường số.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
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
                MessageBox.Show($"Lỗi khi tải lên hình ảnh: {ex.Message}");
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
                MessageBox.Show($"Lỗi khi khởi tạo Cloudinary: {ex.Message}");
            }
        }

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
    }
}
