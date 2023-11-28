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
            panel1 = new Panel();
            label5 = new Label();
            btnTimKiem = new Sunny.UI.UIButton();
            label6 = new Label();
            uiTextBox1 = new Sunny.UI.UITextBox();
            ((System.ComponentModel.ISupportInitialize)dtView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnNap
            // 
            btnNap.FillColor = SystemColors.Highlight;
            btnNap.FillHoverColor = Color.MidnightBlue;
            btnNap.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNap.Location = new Point(1059, 267);
            btnNap.MinimumSize = new Size(1, 1);
            btnNap.Name = "btnNap";
            btnNap.Size = new Size(85, 28);
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
            txtSodu.Location = new Point(735, 301);
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
            txtSdt.Location = new Point(735, 244);
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
            txtEmail.Location = new Point(456, 301);
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
            txtHoten.Location = new Point(456, 244);
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
            label4.Location = new Point(735, 277);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 21;
            label4.Text = "Số dư :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(735, 220);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 20;
            label3.Text = "Số điện thoại :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(456, 277);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 19;
            label2.Text = "Email :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(456, 220);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 18;
            label1.Text = "Họ tên :";
            // 
            // txtNap
            // 
            txtNap.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNap.Location = new Point(1034, 232);
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
            btnXoa.Location = new Point(1038, 301);
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
            dtView.Location = new Point(426, 437);
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
            dtView.Size = new Size(765, 398);
            dtView.Style = Sunny.UI.UIStyle.Custom;
            dtView.TabIndex = 28;
            // 
            // txtId
            // 
            txtId.AutoSize = true;
            txtId.Location = new Point(930, 210);
            txtId.Name = "txtId";
            txtId.Size = new Size(55, 16);
            txtId.TabIndex = 29;
            txtId.Text = "label5";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(749, 627);
            label8.Name = "label8";
            label8.Size = new Size(126, 20);
            label8.TabIndex = 56;
            label8.Text = "Không có dữ liệu";
            label8.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1600, 138);
            panel1.TabIndex = 57;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(261, 46);
            label5.Name = "label5";
            label5.Size = new Size(290, 31);
            label5.TabIndex = 0;
            label5.Text = "Quản Lý Khách Hàng";
            // 
            // btnTimKiem
            // 
            btnTimKiem.FillColor = SystemColors.Highlight;
            btnTimKiem.FillHoverColor = Color.MidnightBlue;
            btnTimKiem.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimKiem.Location = new Point(912, 380);
            btnTimKiem.MinimumSize = new Size(1, 1);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(100, 35);
            btnTimKiem.Style = Sunny.UI.UIStyle.Custom;
            btnTimKiem.TabIndex = 64;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(625, 389);
            label6.Name = "label6";
            label6.Size = new Size(70, 19);
            label6.TabIndex = 63;
            label6.Text = "Tìm Kiếm";
            // 
            // uiTextBox1
            // 
            uiTextBox1.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTextBox1.Location = new Point(702, 384);
            uiTextBox1.Margin = new Padding(4, 5, 4, 5);
            uiTextBox1.MinimumSize = new Size(1, 16);
            uiTextBox1.Name = "uiTextBox1";
            uiTextBox1.Padding = new Padding(5);
            uiTextBox1.ShowText = false;
            uiTextBox1.Size = new Size(203, 27);
            uiTextBox1.Style = Sunny.UI.UIStyle.Custom;
            uiTextBox1.TabIndex = 62;
            uiTextBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox1.Watermark = "Nhập Mã Khách Hàng";
            // 
            // FrmQLKhachHang
            // 
            AllowShowTitle = false;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1600, 965);
            Controls.Add(btnTimKiem);
            Controls.Add(label6);
            Controls.Add(uiTextBox1);
            Controls.Add(panel1);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private Label label5;
        private Sunny.UI.UIButton btnTimKiem;
        private Label label6;
        private Sunny.UI.UITextBox uiTextBox1;
    }
}