﻿namespace QuanLyBDS.NhanVien
{
    partial class FrmDoimatkhau
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
            btnDoimatkhau = new Sunny.UI.UIButton();
            txtMatkhaumoi = new Sunny.UI.UITextBox();
            txtMatkhauhientai = new Sunny.UI.UITextBox();
            txtEmail = new Sunny.UI.UITextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtVerify = new Sunny.UI.UITextBox();
            label4 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnDoimatkhau
            // 
            btnDoimatkhau.FillColor = SystemColors.Highlight;
            btnDoimatkhau.FillHoverColor = Color.MidnightBlue;
            btnDoimatkhau.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDoimatkhau.Location = new Point(481, 482);
            btnDoimatkhau.MinimumSize = new Size(1, 1);
            btnDoimatkhau.Name = "btnDoimatkhau";
            btnDoimatkhau.Size = new Size(113, 35);
            btnDoimatkhau.Style = Sunny.UI.UIStyle.Custom;
            btnDoimatkhau.TabIndex = 13;
            btnDoimatkhau.Text = "Đổi mật khẩu";
            btnDoimatkhau.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDoimatkhau.Click += btnDoimatkhau_Click;
            // 
            // txtMatkhaumoi
            // 
            txtMatkhaumoi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatkhaumoi.Location = new Point(417, 365);
            txtMatkhaumoi.Margin = new Padding(4, 5, 4, 5);
            txtMatkhaumoi.MinimumSize = new Size(1, 16);
            txtMatkhaumoi.Name = "txtMatkhaumoi";
            txtMatkhaumoi.Padding = new Padding(5);
            txtMatkhaumoi.PasswordChar = '•';
            txtMatkhaumoi.ShowText = false;
            txtMatkhaumoi.Size = new Size(241, 29);
            txtMatkhaumoi.Style = Sunny.UI.UIStyle.Custom;
            txtMatkhaumoi.TabIndex = 12;
            txtMatkhaumoi.TextAlignment = ContentAlignment.MiddleLeft;
            txtMatkhaumoi.Watermark = "";
            // 
            // txtMatkhauhientai
            // 
            txtMatkhauhientai.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatkhauhientai.Location = new Point(417, 294);
            txtMatkhauhientai.Margin = new Padding(4, 5, 4, 5);
            txtMatkhauhientai.MinimumSize = new Size(1, 16);
            txtMatkhauhientai.Name = "txtMatkhauhientai";
            txtMatkhauhientai.Padding = new Padding(5);
            txtMatkhauhientai.PasswordChar = '•';
            txtMatkhauhientai.ShowText = false;
            txtMatkhauhientai.Size = new Size(241, 29);
            txtMatkhauhientai.Style = Sunny.UI.UIStyle.Custom;
            txtMatkhauhientai.TabIndex = 11;
            txtMatkhauhientai.TextAlignment = ContentAlignment.MiddleLeft;
            txtMatkhauhientai.Watermark = "";
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(417, 223);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.MinimumSize = new Size(1, 16);
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(5);
            txtEmail.ShowText = false;
            txtEmail.Size = new Size(241, 29);
            txtEmail.Style = Sunny.UI.UIStyle.Custom;
            txtEmail.TabIndex = 10;
            txtEmail.TextAlignment = ContentAlignment.MiddleLeft;
            txtEmail.Watermark = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(417, 334);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 9;
            label3.Text = "Mật khẩu mới";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(417, 263);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 8;
            label2.Text = "Mật khẩu hiện tại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(417, 192);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 7;
            label1.Text = "Email";
            // 
            // txtVerify
            // 
            txtVerify.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtVerify.Location = new Point(417, 436);
            txtVerify.Margin = new Padding(4, 5, 4, 5);
            txtVerify.MinimumSize = new Size(1, 16);
            txtVerify.Name = "txtVerify";
            txtVerify.Padding = new Padding(5);
            txtVerify.PasswordChar = '•';
            txtVerify.ShowText = false;
            txtVerify.Size = new Size(241, 29);
            txtVerify.Style = Sunny.UI.UIStyle.Custom;
            txtVerify.TabIndex = 14;
            txtVerify.TextAlignment = ContentAlignment.MiddleLeft;
            txtVerify.Watermark = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(417, 405);
            label4.Name = "label4";
            label4.Size = new Size(165, 20);
            label4.TabIndex = 13;
            label4.Text = "Nhập lại mật khẩu mới";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(7, 7);
            label9.Name = "label9";
            label9.Size = new Size(146, 30);
            label9.TabIndex = 78;
            label9.Text = "Đổi mật khẩu";
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
            // FrmDoimatkhau
            // 
            AllowShowTitle = false;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1085, 670);
            Controls.Add(panel1);
            Controls.Add(txtVerify);
            Controls.Add(label4);
            Controls.Add(btnDoimatkhau);
            Controls.Add(txtMatkhaumoi);
            Controls.Add(txtMatkhauhientai);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmDoimatkhau";
            Padding = new Padding(0);
            ShowTitle = false;
            Style = Sunny.UI.UIStyle.Custom;
            Text = "FrmDoimatkhau";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Sunny.UI.UIButton btnDoimatkhau;
        private Sunny.UI.UITextBox txtMatkhaumoi;
        private Sunny.UI.UITextBox txtMatkhauhientai;
        private Sunny.UI.UITextBox txtEmail;
        private Label label3;
        private Label label2;
        private Label label1;
        private Sunny.UI.UITextBox txtVerify;
        private Label label4;
        private Label label9;
        private Panel panel1;
    }
}