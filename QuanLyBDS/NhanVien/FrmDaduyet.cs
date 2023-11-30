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
        public FrmDaduyet()
        {
            InitializeComponent();
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
            dtView.ClearAll();
            dtView.DataSource = nv.Daduyet();
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtTieude.Text != "")
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
            else
            {
                MessageBox.Show("Vui lòng đối tượng cần xoá ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            LoadBaiDang();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtView.ClearAll();
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
        }
    }
}
