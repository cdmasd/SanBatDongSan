namespace QuanLyBDS.NhanVien
{
    partial class FrmQLKhachHang
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
            btnNap = new Sunny.UI.UIButton();
            txtSodu = new Sunny.UI.UITextBox();
            txtSdt = new Sunny.UI.UITextBox();
            txtEmail = new Sunny.UI.UITextBox();
            txtHoten = new Sunny.UI.UITextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtNap = new Sunny.UI.UITextBox();
            btnXoa = new Sunny.UI.UIButton();
            dtView = new Sunny.UI.UIDataGridView();
            txtId = new Label();
            label8 = new Label();
            btnTimKiem = new Sunny.UI.UIButton();
            label6 = new Label();
            txtTimKiem = new Sunny.UI.UITextBox();
            txtCurrentPage = new Label();
            btnSau = new Sunny.UI.UIButton();
            btnTruoc = new Sunny.UI.UIButton();
            btnDanhSach = new Sunny.UI.UIButton();
            btnBoQua = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)dtView).BeginInit();
            SuspendLayout();
            // 
            // btnNap
            // 
            btnNap.FillColor = SystemColors.Highlight;
            btnNap.FillHoverColor = Color.MidnightBlue;
            btnNap.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNap.Location = new Point(1223, 165);
            btnNap.MinimumSize = new Size(1, 1);
            btnNap.Name = "btnNap";
            btnNap.Size = new Size(127, 28);
            btnNap.Style = Sunny.UI.UIStyle.Custom;
            btnNap.TabIndex = 26;
            btnNap.Text = "Nạp";
            btnNap.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNap.Click += btnNap_Click;
            // 
            // txtSodu
            // 
            txtSodu.Enabled = false;
            txtSodu.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSodu.Location = new Point(649, 204);
            txtSodu.Margin = new Padding(4, 5, 4, 5);
            txtSodu.MinimumSize = new Size(1, 16);
            txtSodu.Name = "txtSodu";
            txtSodu.Padding = new Padding(5);
            txtSodu.ShowText = false;
            txtSodu.Size = new Size(203, 27);
            txtSodu.Style = Sunny.UI.UIStyle.Custom;
            txtSodu.TabIndex = 23;
            txtSodu.TextAlignment = ContentAlignment.MiddleLeft;
            txtSodu.Watermark = "";
            // 
            // txtSdt
            // 
            txtSdt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSdt.Location = new Point(649, 134);
            txtSdt.Margin = new Padding(4, 5, 4, 5);
            txtSdt.MinimumSize = new Size(1, 16);
            txtSdt.Name = "txtSdt";
            txtSdt.Padding = new Padding(5);
            txtSdt.ShowText = false;
            txtSdt.Size = new Size(203, 27);
            txtSdt.Style = Sunny.UI.UIStyle.Custom;
            txtSdt.TabIndex = 24;
            txtSdt.TextAlignment = ContentAlignment.MiddleLeft;
            txtSdt.Watermark = "";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(192, 204);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.MinimumSize = new Size(1, 16);
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(5);
            txtEmail.ShowText = false;
            txtEmail.Size = new Size(203, 27);
            txtEmail.Style = Sunny.UI.UIStyle.Custom;
            txtEmail.TabIndex = 25;
            txtEmail.TextAlignment = ContentAlignment.MiddleLeft;
            txtEmail.Watermark = "";
            // 
            // txtHoten
            // 
            txtHoten.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHoten.Location = new Point(192, 134);
            txtHoten.Margin = new Padding(4, 5, 4, 5);
            txtHoten.MinimumSize = new Size(1, 16);
            txtHoten.Name = "txtHoten";
            txtHoten.Padding = new Padding(5);
            txtHoten.ShowText = false;
            txtHoten.Size = new Size(203, 27);
            txtHoten.Style = Sunny.UI.UIStyle.Custom;
            txtHoten.TabIndex = 22;
            txtHoten.TextAlignment = ContentAlignment.MiddleLeft;
            txtHoten.Watermark = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(649, 176);
            label4.Name = "label4";
            label4.Size = new Size(75, 25);
            label4.TabIndex = 21;
            label4.Text = "Số dư :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(649, 105);
            label3.Name = "label3";
            label3.Size = new Size(137, 25);
            label3.TabIndex = 20;
            label3.Text = "Số điện thoại :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(192, 176);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 19;
            label2.Text = "Email :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(192, 105);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 18;
            label1.Text = "Họ tên :";
            // 
            // txtNap
            // 
            txtNap.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNap.Location = new Point(1219, 131);
            txtNap.Margin = new Padding(4, 5, 4, 5);
            txtNap.MinimumSize = new Size(1, 16);
            txtNap.Name = "txtNap";
            txtNap.Padding = new Padding(5);
            txtNap.ShowText = false;
            txtNap.Size = new Size(135, 27);
            txtNap.Style = Sunny.UI.UIStyle.Custom;
            txtNap.TabIndex = 24;
            txtNap.TextAlignment = ContentAlignment.MiddleLeft;
            txtNap.Watermark = "Nhập số tiền nạp";
            // 
            // btnXoa
            // 
            btnXoa.FillColor = SystemColors.Highlight;
            btnXoa.FillHoverColor = Color.MidnightBlue;
            btnXoa.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(1223, 200);
            btnXoa.MinimumSize = new Size(1, 1);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(127, 31);
            btnXoa.Style = Sunny.UI.UIStyle.Custom;
            btnXoa.TabIndex = 27;
            btnXoa.Text = "Xoá khách hàng";
            btnXoa.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Click += btnXoa_Click;
            // 
            // dtView
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 249, 255);
            dtView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            dtView.TabIndex = 28;
            // 
            // txtId
            // 
            txtId.AutoSize = true;
            txtId.Location = new Point(844, 109);
            txtId.Name = "txtId";
            txtId.Size = new Size(69, 20);
            txtId.TabIndex = 29;
            txtId.Text = "label5";
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
            label8.TabIndex = 56;
            label8.Text = "Không có dữ liệu";
            label8.Visible = false;
            // 
            // btnTimKiem
            // 
            btnTimKiem.FillColor = SystemColors.Highlight;
            btnTimKiem.FillHoverColor = Color.MidnightBlue;
            btnTimKiem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimKiem.Location = new Point(893, 262);
            btnTimKiem.MinimumSize = new Size(1, 1);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(100, 35);
            btnTimKiem.Style = Sunny.UI.UIStyle.Custom;
            btnTimKiem.TabIndex = 64;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(450, 270);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 63;
            label6.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(536, 266);
            txtTimKiem.Margin = new Padding(4, 5, 4, 5);
            txtTimKiem.MinimumSize = new Size(1, 16);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Padding = new Padding(5);
            txtTimKiem.ShowText = false;
            txtTimKiem.Size = new Size(341, 27);
            txtTimKiem.Style = Sunny.UI.UIStyle.Custom;
            txtTimKiem.TabIndex = 62;
            txtTimKiem.TextAlignment = ContentAlignment.MiddleLeft;
            txtTimKiem.Watermark = "Nhập Mã Khách Hàng";
            // 
            // txtCurrentPage
            // 
            txtCurrentPage.AutoSize = true;
            txtCurrentPage.BackColor = Color.White;
            txtCurrentPage.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCurrentPage.Location = new Point(124, 735);
            txtCurrentPage.Name = "txtCurrentPage";
            txtCurrentPage.Size = new Size(79, 29);
            txtCurrentPage.TabIndex = 70;
            txtCurrentPage.Text = "label9";
            // 
            // btnSau
            // 
            btnSau.FillColor = SystemColors.Highlight;
            btnSau.FillHoverColor = Color.MidnightBlue;
            btnSau.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSau.Location = new Point(256, 393);
            btnSau.MinimumSize = new Size(1, 1);
            btnSau.Name = "btnSau";
            btnSau.Size = new Size(100, 35);
            btnSau.Style = Sunny.UI.UIStyle.Custom;
            btnSau.TabIndex = 72;
            btnSau.Text = "Trang Sau";
            btnSau.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSau.Click += btnSau_Click;
            // 
            // btnTruoc
            // 
            btnTruoc.FillColor = SystemColors.Highlight;
            btnTruoc.FillHoverColor = Color.MidnightBlue;
            btnTruoc.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTruoc.Location = new Point(151, 393);
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
            btnDanhSach.FillColor = SystemColors.Highlight;
            btnDanhSach.FillHoverColor = Color.MidnightBlue;
            btnDanhSach.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDanhSach.Location = new Point(999, 262);
            btnDanhSach.MinimumSize = new Size(1, 1);
            btnDanhSach.Name = "btnDanhSach";
            btnDanhSach.Size = new Size(100, 35);
            btnDanhSach.Style = Sunny.UI.UIStyle.Custom;
            btnDanhSach.TabIndex = 74;
            btnDanhSach.Text = "Danh sách";
            btnDanhSach.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDanhSach.Click += btnDanhSach_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.FillColor = SystemColors.Highlight;
            btnBoQua.FillHoverColor = Color.MidnightBlue;
            btnBoQua.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBoQua.Location = new Point(1223, 237);
            btnBoQua.MinimumSize = new Size(1, 1);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(127, 28);
            btnBoQua.Style = Sunny.UI.UIStyle.Custom;
            btnBoQua.TabIndex = 75;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBoQua.Click += btnBoQua_Click;
            // 
            // FrmQLKhachHang
            // 
            AllowShowTitle = false;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1600, 965);
            Controls.Add(btnBoQua);
            Controls.Add(btnDanhSach);
            Controls.Add(btnTruoc);
            Controls.Add(btnSau);
            Controls.Add(txtCurrentPage);
            Controls.Add(btnTimKiem);
            Controls.Add(label6);
            Controls.Add(txtTimKiem);
            Controls.Add(label8);
            Controls.Add(txtId);
            Controls.Add(dtView);
            Controls.Add(btnXoa);
            Controls.Add(txtNap);
            Controls.Add(btnNap);
            Controls.Add(txtSodu);
            Controls.Add(txtSdt);
            Controls.Add(txtEmail);
            Controls.Add(txtHoten);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmQLKhachHang";
            Padding = new Padding(0);
            ShowTitle = false;
            Style = Sunny.UI.UIStyle.Custom;
            Text = "FrmQLKhachHang";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            ((System.ComponentModel.ISupportInitialize)dtView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Sunny.UI.UIButton btnNap;
        private Sunny.UI.UITextBox txtSodu;
        private Sunny.UI.UITextBox txtSdt;
        private Sunny.UI.UITextBox txtEmail;
        private Sunny.UI.UITextBox txtHoten;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Sunny.UI.UITextBox txtNap;
        private Sunny.UI.UIButton btnXoa;
        private Sunny.UI.UIDataGridView dtView;
        private Label txtId;
        private Label label8;
        private Sunny.UI.UIButton btnTimKiem;
        private Label label6;
        private Sunny.UI.UITextBox txtTimKiem;
        private Label txtCurrentPage;
        private Sunny.UI.UIButton btnSau;
        private Sunny.UI.UIButton btnTruoc;
        private Sunny.UI.UIButton btnDanhSach;
        private Sunny.UI.UIButton btnBoQua;
    }
}