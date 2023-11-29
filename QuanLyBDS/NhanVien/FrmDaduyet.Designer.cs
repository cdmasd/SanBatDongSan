namespace QuanLyBDS.NhanVien
{
    partial class FrmDaduyet
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
            btnXem = new Sunny.UI.UIButton();
            dtView = new Sunny.UI.UIDataGridView();
            txtDiachi = new Sunny.UI.UITextBox();
            label7 = new Label();
            btnXoa = new Sunny.UI.UIButton();
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
            label8 = new Label();
            txtId = new Label();
            btnTimKiem = new Sunny.UI.UIButton();
            label10 = new Label();
            txtTimKiem = new Sunny.UI.UITextBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtView).BeginInit();
            SuspendLayout();
            // 
            // btnXem
            // 
            btnXem.Anchor = AnchorStyles.None;
            btnXem.BackColor = SystemColors.ActiveCaption;
            btnXem.FillColor = SystemColors.Highlight;
            btnXem.FillHoverColor = Color.MidnightBlue;
            btnXem.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnXem.Location = new Point(921, 208);
            btnXem.MinimumSize = new Size(1, 1);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(100, 35);
            btnXem.Style = Sunny.UI.UIStyle.Custom;
            btnXem.TabIndex = 54;
            btnXem.Text = "Xem ảnh";
            btnXem.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
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
            dtView.Location = new Point(60, 362);
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
            dtView.Size = new Size(1388, 345);
            dtView.Style = Sunny.UI.UIStyle.Custom;
            dtView.TabIndex = 53;
            dtView.Click += dtView_Click;
            // 
            // txtDiachi
            // 
            txtDiachi.Anchor = AnchorStyles.None;
            txtDiachi.Enabled = false;
            txtDiachi.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiachi.Location = new Point(929, 107);
            txtDiachi.Margin = new Padding(4, 5, 4, 5);
            txtDiachi.MinimumSize = new Size(1, 16);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Padding = new Padding(5);
            txtDiachi.ShowText = false;
            txtDiachi.Size = new Size(203, 34);
            txtDiachi.Style = Sunny.UI.UIStyle.Custom;
            txtDiachi.TabIndex = 49;
            txtDiachi.TextAlignment = ContentAlignment.MiddleLeft;
            txtDiachi.Watermark = "";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(925, 81);
            label7.Name = "label7";
            label7.Size = new Size(275, 31);
            label7.TabIndex = 48;
            label7.Text = "Địa chỉ bất động sản :";
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.BackColor = SystemColors.ActiveCaption;
            btnXoa.FillColor = SystemColors.Highlight;
            btnXoa.FillHoverColor = Color.MidnightBlue;
            btnXoa.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(1038, 209);
            btnXoa.MinimumSize = new Size(1, 1);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 35);
            btnXoa.Style = Sunny.UI.UIStyle.Custom;
            btnXoa.TabIndex = 52;
            btnXoa.Text = "Xoá bài";
            btnXoa.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Click += btnXoa_Click;
            // 
            // txtHinhanh
            // 
            txtHinhanh.Anchor = AnchorStyles.None;
            txtHinhanh.Enabled = false;
            txtHinhanh.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtHinhanh.Location = new Point(929, 167);
            txtHinhanh.Margin = new Padding(4, 5, 4, 5);
            txtHinhanh.MinimumSize = new Size(1, 16);
            txtHinhanh.Name = "txtHinhanh";
            txtHinhanh.Padding = new Padding(5);
            txtHinhanh.ShowText = false;
            txtHinhanh.Size = new Size(203, 34);
            txtHinhanh.Style = Sunny.UI.UIStyle.Custom;
            txtHinhanh.TabIndex = 50;
            txtHinhanh.TextAlignment = ContentAlignment.MiddleLeft;
            txtHinhanh.Watermark = "";
            // 
            // txtGia
            // 
            txtGia.Anchor = AnchorStyles.None;
            txtGia.Enabled = false;
            txtGia.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtGia.Location = new Point(539, 220);
            txtGia.Margin = new Padding(4, 5, 4, 5);
            txtGia.MinimumSize = new Size(1, 16);
            txtGia.Name = "txtGia";
            txtGia.Padding = new Padding(5);
            txtGia.ShowText = false;
            txtGia.Size = new Size(203, 34);
            txtGia.Style = Sunny.UI.UIStyle.Custom;
            txtGia.TabIndex = 47;
            txtGia.TextAlignment = ContentAlignment.MiddleLeft;
            txtGia.Watermark = "";
            // 
            // txtSophong
            // 
            txtSophong.Anchor = AnchorStyles.None;
            txtSophong.Enabled = false;
            txtSophong.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSophong.Location = new Point(539, 185);
            txtSophong.Margin = new Padding(4, 5, 4, 5);
            txtSophong.MinimumSize = new Size(1, 16);
            txtSophong.Name = "txtSophong";
            txtSophong.Padding = new Padding(5);
            txtSophong.ShowText = false;
            txtSophong.Size = new Size(203, 34);
            txtSophong.Style = Sunny.UI.UIStyle.Custom;
            txtSophong.TabIndex = 46;
            txtSophong.TextAlignment = ContentAlignment.MiddleLeft;
            txtSophong.Watermark = "";
            // 
            // txtDientich
            // 
            txtDientich.Anchor = AnchorStyles.None;
            txtDientich.Enabled = false;
            txtDientich.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDientich.Location = new Point(539, 150);
            txtDientich.Margin = new Padding(4, 5, 4, 5);
            txtDientich.MinimumSize = new Size(1, 16);
            txtDientich.Name = "txtDientich";
            txtDientich.Padding = new Padding(5);
            txtDientich.ShowText = false;
            txtDientich.Size = new Size(203, 34);
            txtDientich.Style = Sunny.UI.UIStyle.Custom;
            txtDientich.TabIndex = 45;
            txtDientich.TextAlignment = ContentAlignment.MiddleLeft;
            txtDientich.Watermark = "";
            // 
            // cbLoainha
            // 
            cbLoainha.Anchor = AnchorStyles.None;
            cbLoainha.DataSource = null;
            cbLoainha.Enabled = false;
            cbLoainha.FillColor = Color.White;
            cbLoainha.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbLoainha.Location = new Point(539, 115);
            cbLoainha.Margin = new Padding(4, 5, 4, 5);
            cbLoainha.MinimumSize = new Size(63, 0);
            cbLoainha.Name = "cbLoainha";
            cbLoainha.Padding = new Padding(0, 0, 30, 2);
            cbLoainha.Size = new Size(203, 34);
            cbLoainha.Style = Sunny.UI.UIStyle.Custom;
            cbLoainha.TabIndex = 44;
            cbLoainha.TextAlignment = ContentAlignment.MiddleLeft;
            cbLoainha.Watermark = "";
            // 
            // txtTieude
            // 
            txtTieude.Anchor = AnchorStyles.None;
            txtTieude.Enabled = false;
            txtTieude.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTieude.Location = new Point(539, 80);
            txtTieude.Margin = new Padding(4, 5, 4, 5);
            txtTieude.MinimumSize = new Size(1, 16);
            txtTieude.Name = "txtTieude";
            txtTieude.Padding = new Padding(5);
            txtTieude.ShowText = false;
            txtTieude.Size = new Size(203, 34);
            txtTieude.Style = Sunny.UI.UIStyle.Custom;
            txtTieude.TabIndex = 43;
            txtTieude.TextAlignment = ContentAlignment.MiddleLeft;
            txtTieude.Watermark = "";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(925, 141);
            label6.Name = "label6";
            label6.Size = new Size(137, 31);
            label6.TabIndex = 42;
            label6.Text = "Hình ảnh :";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(471, 220);
            label5.Name = "label5";
            label5.Size = new Size(71, 31);
            label5.TabIndex = 41;
            label5.Text = "Giá :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(424, 186);
            label4.Name = "label4";
            label4.Size = new Size(144, 31);
            label4.TabIndex = 40;
            label4.Text = "Số phòng :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(427, 151);
            label3.Name = "label3";
            label3.Size = new Size(135, 31);
            label3.TabIndex = 39;
            label3.Text = "Diện tích :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(428, 116);
            label2.Name = "label2";
            label2.Size = new Size(132, 31);
            label2.TabIndex = 38;
            label2.Text = "Loại nhà :";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(436, 81);
            label1.Name = "label1";
            label1.Size = new Size(119, 31);
            label1.TabIndex = 37;
            label1.Text = "Tiêu đề :";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(671, 668);
            label8.Name = "label8";
            label8.Size = new Size(214, 31);
            label8.TabIndex = 56;
            label8.Text = "Không có dữ liệu";
            label8.Visible = false;
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.None;
            txtId.AutoSize = true;
            txtId.Location = new Point(167, 186);
            txtId.Name = "txtId";
            txtId.Size = new Size(69, 20);
            txtId.TabIndex = 57;
            txtId.Text = "label8";
            txtId.Visible = false;
            // 
            // btnTimKiem
            // 
            btnTimKiem.FillColor = SystemColors.Highlight;
            btnTimKiem.FillHoverColor = Color.MidnightBlue;
            btnTimKiem.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimKiem.Location = new Point(905, 299);
            btnTimKiem.MinimumSize = new Size(1, 1);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(100, 35);
            btnTimKiem.Style = Sunny.UI.UIStyle.Custom;
            btnTimKiem.TabIndex = 64;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(583, 305);
            label10.Name = "label10";
            label10.Size = new Size(127, 31);
            label10.TabIndex = 63;
            label10.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(695, 303);
            txtTimKiem.Margin = new Padding(4, 5, 4, 5);
            txtTimKiem.MinimumSize = new Size(1, 16);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Padding = new Padding(5);
            txtTimKiem.ShowText = false;
            txtTimKiem.Size = new Size(203, 34);
            txtTimKiem.Style = Sunny.UI.UIStyle.Custom;
            txtTimKiem.TabIndex = 62;
            txtTimKiem.TextAlignment = ContentAlignment.MiddleLeft;
            txtTimKiem.Watermark = "Nhập Mã Bài Đăng";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(224, 272);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 65;
            // 
            // FrmDaduyet
            // 
            AllowShowTitle = false;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1600, 965);
            Controls.Add(label9);
            Controls.Add(btnTimKiem);
            Controls.Add(label10);
            Controls.Add(txtTimKiem);
            Controls.Add(txtId);
            Controls.Add(label8);
            Controls.Add(btnXem);
            Controls.Add(dtView);
            Controls.Add(txtDiachi);
            Controls.Add(label7);
            Controls.Add(btnXoa);
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
            Name = "FrmDaduyet";
            Padding = new Padding(0);
            ShowTitle = false;
            Style = Sunny.UI.UIStyle.Custom;
            Text = "FrmDaduyet";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            Load += FrmDaduyet_Load;
            ((System.ComponentModel.ISupportInitialize)dtView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Sunny.UI.UIButton btnXem;
        private Sunny.UI.UIDataGridView dtView;
        private Sunny.UI.UITextBox txtDiachi;
        private Label label7;
        private Sunny.UI.UIButton btnXoa;
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
        private Label label8;
        private Label txtId;
        private Sunny.UI.UIButton btnTimKiem;
        private Label label10;
        private Sunny.UI.UITextBox txtTimKiem;
        private Label label9;
    }
}