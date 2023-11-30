using DTO_QuanLyBDS;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBDS.Admin
{
    public partial class FrmThongKe : UIForm
    {

        private BUS_QuanLyBDS.Admin bus_Admin;

        public FrmThongKe()
        {
            InitializeComponent();
            bus_Admin = new BUS_QuanLyBDS.Admin();
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadBarChart(bus_Admin.ThongKeBaiDang());
            LoadPieChart(bus_Admin.ThongKeTop5());
            LoadBarChartDT(bus_Admin.ThongKeDoanhThu());
        }

        private void LoadData()
        {
            labelKhachHang.Text = bus_Admin.TongKhachHang().ToString();
            labelSoBaiDang.Text = bus_Admin.TongSoLuongBaiDang().ToString() + " Bài";
            labelTongGiaTri.Text = bus_Admin.TongGiaTriBDS().ToString() + " VND";
            labelDoanhThu.Text = bus_Admin.TongDoanhThu().ToString() + " VND";
        }

        private void LoadBarChart(List<ThongKeDTO> data)
        {
            UIBarOption option = new UIBarOption();
            option.Title = new UITitle();
            option.Title.Text = "Số Lượng Bài Đăng";
            option.Title.SubText = "Biểu Đồ cột";

            option.Legend = new UILegend();
            option.Legend.Orient = UIOrient.Horizontal;
            option.Legend.Top = UITopAlignment.Top;
            option.Legend.Left = UILeftAlignment.Left;
            option.Legend.AddData("Số Bài Đăng");

            var series = new UIBarSeries();

            foreach (var baiDang in data)
            {
                series.AddData(baiDang.Soluongbaidang);
            }

            series.DecimalPlaces = 1;
            option.Series.Add(series);

            foreach (var baiDang in data)
            {
                option.XAxis.Data.Add(baiDang.Thoigiandang.ToString("dd/MM/yyyy"));
            }

            option.ToolTip.Visible = true;
            option.YAxis.Scale = true;

            option.XAxis.AxisLabel.Angle = 45;//(0° ~ 90°)

            option.YAxis.Name = "Số Bài đăng";

            option.YAxis.AxisLabel.DecimalPlaces = 1;

            option.YAxisScaleLines.Add(new UIScaleLine() { Color = Color.Red, Name = "Giới Hạn Trên", Value = 12 });
            option.YAxisScaleLines.Add(new UIScaleLine() { Color = Color.Gold, Name = "Giới Hạn dưới", Value = -20 });

            option.ToolTip.AxisPointer.Type = UIAxisPointerType.Shadow;

            option.ShowValue = true;

            chartThongKeBaiDang.SetOption(option);
        }

        private void LoadPieChart(List<ThongKeDTO> data)
        {
            var option = new UIPieOption();

            option.Title = new UITitle();
            option.Title.Text = "Thống kê Loại Nhà";
            option.Title.SubText = "Số lượng bài đăng theo từng loại nhà";
            option.Title.Left = UILeftAlignment.Center;

            option.ToolTip.Visible = true;

            option.Legend = new UILegend();
            option.Legend.Orient = UIOrient.Vertical;
            option.Legend.Top = UITopAlignment.Top;
            option.Legend.Left = UILeftAlignment.Left;

            foreach (var bai in data)
            {
                option.Legend.AddData(bai.Loainha);
            }

            var series = new UIPieSeries();
            series.Name = "Loại Nhà";
            series.Center = new UICenter(50, 55);
            series.Radius = 70;
            series.Label.Show = true;

            foreach (var bai in data)
            {
                series.AddData(bai.Loainha, bai.Soluongbaidang);
            }

            option.Series.Clear();
            option.Series.Add(series);

            option.DecimalPlaces = 1;

            chartTop5.SetOption(option);
        }

        private void LoadBarChartDT(List<ThongKeDoanhThuDTO> data)
        {

            UIBarOption option = new UIBarOption();
            option.Title = new UITitle();
            option.Title.Text = "Doanh Thu";
            option.Title.SubText = "Biểu Đồ cột";

            option.Legend = new UILegend();
            option.Legend.Orient = UIOrient.Horizontal;
            option.Legend.Top = UITopAlignment.Top;
            option.Legend.Left = UILeftAlignment.Left;
            option.Legend.AddData("Doanh Thu");

            var series = new UIBarSeries();
            foreach (var log in data)
            {
                series.AddData(log.Tongtiennap);
            }

            series.DecimalPlaces = 1;
            option.Series.Add(series);

            foreach (var log in data)
            {
                option.XAxis.Data.Add(log.Ngaynap);
            }

            option.ToolTip.Visible = true;
            option.YAxis.Scale = true;

            option.XAxis.AxisLabel.Angle = 45;

            option.YAxis.Name = "Doanh Thu";

            option.YAxis.AxisLabel.DecimalPlaces = 1;

            option.ToolTip.AxisPointer.Type = UIAxisPointerType.Shadow;

            option.ShowValue = true;

            chartDoanhThu.SetOption(option);
        }

        private void btnTongQuat_Click(object sender, EventArgs e)
        {
            LoadData();
            LoadBarChart(bus_Admin.ThongKeBaiDang());
            LoadPieChart(bus_Admin.ThongKeTop5());
            LoadBarChartDT(bus_Admin.ThongKeDoanhThu());
        }

        private void btnTrongThang_Click(object sender, EventArgs e)
        {
            int soBaiDang = bus_Admin.ThongKeNgayTrongThang();
            int soKhachHang = bus_Admin.ThongKeKhachHangTrongThang();
            double giatriBDS = bus_Admin.ThongKeTongGiaTriBDS();
            double doanhThuTrongThang = bus_Admin.ThongKeDoanhThuTrongThang();
            labelSoBaiDang.Text = soBaiDang.ToString() + "Bài";
            labelKhachHang.Text = soKhachHang.ToString();
            labelDoanhThu.Text = doanhThuTrongThang.ToString() + " VND";
            labelTongGiaTri.Text = giatriBDS.ToString() + " VND";
            LoadBarChart(bus_Admin.ThongKeBaiDangTrongThangChart());
            LoadPieChart(bus_Admin.ThongKeLoaiNhaTrongThangChart());
            LoadBarChartDT(bus_Admin.ThongKeDoanThuTrongThang());
        }

        private void btnHomNay_Click(object sender, EventArgs e)
        {
            int soBaiDang = bus_Admin.SoBaiDangTheoNgay(DateTime.Now);
            int soKhachHang = bus_Admin.SoKhachHangTheoNgay(DateTime.Now);
            double giatriBDS = bus_Admin.TongGiaTriBDSTheoNgay(DateTime.Now);
            double doanhThu = bus_Admin.TongDoangThuTheoNgay(DateTime.Now);
            labelSoBaiDang.Text = soBaiDang.ToString() + " Bài";
            labelSoBaiDang.Text = soBaiDang.ToString() + "Bài";
            labelKhachHang.Text = soKhachHang.ToString();
            labelDoanhThu.Text = doanhThu.ToString() + " VND";
            labelTongGiaTri.Text = giatriBDS.ToString() + " VND";
            LoadBarChartTheoNgay(DateTime.Now, soBaiDang);
            LoadBarChartDTTheoNgay(DateTime.Now, doanhThu);
            LoadPieChart(bus_Admin.ThongKeLoaiNhaTheoNgay(DateTime.Now));
        }

        private void LoadBarChartTheoNgay(DateTime ngay, int soBaiDang)
        {
            int yesterdayPost = bus_Admin.SoBaiDangTheoNgay(ngay.AddDays(-1));
            UIBarOption option = new UIBarOption();
            option.Title = new UITitle();
            option.Title.Text = "Số Lượng Bài Đăng";
            option.Title.SubText = "Biểu Đồ cột";

            option.Legend = new UILegend();
            option.Legend.Orient = UIOrient.Horizontal;
            option.Legend.Top = UITopAlignment.Top;
            option.Legend.Left = UILeftAlignment.Left;
            option.Legend.AddData("Số Bài Đăng");

            var series = new UIBarSeries();
            series.AddData(yesterdayPost);
            series.AddData(soBaiDang);

            series.DecimalPlaces = 1;
            option.Series.Add(series);

            option.XAxis.Data.Add(ngay.AddDays(-1).ToString("dd/MM/yyyy"));
            option.XAxis.Data.Add(ngay.ToString("dd/MM/yyyy"));

            option.ToolTip.Visible = true;
            option.YAxis.Scale = true;

            option.XAxis.AxisLabel.Angle = 45;//(0° ~ 90°)

            option.YAxis.Name = "Số Bài đăng";

            option.YAxis.AxisLabel.DecimalPlaces = 1;

            option.ToolTip.AxisPointer.Type = UIAxisPointerType.Shadow;

            option.ShowValue = true;

            chartThongKeBaiDang.SetOption(option);
        }

        private void LoadBarChartDTTheoNgay(DateTime ngay, double doanhThu)
        {

            double doanhThuHomqua = bus_Admin.TongDoangThuTheoNgay(ngay.AddDays(-1));
            UIBarOption option = new UIBarOption();
            option.Title = new UITitle();
            option.Title.Text = "Doanh Thu";
            option.Title.SubText = "Biểu Đồ cột";

            option.Legend = new UILegend();
            option.Legend.Orient = UIOrient.Horizontal;
            option.Legend.Top = UITopAlignment.Top;
            option.Legend.Left = UILeftAlignment.Left;
            option.Legend.AddData("Doanh Thu");

            var series = new UIBarSeries();
            series.AddData(doanhThuHomqua);
            series.AddData(doanhThu);

            series.DecimalPlaces = 1;
            option.Series.Add(series);

            option.XAxis.Data.Add(ngay.AddDays(-1).ToString("dd/MM/yyyy"));
            option.XAxis.Data.Add(ngay.ToString("dd/MM/yyyy"));

            option.ToolTip.Visible = true;
            option.YAxis.Scale = true;

            option.XAxis.AxisLabel.Angle = 45;//(0° ~ 90°)

            option.YAxis.Name = "Doanh Thu";

            option.YAxis.AxisLabel.DecimalPlaces = 1;

            option.ToolTip.AxisPointer.Type = UIAxisPointerType.Shadow;

            option.ShowValue = true;

            chartDoanhThu.SetOption(option);
        }

        private void btnChonNgay_Click(object sender, EventArgs e)
        {
            int soBaiDang = bus_Admin.SoBaiDangTheoNgay(dateTimePicker.Value);
            int soKhachHang = bus_Admin.SoKhachHangTheoNgay(dateTimePicker.Value);
            double giatriBDS = bus_Admin.TongGiaTriBDSTheoNgay(dateTimePicker.Value);
            double doanhThu = bus_Admin.TongDoangThuTheoNgay(dateTimePicker.Value);
            labelSoBaiDang.Text = soBaiDang.ToString() + " Bài";
            labelSoBaiDang.Text = soBaiDang.ToString() + "Bài";
            labelKhachHang.Text = soKhachHang.ToString();
            labelDoanhThu.Text = doanhThu.ToString() + " VND";
            labelTongGiaTri.Text = giatriBDS.ToString() + " VND";
            LoadBarChartTheoNgay(dateTimePicker.Value, soBaiDang);
            LoadBarChartDTTheoNgay(dateTimePicker.Value, doanhThu);
            LoadPieChart(bus_Admin.ThongKeLoaiNhaTheoNgay(dateTimePicker.Value));
        }
    }
}