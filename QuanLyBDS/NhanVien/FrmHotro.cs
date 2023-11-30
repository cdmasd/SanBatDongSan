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
    public partial class FrmHotro : UIForm
    {
        BUS_QuanLyBDS.NhanVien nv = new BUS_QuanLyBDS.NhanVien();
        public FrmHotro()
        {
            InitializeComponent();
        }
        private void LoadBaiDang()
        {
            dtView.ClearAll();
            dtView.DataSource = nv.Chuahotro();
            if (dtView.Rows.Count > 0)
            {
                dtView.Columns[0].HeaderText = "ID";
                dtView.Columns[1].HeaderText = "Số điện thoại";
                dtView.Columns[2].HeaderText = "Vấn đề";
                dtView.Columns[3].HeaderText = "Chi tiết vấn đề";
                dtView.Columns[4].HeaderText = "Trạng thái";
                dtView.Columns[5].HeaderText = "Người hỗ trợ";
                dtView.Columns[6].HeaderText = "Ngày đăng";
                label8.Visible = false;
            }
            else
            {
                label8.Visible = true;
            }
        }

        private void FrmHotro_Load(object sender, EventArgs e)
        {
            LoadBaiDang();
        }

        private void dtView_Click(object sender, EventArgs e)
        {
            try
            {
                // Nếu có tồn tại trên 1 dòng
                if (dtView.Rows.Count > 0)
                {
                    // hiện dữ liệu khi dòng được chọn
                    txtId.Text = dtView.CurrentRow.Cells[0].Value.ToString();
                    txtHotro.Text = dtView.CurrentRow.Cells[2].Value.ToString();
                    txtChitiethotro.Text = dtView.CurrentRow.Cells[3].Value.ToString();
                    txtSodt.Text = dtView.CurrentRow.Cells[1].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Hàng không tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi phát sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void resetValues()
        {
            txtHotro.Text = "";
            txtChitiethotro.Text = "";
            txtSodt.Text = "";
        }

        private void btnDahotro_Click(object sender, EventArgs e)
        {
            if (nv.Hotro(txtId.Text, FrmMain.mail))
            {
                MessageBox.Show("Đã phản hồi khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resetValues();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng phản hồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadBaiDang();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtView.ClearAll();
            dtView.DataSource = nv.TimKiemTicket(txtSodt.Text);
            if (dtView.Rows.Count > 0)
            {
                dtView.Columns[0].HeaderText = "ID";
                dtView.Columns[1].HeaderText = "Số điện thoại";
                dtView.Columns[2].HeaderText = "Vấn đề";
                dtView.Columns[3].HeaderText = "Chi tiết vấn đề";
                dtView.Columns[4].HeaderText = "Trạng thái";
                dtView.Columns[5].HeaderText = "Người hỗ trợ";
                dtView.Columns[6].HeaderText = "Ngày đăng";
                label8.Visible = false;
            }
            else
            {
                label8.Visible = true;
            }
        }
    }
}
