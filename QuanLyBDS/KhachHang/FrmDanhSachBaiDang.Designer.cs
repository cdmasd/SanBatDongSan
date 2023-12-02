namespace QuanLyBDS.KhachHang
{
    partial class FrmDanhSachBaiDang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            btnUpdate = new Sunny.UI.UIButton();
            btnUpload = new Sunny.UI.UIButton();
            txtGia = new Sunny.UI.UITextBox();
            txtSophong = new Sunny.UI.UITextBox();
            txtDientich = new Sunny.UI.UITextBox();
            cbLoainha = new Sunny.UI.UIComboBox();
            txtTieude = new Sunny.UI.UITextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtView = new Sunny.UI.UIDataGridView();
            txtDiachi = new Sunny.UI.UITextBox();
            label7 = new Label();
            txtHinhanh = new Sunny.UI.UITextBox();
            label6 = new Label();
            txtId = new Label();
            label8 = new Label();
            btnTimKiem = new Sunny.UI.UIButton();
            label10 = new Label();
            txtTimKiem = new Sunny.UI.UITextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btDaduyet = new Sunny.UI.UIButton();
            btChuaduyet = new Sunny.UI.UIButton();
            btBituchoi = new Sunny.UI.UIButton();
            btXoa = new Sunny.UI.UIButton();
            txtCurrentPage = new Label();
            btnSau = new Sunny.UI.UIButton();
            btnTruoc = new Sunny.UI.UIButton();
            btnDanhSach = new Sunny.UI.UIButton();
            btnBoQua = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)dtView).BeginInit();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.FillColor = SystemColors.Highlight;
            btnUpdate.FillHoverColor = Color.MidnightBlue;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(1044, 66);
            btnUpdate.MinimumSize = new Size(1, 1);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 35);
            btnUpdate.Style = Sunny.UI.UIStyle.Custom;
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnUpload
            // 
            btnUpload.Anchor = AnchorStyles.None;
            btnUpload.FillColor = SystemColors.Highlight;
            btnUpload.FillHoverColor = Color.MidnightBlue;
            btnUpload.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpload.Location = new Point(1044, 189);
            btnUpload.MinimumSize = new Size(1, 1);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(100, 35);
            btnUpload.Style = Sunny.UI.UIStyle.Custom;
            btnUpload.TabIndex = 26;
            btnUpload.Text = "Upload";
            btnUpload.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpload.Click += btnUpload_Click;
            // 
            // txtGia
            // 
            txtGia.Anchor = AnchorStyles.None;
            txtGia.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtGia.Location = new Point(377, 210);
            txtGia.Margin = new Padding(4, 5, 4, 5);
            txtGia.MinimumSize = new Size(1, 16);
            txtGia.Name = "txtGia";
            txtGia.Padding = new Padding(5);
            txtGia.ShowText = false;
            txtGia.Size = new Size(203, 27);
            txtGia.Style = Sunny.UI.UIStyle.Custom;
            txtGia.TabIndex = 24;
            txtGia.TextAlignment = ContentAlignment.MiddleLeft;
            txtGia.Watermark = "";
            // 
            // txtSophong
            // 
            txtSophong.Anchor = AnchorStyles.None;
            txtSophong.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSophong.Location = new Point(377, 167);
            txtSophong.Margin = new Padding(4, 5, 4, 5);
            txtSophong.MinimumSize = new Size(1, 16);
            txtSophong.Name = "txtSophong";
            txtSophong.Padding = new Padding(5);
            txtSophong.ShowText = false;
            txtSophong.Size = new Size(203, 27);
            txtSophong.Style = Sunny.UI.UIStyle.Custom;
            txtSophong.TabIndex = 23;
            txtSophong.TextAlignment = ContentAlignment.MiddleLeft;
            txtSophong.Watermark = "";
            // 
            // txtDientich
            // 
            txtDientich.Anchor = AnchorStyles.None;
            txtDientich.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDientich.Location = new Point(377, 124);
            txtDientich.Margin = new Padding(4, 5, 4, 5);
            txtDientich.MinimumSize = new Size(1, 16);
            txtDientich.Name = "txtDientich";
            txtDientich.Padding = new Padding(5);
            txtDientich.ShowText = false;
            txtDientich.Size = new Size(203, 27);
            txtDientich.Style = Sunny.UI.UIStyle.Custom;
            txtDientich.TabIndex = 22;
            txtDientich.TextAlignment = ContentAlignment.MiddleLeft;
            txtDientich.Watermark = "";
            // 
            // cbLoainha
            // 
            cbLoainha.Anchor = AnchorStyles.None;
            cbLoainha.DataSource = null;
            cbLoainha.FillColor = Color.White;
            cbLoainha.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbLoainha.Items.AddRange(new object[] { "Chung cư", "Căn hộ mini", "Nhà nguyên căn", "Biệt thự", "Văn phòng" });
            cbLoainha.Location = new Point(377, 81);
            cbLoainha.Margin = new Padding(4, 5, 4, 5);
            cbLoainha.MinimumSize = new Size(63, 0);
            cbLoainha.Name = "cbLoainha";
            cbLoainha.Padding = new Padding(0, 0, 30, 2);
            cbLoainha.Size = new Size(203, 27);
            cbLoainha.Style = Sunny.UI.UIStyle.Custom;
            cbLoainha.TabIndex = 21;
            cbLoainha.TextAlignment = ContentAlignment.MiddleLeft;
            cbLoainha.Watermark = "";
            // 
            // txtTieude
            // 
            txtTieude.Anchor = AnchorStyles.None;
            txtTieude.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTieude.Location = new Point(377, 38);
            txtTieude.Margin = new Padding(4, 5, 4, 5);
            txtTieude.MinimumSize = new Size(1, 16);
            txtTieude.Name = "txtTieude";
            txtTieude.Padding = new Padding(5);
            txtTieude.ShowText = false;
            txtTieude.Size = new Size(203, 27);
            txtTieude.Style = Sunny.UI.UIStyle.Custom;
            txtTieude.TabIndex = 20;
            txtTieude.TextAlignment = ContentAlignment.MiddleLeft;
            txtTieude.Watermark = "";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(284, 213);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 18;
            label5.Text = "Giá (VND):";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(284, 170);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 17;
            label4.Text = "Số phòng :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(259, 127);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 16;
            label3.Text = "Diện tích (m²) :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(292, 84);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 15;
            label2.Text = "Loại nhà :";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(301, 41);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 14;
            label1.Text = "Tiêu đề :";
            // 
            // dtView
            // 
            dtView.AllowUserToAddRows = false;
            dtView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(243, 249, 255);
            dtView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dtView.Anchor = AnchorStyles.None;
            dtView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtView.BackgroundColor = Color.FromArgb(243, 249, 255);
            dtView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dtView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dtView.ColumnHeadersHeight = 32;
            dtView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dtView.DefaultCellStyle = dataGridViewCellStyle8;
            dtView.EnableHeadersVisualStyles = false;
            dtView.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtView.GridColor = Color.FromArgb(104, 173, 255);
            dtView.Location = new Point(113, 331);
            dtView.MultiSelect = false;
            dtView.Name = "dtView";
            dtView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(243, 249, 255);
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dtView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dtView.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dtView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dtView.RowTemplate.Height = 25;
            dtView.ScrollBarRectColor = Color.FromArgb(80, 160, 255);
            dtView.SelectedIndex = -1;
            dtView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtView.Size = new Size(1315, 465);
            dtView.Style = Sunny.UI.UIStyle.Custom;
            dtView.TabIndex = 28;
            // 
            // txtDiachi
            // 
            txtDiachi.Anchor = AnchorStyles.None;
            txtDiachi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiachi.Location = new Point(690, 66);
            txtDiachi.Margin = new Padding(4, 5, 4, 5);
            txtDiachi.MinimumSize = new Size(1, 16);
            txtDiachi.Multiline = true;
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Padding = new Padding(5);
            txtDiachi.ShowText = false;
            txtDiachi.Size = new Size(321, 81);
            txtDiachi.Style = Sunny.UI.UIStyle.Custom;
            txtDiachi.TabIndex = 31;
            txtDiachi.TextAlignment = ContentAlignment.MiddleLeft;
            txtDiachi.Watermark = "";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(690, 41);
            label7.Name = "label7";
            label7.Size = new Size(162, 20);
            label7.TabIndex = 30;
            label7.Text = "Địa chỉ bất động sản :";
            // 
            // txtHinhanh
            // 
            txtHinhanh.Anchor = AnchorStyles.None;
            txtHinhanh.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHinhanh.Location = new Point(690, 179);
            txtHinhanh.Margin = new Padding(4, 5, 4, 5);
            txtHinhanh.MinimumSize = new Size(1, 16);
            txtHinhanh.Multiline = true;
            txtHinhanh.Name = "txtHinhanh";
            txtHinhanh.Padding = new Padding(5);
            txtHinhanh.ShowText = false;
            txtHinhanh.Size = new Size(321, 58);
            txtHinhanh.Style = Sunny.UI.UIStyle.Custom;
            txtHinhanh.TabIndex = 32;
            txtHinhanh.TextAlignment = ContentAlignment.MiddleLeft;
            txtHinhanh.Watermark = "";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(686, 153);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 29;
            label6.Text = "Hình ảnh :";
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.None;
            txtId.AutoSize = true;
            txtId.Location = new Point(621, 104);
            txtId.Name = "txtId";
            txtId.Size = new Size(0, 16);
            txtId.TabIndex = 33;
            txtId.Visible = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(726, 543);
            label8.Name = "label8";
            label8.Size = new Size(126, 20);
            label8.TabIndex = 57;
            label8.Text = "Không có dữ liệu";
            label8.Visible = false;
            // 
            // btnTimKiem
            // 
            btnTimKiem.FillColor = SystemColors.Highlight;
            btnTimKiem.FillHoverColor = Color.MidnightBlue;
            btnTimKiem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimKiem.Location = new Point(754, 281);
            btnTimKiem.MinimumSize = new Size(1, 1);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(100, 35);
            btnTimKiem.Style = Sunny.UI.UIStyle.Custom;
            btnTimKiem.TabIndex = 64;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(406, 288);
            label10.Name = "label10";
            label10.Size = new Size(73, 20);
            label10.TabIndex = 63;
            label10.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(518, 285);
            txtTimKiem.Margin = new Padding(4, 5, 4, 5);
            txtTimKiem.MinimumSize = new Size(1, 16);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Padding = new Padding(5);
            txtTimKiem.ShowText = false;
            txtTimKiem.Size = new Size(203, 27);
            txtTimKiem.Style = Sunny.UI.UIStyle.Custom;
            txtTimKiem.TabIndex = 62;
            txtTimKiem.TextAlignment = ContentAlignment.MiddleLeft;
            txtTimKiem.Watermark = "Nhập mã bài đăng";
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // btDaduyet
            // 
            btDaduyet.BackColor = Color.LimeGreen;
            btDaduyet.FillColor = Color.LimeGreen;
            btDaduyet.FillHoverColor = Color.MediumSpringGreen;
            btDaduyet.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btDaduyet.Location = new Point(905, 275);
            btDaduyet.MinimumSize = new Size(1, 1);
            btDaduyet.Name = "btDaduyet";
            btDaduyet.RectColor = Color.LimeGreen;
            btDaduyet.Size = new Size(164, 46);
            btDaduyet.Style = Sunny.UI.UIStyle.Custom;
            btDaduyet.TabIndex = 65;
            btDaduyet.Text = "Đã được duyệt";
            btDaduyet.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btDaduyet.Click += btDaduyet_Click;
            // 
            // btChuaduyet
            // 
            btChuaduyet.BackColor = Color.RoyalBlue;
            btChuaduyet.FillColor = Color.RoyalBlue;
            btChuaduyet.FillHoverColor = Color.MidnightBlue;
            btChuaduyet.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btChuaduyet.Location = new Point(1086, 275);
            btChuaduyet.MinimumSize = new Size(1, 1);
            btChuaduyet.Name = "btChuaduyet";
            btChuaduyet.RectColor = Color.RoyalBlue;
            btChuaduyet.Size = new Size(164, 46);
            btChuaduyet.Style = Sunny.UI.UIStyle.Custom;
            btChuaduyet.TabIndex = 66;
            btChuaduyet.Text = "Chưa được duyệt";
            btChuaduyet.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btChuaduyet.Click += btChuaduyet_Click;
            // 
            // btBituchoi
            // 
            btBituchoi.BackColor = Color.RoyalBlue;
            btBituchoi.FillColor = Color.Crimson;
            btBituchoi.FillHoverColor = Color.LightPink;
            btBituchoi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btBituchoi.Location = new Point(1264, 275);
            btBituchoi.MinimumSize = new Size(1, 1);
            btBituchoi.Name = "btBituchoi";
            btBituchoi.RectColor = Color.Crimson;
            btBituchoi.Size = new Size(164, 46);
            btBituchoi.Style = Sunny.UI.UIStyle.Custom;
            btBituchoi.TabIndex = 67;
            btBituchoi.Text = "Bị từ chối";
            btBituchoi.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btBituchoi.Click += btBituchoi_Click;
            // 
            // btXoa
            // 
            btXoa.Anchor = AnchorStyles.None;
            btXoa.FillColor = SystemColors.Highlight;
            btXoa.FillHoverColor = Color.MidnightBlue;
            btXoa.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btXoa.Location = new Point(1170, 66);
            btXoa.MinimumSize = new Size(1, 1);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(100, 35);
            btXoa.Style = Sunny.UI.UIStyle.Custom;
            btXoa.TabIndex = 68;
            btXoa.Text = "Xoá bài";
            btXoa.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btXoa.Click += btXoa_Click;
            // 
            // txtCurrentPage
            // 
            txtCurrentPage.AutoSize = true;
            txtCurrentPage.BackColor = Color.White;
            txtCurrentPage.Font = new Font("Roboto Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCurrentPage.Location = new Point(124, 735);
            txtCurrentPage.Name = "txtCurrentPage";
            txtCurrentPage.Size = new Size(54, 23);
            txtCurrentPage.TabIndex = 72;
            txtCurrentPage.Text = "label9";
            // 
            // btnSau
            // 
            btnSau.FillColor = SystemColors.Highlight;
            btnSau.FillHoverColor = Color.MidnightBlue;
            btnSau.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSau.Location = new Point(1328, 802);
            btnSau.MinimumSize = new Size(1, 1);
            btnSau.Name = "btnSau";
            btnSau.Size = new Size(100, 35);
            btnSau.Style = Sunny.UI.UIStyle.Custom;
            btnSau.TabIndex = 74;
            btnSau.Text = "Trang Sau";
            btnSau.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSau.Click += btnSau_Click;
            // 
            // btnTruoc
            // 
            btnTruoc.FillColor = SystemColors.Highlight;
            btnTruoc.FillHoverColor = Color.MidnightBlue;
            btnTruoc.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTruoc.Location = new Point(1221, 802);
            btnTruoc.MinimumSize = new Size(1, 1);
            btnTruoc.Name = "btnTruoc";
            btnTruoc.Size = new Size(100, 35);
            btnTruoc.Style = Sunny.UI.UIStyle.Custom;
            btnTruoc.TabIndex = 73;
            btnTruoc.Text = "Trang Trước";
            btnTruoc.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnTruoc.Click += btnTruoc_Click;
            // 
            // btnDanhSach
            // 
            btnDanhSach.Anchor = AnchorStyles.None;
            btnDanhSach.FillColor = SystemColors.Highlight;
            btnDanhSach.FillHoverColor = Color.MidnightBlue;
            btnDanhSach.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDanhSach.Location = new Point(1044, 116);
            btnDanhSach.MinimumSize = new Size(1, 1);
            btnDanhSach.Name = "btnDanhSach";
            btnDanhSach.Size = new Size(100, 35);
            btnDanhSach.Style = Sunny.UI.UIStyle.Custom;
            btnDanhSach.TabIndex = 75;
            btnDanhSach.Text = "Danh sách";
            btnDanhSach.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDanhSach.Click += btnDanhSach_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.Anchor = AnchorStyles.None;
            btnBoQua.FillColor = SystemColors.Highlight;
            btnBoQua.FillHoverColor = Color.MidnightBlue;
            btnBoQua.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBoQua.Location = new Point(1170, 116);
            btnBoQua.MinimumSize = new Size(1, 1);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(100, 35);
            btnBoQua.Style = Sunny.UI.UIStyle.Custom;
            btnBoQua.TabIndex = 76;
            btnBoQua.Text = "Bỏ Qua";
            btnBoQua.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBoQua.Click += btnBoQua_Click;
            // 
            // FrmDanhSachBaiDang
            // 
            AllowShowTitle = false;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1600, 965);
            Controls.Add(btnBoQua);
            Controls.Add(btnDanhSach);
            Controls.Add(btnSau);
            Controls.Add(btnTruoc);
            Controls.Add(txtCurrentPage);
            Controls.Add(btXoa);
            Controls.Add(btBituchoi);
            Controls.Add(btChuaduyet);
            Controls.Add(btDaduyet);
            Controls.Add(btnTimKiem);
            Controls.Add(label10);
            Controls.Add(txtTimKiem);
            Controls.Add(label8);
            Controls.Add(txtId);
            Controls.Add(txtDiachi);
            Controls.Add(label7);
            Controls.Add(txtHinhanh);
            Controls.Add(label6);
            Controls.Add(dtView);
            Controls.Add(btnUpdate);
            Controls.Add(btnUpload);
            Controls.Add(txtGia);
            Controls.Add(txtSophong);
            Controls.Add(txtDientich);
            Controls.Add(cbLoainha);
            Controls.Add(txtTieude);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmDanhSachBaiDang";
            Padding = new Padding(0);
            ShowTitle = false;
            Style = Sunny.UI.UIStyle.Custom;
            Text = "FrmDanhSachBaiDang";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            Load += FrmDanhSachBaiDang_Load;
            ((System.ComponentModel.ISupportInitialize)dtView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Sunny.UI.UIButton btnUpdate;
        private Sunny.UI.UIButton btnUpload;
        private Sunny.UI.UITextBox txtGia;
        private Sunny.UI.UITextBox txtSophong;
        private Sunny.UI.UITextBox txtDientich;
        private Sunny.UI.UIComboBox cbLoainha;
        private Sunny.UI.UITextBox txtTieude;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Sunny.UI.UIDataGridView dtView;
        private Sunny.UI.UITextBox txtDiachi;
        private Label label7;
        private Sunny.UI.UITextBox txtHinhanh;
        private Label label6;
        private Label txtId;
        private Label label8;
        private Sunny.UI.UIButton btnTimKiem;
        private Label label10;
        private Sunny.UI.UITextBox txtTimKiem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Sunny.UI.UIButton btDaduyet;
        private Sunny.UI.UIButton btChuaduyet;
        private Sunny.UI.UIButton btBituchoi;
        private Sunny.UI.UIButton btXoa;
        private Label txtCurrentPage;
        private Sunny.UI.UIButton btnSau;
        private Sunny.UI.UIButton btnTruoc;
        private Sunny.UI.UIButton btnDanhSach;
        private Sunny.UI.UIButton btnBoQua;
    }
}