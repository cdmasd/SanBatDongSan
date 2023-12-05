namespace QuanLyBDS.NhanVien
{
    partial class Lydo
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
            txtLydo = new TextBox();
            btSend = new Sunny.UI.UIButton();
            SuspendLayout();
            // 
            // txtLydo
            // 
            txtLydo.BorderStyle = BorderStyle.FixedSingle;
            txtLydo.Location = new Point(10, 9);
            txtLydo.Margin = new Padding(3, 2, 3, 2);
            txtLydo.Multiline = true;
            txtLydo.Name = "txtLydo";
            txtLydo.PlaceholderText = "Vui lòng nhập lí do";
            txtLydo.Size = new Size(438, 119);
            txtLydo.TabIndex = 0;
            // 
            // btSend
            // 
            btSend.BackColor = SystemColors.MenuHighlight;
            btSend.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btSend.Location = new Point(335, 135);
            btSend.Margin = new Padding(3, 2, 3, 2);
            btSend.MinimumSize = new Size(1, 1);
            btSend.Name = "btSend";
            btSend.Size = new Size(113, 33);
            btSend.TabIndex = 1;
            btSend.Text = "Gửi kết quả";
            btSend.TipsFont = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btSend.Click += btSend_Click;
            // 
            // Lydo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 177);
            Controls.Add(btSend);
            Controls.Add(txtLydo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Lydo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lý do";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLydo;
        private Sunny.UI.UIButton btSend;
    }
}