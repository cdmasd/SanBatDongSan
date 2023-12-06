namespace QuanLyBDS.DangNhap
{
    partial class QuenMatKhau
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
            txtEmail = new TextBox();
            uiVerificationCode1 = new Sunny.UI.UIVerificationCode();
            btnResetCode = new Sunny.UI.UIButton();
            txtCode = new TextBox();
            label2 = new Label();
            btKhoiPhuc = new Sunny.UI.UIButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 63);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 0;
            label1.Text = "Email :";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(39, 93);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Nhập email khôi phục";
            txtEmail.Size = new Size(251, 29);
            txtEmail.TabIndex = 1;
            // 
            // uiVerificationCode1
            // 
            uiVerificationCode1.CodeLength = 6;
            uiVerificationCode1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiVerificationCode1.Location = new Point(39, 131);
            uiVerificationCode1.MinimumSize = new Size(1, 1);
            uiVerificationCode1.Name = "uiVerificationCode1";
            uiVerificationCode1.Size = new Size(135, 38);
            uiVerificationCode1.TabIndex = 2;
            uiVerificationCode1.Click += uiVerificationCode1_Click;
            // 
            // btnResetCode
            // 
            btnResetCode.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnResetCode.Location = new Point(188, 132);
            btnResetCode.MinimumSize = new Size(1, 1);
            btnResetCode.Name = "btnResetCode";
            btnResetCode.Size = new Size(100, 38);
            btnResetCode.TabIndex = 3;
            btnResetCode.Text = "Lấy mã khác";
            btnResetCode.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnResetCode.Click += btnResetCode_Click;
            // 
            // txtCode
            // 
            txtCode.BorderStyle = BorderStyle.FixedSingle;
            txtCode.Location = new Point(39, 208);
            txtCode.Name = "txtCode";
            txtCode.PlaceholderText = "Nhập mã xác minh";
            txtCode.Size = new Size(135, 29);
            txtCode.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 178);
            label2.Name = "label2";
            label2.Size = new Size(105, 21);
            label2.TabIndex = 4;
            label2.Text = "Mã xác minh :";
            // 
            // btKhoiPhuc
            // 
            btKhoiPhuc.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btKhoiPhuc.Location = new Point(190, 203);
            btKhoiPhuc.MinimumSize = new Size(1, 1);
            btKhoiPhuc.Name = "btKhoiPhuc";
            btKhoiPhuc.Size = new Size(100, 38);
            btKhoiPhuc.TabIndex = 6;
            btKhoiPhuc.Text = "Khôi phục";
            btKhoiPhuc.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btKhoiPhuc.Click += btKhoiPhuc_Click;
            // 
            // QuenMatKhau
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(338, 294);
            Controls.Add(btKhoiPhuc);
            Controls.Add(txtCode);
            Controls.Add(label2);
            Controls.Add(btnResetCode);
            Controls.Add(uiVerificationCode1);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "QuenMatKhau";
            Text = "Khôi phục mật khẩu";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private Sunny.UI.UIVerificationCode uiVerificationCode1;
        private Sunny.UI.UIButton btnResetCode;
        private TextBox txtCode;
        private Label label2;
        private Sunny.UI.UIButton btKhoiPhuc;
    }
}