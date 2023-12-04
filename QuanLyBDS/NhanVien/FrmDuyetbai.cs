using BUS_QuanLyBDS;
using MongoDB.Bson;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBDS.NhanVien
{
    public partial class FrmDuyetbai : UIForm
    {
        private int currentpage = 1;
        private int recordPerPages = 10;
        private int totalRecord;

        BUS_QuanLyBDS.NhanVien nv = new BUS_QuanLyBDS.NhanVien();
        BUS_QuanLyBDS.PhanTrang pt;
        public FrmDuyetbai()
        {
            InitializeComponent();
            UiSettings();
            pt = new();
            totalRecord = (int)pt.GetTotalRecordsDangTinChuaDuyet();
        }
        public void UiSettings()
        {
            UIStyles.DPIScale = true;
            UIStyles.GlobalFont = true;
            UIStyles.GlobalFontName = "Tahoma";
            UIStyles.SetDPIScale();
            UILocalize.OK = "Ok";
            UILocalize.Cancel = "Cancel";
            UILocalize.SuccessTitle = "Success";
            UILocalize.ErrorTitle = "Error";
        }
        private void FrmDuyetbai_Load(object sender, EventArgs e)
        {
            LoadBaiDang();

        }
        private void LoadBaiDang()
        {
            var data = pt.GetDataPageDangTinChuaDuyet(currentpage, recordPerPages);
            dtView.ClearAll();
            dtView.DataSource = data;
            if (dtView.Rows.Count > 0)
            {
                dtView.Columns[0].HeaderText = "ID";
                dtView.Columns[1].HeaderText = "Tiêu đề";
                dtView.Columns[2].HeaderText = "Loại nhà";
                dtView.Columns[3].HeaderText = "Diện tích";
                dtView.Columns[4].HeaderText = "Số phòng";
                dtView.Columns[5].HeaderText = "Giá";
                dtView.Columns[6].HeaderText = "Địa chỉ";
                dtView.Columns[7].HeaderText = "Hình ảnh";
                dtView.Columns[8].HeaderText = "ID người đăng";
                dtView.Columns[9].HeaderText = "Thời gian đăng";
                dtView.Columns[10].HeaderText = "Trạng thái";
                label8.Visible = false;
            }
            else
            {
                label8.Visible = true;
            }
            UpdatePage();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string localFilePath = txtHinhanh.Text;

            if (!string.IsNullOrEmpty(localFilePath))
            {
                string imageUrl = new Uri(localFilePath).AbsoluteUri;
                ShowImageDialog(imageUrl);
            }
            else
            {
                MessageBox.Show("Không tìm thấy hình ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShowImageDialog(string imageUrl)
        {
            HinhAnh hinhanh = new HinhAnh(imageUrl);
            hinhanh.ShowDialog();
        }

        private void btnTuchoi_Click(object sender, EventArgs e)
        {
            if (txtTieude.Text != "")
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn từ chối ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    Lydo ld = new Lydo(txtId.Text);
                    ld.Show();
                    ld.FormClosed += new FormClosedEventHandler(Lydo_FormClosed);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bài đăng trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            resetValues();
            LoadBaiDang();
        }
        void Lydo_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Đã từ chối bài đăng", "Thông báo", MessageBoxButtons.OK);
            this.Refresh();
            FrmDuyetbai_Load(sender, e);
        }
        private void dtView_Click(object sender, EventArgs e)
        {
            try
            {
                // Nếu có tồn tại trên 1 dòng
                if (dtView.Rows.Count > 1)
                {
                    // hiện dữ liệu khi dòng được chọn
                    txtId.Text = dtView.CurrentRow.Cells[0].Value.ToString();
                    txtTieude.Text = dtView.CurrentRow.Cells[1].Value.ToString();
                    cbLoainha.Text = dtView.CurrentRow.Cells[2].Value.ToString();
                    txtDientich.Text = dtView.CurrentRow.Cells[3].Value.ToString();
                    txtSophong.Text = dtView.CurrentRow.Cells[4].Value.ToString();
                    txtHinhanh.Text = dtView.CurrentRow.Cells[7].Value.ToString();
                    txtDiachi.Text = dtView.CurrentRow.Cells[6].Value.ToString();
                    txtGia.Text = dtView.CurrentRow.Cells[5].Value.ToString();
                    picSmallImage.ImageLocation = dtView.CurrentRow.Cells[7].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Hàng không tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi phát sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            if (txtTieude.Text != "")
            {
                if (nv.Duyetbai(txtId.Text, FrmMain.mail))
                {
                    MessageBox.Show("Duyệt thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    resetValues();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bài đăng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đối tượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadBaiDang();
        }
        void resetValues()
        {
            txtId.Text = "";
            txtTieude.Text = "";
            cbLoainha.Text = "";
            txtDientich.Text = "";
            txtSophong.Text = "";
            txtHinhanh.Text = "";
            txtDiachi.Text = "";
            txtGia.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtView.ClearAll();
            dtView.DataSource = nv.TimKiemBaiDang(txtTimKiem.Text.Trim().ToUpper());
            if (dtView.Rows.Count > 0)
            {
                dtView.Columns[0].HeaderText = "ID";
                dtView.Columns[1].HeaderText = "Tiêu đề";
                dtView.Columns[2].HeaderText = "Loại nhà";
                dtView.Columns[3].HeaderText = "Diện tích";
                dtView.Columns[4].HeaderText = "Số phòng";
                dtView.Columns[5].HeaderText = "Giá";
                dtView.Columns[6].HeaderText = "Địa chỉ";
                dtView.Columns[7].HeaderText = "Hình ảnh";
                dtView.Columns[8].HeaderText = "ID người đăng";
                dtView.Columns[9].HeaderText = "Thời gian đăng";
                dtView.Columns[10].HeaderText = "Trạng thái";
                label8.Visible = false;
            }
            else
            {
                label8.Visible = true;
            }
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (currentpage > 1)
            {
                currentpage--;
                LoadBaiDang();
            }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if (currentpage * recordPerPages < totalRecord)
            {
                currentpage++;
                LoadBaiDang();
            }
        }
        void UpdatePage()
        {
            txtCurrentPage.Text = $"Trang : {currentpage}";
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            currentpage = 1;
            LoadBaiDang();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtTieude.Text = string.Empty;
            cbLoainha.Text = string.Empty;
            cbLoainha.SelectedIndex = -1;
            txtDientich.Text = string.Empty;
            txtSophong.Text = string.Empty;
            txtGia.Text = string.Empty;
            txtDiachi.Text = string.Empty;
            txtHinhanh.Text = string.Empty;
            dtView.ClearSelection();
        }
    }
}
