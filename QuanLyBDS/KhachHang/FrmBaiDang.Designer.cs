namespace QuanLyBDS.KhachHang
{
    partial class FrmBaiDang
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtTieude = new Sunny.UI.UITextBox();
            cbLoainha = new Sunny.UI.UIComboBox();
            txtDientich = new Sunny.UI.UITextBox();
            txtSophong = new Sunny.UI.UITextBox();
            txtGia = new Sunny.UI.UITextBox();
            txtHinhanh = new Sunny.UI.UITextBox();
            btnUpload = new Sunny.UI.UIButton();
            btnInsert = new Sunny.UI.UIButton();
            uiLine1 = new Sunny.UI.UILine();
            picHinhAnh = new PictureBox();
            txtDiachi = new Sunny.UI.UITextBox();
            label7 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label9 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(129, 78);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Tiêu đề :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(121, 113);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 1;
            label2.Text = "Loại nhà :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(87, 148);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 2;
            label3.Text = "Diện tích (m²) :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(113, 183);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 3;
            label4.Text = "Số phòng :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(103, 218);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 4;
            label5.Text = "Giá (VND) :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(624, 155);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 5;
            label6.Text = "Hình ảnh :";
            // 
            // txtTieude
            // 
            txtTieude.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTieude.Location = new Point(203, 75);
            txtTieude.Margin = new Padding(4, 5, 4, 5);
            txtTieude.MinimumSize = new Size(1, 16);
            txtTieude.Name = "txtTieude";
            txtTieude.Padding = new Padding(5);
            txtTieude.ShowText = false;
            txtTieude.Size = new Size(203, 27);
            txtTieude.Style = Sunny.UI.UIStyle.Custom;
            txtTieude.TabIndex = 6;
            txtTieude.TextAlignment = ContentAlignment.MiddleLeft;
            txtTieude.Watermark = "Nhập tiêu đề bài đăng";
            // 
            // cbLoainha
            // 
            cbLoainha.DataSource = null;
            cbLoainha.FillColor = Color.White;
            cbLoainha.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbLoainha.Items.AddRange(new object[] { "Chung cư", "Căn hộ mini", "Nhà nguyên căn", "Biệt thự", "Văn phòng" });
            cbLoainha.Location = new Point(203, 110);
            cbLoainha.Margin = new Padding(4, 5, 4, 5);
            cbLoainha.MinimumSize = new Size(63, 0);
            cbLoainha.Name = "cbLoainha";
            cbLoainha.Padding = new Padding(0, 0, 30, 2);
            cbLoainha.Size = new Size(203, 27);
            cbLoainha.Style = Sunny.UI.UIStyle.Custom;
            cbLoainha.TabIndex = 7;
            cbLoainha.TextAlignment = ContentAlignment.MiddleLeft;
            cbLoainha.Watermark = "";
            // 
            // txtDientich
            // 
            txtDientich.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDientich.Location = new Point(203, 145);
            txtDientich.Margin = new Padding(4, 5, 4, 5);
            txtDientich.MinimumSize = new Size(1, 16);
            txtDientich.Name = "txtDientich";
            txtDientich.Padding = new Padding(5);
            txtDientich.ShowText = false;
            txtDientich.Size = new Size(203, 27);
            txtDientich.Style = Sunny.UI.UIStyle.Custom;
            txtDientich.TabIndex = 8;
            txtDientich.TextAlignment = ContentAlignment.MiddleLeft;
            txtDientich.Watermark = "Nhập diện tích";
            txtDientich.KeyPress += txtDientich_KeyPress;
            // 
            // txtSophong
            // 
            txtSophong.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSophong.Location = new Point(203, 180);
            txtSophong.Margin = new Padding(4, 5, 4, 5);
            txtSophong.MinimumSize = new Size(1, 16);
            txtSophong.Name = "txtSophong";
            txtSophong.Padding = new Padding(5);
            txtSophong.ShowText = false;
            txtSophong.Size = new Size(203, 27);
            txtSophong.Style = Sunny.UI.UIStyle.Custom;
            txtSophong.TabIndex = 9;
            txtSophong.TextAlignment = ContentAlignment.MiddleLeft;
            txtSophong.Watermark = "Nhập số phòng";
            txtSophong.KeyPress += txtSophong_KeyPress;
            // 
            // txtGia
            // 
            txtGia.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtGia.Location = new Point(203, 215);
            txtGia.Margin = new Padding(4, 5, 4, 5);
            txtGia.MinimumSize = new Size(1, 16);
            txtGia.Name = "txtGia";
            txtGia.Padding = new Padding(5);
            txtGia.ShowText = false;
            txtGia.Size = new Size(203, 27);
            txtGia.Style = Sunny.UI.UIStyle.Custom;
            txtGia.TabIndex = 10;
            txtGia.TextAlignment = ContentAlignment.MiddleLeft;
            txtGia.Watermark = "Nhập vào giá";
            txtGia.KeyPress += txtGia_KeyPress;
            // 
            // txtHinhanh
            // 
            txtHinhanh.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHinhanh.Location = new Point(624, 180);
            txtHinhanh.Margin = new Padding(4, 5, 4, 5);
            txtHinhanh.MinimumSize = new Size(1, 16);
            txtHinhanh.Multiline = true;
            txtHinhanh.Name = "txtHinhanh";
            txtHinhanh.Padding = new Padding(5);
            txtHinhanh.ShowText = false;
            txtHinhanh.Size = new Size(232, 55);
            txtHinhanh.Style = Sunny.UI.UIStyle.Custom;
            txtHinhanh.TabIndex = 14;
            txtHinhanh.TextAlignment = ContentAlignment.MiddleLeft;
            txtHinhanh.Watermark = "";
            // 
            // btnUpload
            // 
            btnUpload.FillColor = SystemColors.Highlight;
            btnUpload.FillHoverColor = Color.MidnightBlue;
            btnUpload.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpload.Location = new Point(863, 183);
            btnUpload.MinimumSize = new Size(1, 1);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(100, 35);
            btnUpload.Style = Sunny.UI.UIStyle.Custom;
            btnUpload.TabIndex = 15;
            btnUpload.Text = "Upload hình";
            btnUpload.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpload.Click += btnUpload_Click;
            // 
            // btnInsert
            // 
            btnInsert.FillColor = SystemColors.Highlight;
            btnInsert.FillHoverColor = Color.MidnightBlue;
            btnInsert.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsert.Location = new Point(863, 96);
            btnInsert.MinimumSize = new Size(1, 1);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(100, 35);
            btnInsert.Style = Sunny.UI.UIStyle.Custom;
            btnInsert.TabIndex = 16;
            btnInsert.Text = "Đăng bài";
            btnInsert.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsert.Click += btnInsert_Click;
            // 
            // uiLine1
            // 
            uiLine1.FillColor = SystemColors.ActiveCaption;
            uiLine1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLine1.LineColor = SystemColors.MenuHighlight;
            uiLine1.LineColor2 = Color.FromArgb(80, 160, 255);
            uiLine1.Location = new Point(349, 275);
            uiLine1.MinimumSize = new Size(1, 1);
            uiLine1.Name = "uiLine1";
            uiLine1.Size = new Size(360, 29);
            uiLine1.Style = Sunny.UI.UIStyle.Custom;
            uiLine1.TabIndex = 14;
            uiLine1.Text = "Hình ảnh";
            // 
            // picHinhAnh
            // 
            picHinhAnh.BorderStyle = BorderStyle.FixedSingle;
            picHinhAnh.Location = new Point(147, 310);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(765, 314);
            picHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
            picHinhAnh.TabIndex = 15;
            picHinhAnh.TabStop = false;
            // 
            // txtDiachi
            // 
            txtDiachi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiachi.Location = new Point(624, 96);
            txtDiachi.Margin = new Padding(4, 5, 4, 5);
            txtDiachi.MinimumSize = new Size(1, 16);
            txtDiachi.Multiline = true;
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Padding = new Padding(5);
            txtDiachi.ShowText = false;
            txtDiachi.Size = new Size(232, 54);
            txtDiachi.Style = Sunny.UI.UIStyle.Custom;
            txtDiachi.TabIndex = 13;
            txtDiachi.TextAlignment = ContentAlignment.MiddleLeft;
            txtDiachi.Watermark = "Nhập địa chỉ cụ thể";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(624, 71);
            label7.Name = "label7";
            label7.Size = new Size(162, 20);
            label7.TabIndex = 12;
            label7.Text = "Địa chỉ bất động sản :";
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(7, 7);
            label9.Name = "label9";
            label9.Size = new Size(101, 30);
            label9.TabIndex = 78;
            label9.Text = "Đăng bài";
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
            // FrmBaiDang
            // 
            AllowShowTitle = false;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1085, 670);
            Controls.Add(panel1);
            Controls.Add(txtDiachi);
            Controls.Add(label7);
            Controls.Add(picHinhAnh);
            Controls.Add(uiLine1);
            Controls.Add(btnInsert);
            Controls.Add(btnUpload);
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
            Name = "FrmBaiDang";
            Padding = new Padding(0);
            ShowTitle = false;
            Style = Sunny.UI.UIStyle.Custom;
            Text = "FrmBaiDang";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            Load += FrmBaiDang_Load;
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Sunny.UI.UITextBox txtTieude;
        private Sunny.UI.UIComboBox cbLoainha;
        private Sunny.UI.UITextBox txtDientich;
        private Sunny.UI.UITextBox txtSophong;
        private Sunny.UI.UITextBox txtGia;
        private Sunny.UI.UITextBox txtHinhanh;
        private Sunny.UI.UIButton btnUpload;
        private Sunny.UI.UIButton btnInsert;
        private Sunny.UI.UILine uiLine1;
        private PictureBox picHinhAnh;
        private Sunny.UI.UITextBox txtDiachi;
        private Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label9;
        private Panel panel1;
    }
}