using DTO_QuanLyBDS;
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

namespace QuanLyBDS.Admin
{
    public partial class FrmQLNhanVien : UIForm
    {
        private BUS_QuanLyBDS.Admin bus_Admin;
        BUS_QuanLyBDS.PhanTrang bus_PhanTrang;
        private int currentpage = 1;
        private int recordPerPages = 10;
        private int totalRecord;

        public FrmQLNhanVien()
        {
            InitializeComponent();
            bus_Admin = new BUS_QuanLyBDS.Admin();
            bus_PhanTrang = new();
            totalRecord = (int)bus_PhanTrang.GetTotalRecordNhanVien();
        }

        private void FrmQLNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
            SettingUI();
            DatetimePicker.Value = DateTime.Now;
        }

        private void btnDanhsach_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            if (txtHoten.Text == string.Empty || txtEmail.Text == string.Empty || txtDiachi.Text == string.Empty || txtSodienthoai.Text == string.Empty || !bus_Admin.KiemTraEmail(txtEmail.Text.Trim()))
            {
                KiemTraTextBox();
                return;
            }
            string emailCheck = await bus_Admin.KiemTraEmailTonTai(txtEmail.Text.Trim());
            if (emailCheck != "Email hợp lệ")
            {
                MessageBox.Show(emailCheck, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string thongBao = bus_Admin.ThemNhanVien(
            new NhanVienDTO
            {
                _id = bus_Admin.MaNhanVien(),
                Email = txtEmail.Text.Trim(),
                Hoten = txtHoten.Text.Trim(),
                Sodienthoai = txtSodienthoai.Text.Trim(),
                Diachi = txtDiachi.Text.Trim(),
                Ngaybatdau = DatetimePicker.Value,
            },
            new TaiKhoanDTO
            {
                Email = txtEmail.Text.Trim(),
                Matkhau = bus_Admin.Encrytion("abc123"),
                Vaitro = "nhanvien"
            });
            MessageBox.Show(thongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            ClearFields();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtHoten.Text == string.Empty || txtEmail.Text == string.Empty || txtDiachi.Text == string.Empty || txtSodienthoai.Text == string.Empty || !bus_Admin.KiemTraEmail(txtEmail.Text.Trim()))
            {
                KiemTraTextBox();
                return;
            }
            string thongBao = bus_Admin.CapNhatNhanVien(new NhanVienDTO
            {
                Hoten = txtHoten.Text.Trim(),
                Diachi = txtDiachi.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Sodienthoai = txtSodienthoai.Text.Trim(),
                Ngaybatdau = DatetimePicker.Value,
            });
            MessageBox.Show(thongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            ClearFields();
        }

        private void dtView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cellEmail = dtView.Rows[e.RowIndex].Cells["Email"];
                object cellDate = dtView.Rows[e.RowIndex].Cells[4].Value;
                if (cellEmail != null && cellEmail.Value != null)
                {
                    txtEmail.Text = cellEmail.Value.ToString();
                    txtSodienthoai.Text = dtView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtDiachi.Text = dtView.Rows[e.RowIndex].Cells[3].Value.ToString();
                    if (dtView.Rows[e.RowIndex].Cells[4].Value.ToString() != string.Empty)
                    {
                        DatetimePicker.Value = Convert.ToDateTime(dtView.Rows[e.RowIndex].Cells[4].Value);
                    }
                    else
                    {
                        // Xử lý trường hợp ô ngày không có giá trị
                        DatetimePicker.Value = DateTime.Now; // Hoặc giá trị mặc định khác tùy vào yêu cầu của bạn
                    }
                    txtHoten.Text = dtView.Rows[e.RowIndex].Cells[5].Value.ToString();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                UIMessageDialog.ShowSuccessDialog(this, "Thông Báo", "Hãy Chọn Nhân Viên Muốn Xóa", UIStyle.Red);
                return;
            }
            UILocalize.AskTitle = "Xác Nhận";
            bool xacNhan = UIMessageBox.ShowAsk("Bạn có muốn xóa nhân viên này", true, false);
            if (xacNhan == true)
            {
                string thongBao = bus_Admin.XoaNhanVien(txtEmail.Text.Trim());
                MessageBox.Show(thongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearFields();
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (txtTimkiem.Text != null)
            {
                dtView.DataSource = bus_Admin.TimKiemNhanVienTheoId(txtTimkiem.Text);
            }
            else
            {
                dtView.DataSource = new DataTable();
            }
            txtTimkiem.Text = string.Empty;
        }

        private void ClearFields()
        {
            txtEmail.Text = string.Empty;
            txtHoten.Text = string.Empty;
            txtDiachi.Text = string.Empty;
            txtSodienthoai.Text = "0";
            DatetimePicker.Value = DateTime.Now.Date;
        }

        private void LoadData()
        {
            var data = bus_PhanTrang.GetDataPageNhanVien(currentpage, recordPerPages);
            dtView.ClearAll();
            dtView.DataSource = data;
            UpdatePage();
            if (dtView.ColumnCount > 0)
            {
                dtView.Columns["_id"].HeaderText = "Mã Nhân Viên";
                dtView.Columns["Sodienthoai"].HeaderText = "Số Điện Thoại";
                dtView.Columns["Diachi"].HeaderText = "Địa Chỉ";
                dtView.Columns["Ngaybatdau"].HeaderText = "Ngày Bắt Đầu";
                dtView.Columns["Hoten"].HeaderText = "Họ Tên";
                label8.Visible = false;
            }
            else
            {
                label8.Visible = true;
            }

        }

        public void SettingUI()
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

        private void KiemTraTextBox()
        {
            if (txtHoten.Text == string.Empty)
            {
                MessageBox.Show("Họ Tên đang trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Email đang trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtDiachi.Text == string.Empty)
            {
                MessageBox.Show("Địa chỉ đang trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtSodienthoai.Text == string.Empty)
            {
                MessageBox.Show("Số điện đang trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!bus_Admin.KiemTraEmail(txtEmail.Text.Trim()))
            {
                MessageBox.Show("mail không hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (currentpage > 1)
            {
                currentpage--;
                LoadData();
            }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if (currentpage * recordPerPages < totalRecord)
            {
                currentpage++;
                LoadData();
            }
        }
        void UpdatePage()
        {
            txtCurrentPage.Text = $"Trang : {currentpage}";
        }
    }
}
