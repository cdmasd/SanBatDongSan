using DTO_QuanLyBDS;
using OfficeOpenXml;
using OfficeOpenXml.Style;
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
        private int Status = 1;
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
            Status = 1;
            LoadData();
            LoadBarChart(bus_Admin.ThongKeBaiDang());
            LoadPieChart(bus_Admin.ThongKeTop5());
            LoadBarChartDT(bus_Admin.ThongKeDoanhThu());
        }

        private void btnTrongThang_Click(object sender, EventArgs e)
        {
            Status = 2;
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
            Status = 3;
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
            Status = 4;
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

        private void btnXuatFileExcel_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xlsx;*.xls|All Files|*.*";
                openFileDialog.Title = "Select Excel File";

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files|*.xlsx;*.xls|All Files|*.*";
                    saveFileDialog.Title = "Save Excel File";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Lấy đường dẫn tệp để lưu
                        string filePath = saveFileDialog.FileName;

                        // Gọi hàm để xử lý xuất dữ liệu Excel với đường dẫn tệp đã chọn
                        if (ExportToExcel(filePath))
                        {
                            MessageBox.Show("Xuất file thành công !!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Xuất file không thành công !!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private bool ExportToExcel(string filepath)
        {
            try
            {
                FileInfo excelFile = new FileInfo(filepath);
                List<ThongKeDTO> dataList = bus_Admin.ThongKeBaiDangTrongThangChart();

                if (Status == 1)
                {
                    using (ExcelPackage package = new ExcelPackage(excelFile))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add($"{DateTime.Now.Year}");

                        // Thiết kế tên cột
                        string[] columnHeaders1 = { "Số bài đăng", "Khách hàng", "Tổng giá trị BDS", "Doanh thu" };
                        string[] columnHeaders2 = { "Ngày", "Số bài đăng" };
                        string[] columnHeaders3 = { "Ngày", "Doanh Thu" };
                        string[] columnHeaders4 = { "Loại nhà", "Số lượt đăng" };

                        int row = 2; // Bắt đầu từ dòng 2 để bỏ qua dòng "Thống kê"

                        // Thiết kế tên cột "Thống kê"
                        ExcelRange titleRange1 = worksheet.Cells["A1:H1"];
                        titleRange1.Merge = true;
                        titleRange1.Value = "Thống kê Tổng quát";
                        titleRange1.Style.Font.Size = 28;
                        titleRange1.Style.Font.Bold = true;
                        titleRange1.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        titleRange1.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(173, 216, 230)); // Màu vàng nhạt
                        titleRange1.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; // Căn giữa ngang
                        titleRange1.Style.VerticalAlignment = ExcelVerticalAlignment.Center; // Căn giữa dọc
                        titleRange1.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                        titleRange1.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        titleRange1.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                        titleRange1.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                        row++;


                        // Ghi tên cột "Thống kê"
                        for (int i = 0; i < columnHeaders1.Length; i++)
                        {
                            worksheet.Cells[row, i + 1].Value = columnHeaders1[i];
                            worksheet.Cells[row, i + 1].Style.Font.Bold = true;
                        }
                        worksheet.Cells.AutoFitColumns();
                        row++;

                        worksheet.Cells[$"A{row}"].Value = bus_Admin.TongSoLuongBaiDang();
                        worksheet.Cells[$"B{row}"].Value = bus_Admin.TongKhachHang();
                        worksheet.Cells[$"C{row}"].Value = bus_Admin.TongGiaTriBDS();
                        worksheet.Cells[$"D{row}"].Value = bus_Admin.TongDoanhThu();
                        worksheet.Cells.AutoFitColumns();

                        row += 2;

                        // Thiết kế tên cột "Thống kê bài đăng"
                        ExcelRange titleRange2 = worksheet.Cells[$"A{row}:H{row}"];
                        titleRange2.Merge = true;
                        titleRange2.Value = "Thống kê bài đăng";
                        titleRange2.Style.Font.Size = 28;
                        titleRange2.Style.Font.Bold = true;
                        titleRange2.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        titleRange2.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(173, 216, 230)); // Màu xanh dương tối
                        titleRange2.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; // Căn giữa ngang
                        titleRange2.Style.VerticalAlignment = ExcelVerticalAlignment.Center; // Căn giữa dọc
                        titleRange2.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                        titleRange2.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        titleRange2.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                        titleRange2.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                        row += 2; // Bỏ qua 1 dòng trống và 1 dòng cho "Thống kê bài đăng"

                        // Ghi tên cột "Thống kê bài đăng"
                        for (int i = 0; i < columnHeaders2.Length; i++)
                        {
                            worksheet.Cells[row, i + 1].Value = columnHeaders2[i];
                            worksheet.Cells[row, i + 1].Style.Font.Bold = true;
                        }
                        row++;
                        worksheet.Cells.AutoFitColumns();

                        List<ThongKeDTO> thongKeBaiDang = bus_Admin.ThongKeBaiDang();
                        foreach (var data in thongKeBaiDang)
                        {
                            worksheet.Cells[row, 1].Value = data.Thoigiandang;
                            worksheet.Cells[row, 1].Style.Numberformat.Format = "dd-MM-yyy";
                            worksheet.Cells[row, 2].Value = data.Soluongbaidang;
                            row++;
                        }
                        worksheet.Cells.AutoFitColumns();
                        row += 2;

                        ExcelRange titleRange3 = worksheet.Cells[$"A{row}:H{row}"];
                        titleRange3.Merge = true;
                        titleRange3.Value = "Thống kê doanh thu";
                        titleRange3.Style.Font.Size = 28;
                        titleRange3.Style.Font.Bold = true;
                        titleRange3.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        titleRange3.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(173, 216, 230)); // Màu xanh dương tối
                        titleRange3.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; // Căn giữa ngang
                        titleRange3.Style.VerticalAlignment = ExcelVerticalAlignment.Center; // Căn giữa dọc
                        titleRange3.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                        titleRange3.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        titleRange3.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                        titleRange3.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                        row += 2;

                        for (int i = 0; i < columnHeaders3.Length; i++)
                        {
                            worksheet.Cells[row, i + 1].Value = columnHeaders3[i];
                            worksheet.Cells[row, i + 1].Style.Font.Bold = true;
                        }
                        row++;
                        worksheet.Cells.AutoFitColumns();

                        List<ThongKeDoanhThuDTO> thongKeDoanhThu = bus_Admin.ThongKeDoanhThu();
                        foreach (var data in thongKeDoanhThu)
                        {
                            worksheet.Cells[row, 1].Value = data.Ngaynap;
                            worksheet.Cells[row, 1].Style.Numberformat.Format = "dd-MM-yyy";
                            worksheet.Cells[row, 2].Value = data.Tongtiennap;
                            row++;
                        }
                        row += 2;

                        ExcelRange titleRange4 = worksheet.Cells[$"A{row}:H{row}"];
                        titleRange4.Merge = true;
                        titleRange4.Value = "Thống kê Loại nhà";
                        titleRange4.Style.Font.Size = 28;
                        titleRange4.Style.Font.Bold = true;
                        titleRange4.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        titleRange4.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(173, 216, 230)); // Màu xanh dương tối
                        titleRange4.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; // Căn giữa ngang
                        titleRange4.Style.VerticalAlignment = ExcelVerticalAlignment.Center; // Căn giữa dọc
                        titleRange4.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                        titleRange4.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        titleRange4.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                        titleRange4.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                        row += 2;

                        for (int i = 0; i < columnHeaders3.Length; i++)
                        {
                            worksheet.Cells[row, i + 1].Value = columnHeaders4[i];
                            worksheet.Cells[row, i + 1].Style.Font.Bold = true;
                        }
                        row++;
                        worksheet.Cells.AutoFitColumns();

                        List<ThongKeDTO> thongKeLoaiNha = bus_Admin.ThongKeTop5();
                        foreach (var data in thongKeLoaiNha)
                        {
                            worksheet.Cells[row, 1].Value = data.Loainha;
                            worksheet.Cells[row, 2].Value = data.Soluongbaidang;
                            row++;
                        }

                        package.Save();

                    }
                    return true;
                }
                else if (Status == 2)
                {
                    int soBaiDang = bus_Admin.ThongKeNgayTrongThang();
                    int soKhachHang = bus_Admin.ThongKeKhachHangTrongThang();
                    double giatriBDS = bus_Admin.ThongKeTongGiaTriBDS();
                    double doanhThuTrongThang = bus_Admin.ThongKeDoanhThuTrongThang();

                    using (ExcelPackage package = new ExcelPackage(excelFile))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add($"{DateTime.Now.ToString("MM-yyyy")}");

                        // Thiết kế tên cột
                        string[] columnHeaders1 = { "Số bài đăng", "Khách hàng", "Tổng giá trị BDS", "Doanh thu" };
                        string[] columnHeaders2 = { "Ngày", "Số bài đăng" };
                        string[] columnHeaders3 = { "Ngày", "Doanh Thu" };
                        string[] columnHeaders4 = { "Loại nhà", "Số lượt đăng" };

                        int row = 2; // Bắt đầu từ dòng 2 để bỏ qua dòng "Thống kê"

                        // Thiết kế tên cột "Thống kê"
                        ExcelRange titleRange1 = worksheet.Cells["A1:H1"];
                        titleRange1.Merge = true;
                        titleRange1.Value = $"Thống kê tổng quát {DateTime.Now.ToString("MM-yyyy")}";
                        titleRange1.Style.Font.Size = 28;
                        titleRange1.Style.Font.Bold = true;
                        titleRange1.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        titleRange1.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(173, 216, 230)); // Màu vàng nhạt
                        titleRange1.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; // Căn giữa ngang
                        titleRange1.Style.VerticalAlignment = ExcelVerticalAlignment.Center; // Căn giữa dọc
                        titleRange1.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                        titleRange1.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        titleRange1.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                        titleRange1.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                        row++;


                        // Ghi tên cột "Thống kê"
                        for (int i = 0; i < columnHeaders1.Length; i++)
                        {
                            worksheet.Cells[row, i + 1].Value = columnHeaders1[i];
                            worksheet.Cells[row, i + 1].Style.Font.Bold = true;
                        }
                        worksheet.Cells.AutoFitColumns();
                        row++;

                        worksheet.Cells[$"A{row}"].Value = soBaiDang;
                        worksheet.Cells[$"B{row}"].Value = soKhachHang;
                        worksheet.Cells[$"C{row}"].Value = giatriBDS;
                        worksheet.Cells[$"D{row}"].Value = doanhThuTrongThang;
                        worksheet.Cells.AutoFitColumns();

                        row += 2;

                        // Thiết kế tên cột "Thống kê bài đăng"
                        ExcelRange titleRange2 = worksheet.Cells[$"A{row}:H{row}"];
                        titleRange2.Merge = true;
                        titleRange2.Value = $"Thống kê bài đăng {DateTime.Now.ToString("MM-yyyy")}";
                        titleRange2.Style.Font.Size = 28;
                        titleRange2.Style.Font.Bold = true;
                        titleRange2.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        titleRange2.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(173, 216, 230)); // Màu xanh dương tối
                        titleRange2.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; // Căn giữa ngang
                        titleRange2.Style.VerticalAlignment = ExcelVerticalAlignment.Center; // Căn giữa dọc
                        titleRange2.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                        titleRange2.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        titleRange2.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                        titleRange2.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                        row += 2; // Bỏ qua 1 dòng trống và 1 dòng cho "Thống kê bài đăng"

                        // Ghi tên cột "Thống kê bài đăng"
                        for (int i = 0; i < columnHeaders2.Length; i++)
                        {
                            worksheet.Cells[row, i + 1].Value = columnHeaders2[i];
                            worksheet.Cells[row, i + 1].Style.Font.Bold = true;
                        }
                        row++;
                        worksheet.Cells.AutoFitColumns();

                        List<ThongKeDTO> thongKeBaiDang = bus_Admin.ThongKeBaiDangTrongThangChart();
                        foreach (var data in thongKeBaiDang)
                        {
                            worksheet.Cells[row, 1].Value = data.Thoigiandang;
                            worksheet.Cells[row, 1].Style.Numberformat.Format = "dd-MM-yyy";
                            worksheet.Cells[row, 2].Value = data.Soluongbaidang;
                            row++;
                        }
                        worksheet.Cells.AutoFitColumns();

                        ExcelRange titleRange3 = worksheet.Cells[$"A{row}:H{row}"];
                        titleRange3.Merge = true;
                        titleRange3.Value = $"Thống kê doanh thu {DateTime.Now.ToString("MM-yyyy")}";
                        titleRange3.Style.Font.Size = 28;
                        titleRange3.Style.Font.Bold = true;
                        titleRange3.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        titleRange3.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(173, 216, 230)); // Màu xanh dương tối
                        titleRange3.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; // Căn giữa ngang
                        titleRange3.Style.VerticalAlignment = ExcelVerticalAlignment.Center; // Căn giữa dọc
                        titleRange3.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                        titleRange3.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        titleRange3.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                        titleRange3.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                        row += 2;

                        for (int i = 0; i < columnHeaders3.Length; i++)
                        {
                            worksheet.Cells[row, i + 1].Value = columnHeaders3[i];
                            worksheet.Cells[row, i + 1].Style.Font.Bold = true;
                        }
                        row++;
                        worksheet.Cells.AutoFitColumns();

                        List<ThongKeDoanhThuDTO> thongKeDoanhThu = bus_Admin.ThongKeDoanThuTrongThang();
                        foreach (var data in thongKeDoanhThu)
                        {
                            worksheet.Cells[row, 1].Value = data.Ngaynap;
                            worksheet.Cells[row, 1].Style.Numberformat.Format = "dd-MM-yyy";
                            worksheet.Cells[row, 2].Value = data.Tongtiennap;
                            row++;
                        }
                        row += 2;

                        ExcelRange titleRange4 = worksheet.Cells[$"A{row}:H{row}"];
                        titleRange4.Merge = true;
                        titleRange4.Value = $"Thống kê Loại nhà {DateTime.Now.ToString("MM-yyyy")}";
                        titleRange4.Style.Font.Size = 28;
                        titleRange4.Style.Font.Bold = true;
                        titleRange4.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        titleRange4.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(173, 216, 230)); // Màu xanh dương tối
                        titleRange4.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; // Căn giữa ngang
                        titleRange4.Style.VerticalAlignment = ExcelVerticalAlignment.Center; // Căn giữa dọc
                        titleRange4.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                        titleRange4.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        titleRange4.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                        titleRange4.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                        row += 2;

                        for (int i = 0; i < columnHeaders3.Length; i++)
                        {
                            worksheet.Cells[row, i + 1].Value = columnHeaders4[i];
                            worksheet.Cells[row, i + 1].Style.Font.Bold = true;
                        }
                        row++;
                        worksheet.Cells.AutoFitColumns();

                        List<ThongKeDTO> thongKeLoaiNha = bus_Admin.ThongKeLoaiNhaTrongThangChart();
                        foreach (var data in thongKeLoaiNha)
                        {
                            worksheet.Cells[row, 1].Value = data.Loainha;
                            worksheet.Cells[row, 2].Value = data.Soluongbaidang;
                            row++;
                        }

                        package.Save();

                    }
                    return true;
                }
                else if (Status == 3)
                {
                    int soBaiDang = bus_Admin.SoBaiDangTheoNgay(DateTime.Now);
                    int soKhachHang = bus_Admin.SoKhachHangTheoNgay(DateTime.Now);
                    double giatriBDS = bus_Admin.TongGiaTriBDSTheoNgay(DateTime.Now);
                    double doanhThu = bus_Admin.TongDoangThuTheoNgay(DateTime.Now);
                    using (ExcelPackage package = new ExcelPackage(excelFile))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add($"{DateTime.Now.ToString("dd-MM-yyyy")}");

                        // Thiết kế tên cột
                        string[] columnHeaders1 = { "Số bài đăng", "Khách hàng", "Tổng giá trị BDS", "Doanh thu" };
                        string[] columnHeaders2 = { "Ngày", "Số bài đăng" };
                        string[] columnHeaders3 = { "Ngày", "Doanh Thu" };
                        string[] columnHeaders4 = { "Loại nhà", "Số lượt đăng" };

                        int row = 2; // Bắt đầu từ dòng 2 để bỏ qua dòng "Thống kê"

                        // Thiết kế tên cột "Thống kê"
                        ExcelRange titleRange1 = worksheet.Cells["A1:H1"];
                        titleRange1.Merge = true;
                        titleRange1.Value = $"Thống kê tổng quát {DateTime.Now.ToString("dd-MM-yyyy")}";
                        titleRange1.Style.Font.Size = 28;
                        titleRange1.Style.Font.Bold = true;
                        titleRange1.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        titleRange1.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(173, 216, 230));
                        titleRange1.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; // Căn giữa ngang
                        titleRange1.Style.VerticalAlignment = ExcelVerticalAlignment.Center; // Căn giữa dọc
                        titleRange1.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                        titleRange1.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        titleRange1.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                        titleRange1.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                        row++;


                        // Ghi tên cột "Thống kê"
                        for (int i = 0; i < columnHeaders1.Length; i++)
                        {
                            worksheet.Cells[row, i + 1].Value = columnHeaders1[i];
                            worksheet.Cells[row, i + 1].Style.Font.Bold = true;
                        }
                        worksheet.Cells.AutoFitColumns();
                        row++;

                        worksheet.Cells[$"A{row}"].Value = soBaiDang;
                        worksheet.Cells[$"B{row}"].Value = soKhachHang;
                        worksheet.Cells[$"C{row}"].Value = giatriBDS;
                        worksheet.Cells[$"D{row}"].Value = doanhThu;
                        worksheet.Cells.AutoFitColumns();

                        row += 2;

                        // Thiết kế tên cột "Thống kê bài đăng"
                        ExcelRange titleRange2 = worksheet.Cells[$"A{row}:H{row}"];
                        titleRange2.Merge = true;
                        titleRange2.Value = $"Thống kê bài đăng {DateTime.Now.ToString("dd-MM-yyyy")}";
                        titleRange2.Style.Font.Size = 28;
                        titleRange2.Style.Font.Bold = true;
                        titleRange2.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        titleRange2.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(173, 216, 230)); // Màu xanh dương tối
                        titleRange2.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; // Căn giữa ngang
                        titleRange2.Style.VerticalAlignment = ExcelVerticalAlignment.Center; // Căn giữa dọc
                        titleRange2.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                        titleRange2.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        titleRange2.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                        titleRange2.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                        row += 2; // Bỏ qua 1 dòng trống và 1 dòng cho "Thống kê bài đăng"

                        // Ghi tên cột "Thống kê bài đăng"
                        for (int i = 0; i < columnHeaders2.Length; i++)
                        {
                            worksheet.Cells[row, i + 1].Value = columnHeaders2[i];
                            worksheet.Cells[row, i + 1].Style.Font.Bold = true;
                        }
                        row++;
                        worksheet.Cells.AutoFitColumns();


                        worksheet.Cells[$"A{row}"].Value = DateTime.Now.ToString("dd-MM-yyyy");
                        worksheet.Cells[$"A{row}"].Style.Numberformat.Format = "dd-MM-yyyy";
                        worksheet.Cells[$"B{row}"].Value = bus_Admin.SoKhachHangTheoNgay(DateTime.Now);
                        worksheet.Cells.AutoFitColumns();
                        row += 2;

                        ExcelRange titleRange3 = worksheet.Cells[$"A{row}:H{row}"];
                        titleRange3.Merge = true;
                        titleRange3.Value = $"Thống kê doanh thu {DateTime.Now.ToString("dd-MM-yyyy")}";
                        titleRange3.Style.Font.Size = 28;
                        titleRange3.Style.Font.Bold = true;
                        titleRange3.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        titleRange3.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(173, 216, 230)); // Màu xanh dương tối
                        titleRange3.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; // Căn giữa ngang
                        titleRange3.Style.VerticalAlignment = ExcelVerticalAlignment.Center; // Căn giữa dọc
                        titleRange3.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                        titleRange3.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        titleRange3.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                        titleRange3.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                        row++;

                        for (int i = 0; i < columnHeaders3.Length; i++)
                        {
                            worksheet.Cells[row, i + 1].Value = columnHeaders3[i];
                            worksheet.Cells[row, i + 1].Style.Font.Bold = true;
                        }
                        row++;
                        worksheet.Cells.AutoFitColumns();

                        double thongKeDoanhThu = bus_Admin.TongDoangThuTheoNgay(DateTime.Now);
                        worksheet.Cells[row, 1].Value = DateTime.Now.ToString("dd-MM-yyyy");
                        worksheet.Cells[row, 2].Value = thongKeDoanhThu;

                        row += 2;

                        ExcelRange titleRange4 = worksheet.Cells[$"A{row}:H{row}"];
                        titleRange4.Merge = true;
                        titleRange4.Value = $"Thống kê Loại nhà {DateTime.Now.ToString("dd-MM-yyyy")}";
                        titleRange4.Style.Font.Size = 28;
                        titleRange4.Style.Font.Bold = true;
                        titleRange4.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        titleRange4.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(173, 216, 230)); // Màu xanh dương tối
                        titleRange4.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; // Căn giữa ngang
                        titleRange4.Style.VerticalAlignment = ExcelVerticalAlignment.Center; // Căn giữa dọc
                        titleRange4.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                        titleRange4.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        titleRange4.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                        titleRange4.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                        row += 2;

                        for (int i = 0; i < columnHeaders3.Length; i++)
                        {
                            worksheet.Cells[row, i + 1].Value = columnHeaders4[i];
                            worksheet.Cells[row, i + 1].Style.Font.Bold = true;
                        }
                        row += 2;
                        worksheet.Cells.AutoFitColumns();

                        List<ThongKeDTO> thongKeLoaiNha = bus_Admin.ThongKeLoaiNhaTheoNgay(DateTime.Now);
                        foreach (var data in thongKeLoaiNha)
                        {
                            worksheet.Cells[row, 1].Value = data.Loainha;
                            worksheet.Cells[row, 2].Value = data.Soluongbaidang;
                            row++;
                        }

                        package.Save();
                    }
                    return true;
                }
                else
                {
                    int soBaiDang = bus_Admin.SoBaiDangTheoNgay(dateTimePicker.Value);
                    int soKhachHang = bus_Admin.SoKhachHangTheoNgay(dateTimePicker.Value);
                    double giatriBDS = bus_Admin.TongGiaTriBDSTheoNgay(dateTimePicker.Value);
                    double doanhThu = bus_Admin.TongDoangThuTheoNgay(dateTimePicker.Value);

                    using (ExcelPackage package = new ExcelPackage(excelFile))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add($"{dateTimePicker.Value.ToString("dd-MM-yyyy")}");

                        // Thiết kế tên cột
                        string[] columnHeaders1 = { "Số bài đăng", "Khách hàng", "Tổng giá trị BDS", "Doanh thu" };
                        string[] columnHeaders2 = { "Ngày", "Số bài đăng" };
                        string[] columnHeaders3 = { "Ngày", "Doanh Thu" };
                        string[] columnHeaders4 = { "Loại nhà", "Số lượt đăng" };

                        int row = 2; // Bắt đầu từ dòng 2 để bỏ qua dòng "Thống kê"

                        // Thiết kế tên cột "Thống kê"
                        ExcelRange titleRange1 = worksheet.Cells["A1:H1"];
                        titleRange1.Merge = true;
                        titleRange1.Value = $"Thống kê tổng quát {dateTimePicker.Value.ToString("dd-MM-yyyy")}";
                        titleRange1.Style.Font.Size = 28;
                        titleRange1.Style.Font.Bold = true;
                        titleRange1.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        titleRange1.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(173, 216, 230)); // Màu vàng nhạt
                        titleRange1.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; // Căn giữa ngang
                        titleRange1.Style.VerticalAlignment = ExcelVerticalAlignment.Center; // Căn giữa dọc
                        titleRange1.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                        titleRange1.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        titleRange1.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                        titleRange1.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                        row++;


                        // Ghi tên cột "Thống kê"
                        for (int i = 0; i < columnHeaders1.Length; i++)
                        {
                            worksheet.Cells[row, i + 1].Value = columnHeaders1[i];
                            worksheet.Cells[row, i + 1].Style.Font.Bold = true;
                        }
                        worksheet.Cells.AutoFitColumns();
                        row++;

                        worksheet.Cells[$"A{row}"].Value = soBaiDang;
                        worksheet.Cells[$"B{row}"].Value = soKhachHang;
                        worksheet.Cells[$"C{row}"].Value = giatriBDS;
                        worksheet.Cells[$"D{row}"].Value = doanhThu;
                        worksheet.Cells.AutoFitColumns();

                        row += 2;

                        // Thiết kế tên cột "Thống kê bài đăng"
                        ExcelRange titleRange2 = worksheet.Cells[$"A{row}:H{row}"];
                        titleRange2.Merge = true;
                        titleRange2.Value = $"Thống kê bài đăng {dateTimePicker.Value}";
                        titleRange2.Style.Font.Size = 28;
                        titleRange2.Style.Font.Bold = true;
                        titleRange2.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        titleRange2.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(173, 216, 230)); // Màu xanh dương tối
                        titleRange2.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; // Căn giữa ngang
                        titleRange2.Style.VerticalAlignment = ExcelVerticalAlignment.Center; // Căn giữa dọc
                        titleRange2.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                        titleRange2.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        titleRange2.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                        titleRange2.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                        row += 2; // Bỏ qua 1 dòng trống và 1 dòng cho "Thống kê bài đăng"

                        // Ghi tên cột "Thống kê bài đăng"
                        for (int i = 0; i < columnHeaders2.Length; i++)
                        {
                            worksheet.Cells[row, i + 1].Value = columnHeaders2[i];
                            worksheet.Cells[row, i + 1].Style.Font.Bold = true;
                        }
                        row += 2;
                        worksheet.Cells.AutoFitColumns();


                        worksheet.Cells[$"A{row}"].Value = DateTime.Now.ToString("dd-MM-yyyy");
                        worksheet.Cells[$"A{row}"].Style.Numberformat.Format = "dd-MM-yyyy";
                        worksheet.Cells[$"B{row}"].Value = bus_Admin.SoKhachHangTheoNgay(DateTime.Now);
                        worksheet.Cells.AutoFitColumns();

                        ExcelRange titleRange3 = worksheet.Cells[$"A{row}:H{row}"];
                        titleRange3.Merge = true;
                        titleRange3.Value = $"Thống kê doanh thu {dateTimePicker.Value.ToString("dd-MM-yyyy")}";
                        titleRange3.Style.Font.Size = 28;
                        titleRange3.Style.Font.Bold = true;
                        titleRange3.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        titleRange3.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(173, 216, 230)); // Màu xanh dương tối
                        titleRange3.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; // Căn giữa ngang
                        titleRange3.Style.VerticalAlignment = ExcelVerticalAlignment.Center; // Căn giữa dọc
                        titleRange3.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                        titleRange3.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        titleRange3.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                        titleRange3.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                        row++;

                        for (int i = 0; i < columnHeaders3.Length; i++)
                        {
                            worksheet.Cells[row, i + 1].Value = columnHeaders3[i];
                            worksheet.Cells[row, i + 1].Style.Font.Bold = true;
                        }
                        row++;
                        worksheet.Cells.AutoFitColumns();

                        double thongKeDoanhThu = bus_Admin.TongDoangThuTheoNgay(dateTimePicker.Value);
                        worksheet.Cells[row, 1].Value = dateTimePicker.Value.ToString("dd-MM-yyyy");
                        worksheet.Cells[row, 2].Value = thongKeDoanhThu;
                        row += 2;

                        ExcelRange titleRange4 = worksheet.Cells[$"A{row}:H{row}"];
                        titleRange4.Merge = true;
                        titleRange4.Value = $"Thống kê Loại nhà {dateTimePicker.Value.ToString("dd-MM-yyyy")}";
                        titleRange4.Style.Font.Size = 28;
                        titleRange4.Style.Font.Bold = true;
                        titleRange4.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        titleRange4.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(173, 216, 230)); // Màu xanh dương tối
                        titleRange4.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; // Căn giữa ngang
                        titleRange4.Style.VerticalAlignment = ExcelVerticalAlignment.Center; // Căn giữa dọc
                        titleRange4.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                        titleRange4.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        titleRange4.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                        titleRange4.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                        row += 2;

                        for (int i = 0; i < columnHeaders3.Length; i++)
                        {
                            worksheet.Cells[row, i + 1].Value = columnHeaders4[i];
                            worksheet.Cells[row, i + 1].Style.Font.Bold = true;
                        }
                        row++;
                        worksheet.Cells.AutoFitColumns();

                        List<ThongKeDTO> thongKeLoaiNha = bus_Admin.ThongKeLoaiNhaTheoNgay(dateTimePicker.Value);
                        foreach (var data in thongKeLoaiNha)
                        {
                            worksheet.Cells[row, 1].Value = data.Loainha;
                            worksheet.Cells[row, 2].Value = data.Soluongbaidang;
                            row++;
                        }

                        package.Save();
                    }
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}