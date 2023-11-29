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
            txtLydo.Location = new Point(12, 12);
            txtLydo.Multiline = true;
            txtLydo.Name = "txtLydo";
            txtLydo.PlaceholderText = "Vui lòng nhập lí do từ chối";
            txtLydo.Size = new Size(500, 158);
            txtLydo.TabIndex = 0;
            // 
            // btSend
            // 
            btSend.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btSend.Location = new Point(383, 180);
            btSend.MinimumSize = new Size(1, 1);
            btSend.Name = "btSend";
            btSend.Size = new Size(129, 44);
            btSend.TabIndex = 1;
            btSend.Text = "Gửi từ chối";
            btSend.TipsFont = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btSend.Click += btSend_Click;
            // 
            // Lydo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 236);
            Controls.Add(btSend);
            Controls.Add(txtLydo);
            Name = "Lydo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lý do từ chối";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLydo;
        private Sunny.UI.UIButton btSend;
    }
}