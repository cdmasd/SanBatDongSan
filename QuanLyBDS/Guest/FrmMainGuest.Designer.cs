namespace QuanLyBDS.Guest
{
    partial class FrmMainGuest
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
            dtView = new Sunny.UI.UIDataGridView();
            cbLoainha = new Sunny.UI.UIComboBox();
            cbDientich = new Sunny.UI.UIComboBox();
            cbSophong = new Sunny.UI.UIComboBox();
            cbGia = new Sunny.UI.UIComboBox();
            cbDiachi = new Sunny.UI.UIComboBox();
            label1 = new Label();
            label2 = new Label();
            txtHoten = new Label();
            label3 = new Label();
            txtEmail = new Label();
            label5 = new Label();
            txtSodt = new Label();
            panelGuest = new Panel();
            btnXemanh = new Sunny.UI.UIButton();
            txtHinhanh = new Label();
            btnQuayLai = new Sunny.UI.UIButton();
            label8 = new Label();
            txtCurrentPage = new Label();
            btnSau = new Sunny.UI.UIButton();
            btnTruoc = new Sunny.UI.UIButton();
            btnDanhSach = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)dtView).BeginInit();
            panelGuest.SuspendLayout();
            SuspendLayout();
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
            dtView.Location = new Point(106, 327);
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
            dtView.TabIndex = 45;
            dtView.CellClick += dtView_CellClick;
            dtView.CellContentClick += dtView_CellContentClick;
            // 
            // cbLoainha
            // 
            cbLoainha.Anchor = AnchorStyles.None;
            cbLoainha.DataSource = null;
            cbLoainha.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cbLoainha.FillColor = Color.White;
            cbLoainha.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbLoainha.Items.AddRange(new object[] { "Chung cư", "Căn hộ mini", "Nhà nguyên căn", "Biệt thự", "Văn phòng", "Khác" });
            cbLoainha.Location = new Point(326, 135);
            cbLoainha.Margin = new Padding(4, 5, 4, 5);
            cbLoainha.MinimumSize = new Size(63, 0);
            cbLoainha.Name = "cbLoainha";
            cbLoainha.Padding = new Padding(0, 0, 30, 2);
            cbLoainha.Size = new Size(241, 48);
            cbLoainha.Style = Sunny.UI.UIStyle.Custom;
            cbLoainha.TabIndex = 46;
            cbLoainha.TextAlignment = ContentAlignment.MiddleLeft;
            cbLoainha.Watermark = "Loại nhà";
            cbLoainha.SelectedIndexChanged += cbLoainha_SelectedIndexChanged;
            // 
            // cbDientich
            // 
            cbDientich.Anchor = AnchorStyles.None;
            cbDientich.DataSource = null;
            cbDientich.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cbDientich.FillColor = Color.White;
            cbDientich.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbDientich.Items.AddRange(new object[] { "20 đến 30 m²", "30 đến 70 m²", "70 đến 80 m²", "80 đến 100 m²", "100 đến 150 m²", "150 đến 200 m²", "200 đến 250 m²" });
            cbDientich.Location = new Point(630, 135);
            cbDientich.Margin = new Padding(4, 5, 4, 5);
            cbDientich.MinimumSize = new Size(63, 0);
            cbDientich.Name = "cbDientich";
            cbDientich.Padding = new Padding(0, 0, 30, 2);
            cbDientich.Size = new Size(241, 48);
            cbDientich.Style = Sunny.UI.UIStyle.Custom;
            cbDientich.TabIndex = 47;
            cbDientich.TextAlignment = ContentAlignment.MiddleLeft;
            cbDientich.Watermark = "Diện tích";
            cbDientich.SelectedIndexChanged += cbDientich_SelectedIndexChanged;
            // 
            // cbSophong
            // 
            cbSophong.Anchor = AnchorStyles.None;
            cbSophong.DataSource = null;
            cbSophong.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cbSophong.FillColor = Color.White;
            cbSophong.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbSophong.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cbSophong.Location = new Point(923, 135);
            cbSophong.Margin = new Padding(4, 5, 4, 5);
            cbSophong.MinimumSize = new Size(63, 0);
            cbSophong.Name = "cbSophong";
            cbSophong.Padding = new Padding(0, 0, 30, 2);
            cbSophong.Size = new Size(241, 48);
            cbSophong.Style = Sunny.UI.UIStyle.Custom;
            cbSophong.TabIndex = 48;
            cbSophong.TextAlignment = ContentAlignment.MiddleLeft;
            cbSophong.Watermark = "Số phòng";
            cbSophong.SelectedIndexChanged += cbSophong_SelectedIndexChanged;
            // 
            // cbGia
            // 
            cbGia.Anchor = AnchorStyles.None;
            cbGia.DataSource = null;
            cbGia.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cbGia.FillColor = Color.White;
            cbGia.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbGia.Items.AddRange(new object[] { "Dưới 1 tỷ", "1 - 3 tỷ", "3 - 5 tỷ", "5 - 10 tỷ", "10 - 40 tỷ", "40 - 70 tỷ", "70 - 100 tỷ" });
            cbGia.Location = new Point(630, 215);
            cbGia.Margin = new Padding(4, 5, 4, 5);
            cbGia.MinimumSize = new Size(63, 0);
            cbGia.Name = "cbGia";
            cbGia.Padding = new Padding(0, 0, 30, 2);
            cbGia.Size = new Size(241, 48);
            cbGia.Style = Sunny.UI.UIStyle.Custom;
            cbGia.TabIndex = 49;
            cbGia.TextAlignment = ContentAlignment.MiddleLeft;
            cbGia.Watermark = "Khoảng giá";
            cbGia.SelectedIndexChanged += cbGia_SelectedIndexChanged;
            // 
            // cbDiachi
            // 
            cbDiachi.Anchor = AnchorStyles.None;
            cbDiachi.DataSource = null;
            cbDiachi.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cbDiachi.FillColor = Color.White;
            cbDiachi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbDiachi.Items.AddRange(new object[] { "Quận 1", "Quận 2", "Quận 3", "Quận 4", "Quận 5", "Quận 6", "Quận 7", "Quận 8", "Quận 9", "Quận 10", "Quận 11", "Quận 12", "Quận Bình Thạnh", "Quận Gò Vấp", "Quận Phú Nhuận", "Quận Tân Bình", "Quận Tân Phú", "Quận Bình Tân", "TP.Thủ Đức", "Huyện Bình Chánh", "Cần Giờ", "Củ Chi", "Hóc Môn", "Nhà Bè" });
            cbDiachi.Location = new Point(326, 215);
            cbDiachi.Margin = new Padding(4, 5, 4, 5);
            cbDiachi.MinimumSize = new Size(63, 0);
            cbDiachi.Name = "cbDiachi";
            cbDiachi.Padding = new Padding(0, 0, 30, 2);
            cbDiachi.Size = new Size(241, 48);
            cbDiachi.Style = Sunny.UI.UIStyle.Custom;
            cbDiachi.TabIndex = 50;
            cbDiachi.TextAlignment = ContentAlignment.MiddleLeft;
            cbDiachi.Watermark = "Khu vực";
            cbDiachi.SelectedIndexChanged += cbDiachi_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1463, 331);
            label1.Name = "label1";
            label1.Size = new Size(152, 24);
            label1.TabIndex = 51;
            label1.Text = "Thông tin liên hệ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(11, 39);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 0;
            label2.Text = "Họ và tên :";
            // 
            // txtHoten
            // 
            txtHoten.AutoSize = true;
            txtHoten.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHoten.Location = new Point(11, 64);
            txtHoten.Name = "txtHoten";
            txtHoten.Size = new Size(137, 20);
            txtHoten.TabIndex = 1;
            txtHoten.Text = "Bấm vào dataview";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(11, 111);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 2;
            label3.Text = "Email :";
            // 
            // txtEmail
            // 
            txtEmail.AutoSize = true;
            txtEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(11, 136);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(137, 20);
            txtEmail.TabIndex = 3;
            txtEmail.Text = "Bấm vào dataview";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(11, 183);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 4;
            label5.Text = "Số điện thoại :";
            // 
            // txtSodt
            // 
            txtSodt.AutoSize = true;
            txtSodt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSodt.Location = new Point(11, 208);
            txtSodt.Name = "txtSodt";
            txtSodt.Size = new Size(137, 20);
            txtSodt.TabIndex = 5;
            txtSodt.Text = "Bấm vào dataview";
            // 
            // panelGuest
            // 
            panelGuest.Anchor = AnchorStyles.None;
            panelGuest.BorderStyle = BorderStyle.FixedSingle;
            panelGuest.Controls.Add(txtSodt);
            panelGuest.Controls.Add(label5);
            panelGuest.Controls.Add(txtEmail);
            panelGuest.Controls.Add(label3);
            panelGuest.Controls.Add(txtHoten);
            panelGuest.Controls.Add(label2);
            panelGuest.Location = new Point(1439, 378);
            panelGuest.Name = "panelGuest";
            panelGuest.Size = new Size(203, 268);
            panelGuest.TabIndex = 52;
            panelGuest.Visible = false;
            // 
            // btnXemanh
            // 
            btnXemanh.Anchor = AnchorStyles.None;
            btnXemanh.BackColor = SystemColors.Highlight;
            btnXemanh.FillColor = SystemColors.Highlight;
            btnXemanh.FillHoverColor = Color.MidnightBlue;
            btnXemanh.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXemanh.Location = new Point(1488, 661);
            btnXemanh.MinimumSize = new Size(1, 1);
            btnXemanh.Name = "btnXemanh";
            btnXemanh.Size = new Size(100, 35);
            btnXemanh.Style = Sunny.UI.UIStyle.Custom;
            btnXemanh.TabIndex = 54;
            btnXemanh.Text = "Xem ảnh";
            btnXemanh.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnXemanh.Click += btnXemanh_Click;
            // 
            // txtHinhanh
            // 
            txtHinhanh.AutoSize = true;
            txtHinhanh.Location = new Point(1515, 717);
            txtHinhanh.Name = "txtHinhanh";
            txtHinhanh.Size = new Size(0, 16);
            txtHinhanh.TabIndex = 56;
            txtHinhanh.Visible = false;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Anchor = AnchorStyles.None;
            btnQuayLai.BackColor = SystemColors.Highlight;
            btnQuayLai.FillColor = SystemColors.Highlight;
            btnQuayLai.FillHoverColor = Color.MidnightBlue;
            btnQuayLai.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnQuayLai.Location = new Point(1460, 768);
            btnQuayLai.MinimumSize = new Size(1, 1);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(173, 65);
            btnQuayLai.Style = Sunny.UI.UIStyle.Custom;
            btnQuayLai.TabIndex = 57;
            btnQuayLai.Text = "Quay lại đăng nhập";
            btnQuayLai.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(700, 549);
            label8.Name = "label8";
            label8.Size = new Size(126, 20);
            label8.TabIndex = 58;
            label8.Text = "Không có dữ liệu";
            label8.Visible = false;
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
            btnSau.Location = new Point(1321, 798);
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
            btnTruoc.Location = new Point(1214, 798);
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
            btnDanhSach.BackColor = SystemColors.Highlight;
            btnDanhSach.FillColor = SystemColors.Highlight;
            btnDanhSach.FillHoverColor = Color.MidnightBlue;
            btnDanhSach.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDanhSach.Location = new Point(1261, 270);
            btnDanhSach.MinimumSize = new Size(1, 1);
            btnDanhSach.Name = "btnDanhSach";
            btnDanhSach.Size = new Size(160, 51);
            btnDanhSach.Style = Sunny.UI.UIStyle.Custom;
            btnDanhSach.TabIndex = 75;
            btnDanhSach.Text = "Danh sách mặc định";
            btnDanhSach.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDanhSach.Click += btnDanhSach_Click;
            // 
            // FrmMainGuest
            // 
            AllowShowTitle = false;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1800, 965);
            Controls.Add(btnDanhSach);
            Controls.Add(btnSau);
            Controls.Add(btnTruoc);
            Controls.Add(txtCurrentPage);
            Controls.Add(label8);
            Controls.Add(btnQuayLai);
            Controls.Add(txtHinhanh);
            Controls.Add(btnXemanh);
            Controls.Add(panelGuest);
            Controls.Add(label1);
            Controls.Add(cbDiachi);
            Controls.Add(cbGia);
            Controls.Add(cbSophong);
            Controls.Add(cbDientich);
            Controls.Add(cbLoainha);
            Controls.Add(dtView);
            Name = "FrmMainGuest";
            Padding = new Padding(0);
            ShowTitle = false;
            Style = Sunny.UI.UIStyle.Custom;
            Text = "";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            Load += FrmMainGuest_Load;
            ((System.ComponentModel.ISupportInitialize)dtView).EndInit();
            panelGuest.ResumeLayout(false);
            panelGuest.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Sunny.UI.UIDataGridView dtView;
        private Sunny.UI.UIComboBox cbLoainha;
        private Sunny.UI.UIComboBox cbDientich;
        private Sunny.UI.UIComboBox cbSophong;
        private Sunny.UI.UIComboBox cbGia;
        private Sunny.UI.UIComboBox cbDiachi;
        private Label label1;
        private Label label2;
        private Label txtHoten;
        private Label label3;
        private Label txtEmail;
        private Label label5;
        private Label txtSodt;
        private Panel panelGuest;
        private Sunny.UI.UIButton btnXemanh;
        private Label txtHinhanh;
        private Sunny.UI.UIButton btnQuayLai;
        private Label label8;
        private Label txtCurrentPage;
        private Sunny.UI.UIButton btnSau;
        private Sunny.UI.UIButton btnTruoc;
        private Sunny.UI.UIButton btnDanhSach;
    }
}