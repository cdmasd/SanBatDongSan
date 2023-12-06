namespace QuanLyBDS.KhachHang
{
    partial class FrmNapTien
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPhone = new TextBox();
            txtId = new TextBox();
            txtNap = new TextBox();
            btnTaoMa = new Button();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(80, 506);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 4;
            label4.Text = " Lưu ý : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(80, 614);
            label5.Name = "label5";
            label5.Size = new Size(758, 25);
            label5.TabIndex = 5;
            label5.Text = "- Mọi thắc mắc xin hãy liên hệ đến Hotline : 0937806350 hoặc tạo ticket để được hỗ trợ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(80, 552);
            label6.Name = "label6";
            label6.Size = new Size(775, 25);
            label6.TabIndex = 6;
            label6.Text = "- Để tránh mất tiền quý khách vui lòng kiểm tra kỹ các thông tin trước khi chuyển khoản";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(80, 583);
            label7.Name = "label7";
            label7.Size = new Size(409, 25);
            label7.TabIndex = 7;
            label7.Text = "- Số tiền chuyển khoản phải chia hết cho 1000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(152, 129);
            label1.Name = "label1";
            label1.Size = new Size(108, 21);
            label1.TabIndex = 8;
            label1.Text = "Số điện thoại :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(152, 213);
            label2.Name = "label2";
            label2.Size = new Size(32, 21);
            label2.TabIndex = 9;
            label2.Text = "ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(152, 291);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 10;
            label3.Text = "Tiền nạp :";
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Enabled = false;
            txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(154, 156);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Nhập vào email";
            txtPhone.Size = new Size(216, 29);
            txtPhone.TabIndex = 11;
            // 
            // txtId
            // 
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(152, 237);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "Nhập vào email";
            txtId.Size = new Size(216, 29);
            txtId.TabIndex = 12;
            // 
            // txtNap
            // 
            txtNap.BorderStyle = BorderStyle.FixedSingle;
            txtNap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNap.Location = new Point(154, 316);
            txtNap.Name = "txtNap";
            txtNap.PlaceholderText = "Nhập số tiền cần nạp";
            txtNap.Size = new Size(216, 29);
            txtNap.TabIndex = 13;
            // 
            // btnTaoMa
            // 
            btnTaoMa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTaoMa.Location = new Point(211, 366);
            btnTaoMa.Name = "btnTaoMa";
            btnTaoMa.Size = new Size(85, 39);
            btnTaoMa.TabIndex = 14;
            btnTaoMa.Text = "Tạo QR";
            btnTaoMa.UseVisualStyleBackColor = true;
            btnTaoMa.Click += btnTaoMa_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(536, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(505, 436);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(7, 7);
            label9.Name = "label9";
            label9.Size = new Size(98, 30);
            label9.TabIndex = 78;
            label9.Text = "Nạp tiền";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1085, 45);
            panel1.TabIndex = 82;
            // 
            // FrmNapTien
            // 
            AllowShowTitle = false;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1085, 670);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(btnTaoMa);
            Controls.Add(txtNap);
            Controls.Add(txtId);
            Controls.Add(txtPhone);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmNapTien";
            Padding = new Padding(0);
            ShowTitle = false;
            Style = Sunny.UI.UIStyle.Custom;
            Text = "FrmNapTien";
            ZoomScaleRect = new Rectangle(15, 15, 1584, 926);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPhone;
        private TextBox txtId;
        private TextBox txtNap;
        private Button btnTaoMa;
        private PictureBox pictureBox1;
        private Label label9;
        private Panel panel1;
    }
}