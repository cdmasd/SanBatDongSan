namespace QuanLyBDS.Admin
{
    partial class FrmQLNhanVien
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
            uiLabel1 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel3 = new Sunny.UI.UILabel();
            uiLabel4 = new Sunny.UI.UILabel();
            uiLabel5 = new Sunny.UI.UILabel();
            txtHoten = new Sunny.UI.UITextBox();
            txtDiachi = new Sunny.UI.UITextBox();
            txtEmail = new Sunny.UI.UITextBox();
            txtSodienthoai = new Sunny.UI.UITextBox();
            DatetimePicker = new DateTimePicker();
            btnThem = new Sunny.UI.UIButton();
            btnSua = new Sunny.UI.UIButton();
            btnXoa = new Sunny.UI.UIButton();
            btnDanhsach = new Sunny.UI.UIButton();
            txtTimkiem = new Sunny.UI.UITextBox();
            btnTimkiem = new Sunny.UI.UIButton();
            dtView = new Sunny.UI.UIDataGridView();
            btnBoQua = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)dtView).BeginInit();
            SuspendLayout();
            // 
            // uiLabel1
            // 
            uiLabel1.Anchor = AnchorStyles.None;
            uiLabel1.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.Location = new Point(456, 100);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(100, 23);
            uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "Họ và tên :";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            uiLabel2.Anchor = AnchorStyles.None;
            uiLabel2.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel2.Location = new Point(456, 163);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(100, 23);
            uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            uiLabel2.TabIndex = 1;
            uiLabel2.Text = "Địa chỉ :";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            uiLabel3.Anchor = AnchorStyles.None;
            uiLabel3.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel3.Location = new Point(456, 228);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(100, 23);
            uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            uiLabel3.TabIndex = 2;
            uiLabel3.Text = "Email :";
            uiLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            uiLabel4.Anchor = AnchorStyles.None;
            uiLabel4.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel4.Location = new Point(867, 111);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(106, 23);
            uiLabel4.Style = Sunny.UI.UIStyle.Custom;
            uiLabel4.TabIndex = 3;
            uiLabel4.Text = "Số điện thoại :";
            uiLabel4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            uiLabel5.Anchor = AnchorStyles.None;
            uiLabel5.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel5.Location = new Point(867, 174);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new Size(106, 23);
            uiLabel5.Style = Sunny.UI.UIStyle.Custom;
            uiLabel5.TabIndex = 4;
            uiLabel5.Text = "Ngày vào làm :";
            uiLabel5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtHoten
            // 
            txtHoten.Anchor = AnchorStyles.None;
            txtHoten.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHoten.Location = new Point(456, 125);
            txtHoten.Margin = new Padding(4, 5, 4, 5);
            txtHoten.MinimumSize = new Size(1, 16);
            txtHoten.Name = "txtHoten";
            txtHoten.Padding = new Padding(5);
            txtHoten.ShowText = false;
            txtHoten.Size = new Size(261, 29);
            txtHoten.Style = Sunny.UI.UIStyle.Custom;
            txtHoten.TabIndex = 5;
            txtHoten.TextAlignment = ContentAlignment.MiddleLeft;
            txtHoten.Watermark = "";
            // 
            // txtDiachi
            // 
            txtDiachi.Anchor = AnchorStyles.None;
            txtDiachi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiachi.Location = new Point(456, 188);
            txtDiachi.Margin = new Padding(4, 5, 4, 5);
            txtDiachi.MinimumSize = new Size(1, 16);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Padding = new Padding(5);
            txtDiachi.ShowText = false;
            txtDiachi.Size = new Size(261, 29);
            txtDiachi.Style = Sunny.UI.UIStyle.Custom;
            txtDiachi.TabIndex = 6;
            txtDiachi.TextAlignment = ContentAlignment.MiddleLeft;
            txtDiachi.Watermark = "";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(456, 254);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.MinimumSize = new Size(1, 16);
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(5);
            txtEmail.ShowText = false;
            txtEmail.Size = new Size(261, 29);
            txtEmail.Style = Sunny.UI.UIStyle.Custom;
            txtEmail.TabIndex = 7;
            txtEmail.TextAlignment = ContentAlignment.MiddleLeft;
            txtEmail.Watermark = "";
            // 
            // txtSodienthoai
            // 
            txtSodienthoai.Anchor = AnchorStyles.None;
            txtSodienthoai.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSodienthoai.Location = new Point(867, 136);
            txtSodienthoai.Margin = new Padding(4, 5, 4, 5);
            txtSodienthoai.MinimumSize = new Size(1, 16);
            txtSodienthoai.Name = "txtSodienthoai";
            txtSodienthoai.Padding = new Padding(5);
            txtSodienthoai.ShowText = false;
            txtSodienthoai.Size = new Size(261, 29);
            txtSodienthoai.Style = Sunny.UI.UIStyle.Custom;
            txtSodienthoai.TabIndex = 6;
            txtSodienthoai.Text = "0";
            txtSodienthoai.TextAlignment = ContentAlignment.MiddleLeft;
            txtSodienthoai.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            txtSodienthoai.Watermark = "";
            // 
            // DatetimePicker
            // 
            DatetimePicker.Anchor = AnchorStyles.None;
            DatetimePicker.CalendarTitleBackColor = SystemColors.ControlText;
            DatetimePicker.CalendarTitleForeColor = SystemColors.ButtonHighlight;
            DatetimePicker.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DatetimePicker.Location = new Point(867, 200);
            DatetimePicker.Name = "DatetimePicker";
            DatetimePicker.Size = new Size(261, 27);
            DatetimePicker.TabIndex = 10;
            DatetimePicker.Value = new DateTime(2023, 11, 14, 0, 0, 0, 0);
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.BackColor = SystemColors.Highlight;
            btnThem.FillColor = SystemColors.Highlight;
            btnThem.FillHoverColor = Color.MidnightBlue;
            btnThem.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.Location = new Point(519, 323);
            btnThem.MinimumSize = new Size(1, 1);
            btnThem.Name = "btnThem";
            btnThem.RectColor = SystemColors.Highlight;
            btnThem.Size = new Size(74, 33);
            btnThem.Style = Sunny.UI.UIStyle.Custom;
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm";
            btnThem.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.None;
            btnSua.BackColor = SystemColors.Highlight;
            btnSua.FillColor = SystemColors.Highlight;
            btnSua.FillHoverColor = Color.MidnightBlue;
            btnSua.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSua.Location = new Point(659, 323);
            btnSua.MinimumSize = new Size(1, 1);
            btnSua.Name = "btnSua";
            btnSua.RectColor = SystemColors.Highlight;
            btnSua.Size = new Size(74, 33);
            btnSua.Style = Sunny.UI.UIStyle.Custom;
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.BackColor = SystemColors.Highlight;
            btnXoa.FillColor = SystemColors.Highlight;
            btnXoa.FillHoverColor = Color.MidnightBlue;
            btnXoa.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(797, 323);
            btnXoa.MinimumSize = new Size(1, 1);
            btnXoa.Name = "btnXoa";
            btnXoa.RectColor = SystemColors.Highlight;
            btnXoa.Size = new Size(74, 33);
            btnXoa.Style = Sunny.UI.UIStyle.Custom;
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Click += btnXoa_Click;
            // 
            // btnDanhsach
            // 
            btnDanhsach.Anchor = AnchorStyles.None;
            btnDanhsach.BackColor = SystemColors.Highlight;
            btnDanhsach.FillColor = SystemColors.Highlight;
            btnDanhsach.FillHoverColor = Color.MidnightBlue;
            btnDanhsach.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDanhsach.Location = new Point(928, 323);
            btnDanhsach.MinimumSize = new Size(1, 1);
            btnDanhsach.Name = "btnDanhsach";
            btnDanhsach.RectColor = SystemColors.Highlight;
            btnDanhsach.Size = new Size(74, 33);
            btnDanhsach.Style = Sunny.UI.UIStyle.Custom;
            btnDanhsach.TabIndex = 14;
            btnDanhsach.Text = "Danh sách";
            btnDanhsach.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDanhsach.Click += btnDanhsach_Click;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Anchor = AnchorStyles.None;
            txtTimkiem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimkiem.Location = new Point(594, 405);
            txtTimkiem.Margin = new Padding(4, 5, 4, 5);
            txtTimkiem.MinimumSize = new Size(1, 16);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Padding = new Padding(5);
            txtTimkiem.ShowText = false;
            txtTimkiem.Size = new Size(261, 29);
            txtTimkiem.Style = Sunny.UI.UIStyle.Custom;
            txtTimkiem.TabIndex = 15;
            txtTimkiem.TextAlignment = ContentAlignment.MiddleLeft;
            txtTimkiem.Watermark = "Nhập ID nhân viên cần tìm";
            // 
            // btnTimkiem
            // 
            btnTimkiem.Anchor = AnchorStyles.None;
            btnTimkiem.BackColor = SystemColors.Highlight;
            btnTimkiem.FillColor = SystemColors.Highlight;
            btnTimkiem.FillHoverColor = Color.MidnightBlue;
            btnTimkiem.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimkiem.Location = new Point(867, 405);
            btnTimkiem.MinimumSize = new Size(1, 1);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.RectColor = SystemColors.Highlight;
            btnTimkiem.Size = new Size(74, 33);
            btnTimkiem.Style = Sunny.UI.UIStyle.Custom;
            btnTimkiem.TabIndex = 16;
            btnTimkiem.Text = "Tìm kiếm";
            btnTimkiem.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // dtView
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 249, 255);
            dtView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtView.Anchor = AnchorStyles.None;
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
            dtView.Location = new Point(363, 450);
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
            dtView.Size = new Size(861, 334);
            dtView.Style = Sunny.UI.UIStyle.Custom;
            dtView.TabIndex = 17;
            dtView.CellClick += dtView_CellClick;
            // 
            // btnBoQua
            // 
            btnBoQua.Anchor = AnchorStyles.None;
            btnBoQua.BackColor = SystemColors.Highlight;
            btnBoQua.FillColor = SystemColors.Highlight;
            btnBoQua.FillHoverColor = Color.MidnightBlue;
            btnBoQua.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBoQua.Location = new Point(1054, 323);
            btnBoQua.MinimumSize = new Size(1, 1);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.RectColor = SystemColors.Highlight;
            btnBoQua.Size = new Size(74, 33);
            btnBoQua.Style = Sunny.UI.UIStyle.Custom;
            btnBoQua.TabIndex = 18;
            btnBoQua.Text = "Bỏ Qua";
            btnBoQua.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // FrmQLNhanVien
            // 
            AllowShowTitle = false;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1600, 965);
            Controls.Add(btnBoQua);
            Controls.Add(dtView);
            Controls.Add(btnTimkiem);
            Controls.Add(txtTimkiem);
            Controls.Add(btnDanhsach);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(DatetimePicker);
            Controls.Add(txtSodienthoai);
            Controls.Add(txtEmail);
            Controls.Add(txtDiachi);
            Controls.Add(txtHoten);
            Controls.Add(uiLabel5);
            Controls.Add(uiLabel4);
            Controls.Add(uiLabel3);
            Controls.Add(uiLabel2);
            Controls.Add(uiLabel1);
            Name = "FrmQLNhanVien";
            Padding = new Padding(0);
            ShowTitle = false;
            Style = Sunny.UI.UIStyle.Custom;
            Text = "FrmQLNhanVien";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            Load += FrmQLNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dtView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox txtHoten;
        private Sunny.UI.UITextBox txtDiachi;
        private Sunny.UI.UITextBox txtEmail;
        private Sunny.UI.UITextBox txtSodienthoai;
        private Sunny.UI.UIDatePicker uiDatePicker1;
        private Sunny.UI.UIDatetimePicker uiDatetimePicker1;
        private DateTimePicker DatetimePicker;
        private Sunny.UI.UIButton btnThem;
        private Sunny.UI.UIButton btnSua;
        private Sunny.UI.UIButton btnXoa;
        private Sunny.UI.UIButton btnDanhsach;
        private Sunny.UI.UITextBox txtTimkiem;
        private Sunny.UI.UIButton btnTimkiem;
        private Sunny.UI.UIDataGridView dtView;
        private Sunny.UI.UIButton btnBoQua;
    }
}