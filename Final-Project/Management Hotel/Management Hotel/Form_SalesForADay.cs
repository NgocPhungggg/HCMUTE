using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Management_Hotel
{
    public partial class Form_SalesForADay : Form
    {
        MyDatabase mydatabase = new MyDatabase();
        Bill bill = new Bill();
        public Form_SalesForADay()
        {
            InitializeComponent();
        }

        private void Form_SalesForADay_Load(object sender, EventArgs e)
        {
            mydatabase.openConnection();


            SqlCommand command = new SqlCommand("SELECT YEAR(PayTime) AS [Năm], MONTH(PayTime) AS [Tháng], SUM(TotalMoney) AS [Doanh thu] " +
                                                "FROM Bill " +
                                                "WHERE PayTime IS NOT NULL AND CONVERT (date,PayTime) = @today " +
                                                "GROUP BY YEAR(PayTime), MONTH(PayTime)", mydatabase.getConnection);
            command.Parameters.Add("@today", SqlDbType.Date).Value = DateTime.Now.Date;
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
            chart1.Titles[0].Font = new System.Drawing.Font("Arial", 14, FontStyle.Bold); // Đặt kiểu font và kích thước cho tiêu đề
            chart1.Titles[0].Alignment = ContentAlignment.MiddleCenter; // Căn giữa tiêu đề

            // Hiển thị biểu đồ trên Form
            chart1.Dock = DockStyle.Fill;
            this.Controls.Add(chart1);
        }

        private void Button_Print_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Bill WHERE PayTime IS NOT NULL AND CONVERT(date, PayTime) = @today");
            command.Parameters.Add("@today", SqlDbType.Date).Value = DateTime.Now.Date;

            System.Data.DataTable tablesql = bill.GetBill(command);

            if (tablesql.Rows.Count > 0)
            {
                SaveFileDialog savestudentlist = new SaveFileDialog();
                savestudentlist.Filter = "PDF (*.pdf)|*.pdf";
                savestudentlist.FileName = "Sales";
                bool ErrorMessage = false;

                if (savestudentlist.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(savestudentlist.FileName))
                    {
                        try
                        {
                            File.Delete(savestudentlist.FileName);
                        }
                        catch (IOException ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable Table = new PdfPTable(tablesql.Columns.Count);
                            Table.DefaultCell.Padding = tablesql.Rows.Count + 5;
                            Table.WidthPercentage = 100;
                            Table.HorizontalAlignment = Element.ALIGN_CENTER;

                            //Tiêu đề
                            iTextSharp.text.Image HCMUTE = iTextSharp.text.Image.GetInstance(@"W:\Coding\Window Form\Management Hotel\LogoHotel.jpg");
                            Table.AddCell(HCMUTE);
                            PdfPCell cell = new PdfPCell(new Phrase());
                            cell.Colspan = tablesql.Columns.Count;
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            cell.Border = 0;
                            cell.BackgroundColor = BaseColor.WHITE;
                            cell.ExtraParagraphSpace = 0;
                            Table.AddCell(cell);
                            Table.CompleteRow();

                            iTextSharp.text.Font font = FontFactory.GetFont("Times New Roman", 20, 1);
                            cell = new PdfPCell(new Phrase("Doanh Thu Khach San The Royal Ngay " + DateTime.Now.Date, font));
                            cell.Colspan = tablesql.Columns.Count;
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            cell.Border = 0;
                            cell.BackgroundColor = BaseColor.WHITE;
                            cell.ExtraParagraphSpace = 0;
                            Table.AddCell(cell);
                            Table.CompleteRow();

                            cell = new PdfPCell(new Phrase("So 1 Vo Van Ngan, phuong Linh Chieu, tp Thu Duc"));
                            cell.Colspan = tablesql.Columns.Count;
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            cell.Border = 0;
                            cell.BackgroundColor = BaseColor.WHITE;
                            cell.ExtraParagraphSpace = 0;
                            Table.AddCell(cell);
                            Table.CompleteRow();

                            cell = new PdfPCell(new Phrase(" "));
                            cell.Colspan = tablesql.Columns.Count;
                            cell.HorizontalAlignment = Element.ALIGN_LEFT;
                            cell.Border = 0;
                            cell.BackgroundColor = BaseColor.WHITE;
                            cell.ExtraParagraphSpace = 0;
                            Table.AddCell(cell);
                            Table.CompleteRow();

                            cell = new PdfPCell(new Phrase("Ma Bill"));
                            cell.HorizontalAlignment = Element.ALIGN_LEFT;
                            cell.Border = 0;
                            cell.BackgroundColor = BaseColor.PINK;
                            cell.ExtraParagraphSpace = 0;
                            Table.AddCell(cell);

                            cell = new PdfPCell(new Phrase("Phong"));
                            cell.HorizontalAlignment = Element.ALIGN_LEFT;
                            cell.Border = 0;
                            cell.BackgroundColor = BaseColor.PINK;
                            cell.ExtraParagraphSpace = 0;
                            Table.AddCell(cell);

                            cell = new PdfPCell(new Phrase("Ma khach hang"));

                            cell.HorizontalAlignment = Element.ALIGN_LEFT;
                            cell.Border = 0;
                            cell.BackgroundColor = BaseColor.PINK;
                            cell.ExtraParagraphSpace = 0;
                            Table.AddCell(cell);

                            cell = new PdfPCell(new Phrase("CheckIn"));
                            cell.HorizontalAlignment = Element.ALIGN_LEFT;
                            cell.Border = 0;
                            cell.BackgroundColor = BaseColor.PINK;
                            cell.ExtraParagraphSpace = 0;
                            Table.AddCell(cell);

                            cell = new PdfPCell(new Phrase("CheckOut"));
                            cell.HorizontalAlignment = Element.ALIGN_LEFT;
                            cell.Border = 0;
                            cell.BackgroundColor = BaseColor.PINK;
                            cell.ExtraParagraphSpace = 0;
                            Table.AddCell(cell);

                            cell = new PdfPCell(new Phrase("So ngay dat"));
                            cell.HorizontalAlignment = Element.ALIGN_LEFT;
                            cell.Border = 0;
                            cell.BackgroundColor = BaseColor.PINK;
                            cell.ExtraParagraphSpace = 0;
                            Table.AddCell(cell);

                            cell = new PdfPCell(new Phrase("Tong tien"));
                            cell.HorizontalAlignment = Element.ALIGN_LEFT;
                            cell.Border = 0;
                            cell.BackgroundColor = BaseColor.PINK;
                            cell.ExtraParagraphSpace = 0;
                            Table.AddCell(cell);


                            cell = new PdfPCell(new Phrase("Giam gia"));
                            cell.HorizontalAlignment = Element.ALIGN_LEFT;
                            cell.Border = 0;
                            cell.BackgroundColor = BaseColor.PINK;
                            cell.ExtraParagraphSpace = 0;
                            Table.AddCell(cell);


                            cell = new PdfPCell(new Phrase("Thoi gian thanh toan"));
                            cell.HorizontalAlignment = Element.ALIGN_LEFT;
                            cell.Border = 0;
                            cell.BackgroundColor = BaseColor.PINK;
                            cell.ExtraParagraphSpace = 0;
                            Table.AddCell(cell);

                            cell = new PdfPCell(new Phrase("Phuong thuc thanh toan"));
                            cell.HorizontalAlignment = Element.ALIGN_LEFT;
                            cell.Border = 0;
                            cell.BackgroundColor = BaseColor.PINK;
                            cell.ExtraParagraphSpace = 0;
                            Table.AddCell(cell);


                            cell = new PdfPCell(new Phrase("Ma nhan vien"));
                            cell.HorizontalAlignment = Element.ALIGN_LEFT;
                            cell.Border = 0;
                            cell.BackgroundColor = BaseColor.PINK;
                            cell.ExtraParagraphSpace = 0;
                            Table.AddCell(cell);
                            Table.CompleteRow();


                            for (int i = 0; i < tablesql.Rows.Count; i++)
                            {
                                decimal discount = decimal.Parse(tablesql.Rows[0]["Discount"].ToString());
                                string formattedDiscount = discount.ToString("0.00");

                                Table.AddCell(tablesql.Rows[i][0].ToString());
                                Table.AddCell(tablesql.Rows[i][1].ToString());
                                Table.AddCell(tablesql.Rows[i][2].ToString());
                                Table.AddCell(tablesql.Rows[i][3].ToString());
                                Table.AddCell(tablesql.Rows[i][4].ToString());
                                Table.AddCell(tablesql.Rows[i][5].ToString());
                                Table.AddCell(tablesql.Rows[i][6].ToString());
                                Table.AddCell(formattedDiscount);
                                Table.AddCell(tablesql.Rows[i][8].ToString());
                                Table.AddCell(tablesql.Rows[i][9].ToString());
                                Table.AddCell(tablesql.Rows[i][10].ToString());

                                Table.CompleteRow();
                            }
                            cell = new PdfPCell(new Phrase(" "));
                            cell.Colspan = tablesql.Columns.Count;
                            cell.HorizontalAlignment = Element.ALIGN_LEFT;
                            cell.Border = 0;
                            cell.BackgroundColor = BaseColor.WHITE;
                            cell.ExtraParagraphSpace = 0;
                            Table.AddCell(cell);
                            Table.CompleteRow();



                            cell = new PdfPCell(new Phrase("            Ky ten          ."));
                            cell.Colspan = tablesql.Columns.Count;
                            cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                            cell.Border = 0;
                            cell.BackgroundColor = BaseColor.WHITE;
                            cell.ExtraParagraphSpace = 0;
                            Table.AddCell(cell);
                            Table.CompleteRow();

                            using (FileStream stream = new FileStream(savestudentlist.FileName, FileMode.Create))
                            {
                                iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(Table);
                                pdfDoc.Close();
                                stream.Close();
                            }
                            MessageBox.Show("Data Exported Successfully", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No Record To Export !!!", "Info");
                }
            }
        }
    }
}
