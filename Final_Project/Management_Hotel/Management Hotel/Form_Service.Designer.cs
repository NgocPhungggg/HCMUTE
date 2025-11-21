namespace Management_Hotel
{
    partial class Form_Service
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
            this.components = new System.ComponentModel.Container();
            this.dongiaLabel = new System.Windows.Forms.Label();
            this.Giatxt = new System.Windows.Forms.TextBox();
            this.tendichvuLabel = new System.Windows.Forms.Label();
            this.DichVutxt = new System.Windows.Forms.TextBox();
            this.Button_Edit = new System.Windows.Forms.Button();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.Button_Add = new System.Windows.Forms.Button();
            this.ServiceDGV = new System.Windows.Forms.DataGridView();
            this.TextBox_MaxUnit = new System.Windows.Forms.TextBox();
            this.TextBox_MinUnit = new System.Windows.Forms.TextBox();
            this.lblFilterUnit = new System.Windows.Forms.Label();
            this.lblMinUnit = new System.Windows.Forms.Label();
            this.Button_SelectService = new System.Windows.Forms.Button();
            this.lblMaxUnit = new System.Windows.Forms.Label();
            this.hotel_ManagementDataSet = new Management_Hotel.Hotel_ManagementDataSet();
            this.servicessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicessTableAdapter = new Management_Hotel.Hotel_ManagementDataSetTableAdapters.ServicessTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicessBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dongiaLabel
            // 
            this.dongiaLabel.AutoSize = true;
            this.dongiaLabel.BackColor = System.Drawing.Color.Transparent;
            this.dongiaLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dongiaLabel.Location = new System.Drawing.Point(869, 505);
            this.dongiaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dongiaLabel.Name = "dongiaLabel";
            this.dongiaLabel.Size = new System.Drawing.Size(93, 29);
            this.dongiaLabel.TabIndex = 55;
            this.dongiaLabel.Text = "Đơn Giá";
            // 
            // Giatxt
            // 
            this.Giatxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Giatxt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Giatxt.Location = new System.Drawing.Point(1018, 503);
            this.Giatxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Giatxt.Name = "Giatxt";
            this.Giatxt.Size = new System.Drawing.Size(167, 29);
            this.Giatxt.TabIndex = 56;
            // 
            // tendichvuLabel
            // 
            this.tendichvuLabel.AutoSize = true;
            this.tendichvuLabel.BackColor = System.Drawing.Color.Transparent;
            this.tendichvuLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tendichvuLabel.Location = new System.Drawing.Point(869, 464);
            this.tendichvuLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tendichvuLabel.Name = "tendichvuLabel";
            this.tendichvuLabel.Size = new System.Drawing.Size(149, 29);
            this.tendichvuLabel.TabIndex = 53;
            this.tendichvuLabel.Text = "Tên Dịch Vụ:";
            // 
            // DichVutxt
            // 
            this.DichVutxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DichVutxt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DichVutxt.Location = new System.Drawing.Point(1018, 468);
            this.DichVutxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DichVutxt.Name = "DichVutxt";
            this.DichVutxt.Size = new System.Drawing.Size(167, 29);
            this.DichVutxt.TabIndex = 54;
            //this.DichVutxt.TextChanged += new System.EventHandler(this.DichVutxt_TextChanged);
            // 
            // Button_Edit
            // 
            this.Button_Edit.BackColor = System.Drawing.Color.Linen;
            this.Button_Edit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Edit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Button_Edit.Location = new System.Drawing.Point(977, 547);
            this.Button_Edit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button_Edit.Name = "Button_Edit";
            this.Button_Edit.Size = new System.Drawing.Size(100, 35);
            this.Button_Edit.TabIndex = 49;
            this.Button_Edit.Text = "Sửa";
            this.Button_Edit.UseVisualStyleBackColor = false;
            this.Button_Edit.Click += new System.EventHandler(this.Button_Edit_Click);
            // 
            // Button_Delete
            // 
            this.Button_Delete.BackColor = System.Drawing.Color.Linen;
            this.Button_Delete.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Delete.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Button_Delete.Location = new System.Drawing.Point(1085, 547);
            this.Button_Delete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(100, 35);
            this.Button_Delete.TabIndex = 48;
            this.Button_Delete.Text = "Xóa";
            this.Button_Delete.UseVisualStyleBackColor = false;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // Button_Add
            // 
            this.Button_Add.BackColor = System.Drawing.Color.Linen;
            this.Button_Add.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Add.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Button_Add.Location = new System.Drawing.Point(869, 547);
            this.Button_Add.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(100, 35);
            this.Button_Add.TabIndex = 47;
            this.Button_Add.Text = "Thêm";
            this.Button_Add.UseVisualStyleBackColor = false;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // ServiceDGV
            // 
            this.ServiceDGV.AutoGenerateColumns = false;
            this.ServiceDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.ServiceDGV.DataSource = this.servicessBindingSource;
            this.ServiceDGV.Location = new System.Drawing.Point(337, 200);
            this.ServiceDGV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ServiceDGV.MultiSelect = false;
            this.ServiceDGV.Name = "ServiceDGV";
            this.ServiceDGV.ReadOnly = true;
            this.ServiceDGV.RowHeadersWidth = 51;
            this.ServiceDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ServiceDGV.Size = new System.Drawing.Size(524, 382);
            this.ServiceDGV.TabIndex = 86;
            this.ServiceDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ServiceDGV_CellDoubleClick);
            // 
            // TextBox_MaxUnit
            // 
            this.TextBox_MaxUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_MaxUnit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_MaxUnit.Location = new System.Drawing.Point(808, 601);
            this.TextBox_MaxUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBox_MaxUnit.Name = "TextBox_MaxUnit";
            this.TextBox_MaxUnit.Size = new System.Drawing.Size(161, 29);
            this.TextBox_MaxUnit.TabIndex = 95;
            // 
            // TextBox_MinUnit
            // 
            this.TextBox_MinUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_MinUnit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_MinUnit.Location = new System.Drawing.Point(588, 601);
            this.TextBox_MinUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBox_MinUnit.Name = "TextBox_MinUnit";
            this.TextBox_MinUnit.Size = new System.Drawing.Size(161, 29);
            this.TextBox_MinUnit.TabIndex = 92;
            // 
            // lblFilterUnit
            // 
            this.lblFilterUnit.AutoSize = true;
            this.lblFilterUnit.BackColor = System.Drawing.Color.Transparent;
            this.lblFilterUnit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterUnit.Location = new System.Drawing.Point(468, 601);
            this.lblFilterUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilterUnit.Name = "lblFilterUnit";
            this.lblFilterUnit.Size = new System.Drawing.Size(54, 29);
            this.lblFilterUnit.TabIndex = 91;
            this.lblFilterUnit.Text = "Giá:";
            // 
            // lblMinUnit
            // 
            this.lblMinUnit.AutoSize = true;
            this.lblMinUnit.BackColor = System.Drawing.Color.Transparent;
            this.lblMinUnit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinUnit.Location = new System.Drawing.Point(528, 601);
            this.lblMinUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinUnit.Name = "lblMinUnit";
            this.lblMinUnit.Size = new System.Drawing.Size(41, 29);
            this.lblMinUnit.TabIndex = 93;
            this.lblMinUnit.Text = "Từ";
            // 
            // Button_SelectService
            // 
            this.Button_SelectService.BackColor = System.Drawing.Color.Linen;
            this.Button_SelectService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button_SelectService.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_SelectService.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_SelectService.Location = new System.Drawing.Point(988, 596);
            this.Button_SelectService.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button_SelectService.Name = "Button_SelectService";
            this.Button_SelectService.Size = new System.Drawing.Size(100, 35);
            this.Button_SelectService.TabIndex = 90;
            this.Button_SelectService.Text = "Lọc";
            this.Button_SelectService.UseVisualStyleBackColor = false;
            this.Button_SelectService.Click += new System.EventHandler(this.Button_SelectService_Click);
            // 
            // lblMaxUnit
            // 
            this.lblMaxUnit.AutoSize = true;
            this.lblMaxUnit.BackColor = System.Drawing.Color.Transparent;
            this.lblMaxUnit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxUnit.Location = new System.Drawing.Point(748, 601);
            this.lblMaxUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxUnit.Name = "lblMaxUnit";
            this.lblMaxUnit.Size = new System.Drawing.Size(52, 29);
            this.lblMaxUnit.TabIndex = 94;
            this.lblMaxUnit.Text = "Đến";
            // 
            // hotel_ManagementDataSet
            // 
            this.hotel_ManagementDataSet.DataSetName = "Hotel_ManagementDataSet";
            this.hotel_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicessBindingSource
            // 
            this.servicessBindingSource.DataMember = "Servicess";
            this.servicessBindingSource.DataSource = this.hotel_ManagementDataSet;
            // 
            // servicessTableAdapter
            // 
            this.servicessTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ServiceName";
            this.dataGridViewTextBoxColumn1.HeaderText = "ServiceName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cost";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cost";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Form_Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Management_Hotel.Properties.Resources.ManageService;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.TextBox_MaxUnit);
            this.Controls.Add(this.TextBox_MinUnit);
            this.Controls.Add(this.lblFilterUnit);
            this.Controls.Add(this.lblMinUnit);
            this.Controls.Add(this.Button_SelectService);
            this.Controls.Add(this.lblMaxUnit);
            this.Controls.Add(this.Giatxt);
            this.Controls.Add(this.Button_Edit);
            this.Controls.Add(this.dongiaLabel);
            this.Controls.Add(this.Button_Delete);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.DichVutxt);
            this.Controls.Add(this.tendichvuLabel);
            this.Controls.Add(this.ServiceDGV);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Service";
            this.Text = "DichVu";
            this.Load += new System.EventHandler(this.Form_Service_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicessBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label dongiaLabel;
        private System.Windows.Forms.TextBox Giatxt;
        private System.Windows.Forms.Label tendichvuLabel;
        private System.Windows.Forms.TextBox DichVutxt;
        private System.Windows.Forms.Button Button_Edit;
        private System.Windows.Forms.Button Button_Delete;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.DataGridView ServiceDGV;
        //private PROJECT_WIN_HOTELDataSetAllTableAdapters.ServicesTableAdapter servicesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox TextBox_MaxUnit;
        private System.Windows.Forms.TextBox TextBox_MinUnit;
        private System.Windows.Forms.Label lblFilterUnit;
        private System.Windows.Forms.Label lblMinUnit;
        private System.Windows.Forms.Button Button_SelectService;
        private System.Windows.Forms.Label lblMaxUnit;
        private Hotel_ManagementDataSet hotel_ManagementDataSet;
        private System.Windows.Forms.BindingSource servicessBindingSource;
        private Hotel_ManagementDataSetTableAdapters.ServicessTableAdapter servicessTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}