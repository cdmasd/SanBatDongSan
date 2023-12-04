namespace QuanLyBDS.NhanVien
{
    partial class FrmDuyetbai
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            txtDiachi = new Sunny.UI.UITextBox();
            label7 = new Label();
            btnDuyet = new Sunny.UI.UIButton();
            btnTuchoi = new Sunny.UI.UIButton();
            txtHinhanh = new Sunny.UI.UITextBox();
            txtGia = new Sunny.UI.UITextBox();
            txtSophong = new Sunny.UI.UITextBox();
            txtDientich = new Sunny.UI.UITextBox();
            cbLoainha = new Sunny.UI.UIComboBox();
            txtTieude = new Sunny.UI.UITextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtView = new Sunny.UI.UIDataGridView();
            btnXem = new Sunny.UI.UIButton();
            txtId = new Label();
            label8 = new Label();
            btnTimKiem = new Sunny.UI.UIButton();
            label10 = new Label();
            txtTimKiem = new Sunny.UI.UITextBox();
            btnTruoc = new Sunny.UI.UIButton();
            btnSau = new Sunny.UI.UIButton();
            txtCurrentPage = new Label();
            btnBoQua = new Sunny.UI.UIButton();
            btnDanhSach = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)dtView).BeginInit();
            SuspendLayout();
            // 
            // txtDiachi
            // 
            txtDiachi.Enabled = false;
            txtDiachi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiachi.Location = new Point(904, 75);
            txtDiachi.Margin = new Padding(4, 5, 4, 5);
            txtDiachi.MinimumSize = new Size(1, 16);
            txtDiachi.Multiline = true;
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Padding = new Padding(5);
            txtDiachi.ShowText = false;
            txtDiachi.Size = new Size(203, 68);
            txtDiachi.Style = Sunny.UI.UIStyle.Custom;
            txtDiachi.TabIndex = 29;
            txtDiachi.TextAlignment = ContentAlignment.MiddleLeft;
            txtDiachi.Watermark = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(900, 49);
            label7.Name = "label7";
            label7.Size = new Size(200, 25);
            label7.TabIndex = 28;
            label7.Text = "Địa chỉ bất động sản :";
            // 
            // btnDuyet
            // 
            btnDuyet.FillColor = SystemColors.Highlight;
            btnDuyet.FillHoverColor = Color.MidnightBlue;
            btnDuyet.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDuyet.Location = new Point(1148, 54);
            btnDuyet.MinimumSize = new Size(1, 1);
            btnDuyet.Name = "btnDuyet";
            btnDuyet.Size = new Size(100, 35);
            btnDuyet.Style = Sunny.UI.UIStyle.Custom;
            btnDuyet.TabIndex = 34;
            btnDuyet.Text = "Duyệt";
            btnDuyet.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDuyet.Click += btnDuyet_Click;
            // 
            // btnTuchoi
            // 
            btnTuchoi.FillColor = SystemColors.Highlight;
            btnTuchoi.FillHoverColor = Color.MidnightBlue;
            btnTuchoi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTuchoi.Location = new Point(1148, 159);
            btnTuchoi.MinimumSize = new Size(1, 1);
            btnTuchoi.Name = "btnTuchoi";
            btnTuchoi.Size = new Size(100, 35);
            btnTuchoi.Style = Sunny.UI.UIStyle.Custom;
            btnTuchoi.TabIndex = 32;
            btnTuchoi.Text = "Từ chối";
            btnTuchoi.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnTuchoi.Click += btnTuchoi_Click;
            // 
            // txtHinhanh
            // 
            txtHinhanh.Enabled = false;
            txtHinhanh.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHinhanh.Location = new Point(904, 174);
            txtHinhanh.Margin = new Padding(4, 5, 4, 5);
            txtHinhanh.MinimumSize = new Size(1, 16);
            txtHinhanh.Multiline = true;
            txtHinhanh.Name = "txtHinhanh";
            txtHinhanh.Padding = new Padding(5);
            txtHinhanh.ShowText = false;
            txtHinhanh.Size = new Size(203, 43);
            txtHinhanh.Style = Sunny.UI.UIStyle.Custom;
            txtHinhanh.TabIndex = 30;
            txtHinhanh.TextAlignment = ContentAlignment.MiddleLeft;
            txtHinhanh.Watermark = "";
            // 
            // txtGia
            // 
            txtGia.Enabled = false;
            txtGia.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtGia.Location = new Point(513, 190);
            txtGia.Margin = new Padding(4, 5, 4, 5);
            txtGia.MinimumSize = new Size(1, 16);
            txtGia.Name = "txtGia";
            txtGia.Padding = new Padding(5);
            txtGia.ShowText = false;
            txtGia.Size = new Size(203, 27);
            txtGia.Style = Sunny.UI.UIStyle.Custom;
            txtGia.TabIndex = 27;
            txtGia.TextAlignment = ContentAlignment.MiddleLeft;
            txtGia.Watermark = "";
            // 
            // txtSophong
            // 
            txtSophong.Enabled = false;
            txtSophong.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSophong.Location = new Point(513, 155);
            txtSophong.Margin = new Padding(4, 5, 4, 5);
            txtSophong.MinimumSize = new Size(1, 16);
            txtSophong.Name = "txtSophong";
            txtSophong.Padding = new Padding(5);
            txtSophong.ShowText = false;
            txtSophong.Size = new Size(203, 27);
            txtSophong.Style = Sunny.UI.UIStyle.Custom;
            txtSophong.TabIndex = 26;
            txtSophong.TextAlignment = ContentAlignment.MiddleLeft;
            txtSophong.Watermark = "";
            // 
            // txtDientich
            // 
            txtDientich.Enabled = false;
            txtDientich.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDientich.Location = new Point(513, 120);
            txtDientich.Margin = new Padding(4, 5, 4, 5);
            txtDientich.MinimumSize = new Size(1, 16);
            txtDientich.Name = "txtDientich";
            txtDientich.Padding = new Padding(5);
            txtDientich.ShowText = false;
            txtDientich.Size = new Size(203, 27);
            txtDientich.Style = Sunny.UI.UIStyle.Custom;
            txtDientich.TabIndex = 25;
            txtDientich.TextAlignment = ContentAlignment.MiddleLeft;
            txtDientich.Watermark = "";
            // 
            // cbLoainha
            // 
            cbLoainha.DataSource = null;
            cbLoainha.Enabled = false;
            cbLoainha.FillColor = Color.White;
            cbLoainha.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbLoainha.Location = new Point(513, 85);
            cbLoainha.Margin = new Padding(4, 5, 4, 5);
            cbLoainha.MinimumSize = new Size(63, 0);
            cbLoainha.Name = "cbLoainha";
            cbLoainha.Padding = new Padding(0, 0, 30, 2);
            cbLoainha.Size = new Size(203, 27);
            cbLoainha.Style = Sunny.UI.UIStyle.Custom;
            cbLoainha.TabIndex = 24;
            cbLoainha.TextAlignment = ContentAlignment.MiddleLeft;
            cbLoainha.Watermark = "";
            // 
            // txtTieude
            // 
            txtTieude.Enabled = false;
            txtTieude.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTieude.Location = new Point(513, 50);
            txtTieude.Margin = new Padding(4, 5, 4, 5);
            txtTieude.MinimumSize = new Size(1, 16);
            txtTieude.Name = "txtTieude";
            txtTieude.Padding = new Padding(5);
            txtTieude.ShowText = false;
            txtTieude.Size = new Size(203, 27);
            txtTieude.Style = Sunny.UI.UIStyle.Custom;
            txtTieude.TabIndex = 23;
            txtTieude.TextAlignment = ContentAlignment.MiddleLeft;
            txtTieude.Watermark = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(900, 148);
            label6.Name = "label6";
            label6.Size = new Size(101, 25);
            label6.TabIndex = 22;
            label6.Text = "Hình ảnh :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(418, 193);
            label5.Name = "label5";
            label5.Size = new Size(114, 25);
            label5.TabIndex = 21;
            label5.Text = "Giá (VND) :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(422, 158);
            label4.Name = "label4";
            label4.Size = new Size(108, 25);
            label4.TabIndex = 20;
            label4.Text = "Số phòng :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(401, 123);
            label3.Name = "label3";
            label3.Size = new Size(135, 25);
            label3.TabIndex = 19;
            label3.Text = "Diện tích (m²):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(430, 88);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 18;
            label2.Text = "Loại nhà :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(439, 53);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 17;
            label1.Text = "Tiêu đề :";
            // 
            // dtView
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 249, 255);
            dtView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtView.BackgroundColor = Color.FromArgb(243, 249, 255);
            dtView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtView.DefaultCellStyle = dataGridViewCellStyle3;
            dtView.EnableHeadersVisualStyles = false;
            dtView.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtView.GridColor = Color.FromArgb(104, 173, 255);
            dtView.Location = new Point(113, 331);
            dtView.MultiSelect = false;
            dtView.Name = "dtView";
            dtView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(243, 249, 255);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtView.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dtView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dtView.RowTemplate.Height = 25;
            dtView.ScrollBarRectColor = Color.FromArgb(80, 160, 255);
            dtView.SelectedIndex = -1;
            dtView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtView.Size = new Size(1315, 465);
            dtView.Style = Sunny.UI.UIStyle.Custom;
            dtView.TabIndex = 35;
            dtView.Click += dtView_Click;
            // 
            // btnXem
            // 
            btnXem.FillColor = SystemColors.Highlight;
            btnXem.FillHoverColor = Color.MidnightBlue;
            btnXem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXem.Location = new Point(1148, 109);
            btnXem.MinimumSize = new Size(1, 1);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(100, 35);
            btnXem.Style = Sunny.UI.UIStyle.Custom;
            btnXem.TabIndex = 36;
            btnXem.Text = "Xem ảnh";
            btnXem.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnXem.Click += btnXem_Click;
            // 
            // txtId
            // 
            txtId.AutoSize = true;
            txtId.Location = new Point(717, 93);
            txtId.Name = "txtId";
            txtId.Size = new Size(69, 20);
            txtId.TabIndex = 37;
            txtId.Text = "label8";
            txtId.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(707, 553);
            label8.Name = "label8";
            label8.Size = new Size(158, 25);
            label8.TabIndex = 38;
            label8.Text = "Không có dữ liệu";
            label8.Visible = false;
            // 
            // btnTimKiem
            // 
            btnTimKiem.FillColor = SystemColors.Highlight;
            btnTimKiem.FillHoverColor = Color.MidnightBlue;
            btnTimKiem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimKiem.Location = new Point(901, 270);
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
            label10.Location = new Point(519, 277);
            label10.Name = "label10";
            label10.Size = new Size(95, 25);
            label10.TabIndex = 63;
            label10.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(599, 274);
            txtTimKiem.Margin = new Padding(4, 5, 4, 5);
            txtTimKiem.MinimumSize = new Size(1, 16);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Padding = new Padding(5);
            txtTimKiem.ShowText = false;
            txtTimKiem.Size = new Size(281, 27);
            txtTimKiem.Style = Sunny.UI.UIStyle.Custom;
            txtTimKiem.TabIndex = 62;
            txtTimKiem.TextAlignment = ContentAlignment.MiddleLeft;
            txtTimKiem.Watermark = "Nhập mã bài đăng";
            // 
            // btnTruoc
            // 
            btnTruoc.FillColor = SystemColors.Highlight;
            btnTruoc.FillHoverColor = Color.MidnightBlue;
            btnTruoc.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTruoc.Location = new Point(186, 377);
            btnTruoc.MinimumSize = new Size(1, 1);
            btnTruoc.Name = "btnTruoc";
            btnTruoc.Size = new Size(100, 35);
            btnTruoc.Style = Sunny.UI.UIStyle.Custom;
            btnTruoc.TabIndex = 67;
            btnTruoc.Text = "Trang Trước";
            btnTruoc.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnTruoc.Click += btnTruoc_Click;
            // 
            // btnSau
            // 
            btnSau.FillColor = SystemColors.Highlight;
            btnSau.FillHoverColor = Color.MidnightBlue;
            btnSau.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSau.Location = new Point(293, 377);
            btnSau.MinimumSize = new Size(1, 1);
            btnSau.Name = "btnSau";
            btnSau.Size = new Size(100, 35);
            btnSau.Style = Sunny.UI.UIStyle.Custom;
            btnSau.TabIndex = 68;
            btnSau.Text = "Trang Sau";
            btnSau.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSau.Click += btnSau_Click;
            // 
            // txtCurrentPage
            // 
            txtCurrentPage.AutoSize = true;
            txtCurrentPage.BackColor = Color.White;
            txtCurrentPage.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCurrentPage.Location = new Point(124, 735);
            txtCurrentPage.Name = "txtCurrentPage";
            txtCurrentPage.Size = new Size(79, 29);
            txtCurrentPage.TabIndex = 69;
            txtCurrentPage.Text = "label9";
            // 
            // btnBoQua
            // 
            btnBoQua.FillColor = SystemColors.Highlight;
            btnBoQua.FillHoverColor = Color.MidnightBlue;
            btnBoQua.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBoQua.Location = new Point(1148, 212);
            btnBoQua.MinimumSize = new Size(1, 1);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(100, 35);
            btnBoQua.Style = Sunny.UI.UIStyle.Custom;
            btnBoQua.TabIndex = 70;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBoQua.Click += btnBoQua_Click;
            // 
            // btnDanhSach
            // 
            btnDanhSach.FillColor = SystemColors.Highlight;
            btnDanhSach.FillHoverColor = Color.MidnightBlue;
            btnDanhSach.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDanhSach.Location = new Point(1021, 270);
            btnDanhSach.MinimumSize = new Size(1, 1);
            btnDanhSach.Name = "btnDanhSach";
            btnDanhSach.Size = new Size(100, 35);
            btnDanhSach.Style = Sunny.UI.UIStyle.Custom;
            btnDanhSach.TabIndex = 71;
            btnDanhSach.Text = "Danh sách";
            btnDanhSach.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDanhSach.Click += btnDanhSach_Click;
            // 
            // FrmDuyetbai
            // 
            AllowShowTitle = false;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1600, 965);
            Controls.Add(btnDanhSach);
            Controls.Add(btnBoQua);
            Controls.Add(txtCurrentPage);
            Controls.Add(btnSau);
            Controls.Add(btnTruoc);
            Controls.Add(btnTimKiem);
            Controls.Add(label10);
            Controls.Add(txtTimKiem);
            Controls.Add(label8);
            Controls.Add(txtId);
            Controls.Add(btnXem);
            Controls.Add(dtView);
            Controls.Add(txtDiachi);
            Controls.Add(label7);
            Controls.Add(btnDuyet);
            Controls.Add(btnTuchoi);
            Controls.Add(txtHinhanh);
            Controls.Add(txtGia);
            Controls.Add(txtSophong);
            Controls.Add(txtDientich);
            Controls.Add(cbLoainha);
            Controls.Add(txtTieude);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            HelpButton = true;
            Name = "FrmDuyetbai";
            Padding = new Padding(0);
            ShowTitle = false;
            Style = Sunny.UI.UIStyle.Custom;
            Text = "FrmDuyetbai";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            Load += FrmDuyetbai_Load;
            ((System.ComponentModel.ISupportInitialize)dtView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Sunny.UI.UITextBox txtDiachi;
        private Label label7;
        private Sunny.UI.UIButton btnDuyet;
        private Sunny.UI.UIButton btnTuchoi;
        private Sunny.UI.UITextBox txtHinhanh;
        private Sunny.UI.UITextBox txtGia;
        private Sunny.UI.UITextBox txtSophong;
        private Sunny.UI.UITextBox txtDientich;
        private Sunny.UI.UIComboBox cbLoainha;
        private Sunny.UI.UITextBox txtTieude;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        public Sunny.UI.UIDataGridView dtView;
        private Sunny.UI.UIButton btnXem;
        private Label txtId;
        private Label label8;
        private Sunny.UI.UIButton btnTimKiem;
        private Label label10;
        private Sunny.UI.UITextBox txtTimKiem;
        private Sunny.UI.UIButton btnTruoc;
        private Sunny.UI.UIButton btnSau;
        private Label txtCurrentPage;
        private Sunny.UI.UIButton btnBoQua;
        private Sunny.UI.UIButton btnDanhSach;
    }
}