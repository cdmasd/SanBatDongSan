namespace QuanLyBDS.NhanVien
{
    partial class FrmHotro
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
            txtChitiethotro = new Sunny.UI.UITextBox();
            txtSodt = new Sunny.UI.UITextBox();
            label3 = new Label();
            btnDahotro = new Sunny.UI.UIButton();
            txtHotro = new Sunny.UI.UITextBox();
            label2 = new Label();
            label1 = new Label();
            dtView = new Sunny.UI.UIDataGridView();
            label8 = new Label();
            txtId = new Label();
            btnTimKiem = new Sunny.UI.UIButton();
            label5 = new Label();
            txtTimKiem = new Sunny.UI.UITextBox();
            txtCurrentPage = new Label();
            btnTruoc = new Sunny.UI.UIButton();
            btnTrangSau = new Sunny.UI.UIButton();
            btnBoQua = new Sunny.UI.UIButton();
            btnDanhSach = new Sunny.UI.UIButton();
            label9 = new Label();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dtView).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtChitiethotro
            // 
            txtChitiethotro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtChitiethotro.Location = new Point(12, 156);
            txtChitiethotro.Margin = new Padding(4, 5, 4, 5);
            txtChitiethotro.MinimumSize = new Size(1, 16);
            txtChitiethotro.Multiline = true;
            txtChitiethotro.Name = "txtChitiethotro";
            txtChitiethotro.Padding = new Padding(5);
            txtChitiethotro.ShowText = false;
            txtChitiethotro.Size = new Size(763, 88);
            txtChitiethotro.Style = Sunny.UI.UIStyle.Custom;
            txtChitiethotro.TabIndex = 12;
            txtChitiethotro.TextAlignment = ContentAlignment.MiddleLeft;
            txtChitiethotro.Watermark = "";
            // 
            // txtSodt
            // 
            txtSodt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSodt.Location = new Point(553, 89);
            txtSodt.Margin = new Padding(4, 5, 4, 5);
            txtSodt.MinimumSize = new Size(1, 16);
            txtSodt.Name = "txtSodt";
            txtSodt.Padding = new Padding(5);
            txtSodt.ShowText = false;
            txtSodt.Size = new Size(222, 29);
            txtSodt.Style = Sunny.UI.UIStyle.Custom;
            txtSodt.TabIndex = 10;
            txtSodt.TextAlignment = ContentAlignment.MiddleLeft;
            txtSodt.Watermark = "";
            txtSodt.KeyPress += txtSodt_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(553, 60);
            label3.Name = "label3";
            label3.Size = new Size(205, 21);
            label3.TabIndex = 9;
            label3.Text = "Số điện thoại liên hệ hỗ trợ :";
            // 
            // btnDahotro
            // 
            btnDahotro.FillColor = SystemColors.Highlight;
            btnDahotro.FillHoverColor = Color.MidnightBlue;
            btnDahotro.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDahotro.Location = new Point(141, 30);
            btnDahotro.MinimumSize = new Size(1, 1);
            btnDahotro.Name = "btnDahotro";
            btnDahotro.Size = new Size(100, 35);
            btnDahotro.Style = Sunny.UI.UIStyle.Custom;
            btnDahotro.TabIndex = 11;
            btnDahotro.Text = "Đã hỗ trợ";
            btnDahotro.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDahotro.Click += btnDahotro_Click;
            // 
            // txtHotro
            // 
            txtHotro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHotro.Location = new Point(12, 89);
            txtHotro.Margin = new Padding(4, 5, 4, 5);
            txtHotro.MinimumSize = new Size(1, 16);
            txtHotro.Name = "txtHotro";
            txtHotro.Padding = new Padding(5);
            txtHotro.ShowText = false;
            txtHotro.Size = new Size(238, 29);
            txtHotro.Style = Sunny.UI.UIStyle.Custom;
            txtHotro.TabIndex = 8;
            txtHotro.TextAlignment = ContentAlignment.MiddleLeft;
            txtHotro.Watermark = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 128);
            label2.Name = "label2";
            label2.Size = new Size(252, 21);
            label2.TabIndex = 7;
            label2.Text = "Mô tả chi tiết về vấn đề cần hỗ trợ :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 60);
            label1.Name = "label1";
            label1.Size = new Size(140, 21);
            label1.TabIndex = 6;
            label1.Text = "Vấn đề cần hỗ trợ :";
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
            dtView.Location = new Point(12, 297);
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
            dtView.Size = new Size(1061, 308);
            dtView.Style = Sunny.UI.UIStyle.Custom;
            dtView.TabIndex = 54;
            dtView.Click += dtView_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(479, 441);
            label8.Name = "label8";
            label8.Size = new Size(126, 20);
            label8.TabIndex = 55;
            label8.Text = "Không có dữ liệu";
            label8.Visible = false;
            // 
            // txtId
            // 
            txtId.AutoSize = true;
            txtId.Location = new Point(340, 75);
            txtId.Name = "txtId";
            txtId.Size = new Size(55, 16);
            txtId.TabIndex = 56;
            txtId.Text = "label4";
            txtId.Visible = false;
            // 
            // btnTimKiem
            // 
            btnTimKiem.FillColor = SystemColors.Highlight;
            btnTimKiem.FillHoverColor = Color.MidnightBlue;
            btnTimKiem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimKiem.Location = new Point(690, 257);
            btnTimKiem.MinimumSize = new Size(1, 1);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(100, 35);
            btnTimKiem.Style = Sunny.UI.UIStyle.Custom;
            btnTimKiem.TabIndex = 64;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(282, 265);
            label5.Name = "label5";
            label5.Size = new Size(81, 21);
            label5.TabIndex = 63;
            label5.Text = "Tìm kiếm :";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(368, 261);
            txtTimKiem.Margin = new Padding(4, 5, 4, 5);
            txtTimKiem.MinimumSize = new Size(1, 16);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Padding = new Padding(5);
            txtTimKiem.ShowText = false;
            txtTimKiem.Size = new Size(308, 27);
            txtTimKiem.Style = Sunny.UI.UIStyle.Custom;
            txtTimKiem.TabIndex = 62;
            txtTimKiem.TextAlignment = ContentAlignment.MiddleLeft;
            txtTimKiem.Watermark = "Nhập Số Điện Thoại";
            txtTimKiem.KeyPress += txtTimKiem_KeyPress;
            // 
            // txtCurrentPage
            // 
            txtCurrentPage.AutoSize = true;
            txtCurrentPage.BackColor = SystemColors.ActiveCaption;
            txtCurrentPage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCurrentPage.Location = new Point(12, 625);
            txtCurrentPage.Name = "txtCurrentPage";
            txtCurrentPage.Size = new Size(52, 21);
            txtCurrentPage.TabIndex = 70;
            txtCurrentPage.Text = "label9";
            // 
            // btnTruoc
            // 
            btnTruoc.FillColor = SystemColors.Highlight;
            btnTruoc.FillHoverColor = Color.MidnightBlue;
            btnTruoc.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTruoc.Location = new Point(848, 623);
            btnTruoc.MinimumSize = new Size(1, 1);
            btnTruoc.Name = "btnTruoc";
            btnTruoc.Size = new Size(100, 35);
            btnTruoc.Style = Sunny.UI.UIStyle.Custom;
            btnTruoc.TabIndex = 71;
            btnTruoc.Text = "Trang Trước";
            btnTruoc.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnTruoc.Click += btnTruoc_Click;
            // 
            // btnTrangSau
            // 
            btnTrangSau.FillColor = SystemColors.Highlight;
            btnTrangSau.FillHoverColor = Color.MidnightBlue;
            btnTrangSau.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTrangSau.Location = new Point(973, 623);
            btnTrangSau.MinimumSize = new Size(1, 1);
            btnTrangSau.Name = "btnTrangSau";
            btnTrangSau.Size = new Size(100, 35);
            btnTrangSau.Style = Sunny.UI.UIStyle.Custom;
            btnTrangSau.TabIndex = 72;
            btnTrangSau.Text = "Trang Sau";
            btnTrangSau.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnTrangSau.Click += btnTrangSau_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.FillColor = SystemColors.Highlight;
            btnBoQua.FillHoverColor = Color.MidnightBlue;
            btnBoQua.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBoQua.Location = new Point(25, 30);
            btnBoQua.MinimumSize = new Size(1, 1);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(100, 35);
            btnBoQua.Style = Sunny.UI.UIStyle.Custom;
            btnBoQua.TabIndex = 73;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBoQua.Click += btnBoQua_Click;
            // 
            // btnDanhSach
            // 
            btnDanhSach.FillColor = SystemColors.Highlight;
            btnDanhSach.FillHoverColor = Color.MidnightBlue;
            btnDanhSach.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDanhSach.Location = new Point(84, 77);
            btnDanhSach.MinimumSize = new Size(1, 1);
            btnDanhSach.Name = "btnDanhSach";
            btnDanhSach.Size = new Size(100, 35);
            btnDanhSach.Style = Sunny.UI.UIStyle.Custom;
            btnDanhSach.TabIndex = 74;
            btnDanhSach.Text = "Làm mới";
            btnDanhSach.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDanhSach.Click += btnDanhSach_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(7, 7);
            label9.Name = "label9";
            label9.Size = new Size(198, 30);
            label9.TabIndex = 78;
            label9.Text = "Hỗ trợ khách hàng";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1085, 45);
            panel1.TabIndex = 80;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBoQua);
            groupBox1.Controls.Add(btnDahotro);
            groupBox1.Controls.Add(btnDanhSach);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(814, 119);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(259, 125);
            groupBox1.TabIndex = 81;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thao tác";
            // 
            // FrmHotro
            // 
            AllowShowTitle = false;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1085, 670);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(btnTrangSau);
            Controls.Add(btnTruoc);
            Controls.Add(txtCurrentPage);
            Controls.Add(btnTimKiem);
            Controls.Add(label5);
            Controls.Add(txtTimKiem);
            Controls.Add(txtId);
            Controls.Add(label8);
            Controls.Add(txtChitiethotro);
            Controls.Add(txtSodt);
            Controls.Add(label3);
            Controls.Add(txtHotro);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtView);
            Name = "FrmHotro";
            Padding = new Padding(0);
            ShowTitle = false;
            Style = Sunny.UI.UIStyle.Custom;
            Text = "FrmHotro";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            Load += FrmHotro_Load;
            ((System.ComponentModel.ISupportInitialize)dtView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Sunny.UI.UITextBox txtChitiethotro;
        private Sunny.UI.UITextBox txtSodt;
        private Label label3;
        private Sunny.UI.UIButton btnDahotro;
        private Sunny.UI.UITextBox txtHotro;
        private Label label2;
        private Label label1;
        private Sunny.UI.UIDataGridView dtView;
        private Label label8;
        private Label txtId;
        private Sunny.UI.UIButton btnTimKiem;
        private Label label5;
        private Sunny.UI.UITextBox txtTimKiem;
        private Label txtCurrentPage;
        private Sunny.UI.UIButton btnTruoc;
        private Sunny.UI.UIButton btnTrangSau;
        private Sunny.UI.UIButton btnBoQua;
        private Sunny.UI.UIButton btnDanhSach;
        private Label label9;
        private Panel panel1;
        private GroupBox groupBox1;
    }
}