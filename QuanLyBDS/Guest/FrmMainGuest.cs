using BUS_QuanLyBDS;
using MongoDB.Bson;
using QuanLyBDS.NhanVien;
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

namespace QuanLyBDS.Guest
{
    public partial class FrmMainGuest : UIForm
    {
        BUS_QuanLyBDS.Guest guest = new BUS_QuanLyBDS.Guest();
        BUS_QuanLyBDS.PhanTrang pt = new BUS_QuanLyBDS.PhanTrang();
        private int currentpage = 1;
        private int recordPerPages = 10;
        private int totalRecord;
        private int index = 1;
        public FrmMainGuest()
        {
            InitializeComponent();
            UpdatePage();
            totalRecord = (int)pt.GetTotalRecordsDanhSach();
            dtView.DataSource = pt.Danhsach(currentpage, recordPerPages);
            cbDiachi.DropDownStyle = UIDropDownStyle.DropDownList;
            cbLoainha.DropDownStyle = UIDropDownStyle.DropDownList;
            cbGia.DropDownStyle = UIDropDownStyle.DropDownList;
            cbDientich.DropDownStyle = UIDropDownStyle.DropDownList;
            cbSophong.DropDownStyle = UIDropDownStyle.DropDownList;
        }

        private void btnXemanh_Click(object sender, EventArgs e)
        {
            int data = dtView.CurrentCell.RowIndex;
            if (string.IsNullOrEmpty(txtHinhanh.Text))
            {
                MessageBox.Show("Hãy chọn một dòng để xem hình ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (data >= 0)
            {
                txtHinhanh.Text = dtView.Rows[data].Cells["Hinhanh"].Value.ToString();

                if (!string.IsNullOrEmpty(txtHinhanh.Text))
                {
                    string ImgUrl = new Uri(txtHinhanh.Text).AbsoluteUri;
                    ImgShow(ImgUrl);
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn một dòng để xem hình ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ImgShow(string ImgUrl)
        {
            HinhAnh ha = new HinhAnh(ImgUrl);
            ha.ShowDialog();
        }


        private void FrmMainGuest_Load(object sender, EventArgs e)
        {
            if (dtView.ColumnCount == 0)
            {
                label8.Visible = true;
            }
        }

        private void cbLoainha_SelectedIndexChanged(object sender, EventArgs e)
        {
            string loainha = cbLoainha.SelectedText;
            dtView.ClearAll();
            // Kiểm tra xem DataTable có dữ liệu hay không
            if (guest.locLoaiNha(loainha) != null && guest.locLoaiNha(loainha).Rows.Count == 0)
            {
                label8.Visible = true;
            }
            else
            {
                currentpage = 1;
                LoadDataLocLoaiNha();
                label8.Visible = false;
            }
        }

        private void cbDientich_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                string input = cbDientich.SelectedText;
                int indexOfDen = input.IndexOf("đến");
                double start = input.Substring(0, indexOfDen).Trim().ToDouble();
                // Lấy phần sau của chuỗi (sau "đến")
                double end = (input.Substring(indexOfDen + "đến".Length).Trim()).Substring(0, input.Substring(indexOfDen + "đến".Length).Trim().IndexOf("m")).ToDouble();
                dtView.ClearAll();
                // Kiểm tra xem DataTable có dữ liệu hay không
                if (guest.locdientich(start, end) != null && guest.locdientich(start, end).Rows.Count == 0)
                {
                    label8.Visible = true;
                }
                else
                {
                    currentpage = 1;
                    LoadDataLocDienTich();
                    label8.Visible = false;
                }
            }
        }

        private void cbSophong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(cbSophong.SelectedItem.ToString(), out int sophong))
            {
                dtView.ClearAll();
                // Kiểm tra xem DataTable có dữ liệu hay không
                if (guest.locsophong(sophong) != null && guest.locsophong(sophong).Rows.Count == 0)
                {
                    label8.Visible = true;
                }
                else
                {
                    currentpage = 1;
                    LoadDatalocSoPhong();
                    label8.Visible = true;
                }
            }
        }

        private void cbDiachi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string diachi = cbDiachi.SelectedText;
            dtView.ClearAll();
            // Kiểm tra xem DataTable có dữ liệu hay không
            if (guest.locKhuVuc(diachi) != null && guest.locKhuVuc(diachi).Rows.Count == 0)
            {
                label8.Visible = true;
            }
            else
            {
                currentpage = 1;
                LoadDataDiaChi();
                label8.Visible = false;
            }
        }

        private void cbGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            string input = cbGia.SelectedText;
            double start, end;
            if (input == "Dưới 1 tỷ")
            {
                start = 0;
                end = 1000000000;
            }
            else
            {
                int indexOfDen = input.IndexOf("-");
                // Lấy phần trước của chuỗi (trước "-")
                start = input.Substring(0, indexOfDen).Trim().ToDouble() * 1000000000;
                // Lấy phần sau của chuỗi (sau "-")
                end = (input.Substring(indexOfDen + "-".Length).Trim()).Substring(0, input.Substring(indexOfDen + "-".Length).Trim().IndexOf("t")).ToDouble() * 1000000000;
            }
            dtView.ClearAll();
            // Kiểm tra xem DataTable có dữ liệu hay không
            if (guest.locGia(start, end) != null && guest.locGia(start, end).Rows.Count == 0)
            {
                label8.Visible = true;
            }
            else
            {
                currentpage = 1;
                LoadDataLocGia();
                label8.Visible = false;
            }
        }

        private void dtView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string tinDangId = dtView.Rows[e.RowIndex].Cells["_id"].Value.ToString();
                string hinhAnh = dtView.Rows[e.RowIndex].Cells["Hinhanh"].Value.ToString();
                List<BsonDocument> thongTinNguoiDangList = guest.Thongtinnguoidang(tinDangId);
                if (thongTinNguoiDangList != null && thongTinNguoiDangList.Count > 0)
                {
                    BsonDocument thongTinNguoiDang = thongTinNguoiDangList[0];

                    txtEmail.Text = thongTinNguoiDang.GetValue("Email").AsString;
                    txtHoten.Text = thongTinNguoiDang.GetValue("Hoten").AsString;
                    txtSodt.Text = thongTinNguoiDang.GetValue("Sodienthoai").AsString;
                    txtHinhanh.Text = hinhAnh;
                    panelGuest.Visible = true;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin người đăng.");
                }
            }
        }



        private void dtView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            FrmMain.mail = "Quản lý bất động sản";
            FrmMain.session = 0;
            this.Close();
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (currentpage > 1)
            {
                currentpage--;
                if (index == 1)
                {
                    dtView.DataSource = pt.Danhsach(currentpage, recordPerPages);
                    UpdatePage();
                }
                else if (index == 2)
                {
                    LoadDataLocDienTich();
                    UpdatePage();
                }
                else if (index == 3)
                {
                    LoadDatalocSoPhong();
                    UpdatePage();
                }
                else if (index == 4)
                {
                    LoadDataDiaChi();
                    UpdatePage();
                }
                else if (index == 5)
                {
                    LoadDataLocGia();
                    UpdatePage();
                }
                else
                {
                    LoadDataLocLoaiNha();
                    UpdatePage();
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
                    dtView.DataSource = pt.Danhsach(currentpage, recordPerPages);
                    UpdatePage();
                }
                else if (index == 2)
                {
                    LoadDataLocDienTich();
                    UpdatePage();
                }
                else if (index == 3)
                {
                    LoadDatalocSoPhong();
                    UpdatePage();
                }
                else if (index == 4)
                {
                    LoadDataDiaChi();
                    UpdatePage();
                }
                else if (index == 5)
                {
                    LoadDataLocGia();
                    UpdatePage();
                }
                else
                {
                    LoadDataLocLoaiNha();
                    UpdatePage();
                }
            }
        }

        private void UpdatePage()
        {
            txtCurrentPage.Text = $"Trang : {currentpage}";
        }

        private void LoadDataLocLoaiNha()
        {
            dtView.ClearAll();
            string loainha = cbLoainha.SelectedText;
            index = 6;
            totalRecord = (int)pt.GetTotalRecordsLocLoaiNha(loainha);
            dtView.DataSource = pt.LocLoaiNha(currentpage, recordPerPages, loainha);
            UpdatePage();
        }

        private void LoadDataLocDienTich()
        {
            string input = cbDientich.SelectedText;
            int indexOfDen = input.IndexOf("đến");
            double start = input.Substring(0, indexOfDen).Trim().ToDouble();
            // Lấy phần sau của chuỗi (sau "đến")
            double end = (input.Substring(indexOfDen + "đến".Length).Trim()).Substring(0, input.Substring(indexOfDen + "đến".Length).Trim().IndexOf("m")).ToDouble();

            dtView.ClearAll();
            index = 2;
            totalRecord = (int)pt.GetTotalRecordsLocDienTich(start, end);
            dtView.DataSource = pt.LocDienTich(currentpage, recordPerPages, start, end);
            UpdatePage();
        }

        private void LoadDatalocSoPhong()
        {
            int.TryParse(cbSophong.SelectedItem.ToString(), out int sophong);
            index = 3;
            totalRecord = (int)pt.GetTotalRecordsLocSoPhong(sophong);
            dtView.DataSource = pt.LocSoPhong(currentpage, recordPerPages, sophong);
            UpdatePage();
        }

        private void LoadDataDiaChi()
        {
            string diachi = cbDiachi.SelectedText;

            index = 4;
            totalRecord = (int)pt.GetTotalRecordsLocKhuVuc(diachi);
            dtView.DataSource = pt.LocKhuVuc(currentpage, recordPerPages, diachi);
            UpdatePage();
        }

        private void LoadDataLocGia()
        {
            string input = cbGia.SelectedText;
            double start, end;
            if (input == "Dưới 1 tỷ")
            {
                start = 0;
                end = 1000000000;
            }
            else
            {
                int indexOfDen = input.IndexOf("-");
                // Lấy phần trước của chuỗi (trước "-")
                start = input.Substring(0, indexOfDen).Trim().ToDouble() * 1000000000;
                // Lấy phần sau của chuỗi (sau "-")
                end = (input.Substring(indexOfDen + "-".Length).Trim()).Substring(0, input.Substring(indexOfDen + "-".Length).Trim().IndexOf("t")).ToDouble() * 1000000000;
            }

            index = 5;
            totalRecord = (int)pt.GetTotalRecordsLocGia(start, end);
            dtView.DataSource = pt.LocGia(currentpage, recordPerPages, start, end);
            UpdatePage();
        }

        private void LoadDanhSach()
        {
            index = 1;
            UpdatePage();
            totalRecord = (int)pt.GetTotalRecordsDanhSach();
            dtView.DataSource = pt.Danhsach(currentpage, recordPerPages);
        }

        private void ClearFiedls()
        {
            txtEmail.Text = string.Empty;
            txtHoten.Text = string.Empty;
            txtSodt.Text = string.Empty;
            txtHinhanh.Text = string.Empty;
            panelGuest.Visible = false;
            cbLoainha.Text = string.Empty;
            cbDientich.Text = string.Empty;
            cbSophong.Text = string.Empty;
            cbDiachi.Text = string.Empty;
            cbGia.Text = string.Empty;
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            currentpage = 1;
            LoadDanhSach();
            ClearFiedls();
        }
    }
}
