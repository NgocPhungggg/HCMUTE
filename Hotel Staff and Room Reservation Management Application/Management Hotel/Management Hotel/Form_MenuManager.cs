using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Hotel
{
    public partial class Form_MenuManager : Form
    {
        public Form_MenuManager()
        {
            InitializeComponent();
        }
        private void Form_MenuManager_Load(object sender, EventArgs e)
        {
        }
        //Lao công
        private void Button_ListJanitor_Click(object sender, EventArgs e)
        {
            Form_ListJanitors listjanitor = new Form_ListJanitors();
            listjanitor.ShowDialog();
        }
        private void Button_ManageJanitor_Click(object sender, EventArgs e)
        {
            Form_ManagerJanitors managejanitor= new Form_ManagerJanitors();
            managejanitor.ShowDialog();
        }
        //Lễ tân
        private void Button_ListReceptionist_Click(object sender, EventArgs e)
        {
            Form_ListReceptionists managejanitor = new Form_ListReceptionists();
            managejanitor.ShowDialog();
        }
        private void Button_ManageReceptionist_Click(object sender, EventArgs e)
        {
            Form_ManageReceptionists managejanitor = new Form_ManageReceptionists();
            managejanitor.ShowDialog();
        }
        //Nhân sự
        private void Button_Annoucement_Click(object sender, EventArgs e)
        {
            Form_Annoucement annoucement = new Form_Annoucement();
            annoucement.ShowDialog();
        }
        private void Button_ListAttendance_Click(object sender, EventArgs e)
        {
            Form_ListAttendances listattendances = new Form_ListAttendances();
            listattendances.ShowDialog();
        }
        //Khách hàng
        private void Button_ListCustomer_Click(object sender, EventArgs e)
        {
            Form_ListCustomers listcustomers = new Form_ListCustomers();
            listcustomers.ShowDialog();
        }
        private void Button_ManageCustomer_Click(object sender, EventArgs e)
        {
            Form_ManageCustomer managecustomer = new Form_ManageCustomer();
            managecustomer.ShowDialog();
        }        
        private void Button_Events_Click(object sender, EventArgs e)
        {
            Form_Events events = new Form_Events();
            events.ShowDialog();
        }
        //Phòng
        private void Button_ListRoom_Click(object sender, EventArgs e)
        {
            Form_ListRooms listrooms = new Form_ListRooms();
            listrooms.ShowDialog();
        }
        private void Button_ManagerRoom_Click(object sender, EventArgs e)
        {
            Form_ManageRooms managerooms = new Form_ManageRooms();
            managerooms.ShowDialog();
        }
        private void Button_CheckOut_Click(object sender, EventArgs e)
        {
            Form_ReportRoom reportroom = new Form_ReportRoom();
            reportroom.ShowDialog();
        }
        //Hóa đơn
        private void Button_Service_Click(object sender, EventArgs e)
        {
            Form_Service service = new Form_Service();
            service.ShowDialog();
        }
        private void Button_Chart_Click(object sender, EventArgs e)
        {
            Form_ChartSales chartsales = new Form_ChartSales();
            chartsales.ShowDialog();
        }
        private void Button_Bill_Click(object sender, EventArgs e)
        {
            Form_Bill bill = new Form_Bill();
            bill.ShowDialog();
        }

        private void Button_Schedule_Click(object sender, EventArgs e)
        {
            Form_Salary salary= new Form_Salary();  
            salary.ShowDialog();
        }


    }
}
