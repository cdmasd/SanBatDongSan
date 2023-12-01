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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.MyQR1;
            pictureBox1.Location = new Point(425, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(427, 473);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(946, 269);
            label1.Name = "label1";
            label1.Size = new Size(337, 29);
            label1.TabIndex = 1;
            label1.Text = "2. Tên TK : NGUYEN NGOC CHIEN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(946, 210);
            label2.Name = "label2";
            label2.Size = new Size(234, 29);
            label2.TabIndex = 2;
            label2.Text = "1. Số TK : 0937806350";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(946, 328);
            label3.Name = "label3";
            label3.Size = new Size(560, 29);
            label3.TabIndex = 3;
            label3.Text = "3. Nội Dung Chuyển Khoản : <Mã Khách Hàng> + <Email>";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto Condensed", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(145, 611);
            label4.Name = "label4";
            label4.Size = new Size(99, 33);
            label4.TabIndex = 4;
            label4.Text = " Lưu ý : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto Condensed", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(145, 701);
            label5.Name = "label5";
            label5.Size = new Size(953, 33);
            label5.TabIndex = 5;
            label5.Text = "- mọi thắc mắc xin hãy liên hệ đến Hotline : 0937806350 hoặc tạo ticket để được hỗ trợ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Roboto Condensed", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(145, 657);
            label6.Name = "label6";
            label6.Size = new Size(947, 33);
            label6.TabIndex = 6;
            label6.Text = "- Để tránh mất tiền quý khách vui lòng kiểm tra kỹ các thông tin trước khi chuyển khoản";
            // 
            // FrmNapTien
            // 
            AllowShowTitle = false;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1584, 926);
            ControlBox = false;
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}