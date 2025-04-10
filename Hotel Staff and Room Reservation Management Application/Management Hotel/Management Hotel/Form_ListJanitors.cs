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

namespace Management_Hotel
{
    public partial class Form_ListJanitors : Form
    {
        public Form_ListJanitors()
        {
            InitializeComponent();
        }
        Janitor janitor = new Janitor(); 

        private void Form_ListJanitors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotel_ManagementDataSet.Information' table. You can move, or remove it, as needed.
            this.informationTableAdapter.Fill(this.hotel_ManagementDataSet.Information);
            SqlCommand command = new SqlCommand("SELECT * FROM Employee E, Information I WHERE E.ID = I.ID AND Position = 'Janitor'");
            DataGridView_ListJanitors.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView_ListJanitors.RowTemplate.Height = 80;
            DataGridView_ListJanitors.DataSource = janitor.GetJanitor(command);
            picCol = (DataGridViewImageColumn)DataGridView_ListJanitors.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView_ListJanitors.AllowUserToAddRows = false;
        }
    }
}
