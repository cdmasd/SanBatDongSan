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
            LoadBarChart();
            LoadPieChart();
            LoadBarChartDT();
        }

        private void LoadData()
        {
            labelKhachHang.Text = bus_Admin.TongKhachHang().ToString();
            labelSoBaiDang.Text = bus_Admin.TongSoLuongBaiDang().ToString() + " Bài";
            labelTongGiaTri.Text = bus_Admin.TongGiaTriBDS().ToString() + " VND";
            labelDoanhThu.Text = bus_Admin.TongDoanhThu().ToString() + " VND";
            labelTicketDaDuyet.Text = bus_Admin.TicketDaDuyet().ToString();
            labelTicketChuaDuyet.Text = bus_Admin.TicketChuaDuyet().ToString();
            labelBaiDangDaDuyet.Text = bus_Admin.BaiDangDaDuyet().ToString();
            labelBaiDangChuaDuyet.Text = bus_Admin.BaiDangChuaDuyet().ToString();
        }

        private void LoadBarChart()
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
            List<ThongKeDTO> thongKe = bus_Admin.ThongKeBaiDang();
            foreach (var baiDang in thongKe)
            {
                series.AddData(baiDang.Soluongbaidang);
            }

            series.DecimalPlaces = 1;
            option.Series.Add(series);

            foreach (var baiDang in thongKe)
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

        private void LoadPieChart()
        {
            var baiDang = bus_Admin.ThongKeTop5();
            var option = new UIPieOption();

            option.Title = new UITitle();
            option.Title.Text = "Top 5 Loại Nhà";
            option.Title.SubText = "Số lượng bài đăng";
            option.Title.Left = UILeftAlignment.Center;

            option.ToolTip.Visible = true;

            option.Legend = new UILegend();
            option.Legend.Orient = UIOrient.Vertical;
            option.Legend.Top = UITopAlignment.Top;
            option.Legend.Left = UILeftAlignment.Left;

            foreach (var bai in baiDang)
            {
                option.Legend.AddData(bai.Loainha);
            }

            var series = new UIPieSeries();
            series.Name = "Loại Nhà";
            series.Center = new UICenter(50, 55);
            series.Radius = 70;
            series.Label.Show = true;

            foreach (var bai in baiDang)
            {
                series.AddData(bai.Loainha, bai.Soluongbaidang);
            }

            option.Series.Clear();
            option.Series.Add(series);

            option.DecimalPlaces = 1;

            chartTop5.SetOption(option);
        }

        private void LoadBarChartDT()
        {
            var data = bus_Admin.ThongKeDoanhThu();

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
            LoadBarChart();
            LoadPieChart();
            LoadBarChartDT();
        }
    }
}
