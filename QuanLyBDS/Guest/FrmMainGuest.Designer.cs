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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
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
            btnTimkiem = new Sunny.UI.UIButton();
            btnXemanh = new Sunny.UI.UIButton();
            panel1 = new Panel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtView).BeginInit();
            panelGuest.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtView
            // 
            dtView.AllowUserToAddRows = false;
            dtView.AllowUserToDeleteRows = false;
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
            dtView.ColumnHeadersHeight = 32;
            dtView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
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
            dtView.Location = new Point(410, 383);
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
            dtView.Size = new Size(756, 400);
            dtView.Style = Sunny.UI.UIStyle.Custom;
            dtView.TabIndex = 45;
            // 
            // cbLoainha
            // 
            cbLoainha.Anchor = AnchorStyles.None;
            cbLoainha.DataSource = null;
            cbLoainha.FillColor = Color.White;
            cbLoainha.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbLoainha.Location = new Point(424, 274);
            cbLoainha.Margin = new Padding(4, 5, 4, 5);
            cbLoainha.MinimumSize = new Size(63, 0);
            cbLoainha.Name = "cbLoainha";
            cbLoainha.Padding = new Padding(0, 0, 30, 2);
            cbLoainha.Size = new Size(150, 29);
            cbLoainha.Style = Sunny.UI.UIStyle.Custom;
            cbLoainha.TabIndex = 46;
            cbLoainha.Text = "Loại Nhà";
            cbLoainha.TextAlignment = ContentAlignment.MiddleLeft;
            cbLoainha.Watermark = "";
            // 
            // cbDientich
            // 
            cbDientich.Anchor = AnchorStyles.None;
            cbDientich.DataSource = null;
            cbDientich.FillColor = Color.White;
            cbDientich.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbDientich.Location = new Point(675, 274);
            cbDientich.Margin = new Padding(4, 5, 4, 5);
            cbDientich.MinimumSize = new Size(63, 0);
            cbDientich.Name = "cbDientich";
            cbDientich.Padding = new Padding(0, 0, 30, 2);
            cbDientich.Size = new Size(150, 29);
            cbDientich.Style = Sunny.UI.UIStyle.Custom;
            cbDientich.TabIndex = 47;
            cbDientich.Text = "Diện tích";
            cbDientich.TextAlignment = ContentAlignment.MiddleLeft;
            cbDientich.Watermark = "";
            // 
            // cbSophong
            // 
            cbSophong.Anchor = AnchorStyles.None;
            cbSophong.DataSource = null;
            cbSophong.FillColor = Color.White;
            cbSophong.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbSophong.Location = new Point(926, 274);
            cbSophong.Margin = new Padding(4, 5, 4, 5);
            cbSophong.MinimumSize = new Size(63, 0);
            cbSophong.Name = "cbSophong";
            cbSophong.Padding = new Padding(0, 0, 30, 2);
            cbSophong.Size = new Size(150, 29);
            cbSophong.Style = Sunny.UI.UIStyle.Custom;
            cbSophong.TabIndex = 48;
            cbSophong.Text = "Số phòng";
            cbSophong.TextAlignment = ContentAlignment.MiddleLeft;
            cbSophong.Watermark = "";
            // 
            // cbGia
            // 
            cbGia.Anchor = AnchorStyles.None;
            cbGia.DataSource = null;
            cbGia.FillColor = Color.White;
            cbGia.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbGia.Location = new Point(675, 328);
            cbGia.Margin = new Padding(4, 5, 4, 5);
            cbGia.MinimumSize = new Size(63, 0);
            cbGia.Name = "cbGia";
            cbGia.Padding = new Padding(0, 0, 30, 2);
            cbGia.Size = new Size(150, 29);
            cbGia.Style = Sunny.UI.UIStyle.Custom;
            cbGia.TabIndex = 49;
            cbGia.Text = "Khoảng giá";
            cbGia.TextAlignment = ContentAlignment.MiddleLeft;
            cbGia.Watermark = "";
            // 
            // cbDiachi
            // 
            cbDiachi.Anchor = AnchorStyles.None;
            cbDiachi.DataSource = null;
            cbDiachi.FillColor = Color.White;
            cbDiachi.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbDiachi.Location = new Point(424, 328);
            cbDiachi.Margin = new Padding(4, 5, 4, 5);
            cbDiachi.MinimumSize = new Size(63, 0);
            cbDiachi.Name = "cbDiachi";
            cbDiachi.Padding = new Padding(0, 0, 30, 2);
            cbDiachi.Size = new Size(150, 29);
            cbDiachi.Style = Sunny.UI.UIStyle.Custom;
            cbDiachi.TabIndex = 50;
            cbDiachi.Text = "Địa chỉ";
            cbDiachi.TextAlignment = ContentAlignment.MiddleLeft;
            cbDiachi.Watermark = "";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Condensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1218, 404);
            label1.Name = "label1";
            label1.Size = new Size(132, 23);
            label1.TabIndex = 51;
            label1.Text = "Thông tin liên hệ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(11, 39);
            label2.Name = "label2";
            label2.Size = new Size(79, 19);
            label2.TabIndex = 0;
            label2.Text = "Họ và tên :";
            // 
            // txtHoten
            // 
            txtHoten.AutoSize = true;
            txtHoten.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHoten.Location = new Point(11, 64);
            txtHoten.Name = "txtHoten";
            txtHoten.Size = new Size(127, 19);
            txtHoten.TabIndex = 1;
            txtHoten.Text = "Bấm vào dataview";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(11, 111);
            label3.Name = "label3";
            label3.Size = new Size(53, 19);
            label3.TabIndex = 2;
            label3.Text = "Email :";
            // 
            // txtEmail
            // 
            txtEmail.AutoSize = true;
            txtEmail.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(11, 136);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(127, 19);
            txtEmail.TabIndex = 3;
            txtEmail.Text = "Bấm vào dataview";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(11, 183);
            label5.Name = "label5";
            label5.Size = new Size(102, 19);
            label5.TabIndex = 4;
            label5.Text = "Số điện thoại :";
            // 
            // txtSodt
            // 
            txtSodt.AutoSize = true;
            txtSodt.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSodt.Location = new Point(11, 208);
            txtSodt.Name = "txtSodt";
            txtSodt.Size = new Size(127, 19);
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
            panelGuest.Location = new Point(1183, 439);
            panelGuest.Name = "panelGuest";
            panelGuest.Size = new Size(203, 268);
            panelGuest.TabIndex = 52;
            panelGuest.Visible = false;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Anchor = AnchorStyles.None;
            btnTimkiem.BackColor = SystemColors.Highlight;
            btnTimkiem.FillColor = SystemColors.Highlight;
            btnTimkiem.FillHoverColor = Color.MidnightBlue;
            btnTimkiem.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimkiem.Location = new Point(948, 322);
            btnTimkiem.MinimumSize = new Size(1, 1);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(100, 35);
            btnTimkiem.Style = Sunny.UI.UIStyle.Custom;
            btnTimkiem.TabIndex = 53;
            btnTimkiem.Text = "Tìm kiếm";
            btnTimkiem.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // btnXemanh
            // 
            btnXemanh.Anchor = AnchorStyles.None;
            btnXemanh.BackColor = SystemColors.Highlight;
            btnXemanh.FillColor = SystemColors.Highlight;
            btnXemanh.FillHoverColor = Color.MidnightBlue;
            btnXemanh.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXemanh.Location = new Point(1237, 730);
            btnXemanh.MinimumSize = new Size(1, 1);
            btnXemanh.Name = "btnXemanh";
            btnXemanh.Size = new Size(100, 35);
            btnXemanh.Style = Sunny.UI.UIStyle.Custom;
            btnXemanh.TabIndex = 54;
            btnXemanh.Text = "Xem ảnh";
            btnXemanh.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnXemanh.Click += btnXemanh_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1800, 138);
            panel1.TabIndex = 55;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(261, 46);
            label4.Name = "label4";
            label4.Size = new Size(177, 31);
            label4.TabIndex = 0;
            label4.Text = "Khách Thăm";
            // 
            // FrmMainGuest
            // 
            AllowShowTitle = false;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1800, 965);
            Controls.Add(panel1);
            Controls.Add(btnXemanh);
            Controls.Add(btnTimkiem);
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
            ((System.ComponentModel.ISupportInitialize)dtView).EndInit();
            panelGuest.ResumeLayout(false);
            panelGuest.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Sunny.UI.UIButton btnTimkiem;
        private Sunny.UI.UIButton btnXemanh;
        private Panel panel1;
        private Label label4;
    }
}