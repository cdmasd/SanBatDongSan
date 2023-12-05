using BUS_QuanLyBDS;
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

namespace QuanLyBDS.NhanVien
{
    public partial class FrmQLKhachHang : UIForm
    {
        BUS_QuanLyBDS.NhanVien nv = new BUS_QuanLyBDS.NhanVien();
        BUS_QuanLyBDS.PhanTrang pt = new PhanTrang();
        private int currentpage = 1;
        private int recordPerPages = 10;
        private int totalRecord;
        public FrmQLKhachHang()
        {
            InitializeComponent();
            LoadDataQLyKhachhang();
            dtView.CellClick += dtView_CellClick;
            totalRecord = (int)pt.GetTotalRecordsKhachHang();
        }

        private void btnNap_Click(object sender, EventArgs e)
        {
            double naptien = double.Parse(txtNap.Text);
            double sodu = double.Parse(txtSodu.Text) + naptien;
            string email = txtEmail.Text;
            string hoten = txtHoten.Text;
            string sdt = txtSdt.Text;
            string id = txtId.Text;
            bool result = nv.UpdateKhachhang(id,email,hoten,naptien, sodu);
            if (result)
            {
                Mail.MailPayment(email, hoten, naptien.ToString(), sodu.ToString());
                MessageBox.Show("Đã nạp tiền khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LoadDataQLyKhachhang();
                resetValue();
                dtView.Refresh();
            }
            else
            {
                MessageBox.Show("Chọn khách hàng nạp tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDataQLyKhachhang()
        {
            if (pt.GetDataPageKhachHang(currentpage, recordPerPages) != null)
            {
                dtView.ClearAll();
                dtView.DataSource = pt.GetDataPageKhachHang(currentpage, recordPerPages);
            }
            if (dtView.Rows.Count > 0)
            {
                dtView.Columns[0].HeaderText = "ID";
                dtView.Columns[1].HeaderText = "Email";
                dtView.Columns[2].HeaderText = "Họ tên";
                dtView.Columns[3].HeaderText = "Số điện thoại";
                dtView.Columns[4].HeaderText = "Số dư";
                dtView.Columns[5].HeaderText = "Ngày đăng ký";
                label8.Visible = false;
            }
            else
            {
                label8.Visible = true;
            }
            UpdatePage();

        }
        private void dtView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtView.Rows[e.RowIndex];

                // Lấy dữ liệu từ các ô của dòng được chọn
                string id = selectedRow.Cells["_id"].Value.ToString();
                string email = selectedRow.Cells["Email"].Value.ToString();
                string hoten = selectedRow.Cells["Hoten"].Value.ToString();
                string sdt = selectedRow.Cells["Sodienthoai"].Value.ToString();
                string sodu = selectedRow.Cells["Sodu"].Value.ToString();

                // Hiển thị dữ liệu lên các controls
                txtId.Text = id;
                txtEmail.Text = email;
                txtHoten.Text = hoten;
                txtSdt.Text = sdt;
                txtSodu.Text = sodu;

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Chọn khách hàng cần xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (nv.DeleteTaikhoanKH(txtEmail.Text, txtId.Text))
            {
                MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadDataQLyKhachhang();
                resetValue();
            }
            else
            {
                MessageBox.Show("Không tìm thấy email khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        void resetValue()
        {
            txtNap.Text = "";
            txtSodu.Text = "";
            txtEmail.Text = "";
            txtHoten.Text = "";
            txtSdt.Text = "";
            txtId.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtView.ClearAll();
            dtView.DataSource = nv.TimKiemKH(txtTimKiem.Text.Trim().ToUpper());
            if (dtView.Rows.Count > 0)
            {
                dtView.Columns[0].HeaderText = "ID";
                dtView.Columns[1].HeaderText = "Email";
                dtView.Columns[2].HeaderText = "Họ tên";
                dtView.Columns[3].HeaderText = "Số điện thoại";
                dtView.Columns[4].HeaderText = "Số dư";
                dtView.Columns[5].HeaderText = "Ngày đăng ký";
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
                LoadDataQLyKhachhang();
            }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if (currentpage * recordPerPages < totalRecord)
            {
                currentpage++;
                LoadDataQLyKhachhang();
            }
        }
        void UpdatePage()
        {
            txtCurrentPage.Text = $"Trang : {currentpage}";
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            currentpage = 1;
            LoadDataQLyKhachhang();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            resetValue();
        }
    }
}
