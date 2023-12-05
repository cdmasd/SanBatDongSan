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
        private int currentpage = 1;
        private int recordPerPages = 10;
        private int totalRecord;

        BUS_QuanLyBDS.NhanVien nv = new BUS_QuanLyBDS.NhanVien();
        BUS_QuanLyBDS.PhanTrang pt = new BUS_QuanLyBDS.PhanTrang();
        public FrmHotro()
        {
            InitializeComponent();
            totalRecord = (int)pt.GetTotalRecordsTicketChuaDuyet();
        }
        private void LoadBaiDang()
        {
            var data = pt.GetDataPageTicketChuaDuyet(currentpage, recordPerPages);
            dtView.ClearAll();
            dtView.DataSource = data;
            UpdatePage();
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
            if(txtTimKiem.Text != string.Empty )
            {
                currentpage = 1;
                totalRecord = (int)pt.GetTotalRecordsFindTicketChuaDuyet(txtTimKiem.Text.Trim());
                dtView.DataSource = pt.GetDataPageFindTicketChuaDuyet(currentpage, recordPerPages, txtTimKiem.Text.Trim());
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
            } else
            {
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
        void UpdatePage()
        {
            txtCurrentPage.Text = $"Trang : {currentpage}";
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            resetValues();
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            currentpage = 1;
            totalRecord = (int)pt.GetTotalRecordsFindTicketChuaDuyet(txtSodt.Text.Trim());
            LoadBaiDang();
        }

        private void btnTrangSau_Click(object sender, EventArgs e)
        {
            if (currentpage * recordPerPages < totalRecord)
            {
                currentpage++;
                LoadBaiDang();
            }
        }

        private void txtSodt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
