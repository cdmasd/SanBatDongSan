using DTO_QuanLyBDS;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private int index = 1;
        public FrmQLNhanVien()
        {
            InitializeComponent();
            bus_Admin = new BUS_QuanLyBDS.Admin();
            bus_PhanTrang = new();
            totalRecord = (int)bus_PhanTrang.GetTotalRecordNhanVien();
        }

        private void FrmQLNhanVien_Load(object sender, EventArgs e)
        {
            txtSodienthoai.MaxLength = 10;
            LoadData();
            btnDSHoatDong.Enabled = false;
            SettingUI();
            DatetimePicker.Value = DateTime.Now;
        }

        private void btnDanhsach_Click(object sender, EventArgs e)
        {

            currentpage = 1;
            LoadData();
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            if (txtHoten.Text == string.Empty || txtEmail.Text == string.Empty || txtDiachi.Text == string.Empty || txtSodienthoai.Text == string.Empty || !bus_Admin.KiemTraEmail(txtEmail.Text.Trim()))
            {
                KiemTraTextBox();
                return;
            }
            if (isPhone(txtSodienthoai.Text.Trim()) == false)
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string emailCheck = await bus_Admin.KiemTraEmailTonTai(txtEmail.Text.Trim());
            if (emailCheck != "Email hợp lệ")
            {
                MessageBox.Show(emailCheck, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string trangThai = string.Empty;
            if (rBtnHoatDong.Checked == true)
            {
                trangThai = "Hoạt động";
            }
            else if (rBtnNgungHoatDong.Checked == true)
            {
                trangThai = "Ngưng hoạt động";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn trạng thái hoạt động", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Luong = (double)numLuong.Value,
                Trangthai = trangThai,
            },
            new TaiKhoanDTO
            {
                Email = txtEmail.Text.Trim(),
                Matkhau = bus_Admin.Encrytion("abc123"),
                Vaitro = "nhanvien"
            });
            MessageBox.Show(thongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (index == 1)
            {
                LoadData();
            }
            else
            {
                LoadDataNoActive();
            }
            ClearFields();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtHoten.Text == string.Empty || txtEmail.Text == string.Empty || txtDiachi.Text == string.Empty || txtSodienthoai.Text == string.Empty || !bus_Admin.KiemTraEmail(txtEmail.Text.Trim()))
            {
                KiemTraTextBox();
                return;
            }
            if (isPhone(txtSodienthoai.Text.Trim()) == false)
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string trangThai = string.Empty;
            if (rBtnHoatDong.Checked == true)
            {
                trangThai = "Hoạt động";
            }
            else if (rBtnNgungHoatDong.Checked == true)
            {
                trangThai = "Ngưng hoạt động";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn trạng thái hoạt động", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            NhanVienDTO nv = new NhanVienDTO
            {
                Hoten = txtHoten.Text.Trim(),
                Diachi = txtDiachi.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Sodienthoai = txtSodienthoai.Text.Trim(),
                Ngaybatdau = DatetimePicker.Value,
                Luong = (double)numLuong.Value,
                Trangthai = trangThai,
            };
            TaiKhoanDTO tk = new TaiKhoanDTO
            {
                Email = txtEmail.Text.Trim(),
                Matkhau = bus_Admin.Encrytion("abc123"),
                Vaitro = "nhanvien"
            };
            string thongBao = bus_Admin.CapNhatNhanVien(nv, tk);

            MessageBox.Show(thongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (index == 1)
            {
                LoadData();
            }
            else
            {
                LoadDataNoActive();
            }
            ClearFields();
        }

        private void dtView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cellEmail = dtView.Rows[e.RowIndex].Cells["Email"];
                if (cellEmail != null && cellEmail.Value != null)
                {
                    txtEmail.Text = cellEmail.Value.ToString();
                    txtEmail.ReadOnly = true;
                    txtSodienthoai.Text = dtView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    numLuong.Text = dtView.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtDiachi.Text = dtView.Rows[e.RowIndex].Cells[4].Value.ToString();
                    if (dtView.Rows[e.RowIndex].Cells[5].Value.ToString() != string.Empty)
                    {
                        DatetimePicker.Value = Convert.ToDateTime(dtView.Rows[e.RowIndex].Cells[5].Value);
                    }
                    else
                    {
                        // Xử lý trường hợp ô ngày không có giá trị
                        DatetimePicker.Value = DateTime.Now; // Hoặc giá trị mặc định khác tùy vào yêu cầu của bạn
                    }
                    txtHoten.Text = dtView.Rows[e.RowIndex].Cells[6].Value.ToString();
                    if (dtView.Rows[e.RowIndex].Cells[7].Value.ToString() != string.Empty)
                    {
                        string Trangthai = dtView.Rows[e.RowIndex].Cells[7].Value.ToString();
                        if (Trangthai == "Hoạt động")
                        {
                            rBtnHoatDong.Checked = true;
                        }
                        else if (Trangthai == "Ngưng hoạt động")
                        {
                            rBtnNgungHoatDong.Checked = true;
                        }
                        else
                        {
                            rBtnHoatDong.Checked = false;
                            rBtnNgungHoatDong.Checked = false;
                        }
                    }
                    else
                    {
                        rBtnHoatDong.Checked = false;
                        rBtnNgungHoatDong.Checked = false;
                    }
                }
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (txtTimkiem.Text != string.Empty)
            {
                dtView.DataSource = bus_Admin.TimKiemNhanVienTheoId(txtTimkiem.Text);
            }
            else
            {
                dtView.DataSource = bus_Admin.DanhSachNhanVien();
            }
            txtTimkiem.Text = string.Empty;
        }

        private void ClearFields()
        {
            txtEmail.Text = string.Empty;
            txtEmail.ReadOnly = false;
            txtHoten.Text = string.Empty;
            txtDiachi.Text = string.Empty;
            txtSodienthoai.Text = "0";
            DatetimePicker.Value = DateTime.Now.Date;
            numLuong.Text = string.Empty;
            rBtnHoatDong.Checked = false;
            rBtnNgungHoatDong.Checked = false;
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
                dtView.Columns["Luong"].HeaderText = "Lương";
                dtView.Columns["Hoten"].HeaderText = "Họ Tên";
                dtView.Columns["Trangthai"].HeaderText = "Trạng Thái";
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
            if (index == 1)
            {
                if (currentpage > 1)
                {
                    currentpage--;
                    LoadData();
                }
            }
            else
            {
                if (currentpage > 1)
                {
                    currentpage--;
                    LoadDataNoActive();
                }
            }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if (index == 1)
            {
                if (currentpage * recordPerPages < totalRecord)
                {
                    currentpage++;
                    LoadData();
                }
            }
            else
            {
                if (currentpage * recordPerPages < totalRecord)
                {
                    currentpage++;
                    LoadDataNoActive();
                }
            }
        }

        void UpdatePage()
        {
            txtCurrentPage.Text = $"Trang : {currentpage}";
        }

        private void txtSodienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static bool isPhone(string phone)
        {
            string strRegex = @"^0\d{9}$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(phone))
                return (true);
            else
                return (false);
        }

        private void btnDSHoatDong_Click(object sender, EventArgs e)
        {
            index = 1;
            btnDSHoatDong.Enabled = false;
            btnDSNgungHoatDong.Enabled = true;
            currentpage = 1;
            totalRecord = (int)bus_PhanTrang.GetTotalRecordNhanVien();
            LoadData();

        }

        private void btnDSNgungHoatDong_Click(object sender, EventArgs e)
        {
            index = 2;
            btnDSNgungHoatDong.Enabled = false;
            btnDSHoatDong.Enabled = true;
            currentpage = 1;
            totalRecord = (int)bus_PhanTrang.GetTotalRecordNhanVienNgungHoatDong();
            LoadDataNoActive();
        }
        void LoadDataNoActive()
        {
            var data = bus_PhanTrang.GetDataPageNhanVienNgungHoatDong(currentpage, recordPerPages);
            dtView.ClearAll();
            dtView.DataSource = data;
            UpdatePage();
            if (dtView.ColumnCount > 0)
            {
                dtView.Columns["_id"].HeaderText = "Mã Nhân Viên";
                dtView.Columns["Sodienthoai"].HeaderText = "Số Điện Thoại";
                dtView.Columns["Diachi"].HeaderText = "Địa Chỉ";
                dtView.Columns["Ngaybatdau"].HeaderText = "Ngày Bắt Đầu";
                dtView.Columns["Luong"].HeaderText = "Lương";
                dtView.Columns["Hoten"].HeaderText = "Họ Tên";
                dtView.Columns["Trangthai"].HeaderText = "Trạng Thái";
                label8.Visible = false;
            }
            else
            {
                label8.Visible = true;
            }
        }
    }
}
