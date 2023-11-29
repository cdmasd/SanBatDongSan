namespace QuanLyBDS.Admin
{
    partial class FrmThongKe
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
            chartThongKeBaiDang = new Sunny.UI.UIBarChart();
            panel1 = new Panel();
            labelSoBaiDang = new Label();
            label2 = new Label();
            panel2 = new Panel();
            labelKhachHang = new Label();
            label3 = new Label();
            btnTrongThang = new Sunny.UI.UIButton();
            btnHomNay = new Sunny.UI.UIButton();
            panel3 = new Panel();
            labelTongGiaTri = new Label();
            label4 = new Label();
            btnTongQuat = new Sunny.UI.UIButton();
            panel5 = new Panel();
            labelDoanhThu = new Label();
            label5 = new Label();
            panel6 = new Panel();
            labelBaiDangDaDuyet = new Label();
            labelBaiDangChuaDuyet = new Label();
            label7 = new Label();
            label6 = new Label();
            labelMain = new Label();
            chartTop5 = new Sunny.UI.UIPieChart();
            dateTimePicker = new DateTimePicker();
            labelPicker = new Label();
            panel7 = new Panel();
            labelTicketChuaDuyet = new Label();
            labelTicketDaDuyet = new Label();
            label8 = new Label();
            label9 = new Label();
            chartDoanhThu = new Sunny.UI.UIBarChart();
            btnChonNgay = new Sunny.UI.UIButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // chartThongKeBaiDang
            // 
            chartThongKeBaiDang.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chartThongKeBaiDang.LegendFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chartThongKeBaiDang.Location = new Point(535, 249);
            chartThongKeBaiDang.MinimumSize = new Size(1, 1);
            chartThongKeBaiDang.Name = "chartThongKeBaiDang";
            chartThongKeBaiDang.Size = new Size(572, 386);
            chartThongKeBaiDang.Style = Sunny.UI.UIStyle.Custom;
            chartThongKeBaiDang.SubFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chartThongKeBaiDang.TabIndex = 0;
            chartThongKeBaiDang.Text = "uiBarChart1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Coral;
            panel1.Controls.Add(labelSoBaiDang);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(39, 109);
            panel1.Name = "panel1";
            panel1.Size = new Size(262, 134);
            panel1.TabIndex = 2;
            // 
            // labelSoBaiDang
            // 
            labelSoBaiDang.AutoSize = true;
            labelSoBaiDang.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelSoBaiDang.ForeColor = Color.White;
            labelSoBaiDang.Location = new Point(42, 58);
            labelSoBaiDang.Name = "labelSoBaiDang";
            labelSoBaiDang.Size = new Size(87, 23);
            labelSoBaiDang.TabIndex = 12;
            labelSoBaiDang.Text = "1000000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(15, 12);
            label2.Name = "label2";
            label2.Size = new Size(113, 18);
            label2.TabIndex = 11;
            label2.Text = "Số Bài Đăng";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Orange;
            panel2.Controls.Add(labelKhachHang);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(307, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(288, 134);
            panel2.TabIndex = 3;
            // 
            // labelKhachHang
            // 
            labelKhachHang.AutoSize = true;
            labelKhachHang.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelKhachHang.ForeColor = Color.White;
            labelKhachHang.Location = new Point(43, 58);
            labelKhachHang.Name = "labelKhachHang";
            labelKhachHang.Size = new Size(87, 23);
            labelKhachHang.TabIndex = 13;
            labelKhachHang.Text = "1000000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(17, 12);
            label3.Name = "label3";
            label3.Size = new Size(113, 18);
            label3.TabIndex = 12;
            label3.Text = "Khách Hàng";
            // 
            // btnTrongThang
            // 
            btnTrongThang.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTrongThang.Location = new Point(1113, 32);
            btnTrongThang.MinimumSize = new Size(1, 1);
            btnTrongThang.Name = "btnTrongThang";
            btnTrongThang.Size = new Size(136, 47);
            btnTrongThang.Style = Sunny.UI.UIStyle.Custom;
            btnTrongThang.TabIndex = 4;
            btnTrongThang.Text = "Tháng Này";
            btnTrongThang.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnTrongThang.Click += btnTrongThang_Click;
            // 
            // btnHomNay
            // 
            btnHomNay.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHomNay.Location = new Point(932, 32);
            btnHomNay.MinimumSize = new Size(1, 1);
            btnHomNay.Name = "btnHomNay";
            btnHomNay.Size = new Size(136, 47);
            btnHomNay.Style = Sunny.UI.UIStyle.Custom;
            btnHomNay.TabIndex = 5;
            btnHomNay.Text = "Hôm Nay";
            btnHomNay.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnHomNay.Click += btnHomNay_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Turquoise;
            panel3.Controls.Add(labelTongGiaTri);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(601, 109);
            panel3.Name = "panel3";
            panel3.Size = new Size(438, 134);
            panel3.TabIndex = 3;
            // 
            // labelTongGiaTri
            // 
            labelTongGiaTri.AutoSize = true;
            labelTongGiaTri.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelTongGiaTri.ForeColor = Color.White;
            labelTongGiaTri.Location = new Point(83, 58);
            labelTongGiaTri.Name = "labelTongGiaTri";
            labelTongGiaTri.Size = new Size(87, 23);
            labelTongGiaTri.TabIndex = 14;
            labelTongGiaTri.Text = "1000000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(14, 12);
            label4.Name = "label4";
            label4.Size = new Size(156, 18);
            label4.TabIndex = 13;
            label4.Text = "Tổng Trị Giá BDS";
            // 
            // btnTongQuat
            // 
            btnTongQuat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTongQuat.Location = new Point(1296, 32);
            btnTongQuat.MinimumSize = new Size(1, 1);
            btnTongQuat.Name = "btnTongQuat";
            btnTongQuat.Size = new Size(136, 47);
            btnTongQuat.Style = Sunny.UI.UIStyle.Custom;
            btnTongQuat.TabIndex = 8;
            btnTongQuat.Text = "Tổng Quát";
            btnTongQuat.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnTongQuat.Click += btnTongQuat_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.RosyBrown;
            panel5.Controls.Add(labelDoanhThu);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(1045, 109);
            panel5.Name = "panel5";
            panel5.Size = new Size(451, 134);
            panel5.TabIndex = 4;
            // 
            // labelDoanhThu
            // 
            labelDoanhThu.AutoSize = true;
            labelDoanhThu.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelDoanhThu.ForeColor = Color.White;
            labelDoanhThu.Location = new Point(34, 58);
            labelDoanhThu.Name = "labelDoanhThu";
            labelDoanhThu.Size = new Size(87, 23);
            labelDoanhThu.TabIndex = 15;
            labelDoanhThu.Text = "1000000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(17, 12);
            label5.Name = "label5";
            label5.Size = new Size(104, 18);
            label5.TabIndex = 14;
            label5.Text = "Doanh Thu";
            // 
            // panel6
            // 
            panel6.BackColor = Color.CornflowerBlue;
            panel6.Controls.Add(labelBaiDangDaDuyet);
            panel6.Controls.Add(labelBaiDangChuaDuyet);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(39, 641);
            panel6.Name = "panel6";
            panel6.Size = new Size(490, 220);
            panel6.TabIndex = 4;
            // 
            // labelBaiDangDaDuyet
            // 
            labelBaiDangDaDuyet.AutoSize = true;
            labelBaiDangDaDuyet.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelBaiDangDaDuyet.ForeColor = Color.White;
            labelBaiDangDaDuyet.Location = new Point(54, 159);
            labelBaiDangDaDuyet.Name = "labelBaiDangDaDuyet";
            labelBaiDangDaDuyet.Size = new Size(87, 23);
            labelBaiDangDaDuyet.TabIndex = 17;
            labelBaiDangDaDuyet.Text = "1000000";
            // 
            // labelBaiDangChuaDuyet
            // 
            labelBaiDangChuaDuyet.AutoSize = true;
            labelBaiDangChuaDuyet.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelBaiDangChuaDuyet.ForeColor = Color.White;
            labelBaiDangChuaDuyet.Location = new Point(54, 66);
            labelBaiDangChuaDuyet.Name = "labelBaiDangChuaDuyet";
            labelBaiDangChuaDuyet.Size = new Size(87, 23);
            labelBaiDangChuaDuyet.TabIndex = 15;
            labelBaiDangChuaDuyet.Text = "1000000";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(22, 116);
            label7.Name = "label7";
            label7.Size = new Size(232, 18);
            label7.TabIndex = 16;
            label7.Text = "Số Bài Đăng Chưa Duyệt :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(22, 24);
            label6.Name = "label6";
            label6.Size = new Size(210, 18);
            label6.TabIndex = 15;
            label6.Text = "Sô Bài Đăng Đã Duyệt :";
            // 
            // labelMain
            // 
            labelMain.AutoSize = true;
            labelMain.Font = new Font("Verdana", 28F, FontStyle.Bold, GraphicsUnit.Point);
            labelMain.ForeColor = Color.White;
            labelMain.Location = new Point(39, 21);
            labelMain.Name = "labelMain";
            labelMain.Size = new Size(220, 46);
            labelMain.TabIndex = 6;
            labelMain.Text = "Thống Kê";
            // 
            // chartTop5
            // 
            chartTop5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chartTop5.LegendFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chartTop5.Location = new Point(1113, 249);
            chartTop5.MinimumSize = new Size(1, 1);
            chartTop5.Name = "chartTop5";
            chartTop5.Size = new Size(383, 612);
            chartTop5.Style = Sunny.UI.UIStyle.Custom;
            chartTop5.SubFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chartTop5.TabIndex = 10;
            chartTop5.Text = "uiPieChart1";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(518, 43);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 26);
            dateTimePicker.TabIndex = 11;
            // 
            // labelPicker
            // 
            labelPicker.AutoSize = true;
            labelPicker.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelPicker.ForeColor = Color.White;
            labelPicker.Location = new Point(320, 49);
            labelPicker.Name = "labelPicker";
            labelPicker.Size = new Size(192, 18);
            labelPicker.TabIndex = 14;
            labelPicker.Text = "Chọn Ngày Cần Xem:";
            // 
            // panel7
            // 
            panel7.BackColor = Color.MediumSlateBlue;
            panel7.Controls.Add(labelTicketChuaDuyet);
            panel7.Controls.Add(labelTicketDaDuyet);
            panel7.Controls.Add(label8);
            panel7.Controls.Add(label9);
            panel7.Location = new Point(535, 641);
            panel7.Name = "panel7";
            panel7.Size = new Size(572, 220);
            panel7.TabIndex = 17;
            // 
            // labelTicketChuaDuyet
            // 
            labelTicketChuaDuyet.AutoSize = true;
            labelTicketChuaDuyet.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelTicketChuaDuyet.ForeColor = Color.White;
            labelTicketChuaDuyet.Location = new Point(50, 159);
            labelTicketChuaDuyet.Name = "labelTicketChuaDuyet";
            labelTicketChuaDuyet.Size = new Size(87, 23);
            labelTicketChuaDuyet.TabIndex = 19;
            labelTicketChuaDuyet.Text = "1000000";
            // 
            // labelTicketDaDuyet
            // 
            labelTicketDaDuyet.AutoSize = true;
            labelTicketDaDuyet.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelTicketDaDuyet.ForeColor = Color.White;
            labelTicketDaDuyet.Location = new Point(50, 66);
            labelTicketDaDuyet.Name = "labelTicketDaDuyet";
            labelTicketDaDuyet.Size = new Size(87, 23);
            labelTicketDaDuyet.TabIndex = 18;
            labelTicketDaDuyet.Text = "1000000";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(22, 116);
            label8.Name = "label8";
            label8.Size = new Size(215, 18);
            label8.TabIndex = 16;
            label8.Text = "Số Ticket Chưa Hỗ Trợ :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(22, 24);
            label9.Name = "label9";
            label9.Size = new Size(193, 18);
            label9.TabIndex = 15;
            label9.Text = "Sô Ticket Đã Hổ Trợ :";
            // 
            // chartDoanhThu
            // 
            chartDoanhThu.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chartDoanhThu.LegendFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chartDoanhThu.Location = new Point(39, 249);
            chartDoanhThu.MinimumSize = new Size(1, 1);
            chartDoanhThu.Name = "chartDoanhThu";
            chartDoanhThu.Size = new Size(490, 386);
            chartDoanhThu.Style = Sunny.UI.UIStyle.Custom;
            chartDoanhThu.SubFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chartDoanhThu.TabIndex = 18;
            chartDoanhThu.Text = "uiBarChart1";
            // 
            // btnChonNgay
            // 
            btnChonNgay.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnChonNgay.Location = new Point(749, 32);
            btnChonNgay.MinimumSize = new Size(1, 1);
            btnChonNgay.Name = "btnChonNgay";
            btnChonNgay.Size = new Size(136, 47);
            btnChonNgay.Style = Sunny.UI.UIStyle.Custom;
            btnChonNgay.TabIndex = 19;
            btnChonNgay.Text = "Chọn Ngày";
            btnChonNgay.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnChonNgay.Click += btnChonNgay_Click;
            // 
            // FrmThongKe
            // 
            AllowShowTitle = false;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1600, 965);
            Controls.Add(btnChonNgay);
            Controls.Add(chartDoanhThu);
            Controls.Add(panel7);
            Controls.Add(labelPicker);
            Controls.Add(dateTimePicker);
            Controls.Add(chartTop5);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(btnTongQuat);
            Controls.Add(panel3);
            Controls.Add(labelMain);
            Controls.Add(btnHomNay);
            Controls.Add(btnTrongThang);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(chartThongKeBaiDang);
            Name = "FrmThongKe";
            Padding = new Padding(0);
            ShowTitle = false;
            Style = Sunny.UI.UIStyle.Custom;
            Text = "FrmThongKe";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            Load += FrmThongKe_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Sunny.UI.UIBarChart chartThongKeBaiDang;
        private Panel panel1;
        private Panel panel2;
        private Sunny.UI.UIButton btnTrongThang;
        private Sunny.UI.UIButton btnHomNay;
        private Panel panel3;
        private Sunny.UI.UIButton btnTongQuat;
        private Panel panel5;
        private Panel panel6;
        private Label labelMain;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label labelSoBaiDang;
        private Label labelKhachHang;
        private Label labelTongGiaTri;
        private Label labelDoanhThu;
        private Sunny.UI.UIPieChart chartTop5;
        private DateTimePicker dateTimePicker;
        private Label labelPicker;
        private Label label6;
        private Label label7;
        private Panel panel7;
        private Label label8;
        private Label label9;
        private Sunny.UI.UIBarChart chartDoanhThu;
        private Label labelBaiDangDaDuyet;
        private Label labelBaiDangChuaDuyet;
        private Label labelTicketChuaDuyet;
        private Label labelTicketDaDuyet;
        private Sunny.UI.UIButton btnChonNgay;
    }
}