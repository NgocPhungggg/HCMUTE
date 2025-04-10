using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Management_Hotel
{
    public partial class Form_ChartSales : Form
    {
        MyDatabase mydatabase = new MyDatabase();
        public Form_ChartSales()
        {
            InitializeComponent();
        }
        private void Form_ChartSales_Load(object sender, EventArgs e)
        {
            mydatabase.openConnection();
            string sqlQuery = "SELECT YEAR(PayTime) AS [Năm], MONTH(PayTime) AS [Tháng], SUM(TotalMoney) AS [Doanh thu] FROM Bill WHERE PayTime IS NOT NULL GROUP BY YEAR(PayTime), MONTH(PayTime)";
            SqlCommand command = new SqlCommand(sqlQuery, mydatabase.getConnection);
            SqlDataReader reader = command.ExecuteReader();

            // Tạo các danh sách để lưu trữ dữ liệu từ cơ sở dữ liệu
            List<string> years = new List<string>();
            List<string> months = new List<string>();
            List<decimal> revenues = new List<decimal>();

            // Đọc dữ liệu từ SqlDataReader và lưu trữ vào danh sách tương ứng
            while (reader.Read())
            {
                years.Add(reader["Năm"].ToString());
                months.Add(reader["Tháng"].ToString());
                revenues.Add(Convert.ToDecimal(reader["Doanh thu"]));
            }

            // Đóng kết nối và giải phóng tài nguyên
            reader.Close();
            mydatabase.closeConnection();

            // Xóa các Series có sẵn trong Chart control
            chart1.Series.Clear();

            // Tạo một Series mới để hiển thị dữ liệu
            Series series = new Series("VND", (int)SeriesChartType.Column);

            // Thêm dữ liệu vào Series
            for (int i = 0; i < years.Count; i++)
            {
                string label = months[i] + "/" + years[i]; // Tạo nhãn cho mỗi cột (tháng/năm)
                decimal revenue = revenues[i]; // Giá trị doanh thu

                series.Points.AddXY(label, revenue); // Thêm điểm (label, revenue) vào Series
            }

            // Thêm Series vào Chart control
            chart1.Series.Add(series);
            // Tuỳ chỉnh biểu đồ
            chart1.ChartAreas[0].AxisX.Interval = 1; // Khoảng cách giữa các cột là 1
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false; // Tắt lưới dọc

            // Hiển thị biểu đồ trên Form
            chart1.Dock = DockStyle.Fill; // Đặt chiều dọc của Chart control là Fill
            this.Controls.Add(chart1); // Th

            // Đặt tiêu đề cho biểu đồ
            chart1.Titles.Add("Doanh thu khách sạn");

            // Cấu hình các thuộc tính của tiêu đề
            chart1.Titles[0].Font = new Font("Arial", 14, FontStyle.Bold); // Đặt kiểu font và kích thước cho tiêu đề
            chart1.Titles[0].Alignment = ContentAlignment.MiddleCenter; // Căn giữa tiêu đề

            // Hiển thị biểu đồ trên Form
            chart1.Dock = DockStyle.Fill;
            this.Controls.Add(chart1);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            Form_SalesForADay chartsale = new Form_SalesForADay();
            chartsale.ShowDialog();
        }
    }
}
