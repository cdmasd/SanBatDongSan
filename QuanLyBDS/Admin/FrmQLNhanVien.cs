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

        public FrmQLNhanVien()
        {
            InitializeComponent();
            bus_Admin = new BUS_QuanLyBDS.Admin();
        }

        private void FrmQLNhanVien_Load(object sender, EventArgs e)
        {
            //LoadData();
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
                MessageBox.Show(emailCheck,"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            UIMessageDialog.ShowSuccessDialog(this, "Thông Báo", thongBao);
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
            UIMessageDialog.ShowSuccessDialog(this, "Thông Báo", thongBao);
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
                    DatetimePicker.Value = Convert.ToDateTime(dtView.Rows[e.RowIndex].Cells[4].Value);
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
                UIMessageDialog.ShowSuccessDialog(this, "Thông Báo", thongBao);
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
            dtView.DataSource = bus_Admin.DanhSachNhanVien();
            dtView.Columns["_id"].HeaderText = "Mã Nhân Viên";
            dtView.Columns["HoTen"].HeaderText = "Họ Tên";
            dtView.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
            dtView.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dtView.Columns["NgayBatDau"].HeaderText = "Ngày Bắt Đầu";
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
                MessageBox.Show("Họ Tên đang trống","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
