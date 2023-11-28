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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
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
            panel1 = new Panel();
            label4 = new Label();
            btnTimKiem = new Sunny.UI.UIButton();
            label5 = new Label();
            uiTextBox1 = new Sunny.UI.UITextBox();
            ((System.ComponentModel.ISupportInitialize)dtView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtChitiethotro
            // 
            txtChitiethotro.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtChitiethotro.Location = new Point(360, 319);
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
            txtSodt.Location = new Point(900, 252);
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
            label3.Location = new Point(900, 223);
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
            btnDahotro.Location = new Point(1023, 418);
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
            txtHotro.Location = new Point(360, 252);
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
            label2.Location = new Point(360, 291);
            label2.Name = "label2";
            label2.Size = new Size(238, 19);
            label2.TabIndex = 7;
            label2.Text = "Mô tả chi tiết về vấn đề cần hỗ trợ :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(360, 223);
            label1.Name = "label1";
            label1.Size = new Size(131, 19);
            label1.TabIndex = 6;
            label1.Text = "Vấn đề cần hỗ trợ :";
            // 
            // dtView
            // 
            dataGridViewCellStyle6.BackColor = Color.FromArgb(243, 249, 255);
            dtView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dtView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtView.BackgroundColor = Color.FromArgb(243, 249, 255);
            dtView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dtView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dtView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dtView.DefaultCellStyle = dataGridViewCellStyle8;
            dtView.EnableHeadersVisualStyles = false;
            dtView.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtView.GridColor = Color.FromArgb(104, 173, 255);
            dtView.Location = new Point(357, 532);
            dtView.MultiSelect = false;
            dtView.Name = "dtView";
            dtView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(243, 249, 255);
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dtView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dtView.RowsDefaultCellStyle = dataGridViewCellStyle10;
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
            label8.Location = new Point(680, 674);
            label8.Name = "label8";
            label8.Size = new Size(118, 19);
            label8.TabIndex = 55;
            label8.Text = "Không có dữ liệu";
            label8.Visible = false;
            // 
            // txtId
            // 
            txtId.AutoSize = true;
            txtId.Location = new Point(660, 252);
            txtId.Name = "txtId";
            txtId.Size = new Size(55, 16);
            txtId.TabIndex = 56;
            txtId.Text = "label4";
            txtId.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1600, 138);
            panel1.TabIndex = 57;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(261, 46);
            label4.Name = "label4";
            label4.Size = new Size(103, 31);
            label4.TabIndex = 0;
            label4.Text = "Hỗ Trợ";
            // 
            // btnTimKiem
            // 
            btnTimKiem.FillColor = SystemColors.Highlight;
            btnTimKiem.FillHoverColor = Color.MidnightBlue;
            btnTimKiem.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimKiem.Location = new Point(870, 465);
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
            label5.Location = new Point(583, 474);
            label5.Name = "label5";
            label5.Size = new Size(70, 19);
            label5.TabIndex = 63;
            label5.Text = "Tìm Kiếm";
            // 
            // uiTextBox1
            // 
            uiTextBox1.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTextBox1.Location = new Point(660, 469);
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
            Controls.Add(panel1);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private Label label4;
        private Sunny.UI.UIButton btnTimKiem;
        private Label label5;
        private Sunny.UI.UITextBox uiTextBox1;
    }
}