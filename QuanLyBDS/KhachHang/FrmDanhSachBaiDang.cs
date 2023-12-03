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
using System.Net.WebSockets;
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
        BUS_QuanLyBDS.PhanTrang pt = new BUS_QuanLyBDS.PhanTrang();
        private int currentpage = 1;
        private int recordPerPages = 10;
        private int totalRecord;
        private int index = 1;
        public FrmDanhSachBaiDang()
        {
            InitializeComponent();
            cbLoainha.DropDownStyle = UIDropDownStyle.DropDownList;
            dtView.CellClick += dtView_CellClick;
            btDaduyet.Enabled = false;
            LoadDaDuyet();
            InitializeCloudinary();
            btXoa.Enabled = false;
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

        void ResetValue()
        {
            txtTieude.Text = "";
            txtDiachi.Text = "";
            txtSophong.Text = "";
            txtGia.Text = "";
            txtDientich.Text = "";
            txtHinhanh.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu có dữ liệu bị bỏ trống
                if (!checkNull())
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin và ảnh cần chỉnh sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string cloudinaryUrl = txtHinhanh.Text;
                // Nếu có thay đổi ảnh, upload ảnh mới lên Cloudinary và lấy URL của ảnh
                if (imagePath != null && imagePath == txtHinhanh.Text)
                {
                    cloudinaryUrl = UploadImageToCloudinary(imagePath);
                }
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn sửa bài đăng", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    txtHinhanh.Text = cloudinaryUrl;
                    bool Ds = kh.UpdateBaidang(txtId.Text, txtTieude.Text, cbLoainha.SelectedText, double.Parse(txtDientich.Text), int.Parse(txtSophong.Text), double.Parse(txtGia.Text), txtDiachi.Text, txtHinhanh.Text);
                    if (Ds)
                    {
                        MessageBox.Show("Đã cập nhật bài đăng của bạn, Vui lòng chờ nhân viên duyệt", "Thông báo", MessageBoxButtons.OK);
                        ResetValue();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn bài đăng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi phát sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                btXoa.Enabled = true;
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
        private void LoadDaDuyet()
        {
            dtView.ClearAll();
            totalRecord = (int)pt.GetTotalRecordsCuaKHDangTinDaDuyet(FrmMain.mail);
            var data = pt.GetDataPageCuaKHDangTinDaDuyet(currentpage, recordPerPages, FrmMain.mail);
            dtView.DataSource = data;
            if (dtView.ColumnCount > 0)
            {
                dtView.Columns[0].HeaderText = "ID";
                dtView.Columns[1].HeaderText = "Tiêu đề";
                dtView.Columns[2].HeaderText = "Loại nhà";
                dtView.Columns[3].HeaderText = "Diện tích";
                dtView.Columns[4].HeaderText = "Số phòng";
                dtView.Columns[5].HeaderText = "Giá";
                dtView.Columns[6].HeaderText = "Địa chỉ";
                dtView.Columns[7].HeaderText = "Hình Ảnh";
                label8.Visible = false;
            }
            else
            {
                label8.Visible = true;
            }
            UpdatePage();
        }

        public void LoadChuaDuyet()
        {
            dtView.ClearAll();

            totalRecord = (int)pt.GetTotalRecordsCuaKHDangTinChuaDuyet(FrmMain.mail);
            var data = pt.GetDataPageCuaKHDangTinChuaDuyet(currentpage, recordPerPages, FrmMain.mail);
            dtView.DataSource = data;
            // Load header name
            if (dtView.ColumnCount > 0)
            {
                dtView.Columns[0].HeaderText = "ID";
                dtView.Columns[1].HeaderText = "Tiêu đề";
                dtView.Columns[2].HeaderText = "Loại nhà";
                dtView.Columns[3].HeaderText = "Diện tích";
                dtView.Columns[4].HeaderText = "Số phòng";
                dtView.Columns[5].HeaderText = "Giá";
                dtView.Columns[6].HeaderText = "Địa chỉ";
                dtView.Columns[7].HeaderText = "Hình Ảnh";
                label8.Visible = false;
            }
            else
            {
                label8.Visible = true;
            }
            UpdatePage();
        }
        public void LoadTuchoi()
        {
            dtView.ClearAll();
            index = 3;
            totalRecord = (int)pt.GetTotalRecordsCuaKHDangTinBiTuChoi(FrmMain.mail);
            var data = pt.GetDataPageCuaHKDangTinBiTuChoi(currentpage, recordPerPages, FrmMain.mail);
            dtView.DataSource = data;
            // Load header name
            if (dtView.ColumnCount > 0)
            {
                dtView.Columns[0].HeaderText = "ID";
                dtView.Columns[1].HeaderText = "Tiêu đề";
                dtView.Columns[2].HeaderText = "Loại nhà";
                dtView.Columns[3].HeaderText = "Diện tích";
                dtView.Columns[4].HeaderText = "Số phòng";
                dtView.Columns[5].HeaderText = "Giá";
                dtView.Columns[6].HeaderText = "Địa chỉ";
                dtView.Columns[7].HeaderText = "Hình Ảnh";
                label8.Visible = false;
            }
            else
            {
                label8.Visible = true;
            }
            UpdatePage();
        }
        private void FrmDanhSachBaiDang_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            UploadImageToCloudinary(imagePath);
        }

        private void btDaduyet_Click(object sender, EventArgs e)
        {
            index = 1;
            currentpage = 1;
            totalRecord = (int)pt.GetTotalRecordsCuaKHDangTinDaDuyet(FrmMain.mail);
            LoadDaDuyet();
            btDaduyet.Enabled = false;
            btChuaduyet.Enabled = true;
            btBituchoi.Enabled = true;
        }

        private void btChuaduyet_Click(object sender, EventArgs e)
        {
            index = 2;
            currentpage = 1;
            totalRecord = (int)pt.GetTotalRecordsCuaKHDangTinChuaDuyet(FrmMain.mail);
            LoadChuaDuyet();
            btDaduyet.Enabled = true;
            btChuaduyet.Enabled = false;
            btBituchoi.Enabled = true;
        }

        private void btBituchoi_Click(object sender, EventArgs e)
        {
            index = 3;
            currentpage = 1;
            totalRecord = (int)pt.GetTotalRecordsCuaKHDangTinBiTuChoi(FrmMain.mail);
            LoadTuchoi();
            btDaduyet.Enabled = true;
            btChuaduyet.Enabled = true;
            btBituchoi.Enabled = false;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá bài đăng ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                if (kh.DeleteBaiDang(txtId.Text))
                {
                    MessageBox.Show("Xoá bài đăng thành công", "Thông báo", MessageBoxButtons.OK);
                    btXoa.Enabled = true;
                }
            }
            ResetValue();
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

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (currentpage > 1)
            {
                currentpage--;
                if (index == 1)
                {
                    LoadDaDuyet();
                }
                else if (index == 2)
                {
                    LoadChuaDuyet();
                }
                else
                {
                    LoadTuchoi();
                }
            }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if (currentpage * recordPerPages < totalRecord)
            {
                currentpage++;
                if (index == 1)
                {
                    LoadDaDuyet();
                }
                else if (index == 2)
                {
                    LoadChuaDuyet();
                }
                else
                {
                    LoadTuchoi();
                }
            }
        }
        void UpdatePage()
        {
            txtCurrentPage.Text = $"Trang : {currentpage}";
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            if (index == 1)
            {
                LoadDaDuyet();
            }
            else if (index == 2)
            {
                LoadChuaDuyet();
            }
            else
            {
                LoadTuchoi();
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            cbLoainha.Text = string.Empty;
            ResetValue();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var result = pt.TimKiemBaiDangCuaKHDangTin(FrmMain.mail, txtTimKiem.Text.Trim().ToUpper());
            dtView.DataSource = result;
            txtTimKiem.Text = string.Empty;
        }
    }
}
