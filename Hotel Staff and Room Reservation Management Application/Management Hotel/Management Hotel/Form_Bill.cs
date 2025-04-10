using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using static Management_Hotel.Global;

namespace Management_Hotel
{
    public partial class Form_Bill : Form
    {
        public Form_Bill()
        {
            InitializeComponent();
        }
        Bill bill = new Bill();
        MyDatabase mydb = new MyDatabase();
        private void Form_Bill_Load(object sender, EventArgs e)
        {      
            SqlCommand command = new SqlCommand("SELECT * FROM Bill");
            LoadData(command);
            btnXoa.Enabled = false;
            if (GlobalVariables.acc =="123456")
            {
                btnXoa.Enabled = true;
            }
            DateTime now = DateTime.Now;
            txtDate_checkout.Text = now.ToString("yyyy-MM-dd HH:mm:ss");
        }
        void LoadData(SqlCommand command)
        {
            // TODO: This line of code loads data into the 'pROJECT_WIN_HOTELDataSetAll.Bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.Fill(this.hotel_ManagementDataSet.Bill);
            dgvHoaDonDatPhong.DataSource = bill.GetBill(command);
            dgvHoaDonDatPhong.Columns["dataGridViewTextBoxColumn8"].DefaultCellStyle.Format = "N2";

        }
        public void CalculateBillTotalMoney(int billID, float discount)
        {

            mydb.openConnection();

            // Lấy thông tin RoomID từ bảng Bill
            string getRoomIDQuery = "SELECT RoomID FROM Bill WHERE BillID = @BillID";
            SqlCommand getRoomIDCommand = new SqlCommand(getRoomIDQuery, mydb.getConnection);
            getRoomIDCommand.Parameters.AddWithValue("@BillID", billID);

            string roomID = (string)getRoomIDCommand.ExecuteScalar();

            // Lấy giá phòng từ bảng Room
            string getRoomPriceQuery = "select Cost from Room inner join TypeRoom on Room.TypeRoomName=TypeRoom.TypeRoomName where RoomID = @RoomID";
            SqlCommand getRoomPriceCommand = new SqlCommand(getRoomPriceQuery, mydb.getConnection);
            getRoomPriceCommand.Parameters.AddWithValue("@RoomID", roomID);

            int roomPrice = (int)getRoomPriceCommand.ExecuteScalar();

            // Lấy tổng tiền dịch vụ từ bảng Detail_Servicess
            string getServiceTotalMoneyQuery = "SELECT SUM(total) FROM Detail_Servicess WHERE BillID = @BillID";
            SqlCommand getServiceTotalMoneyCommand = new SqlCommand(getServiceTotalMoneyQuery, mydb.getConnection);
            getServiceTotalMoneyCommand.Parameters.AddWithValue("@BillID", billID);

            int serviceTotalMoney = 0;
            object serviceTotalMoneyResult = getServiceTotalMoneyCommand.ExecuteScalar();
            if (serviceTotalMoneyResult != DBNull.Value)
            {
                serviceTotalMoney = (int)serviceTotalMoneyResult;
            }

            // Tính tổng tiền của hóa đơn
            int tien = roomPrice + serviceTotalMoney;
            int totalMoney = Convert.ToInt32(tien * (1 - discount));
            txtTotal_money.Text = totalMoney.ToString();
            // Cập nhật cột TotalMoney trong bảng Bill
            string updateTotalMoneyQuery = "UPDATE Bill SET TotalMoney = @TotalMoney WHERE BillID = @BillID";
            SqlCommand updateTotalMoneyCommand = new SqlCommand(updateTotalMoneyQuery, mydb.getConnection);
            updateTotalMoneyCommand.Parameters.AddWithValue("@TotalMoney", totalMoney);
            updateTotalMoneyCommand.Parameters.AddWithValue("@BillID", billID);
            updateTotalMoneyCommand.ExecuteNonQuery();

        }
        private void dgvHoaDonDatPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime now = DateTime.Now;
            txtbill_id.Text = dgvHoaDonDatPhong.CurrentRow.Cells[0].Value.ToString();
            txtRoom_id.Text = dgvHoaDonDatPhong.CurrentRow.Cells[1].Value.ToString();
            txtCustomer_id.Text = dgvHoaDonDatPhong.CurrentRow.Cells[2].Value.ToString();
            txtDate_checkout.Text = now.ToString("yyyy-MM-dd HH:mm:ss");
            if (dgvHoaDonDatPhong.CurrentRow.Cells[7].Value.ToString() == null)
            {
                discounttextBox.Text = "0";
            }
            else
            {
                decimal discount = decimal.Parse(dgvHoaDonDatPhong.CurrentRow.Cells[7].Value.ToString());
                string formattedDiscount = discount.ToString("0.00");
                discounttextBox.Text = formattedDiscount;
            }

            txtTotal_money.Text = dgvHoaDonDatPhong.CurrentRow.Cells[6].Value.ToString();
            txtPay_time.Text = now.ToString("yyyy-MM-dd HH:mm:ss"); ;
            comboBoxPayment.Text = dgvHoaDonDatPhong.CurrentRow.Cells[9].Value.ToString();
            txtEmployee_id.Text = dgvHoaDonDatPhong.CurrentRow.Cells[10].Value.ToString();
            
        }
        private void Button_FindID_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Bill WHERE BillID = @billid");
            int billid = int.Parse(txtbill_id.Text);
            command.Parameters.Add("@billid", SqlDbType.Int).Value = billid;
            LoadData(command);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            int BillID = int.Parse(txtbill_id.Text);
            string CustomerID = txtCustomer_id.Text;
            string RoomID = txtRoom_id.Text;
            DateTime date_checkout = Convert.ToDateTime(txtDate_checkout.Text);
            int TotalMoney = int.Parse(txtTotal_money.Text);
            float Discount = float.Parse(discounttextBox.Text);
            dgvHoaDonDatPhong.Columns["dataGridViewTextBoxColumn8"].DefaultCellStyle.Format = "N2";
            DateTime PayTime = Convert.ToDateTime(txtPay_time.Text);
            string Payment = comboBoxPayment.Text;
            string EmployeeID = txtEmployee_id.Text;
            try
            {


                if (!bill.UpdateBillCheckout(BillID, date_checkout, TotalMoney, Discount, PayTime, Payment))
                {
                    MessageBox.Show("Cập nhật Checkout thành công", "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SqlCommand command = new SqlCommand("SELECT * FROM Bill");
                    LoadData(command);
                }
                else
                {
                    MessageBox.Show("Cập nhật Checkout thất bại", "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex, "Notify", MessageBoxButtons.OK);
                //MessageBox.Show("hi"ex)
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtbill_id.Text);
                if (MessageBox.Show("Bạn có chắc muốn xóa không", "Xóa hóa đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (bill.DeleteBill(id))
                    {
                        MessageBox.Show("Xóa hóa đơn thành công", "Xóa hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SqlCommand command = new SqlCommand("SELECT * FROM Bill");
                        LoadData(command);
                        txtbill_id.Text = "";
                        txtRoom_id.Text = "";
                        txtCustomer_id.Text = "";
                        txtDate_checkout.Text = "";
                        discounttextBox.Text = "";
                        txtTotal_money.Text = "";
                        txtPay_time.Text = "";
                        comboBoxPayment.Text = "";
                        txtEmployee_id.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Xóa hóa đơn không thành công", "Xóa hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng ID", "Xóa hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Button_Discount_Click(object sender, EventArgs e)
        {
            int billID = int.Parse(txtbill_id.Text);
            float Discount = float.Parse(discounttextBox.Text);
            CalculateBillTotalMoney(billID, Discount);
            SqlCommand command = new SqlCommand("SELECT * FROM Bill");
            int billid = int.Parse(txtbill_id.Text);
            command.Parameters.Add("@billid", SqlDbType.Int).Value = billid;
            LoadData(command);
        }
        private void Button_Print_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * " +
                                                "FROM Bill B, Detail_Servicess D " +
                                                "WHERE B.BillID = D.BillID AND B.BillID = @billid");
            command.Parameters.Add("@billid",SqlDbType.Int).Value = int.Parse(txtbill_id.Text);
            System.Data.DataTable tablesql = bill.GetBill(command);

            if (tablesql.Rows.Count > 0)
            {
                SaveFileDialog savestudentlist = new SaveFileDialog();
                savestudentlist.Filter = "PDF (*.pdf)|*.pdf";
                savestudentlist.FileName = "Bill";
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
                            PdfPTable Table = new PdfPTable(3);
                            Table.DefaultCell.Padding = tablesql.Rows.Count + 18;
                            Table.WidthPercentage = 100;
                            Table.HorizontalAlignment = Element.ALIGN_CENTER;

                            //Tiêu đề
                            iTextSharp.text.Image HCMUTE = iTextSharp.text.Image.GetInstance(@"W:\Coding\Window Form\Management Hotel\LogoHotel.jpg");
                            Table.AddCell(HCMUTE);
                            PdfPCell cell = new PdfPCell(new Phrase());
                            cell.Colspan = 3;
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            cell.Border = 0;
                            cell.BackgroundColor = BaseColor.WHITE;
                            cell.ExtraParagraphSpace = 0;
                            Table.AddCell(cell);
                            Table.CompleteRow();

                            iTextSharp.text.Font font = FontFactory.GetFont("Times New Roman", 20, 1);
                            cell = new PdfPCell(new Phrase("Hoa don khach san The Royal", font));
                            cell.Colspan = 3;
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            cell.Border = 0;
                            cell.BackgroundColor = BaseColor.WHITE;
                            cell.ExtraParagraphSpace = 0;
                            Table.AddCell(cell);
                            Table.CompleteRow();

                            cell = new PdfPCell(new Phrase("So 1 Vo Van Ngan, phuong Linh Chieu, tp Thu Duc"));
                            cell.Colspan = 3;
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            cell.Border = 0;
                            cell.BackgroundColor = BaseColor.WHITE;
                            cell.ExtraParagraphSpace = 0;
                            Table.AddCell(cell);
                            Table.CompleteRow();

                            cell = new PdfPCell(new Phrase(" "));
                            cell.Colspan = 3;
                            cell.HorizontalAlignment = Element.ALIGN_LEFT;
                            cell.Border = 0;
                            cell.BackgroundColor = BaseColor.WHITE;
                            cell.ExtraParagraphSpace = 0;
                            Table.AddCell(cell);
                            Table.CompleteRow();

                            cell = new PdfPCell(new Phrase("Ma Bill: " + tablesql.Rows[0]["BillID"].ToString()));
                            cell.Colspan = 3;
                            cell.HorizontalAlignment = Element.ALIGN_LEFT;
                            cell.Border = 0;
                            cell.BackgroundColor = BaseColor.WHITE;
                            cell.ExtraParagraphSpace = 0;
                            Table.AddCell(cell);
                            Table.CompleteRow();

                            cell = new PdfPCell(new Phrase("Phong: " + tablesql.Rows[0]["RoomID"].ToString()));
                            cell.Colspan = 3;
                            cell.HorizontalAlignment = Element.ALIGN_LEFT;
                            cell.Border = 0;
                            cell.BackgroundColor = BaseColor.WHITE;
                            cell.ExtraParagraphSpace = 0;
                            Table.AddCell(cell);
                            Table.CompleteRow();

                            cell = new PdfPCell(new Phrase("Ma khach hang: " + tablesql.Rows[0]["CustomerID"].ToString()));
                            cell.Colspan = 3;
                            cell.HorizontalAlignment = Element.ALIGN_LEFT;
                            cell.Border = 0;
                            cell.BackgroundColor = BaseColor.WHITE;
                            cell.ExtraParagraphSpace = 0;
                            Table.AddCell(cell);
                            Table.CompleteRow();

                            cell = new PdfPCell(new Phrase("CheckIn: " + tablesql.Rows[0]["CheckIn"].ToString()));
                            cell.Colspan = 3;
                            cell.HorizontalAlignment = Element.ALIGN_LEFT;
                            cell.Border = 0;
                            cell.BackgroundColor = BaseColor.WHITE;
                            cell.ExtraParagraphSpace = 0;
                            Table.AddCell(cell);
                            Table.CompleteRow();

                            cell = new PdfPCell(new Phrase("CheckOut: " + tablesql.Rows[0]["CheckOut"].ToString()));
                            cell.Colspan = 3;
                            cell.HorizontalAlignment = Element.ALIGN_LEFT;
                            cell.Border = 0;
                            cell.BackgroundColor = BaseColor.WHITE;
                            cell.ExtraParagraphSpace = 0;
                            Table.AddCell(cell);
                            Table.CompleteRow();

                            cell = new PdfPCell(new Phrase("So ngay dat: " + tablesql.Rows[0]["ReservedDays"].ToString()));
                            cell.Colspan = 3;
                            cell.HorizontalAlignment = Element.ALIGN_LEFT;
                            cell.Border = 0;
                            cell.BackgroundColor = BaseColor.WHITE;
                            cell.ExtraParagraphSpace = 0;
                            Table.AddCell(cell);
                            Table.CompleteRow();

                            cell = new PdfPCell(new Phrase("Ma nhan vien: " + tablesql.Rows[0]["EmployeeID"].ToString()));
                            cell.Colspan = 3;
                            cell.HorizontalAlignment = Element.ALIGN_LEFT;
                            cell.Border = 0;
                            cell.BackgroundColor = BaseColor.WHITE;
                            cell.ExtraParagraphSpace = 0;
                            Table.AddCell(cell);
                            Table.CompleteRow();


                            cell = new PdfPCell(new Phrase(" "));
                            cell.Colspan = 3;
                            cell.HorizontalAlignment = Element.ALIGN_LEFT;
                            cell.Border = 0;
                            cell.BackgroundColor = BaseColor.WHITE;
                            cell.ExtraParagraphSpace = 0;
                            Table.AddCell(cell);
                            Table.CompleteRow();

                            cell = new PdfPCell(new Phrase("Ten dich vu"));
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                            cell.BackgroundColor = BaseColor.WHITE;
                            Table.AddCell(cell);

                            cell = new PdfPCell(new Phrase("So luong"));
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                            cell.BackgroundColor = BaseColor.WHITE;
                            Table.AddCell(cell);

                            cell = new PdfPCell(new Phrase("Tong tien"));
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                            cell.BackgroundColor = BaseColor.WHITE;
                            Table.AddCell(cell);
                            Table.CompleteRow();


                            for (int i = 0; i < tablesql.Rows.Count; i++)
                            {
                                Table.AddCell(tablesql.Rows[i]["ServiceName"].ToString());
                                Table.AddCell(tablesql.Rows[i]["Quantity"].ToString());
                                Table.AddCell(tablesql.Rows[i]["Total"].ToString());
                                Table.CompleteRow();
                            }
                            decimal discount = decimal.Parse(dgvHoaDonDatPhong.CurrentRow.Cells[7].Value.ToString());
                            string formattedDiscount = discount.ToString("0.00");
                            cell = new PdfPCell(new Phrase("Giam gia: " + formattedDiscount));
                            cell.Colspan = 3;
                            cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                            cell.Border = 0;
                            cell.BackgroundColor = BaseColor.WHITE;
                            cell.ExtraParagraphSpace = 0;
                            Table.AddCell(cell);
                            Table.CompleteRow();

                            cell = new PdfPCell(new Phrase("Thoi gian thanh toan: " + tablesql.Rows[0]["PayTime"].ToString())); 
                            cell.Colspan = 3;
                            cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                            cell.Border = 0;
                            cell.BackgroundColor = BaseColor.WHITE;
                            cell.ExtraParagraphSpace = 0;
                            Table.AddCell(cell);
                            Table.CompleteRow();

                            cell = new PdfPCell(new Phrase("Phuong thuc thanh toan: " + tablesql.Rows[0]["Payment"].ToString()));
                            cell.Colspan = 3;
                            cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                            cell.Border = 0;
                            cell.BackgroundColor = BaseColor.WHITE;
                            cell.ExtraParagraphSpace = 0;
                            Table.AddCell(cell);
                            Table.CompleteRow();

                            cell = new PdfPCell(new Phrase("Tong tien: " + tablesql.Rows[0]["TotalMoney"].ToString()));
                            cell.Colspan = 3;
                            cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                            cell.Border = 0;
                            cell.BackgroundColor = BaseColor.WHITE;
                            cell.ExtraParagraphSpace = 0;
                            Table.AddCell(cell);
                            Table.CompleteRow();

                            cell = new PdfPCell(new Phrase("            Ky ten          ."));
                            cell.Colspan = 3;
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
