﻿using MongoDB.Bson;
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
    public partial class FrmDuyetbai : UIForm
    {
        BUS_QuanLyBDS.NhanVien nv = new BUS_QuanLyBDS.NhanVien();
        public FrmDuyetbai()
        {
            InitializeComponent();
            UiSettings();
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
            dtView.ClearAll();
            List<BsonDocument> dataBaiDang = nv.Chuaduyet();
            if (dataBaiDang.Count > 0)
            {
                // Load header name
                foreach (var header in dataBaiDang[0].Names)
                {
                    if (header != "_idnguoidang")
                    {
                        if (header != "Thoigiandang")
                        {
                            if (header != "Trangthai")
                            {
                                dtView.Columns.Add(header, header);
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                // Đổ dữ liệu vào từng dòng của DataGridView
                foreach (var doc in dataBaiDang)
                {
                    List<object> values = new List<object>();
                    foreach (var key in doc.Names)
                    {
                        values.Add(doc[key]);
                    }
                    dtView.Rows.Add(values.ToArray());
                }
                dtView.Columns[0].HeaderText = "ID";
                dtView.Columns[1].HeaderText = "Tiêu đề";
                dtView.Columns[2].HeaderText = "Loại nhà";
                dtView.Columns[3].HeaderText = "Diện tích";
                dtView.Columns[4].HeaderText = "Số phòng";
                dtView.Columns[5].HeaderText = "Giá";
                dtView.Columns[6].HeaderText = "Địa chỉ";
                dtView.Columns[7].HeaderText = "Hình ảnh";
                label8.Visible = false;
            }
            else
            {
                label8.Visible = true;
            }
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
                if (nv.DeleteBaiDang(txtId.Text))
                {
                    resetValues();
                    MessageBox.Show("Đã từ chối ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                 MessageBox.Show("Vui lòng chọn đối tượng","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
    }
}
