﻿namespace QuanLyBDS.KhachHang
{
    partial class FrmThongTin
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
            txtHoten = new Sunny.UI.UITextBox();
            txtEmail = new Sunny.UI.UITextBox();
            txtSdt = new Sunny.UI.UITextBox();
            txtSodu = new Sunny.UI.UITextBox();
            btnUpdate = new Sunny.UI.UIButton();
            label9 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(421, 163);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ tên :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(421, 234);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Email :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(421, 305);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 2;
            label3.Text = "Số điện thoại :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(421, 376);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 3;
            label4.Text = "Số dư :";
            // 
            // txtHoten
            // 
            txtHoten.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHoten.Location = new Point(421, 196);
            txtHoten.Margin = new Padding(4, 5, 4, 5);
            txtHoten.MinimumSize = new Size(1, 16);
            txtHoten.Name = "txtHoten";
            txtHoten.Padding = new Padding(5);
            txtHoten.ShowText = false;
            txtHoten.Size = new Size(203, 27);
            txtHoten.Style = Sunny.UI.UIStyle.Custom;
            txtHoten.TabIndex = 4;
            txtHoten.TextAlignment = ContentAlignment.MiddleLeft;
            txtHoten.Watermark = "";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(421, 267);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.MinimumSize = new Size(1, 16);
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(5);
            txtEmail.ShowText = false;
            txtEmail.Size = new Size(203, 27);
            txtEmail.Style = Sunny.UI.UIStyle.Custom;
            txtEmail.TabIndex = 5;
            txtEmail.TextAlignment = ContentAlignment.MiddleLeft;
            txtEmail.Watermark = "";
            // 
            // txtSdt
            // 
            txtSdt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSdt.Location = new Point(421, 338);
            txtSdt.Margin = new Padding(4, 5, 4, 5);
            txtSdt.MinimumSize = new Size(1, 16);
            txtSdt.Name = "txtSdt";
            txtSdt.Padding = new Padding(5);
            txtSdt.ShowText = false;
            txtSdt.Size = new Size(203, 27);
            txtSdt.Style = Sunny.UI.UIStyle.Custom;
            txtSdt.TabIndex = 5;
            txtSdt.TextAlignment = ContentAlignment.MiddleLeft;
            txtSdt.Watermark = "";
            txtSdt.KeyPress += txtSdt_KeyPress;
            // 
            // txtSodu
            // 
            txtSodu.Enabled = false;
            txtSodu.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSodu.Location = new Point(421, 409);
            txtSodu.Margin = new Padding(4, 5, 4, 5);
            txtSodu.MinimumSize = new Size(1, 16);
            txtSodu.Name = "txtSodu";
            txtSodu.Padding = new Padding(5);
            txtSodu.ShowText = false;
            txtSodu.Size = new Size(203, 27);
            txtSodu.Style = Sunny.UI.UIStyle.Custom;
            txtSodu.TabIndex = 5;
            txtSodu.TextAlignment = ContentAlignment.MiddleLeft;
            txtSodu.Watermark = "";
            // 
            // btnUpdate
            // 
            btnUpdate.FillColor = SystemColors.Highlight;
            btnUpdate.FillHoverColor = Color.MidnightBlue;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(470, 462);
            btnUpdate.MinimumSize = new Size(1, 1);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 35);
            btnUpdate.Style = Sunny.UI.UIStyle.Custom;
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(7, 7);
            label9.Name = "label9";
            label9.Size = new Size(231, 30);
            label9.TabIndex = 78;
            label9.Text = "Thông tin khách hàng";
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
            // FrmThongTin
            // 
            AllowShowTitle = false;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1085, 670);
            Controls.Add(panel1);
            Controls.Add(btnUpdate);
            Controls.Add(txtSodu);
            Controls.Add(txtSdt);
            Controls.Add(txtEmail);
            Controls.Add(txtHoten);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmThongTin";
            Padding = new Padding(0);
            ShowTitle = false;
            Style = Sunny.UI.UIStyle.Custom;
            Text = "FrmThongTin";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            Load += FrmThongTin_Load;
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
        private Sunny.UI.UITextBox txtHoten;
        private Sunny.UI.UITextBox txtEmail;
        private Sunny.UI.UITextBox txtSdt;
        private Sunny.UI.UITextBox txtSodu;
        private Sunny.UI.UIButton btnUpdate;
        private Label label9;
        private Panel panel1;
    }
}