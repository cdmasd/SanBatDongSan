using MongoDB.Bson;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBDS.NhanVien
{
    public partial class FrmDaduyet : UIForm
    {
        BUS_QuanLyBDS.NhanVien nv = new BUS_QuanLyBDS.NhanVien();
        BUS_QuanLyBDS.PhanTrang pt = new BUS_QuanLyBDS.PhanTrang();
        private int currentpage = 1;
        private int recordPerPages = 10;
        private int totalRecord;
        public FrmDaduyet()
        {
            InitializeComponent();
            totalRecord = (int)pt.GetTotalRecordsDangTinDaDuyet();
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

        private void FrmDaduyet_Load(object sender, EventArgs e)
        {
            LoadBaiDang();
        }
        private void LoadBaiDang()
        {
            var data = pt.GetDataPageDangTinDaDuyet(currentpage, recordPerPages);
            dtView.ClearAll();
            dtView.DataSource = data;
            UpdatePage();
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
                dtView.Columns[11].HeaderText = "Người duyệt bài";
                label8.Visible = false;
            }
            else
            {
                label8.Visible = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtTieude.Text != "")
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn xoá ?", "Xác nhận",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(result == DialogResult.OK)
                {
                    if (nv.DeleteBaiDang(txtId.Text))
                    {
                        MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Xoá thất bại, Không tìm thấy đối tượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng đối tượng cần xoá ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            LoadBaiDang();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtView.ClearAll();
            if (!string.IsNullOrEmpty(txtTimKiem.Text.Trim().ToUpper()))
            {
                dtView.DataSource = nv.TimKiemBaiDangDaDuyet(txtTimKiem.Text.Trim().ToUpper());
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
            } else
            {
                currentpage = 1;
                LoadBaiDang();
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

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            currentpage = 1;
            LoadBaiDang();
        }
        private void ShowImageDialog(string imageUrl)
        {
            HinhAnh hinhanh = new HinhAnh(imageUrl);
            hinhanh.ShowDialog();
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
    }
}
