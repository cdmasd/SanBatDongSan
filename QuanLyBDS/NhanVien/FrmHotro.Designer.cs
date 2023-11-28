namespace QuanLyBDS.NhanVien
{
    partial class FrmHotro
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
            txtChitiethotro = new Sunny.UI.UITextBox();
            txtSodt = new Sunny.UI.UITextBox();
            label3 = new Label();
            btnDahotro = new Sunny.UI.UIButton();
            txtHotro = new Sunny.UI.UITextBox();
            label2 = new Label();
            label1 = new Label();
            dtView = new Sunny.UI.UIDataGridView();
            label8 = new Label();
            txtId = new Label();
            btnTimKiem = new Sunny.UI.UIButton();
            label5 = new Label();
            uiTextBox1 = new Sunny.UI.UITextBox();
            ((System.ComponentModel.ISupportInitialize)dtView).BeginInit();
            SuspendLayout();
            // 
            // txtChitiethotro
            // 
            txtChitiethotro.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtChitiethotro.Location = new Point(361, 201);
            txtChitiethotro.Margin = new Padding(4, 5, 4, 5);
            txtChitiethotro.MinimumSize = new Size(1, 16);
            txtChitiethotro.Multiline = true;
            txtChitiethotro.Name = "txtChitiethotro";
            txtChitiethotro.Padding = new Padding(5);
            txtChitiethotro.ShowText = false;
            txtChitiethotro.Size = new Size(763, 88);
            txtChitiethotro.Style = Sunny.UI.UIStyle.Custom;
            txtChitiethotro.TabIndex = 12;
            txtChitiethotro.TextAlignment = ContentAlignment.MiddleLeft;
            txtChitiethotro.Watermark = "";
            // 
            // txtSodt
            // 
            txtSodt.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSodt.Location = new Point(901, 134);
            txtSodt.Margin = new Padding(4, 5, 4, 5);
            txtSodt.MinimumSize = new Size(1, 16);
            txtSodt.Name = "txtSodt";
            txtSodt.Padding = new Padding(5);
            txtSodt.ShowText = false;
            txtSodt.Size = new Size(222, 29);
            txtSodt.Style = Sunny.UI.UIStyle.Custom;
            txtSodt.TabIndex = 10;
            txtSodt.TextAlignment = ContentAlignment.MiddleLeft;
            txtSodt.Watermark = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(901, 105);
            label3.Name = "label3";
            label3.Size = new Size(192, 19);
            label3.TabIndex = 9;
            label3.Text = "Số điện thoại liên hệ hỗ trợ :";
            // 
            // btnDahotro
            // 
            btnDahotro.FillColor = SystemColors.Highlight;
            btnDahotro.FillHoverColor = Color.MidnightBlue;
            btnDahotro.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDahotro.Location = new Point(1024, 300);
            btnDahotro.MinimumSize = new Size(1, 1);
            btnDahotro.Name = "btnDahotro";
            btnDahotro.Size = new Size(100, 35);
            btnDahotro.Style = Sunny.UI.UIStyle.Custom;
            btnDahotro.TabIndex = 11;
            btnDahotro.Text = "Đã hỗ trợ";
            btnDahotro.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDahotro.Click += btnDahotro_Click;
            // 
            // txtHotro
            // 
            txtHotro.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHotro.Location = new Point(361, 134);
            txtHotro.Margin = new Padding(4, 5, 4, 5);
            txtHotro.MinimumSize = new Size(1, 16);
            txtHotro.Name = "txtHotro";
            txtHotro.Padding = new Padding(5);
            txtHotro.ShowText = false;
            txtHotro.Size = new Size(238, 29);
            txtHotro.Style = Sunny.UI.UIStyle.Custom;
            txtHotro.TabIndex = 8;
            txtHotro.TextAlignment = ContentAlignment.MiddleLeft;
            txtHotro.Watermark = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(361, 173);
            label2.Name = "label2";
            label2.Size = new Size(238, 19);
            label2.TabIndex = 7;
            label2.Text = "Mô tả chi tiết về vấn đề cần hỗ trợ :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(361, 105);
            label1.Name = "label1";
            label1.Size = new Size(131, 19);
            label1.TabIndex = 6;
            label1.Text = "Vấn đề cần hỗ trợ :";
            // 
            // dtView
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 249, 255);
            dtView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            dtView.Location = new Point(358, 414);
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
            dtView.Size = new Size(765, 302);
            dtView.Style = Sunny.UI.UIStyle.Custom;
            dtView.TabIndex = 54;
            dtView.Click += dtView_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(681, 556);
            label8.Name = "label8";
            label8.Size = new Size(118, 19);
            label8.TabIndex = 55;
            label8.Text = "Không có dữ liệu";
            label8.Visible = false;
            // 
            // txtId
            // 
            txtId.AutoSize = true;
            txtId.Location = new Point(661, 134);
            txtId.Name = "txtId";
            txtId.Size = new Size(55, 16);
            txtId.TabIndex = 56;
            txtId.Text = "label4";
            txtId.Visible = false;
            // 
            // btnTimKiem
            // 
            btnTimKiem.FillColor = SystemColors.Highlight;
            btnTimKiem.FillHoverColor = Color.MidnightBlue;
            btnTimKiem.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimKiem.Location = new Point(871, 347);
            btnTimKiem.MinimumSize = new Size(1, 1);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(100, 35);
            btnTimKiem.Style = Sunny.UI.UIStyle.Custom;
            btnTimKiem.TabIndex = 64;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(584, 356);
            label5.Name = "label5";
            label5.Size = new Size(70, 19);
            label5.TabIndex = 63;
            label5.Text = "Tìm Kiếm";
            // 
            // uiTextBox1
            // 
            uiTextBox1.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTextBox1.Location = new Point(661, 351);
            uiTextBox1.Margin = new Padding(4, 5, 4, 5);
            uiTextBox1.MinimumSize = new Size(1, 16);
            uiTextBox1.Name = "uiTextBox1";
            uiTextBox1.Padding = new Padding(5);
            uiTextBox1.ShowText = false;
            uiTextBox1.Size = new Size(203, 27);
            uiTextBox1.Style = Sunny.UI.UIStyle.Custom;
            uiTextBox1.TabIndex = 62;
            uiTextBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox1.Watermark = "Nhập Số Điện Thoại";
            // 
            // FrmHotro
            // 
            AllowShowTitle = false;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1600, 965);
            Controls.Add(btnTimKiem);
            Controls.Add(label5);
            Controls.Add(uiTextBox1);
            Controls.Add(txtId);
            Controls.Add(label8);
            Controls.Add(dtView);
            Controls.Add(txtChitiethotro);
            Controls.Add(txtSodt);
            Controls.Add(label3);
            Controls.Add(btnDahotro);
            Controls.Add(txtHotro);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmHotro";
            Padding = new Padding(0);
            ShowTitle = false;
            Style = Sunny.UI.UIStyle.Custom;
            Text = "FrmHotro";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            Load += FrmHotro_Load;
            ((System.ComponentModel.ISupportInitialize)dtView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Sunny.UI.UITextBox txtChitiethotro;
        private Sunny.UI.UITextBox txtSodt;
        private Label label3;
        private Sunny.UI.UIButton btnDahotro;
        private Sunny.UI.UITextBox txtHotro;
        private Label label2;
        private Label label1;
        private Sunny.UI.UIDataGridView dtView;
        private Label label8;
        private Label txtId;
        private Sunny.UI.UIButton btnTimKiem;
        private Label label5;
        private Sunny.UI.UITextBox uiTextBox1;
    }
}