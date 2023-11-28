using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
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
    public partial class FrmDanhSachBaiDang : UIForm
    {
        BUS_QuanLyBDS.KhachHang kh = new BUS_QuanLyBDS.KhachHang();
        private const string CloudName = "dzhievecr";
        private const string ApiKey = "155172834399586";
        private const string ApiSecret = "a4qvVx8GHsPG8xZYTaedG5XJVc8";
        private Cloudinary cloudinary;
        private string imagePath;
        public FrmDanhSachBaiDang()
        {
            InitializeComponent();
            cbLoainha.DropDownStyle = UIDropDownStyle.DropDownList;
            dtView.CellClick += dtView_CellClick;
            LoadDataBaiDang();
            InitializeCloudinary();
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dl = new OpenFileDialog();
            dl.Filter = "Image | *.jpg;*.png;*.jpeg";
            DialogResult result = dl.ShowDialog();

            if (result == DialogResult.OK)
            {

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtId.Text;
                string tieuDe = txtTieude.Text;
                string loaiNha = cbLoainha.Text;

                if (!double.TryParse(txtDientich.Text, out double dientich) ||
                    !int.TryParse(txtSophong.Text, out int sophong) ||
                    !double.TryParse(txtGia.Text, out double gia))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng cho các trường số.");
                    return;
                }
                string diaChi = txtDiachi.Text;
                string hinhAnh = txtHinhanh.Text;

                if (string.IsNullOrEmpty(tieuDe) || string.IsNullOrEmpty(loaiNha) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(hinhAnh))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                    return;
                }
                string cloudinaryUrl = UploadImageToCloudinary(imagePath);
                if (cloudinaryUrl != null)
                {
                    hinhAnh = cloudinaryUrl;
                    bool result = kh.UpdateBaidang(id, tieuDe, loaiNha, dientich, sophong, gia, diaChi, hinhAnh);

                    if (result)
                    {
                        MessageBox.Show("Cập nhật thành công");
                        LoadDataBaiDang();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại. Vui lòng kiểm tra lại thông tin.");
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
        private void dtView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtView.Rows[e.RowIndex];

                // Lấy dữ liệu từ các ô của dòng được chọn
                string id = selectedRow.Cells["_id"].Value.ToString();
                string tieuDe = selectedRow.Cells["Tieude"].Value.ToString();
                string loaiNha = selectedRow.Cells["Loainha"].Value.ToString();
                string dienTich = selectedRow.Cells["Dientich"].Value.ToString();
                string soPhong = selectedRow.Cells["Sophong"].Value.ToString();
                string gia = selectedRow.Cells["Gia"].Value.ToString();
                string diaChi = selectedRow.Cells["Diachi"].Value.ToString();
                string hinhAnh = selectedRow.Cells["Hinhanh"].Value.ToString();

                // Hiển thị dữ liệu lên các controls
                txtId.Text = id;
                txtTieude.Text = tieuDe;
                cbLoainha.Text = loaiNha;
                txtDientich.Text = dienTich;
                txtSophong.Text = soPhong;
                txtGia.Text = gia;
                txtDiachi.Text = diaChi;
                txtHinhanh.Text = hinhAnh;

            }
        }
        private void LoadDataBaiDang()
        {
            List<BsonDocument> dataBaiDang = kh.getBaiDang();
            dtView.ClearAll();
            // Load header name
            if (dataBaiDang.Count > 0)
            {
                foreach (var header in dataBaiDang[0].Names)
                {
                    if (header != "Thoigiandang")
                    {
                        if (header != "Trangthai")
                        {
                            dtView.Columns.Add(header, header);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }


                // Đổ dữ liệu vào từng dòng của DataGridView
                foreach (var doc in dataBaiDang)
                {
                    List<object> values = new List<object>();
                    foreach (var key in doc.Names)
                    {
                        values.Add(doc[key]);
                    }
                    dtView.Rows.Add(values.ToArray());
                }
                dtView.Columns[0].HeaderText = "ID";
                dtView.Columns[1].HeaderText = "Tiêu đề";
                dtView.Columns[2].HeaderText = "Loại nhà";
                dtView.Columns[3].HeaderText = "Diện tích";
                dtView.Columns[4].HeaderText = "Số phòng";
                dtView.Columns[5].HeaderText = "Giá";
                dtView.Columns[6].HeaderText = "Địa chỉ";
                dtView.Columns[7].HeaderText = "Hình Ảnh";
                txtId.Visible = false;
            }
            else
            {
                txtId.Visible = true;
            }
        }

        private void FrmDanhSachBaiDang_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            UploadImageToCloudinary(imagePath);
        }
    }
}
