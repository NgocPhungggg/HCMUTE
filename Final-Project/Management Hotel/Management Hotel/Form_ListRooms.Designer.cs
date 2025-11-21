namespace Management_Hotel
{
    partial class Form_ListRooms
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
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotel_ManagementDataSet = new Management_Hotel.Hotel_ManagementDataSet();
            this.roomTableAdapter = new Management_Hotel.Hotel_ManagementDataSetTableAdapters.RoomTableAdapter();
            this.Label_Room1 = new System.Windows.Forms.Label();
            this.Label_Room2 = new System.Windows.Forms.Label();
            this.Label_Room3 = new System.Windows.Forms.Label();
            this.Label_Room4 = new System.Windows.Forms.Label();
            this.Label_Room8 = new System.Windows.Forms.Label();
            this.Label_Room7 = new System.Windows.Forms.Label();
            this.Label_Room6 = new System.Windows.Forms.Label();
            this.Label_Room5 = new System.Windows.Forms.Label();
            this.Label_Status4 = new System.Windows.Forms.Label();
            this.Label_Status3 = new System.Windows.Forms.Label();
            this.Label_Status2 = new System.Windows.Forms.Label();
            this.Label_Status1 = new System.Windows.Forms.Label();
            this.Label_Status8 = new System.Windows.Forms.Label();
            this.Label_Status7 = new System.Windows.Forms.Label();
            this.Label_Status6 = new System.Windows.Forms.Label();
            this.Label_Status5 = new System.Windows.Forms.Label();
            this.DTP_NgayTim = new System.Windows.Forms.DateTimePicker();
            this.ComboBox_TypeRoom = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.hotel_ManagementDataSet;
            // 
            // hotel_ManagementDataSet
            // 
            this.hotel_ManagementDataSet.DataSetName = "Hotel_ManagementDataSet";
            this.hotel_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // Label_Room1
            // 
            this.Label_Room1.AutoSize = true;
            this.Label_Room1.BackColor = System.Drawing.Color.Transparent;
            this.Label_Room1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Room1.Location = new System.Drawing.Point(224, 247);
            this.Label_Room1.Name = "Label_Room1";
            this.Label_Room1.Size = new System.Drawing.Size(77, 29);
            this.Label_Room1.TabIndex = 0;
            this.Label_Room1.Text = "Room1";
            this.Label_Room1.Click += new System.EventHandler(this.Label_Room1_Click);
            // 
            // Label_Room2
            // 
            this.Label_Room2.AutoSize = true;
            this.Label_Room2.BackColor = System.Drawing.Color.Transparent;
            this.Label_Room2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Room2.Location = new System.Drawing.Point(552, 247);
            this.Label_Room2.Name = "Label_Room2";
            this.Label_Room2.Size = new System.Drawing.Size(77, 29);
            this.Label_Room2.TabIndex = 1;
            this.Label_Room2.Text = "Room2";
            this.Label_Room2.Click += new System.EventHandler(this.Label_Room2_Click);
            // 
            // Label_Room3
            // 
            this.Label_Room3.AutoSize = true;
            this.Label_Room3.BackColor = System.Drawing.Color.Transparent;
            this.Label_Room3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Room3.Location = new System.Drawing.Point(877, 247);
            this.Label_Room3.Name = "Label_Room3";
            this.Label_Room3.Size = new System.Drawing.Size(77, 29);
            this.Label_Room3.TabIndex = 2;
            this.Label_Room3.Text = "Room3";
            this.Label_Room3.Click += new System.EventHandler(this.Label_Room3_Click);
            // 
            // Label_Room4
            // 
            this.Label_Room4.AutoSize = true;
            this.Label_Room4.BackColor = System.Drawing.Color.Transparent;
            this.Label_Room4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Room4.Location = new System.Drawing.Point(1203, 247);
            this.Label_Room4.Name = "Label_Room4";
            this.Label_Room4.Size = new System.Drawing.Size(77, 29);
            this.Label_Room4.TabIndex = 3;
            this.Label_Room4.Text = "Room4";
            this.Label_Room4.Click += new System.EventHandler(this.Label_Room4_Click);
            // 
            // Label_Room8
            // 
            this.Label_Room8.AutoSize = true;
            this.Label_Room8.BackColor = System.Drawing.Color.Transparent;
            this.Label_Room8.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Room8.Location = new System.Drawing.Point(1203, 492);
            this.Label_Room8.Name = "Label_Room8";
            this.Label_Room8.Size = new System.Drawing.Size(77, 29);
            this.Label_Room8.TabIndex = 7;
            this.Label_Room8.Text = "Room8";
            this.Label_Room8.Click += new System.EventHandler(this.Label_Room8_Click);
            // 
            // Label_Room7
            // 
            this.Label_Room7.AutoSize = true;
            this.Label_Room7.BackColor = System.Drawing.Color.Transparent;
            this.Label_Room7.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Room7.Location = new System.Drawing.Point(877, 492);
            this.Label_Room7.Name = "Label_Room7";
            this.Label_Room7.Size = new System.Drawing.Size(77, 29);
            this.Label_Room7.TabIndex = 6;
            this.Label_Room7.Text = "Room7";
            this.Label_Room7.Click += new System.EventHandler(this.Label_Room7_Click);
            // 
            // Label_Room6
            // 
            this.Label_Room6.AutoSize = true;
            this.Label_Room6.BackColor = System.Drawing.Color.Transparent;
            this.Label_Room6.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Room6.Location = new System.Drawing.Point(552, 492);
            this.Label_Room6.Name = "Label_Room6";
            this.Label_Room6.Size = new System.Drawing.Size(77, 29);
            this.Label_Room6.TabIndex = 5;
            this.Label_Room6.Text = "Room6";
            this.Label_Room6.Click += new System.EventHandler(this.Label_Room6_Click);
            // 
            // Label_Room5
            // 
            this.Label_Room5.AutoSize = true;
            this.Label_Room5.BackColor = System.Drawing.Color.Transparent;
            this.Label_Room5.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Room5.Location = new System.Drawing.Point(224, 492);
            this.Label_Room5.Name = "Label_Room5";
            this.Label_Room5.Size = new System.Drawing.Size(77, 29);
            this.Label_Room5.TabIndex = 4;
            this.Label_Room5.Text = "Room5";
            this.Label_Room5.Click += new System.EventHandler(this.Label_Room5_Click);
            // 
            // Label_Status4
            // 
            this.Label_Status4.AutoSize = true;
            this.Label_Status4.BackColor = System.Drawing.Color.Transparent;
            this.Label_Status4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Status4.Location = new System.Drawing.Point(1191, 276);
            this.Label_Status4.Name = "Label_Status4";
            this.Label_Status4.Size = new System.Drawing.Size(77, 29);
            this.Label_Status4.TabIndex = 11;
            this.Label_Status4.Text = "Room4";
            // 
            // Label_Status3
            // 
            this.Label_Status3.AutoSize = true;
            this.Label_Status3.BackColor = System.Drawing.Color.Transparent;
            this.Label_Status3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Status3.Location = new System.Drawing.Point(864, 276);
            this.Label_Status3.Name = "Label_Status3";
            this.Label_Status3.Size = new System.Drawing.Size(77, 29);
            this.Label_Status3.TabIndex = 10;
            this.Label_Status3.Text = "Room3";
            // 
            // Label_Status2
            // 
            this.Label_Status2.AutoSize = true;
            this.Label_Status2.BackColor = System.Drawing.Color.Transparent;
            this.Label_Status2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Status2.Location = new System.Drawing.Point(540, 276);
            this.Label_Status2.Name = "Label_Status2";
            this.Label_Status2.Size = new System.Drawing.Size(77, 29);
            this.Label_Status2.TabIndex = 9;
            this.Label_Status2.Text = "Room2";
            // 
            // Label_Status1
            // 
            this.Label_Status1.AutoSize = true;
            this.Label_Status1.BackColor = System.Drawing.Color.Transparent;
            this.Label_Status1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Status1.Location = new System.Drawing.Point(212, 276);
            this.Label_Status1.Name = "Label_Status1";
            this.Label_Status1.Size = new System.Drawing.Size(73, 29);
            this.Label_Status1.TabIndex = 8;
            this.Label_Status1.Text = "Room1";
            // 
            // Label_Status8
            // 
            this.Label_Status8.AutoSize = true;
            this.Label_Status8.BackColor = System.Drawing.Color.Transparent;
            this.Label_Status8.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Status8.Location = new System.Drawing.Point(1190, 524);
            this.Label_Status8.Name = "Label_Status8";
            this.Label_Status8.Size = new System.Drawing.Size(77, 29);
            this.Label_Status8.TabIndex = 15;
            this.Label_Status8.Text = "Room4";
            // 
            // Label_Status7
            // 
            this.Label_Status7.AutoSize = true;
            this.Label_Status7.BackColor = System.Drawing.Color.Transparent;
            this.Label_Status7.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Status7.Location = new System.Drawing.Point(864, 524);
            this.Label_Status7.Name = "Label_Status7";
            this.Label_Status7.Size = new System.Drawing.Size(77, 29);
            this.Label_Status7.TabIndex = 14;
            this.Label_Status7.Text = "Room3";
            // 
            // Label_Status6
            // 
            this.Label_Status6.AutoSize = true;
            this.Label_Status6.BackColor = System.Drawing.Color.Transparent;
            this.Label_Status6.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Status6.Location = new System.Drawing.Point(538, 524);
            this.Label_Status6.Name = "Label_Status6";
            this.Label_Status6.Size = new System.Drawing.Size(77, 29);
            this.Label_Status6.TabIndex = 13;
            this.Label_Status6.Text = "Room2";
            // 
            // Label_Status5
            // 
            this.Label_Status5.AutoSize = true;
            this.Label_Status5.BackColor = System.Drawing.Color.Transparent;
            this.Label_Status5.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Status5.Location = new System.Drawing.Point(212, 524);
            this.Label_Status5.Name = "Label_Status5";
            this.Label_Status5.Size = new System.Drawing.Size(73, 29);
            this.Label_Status5.TabIndex = 12;
            this.Label_Status5.Text = "Room1";
            // 
            // DTP_NgayTim
            // 
            this.DTP_NgayTim.Location = new System.Drawing.Point(727, 165);
            this.DTP_NgayTim.Name = "DTP_NgayTim";
            this.DTP_NgayTim.Size = new System.Drawing.Size(195, 20);
            this.DTP_NgayTim.TabIndex = 17;
            // 
            // ComboBox_TypeRoom
            // 
            this.ComboBox_TypeRoom.FormattingEnabled = true;
            this.ComboBox_TypeRoom.Location = new System.Drawing.Point(946, 164);
            this.ComboBox_TypeRoom.Name = "ComboBox_TypeRoom";
            this.ComboBox_TypeRoom.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_TypeRoom.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1082, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 20;
            this.button1.Text = "Lọc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_Loc_Click);
            // 
            // Form_ListRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Management_Hotel.Properties.Resources.BackgroundListRoom;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ComboBox_TypeRoom);
            this.Controls.Add(this.DTP_NgayTim);
            this.Controls.Add(this.Label_Status8);
            this.Controls.Add(this.Label_Status7);
            this.Controls.Add(this.Label_Status6);
            this.Controls.Add(this.Label_Status5);
            this.Controls.Add(this.Label_Status4);
            this.Controls.Add(this.Label_Status3);
            this.Controls.Add(this.Label_Status2);
            this.Controls.Add(this.Label_Status1);
            this.Controls.Add(this.Label_Room8);
            this.Controls.Add(this.Label_Room7);
            this.Controls.Add(this.Label_Room6);
            this.Controls.Add(this.Label_Room5);
            this.Controls.Add(this.Label_Room4);
            this.Controls.Add(this.Label_Room3);
            this.Controls.Add(this.Label_Room2);
            this.Controls.Add(this.Label_Room1);
            this.Name = "Form_ListRooms";
            this.Text = "Danh sách các phòng";
            this.Load += new System.EventHandler(this.Form_ListRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagementDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Hotel_ManagementDataSet hotel_ManagementDataSet;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private Hotel_ManagementDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.Label Label_Room1;
        private System.Windows.Forms.Label Label_Room2;
        private System.Windows.Forms.Label Label_Room3;
        private System.Windows.Forms.Label Label_Room4;
        private System.Windows.Forms.Label Label_Room8;
        private System.Windows.Forms.Label Label_Room7;
        private System.Windows.Forms.Label Label_Room6;
        private System.Windows.Forms.Label Label_Room5;
        private System.Windows.Forms.Label Label_Status4;
        private System.Windows.Forms.Label Label_Status3;
        private System.Windows.Forms.Label Label_Status2;
        private System.Windows.Forms.Label Label_Status1;
        private System.Windows.Forms.Label Label_Status8;
        private System.Windows.Forms.Label Label_Status7;
        private System.Windows.Forms.Label Label_Status6;
        private System.Windows.Forms.Label Label_Status5;
        private System.Windows.Forms.DateTimePicker DTP_NgayTim;
        private System.Windows.Forms.ComboBox ComboBox_TypeRoom;
        private System.Windows.Forms.Button button1;
    }
}