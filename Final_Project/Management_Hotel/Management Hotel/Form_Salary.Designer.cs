namespace Management_Hotel
{
    partial class Form_Salary
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
            this.DataGridView_Schedule = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TB_End = new System.Windows.Forms.TextBox();
            this.TB_Start = new System.Windows.Forms.TextBox();
            this.DTP_Schedule = new System.Windows.Forms.DateTimePicker();
            this.Button_Add = new System.Windows.Forms.Button();
            this.IDcomboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Schedule)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView_Schedule
            // 
            this.DataGridView_Schedule.BackgroundColor = System.Drawing.Color.Linen;
            this.DataGridView_Schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Schedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DataGridView_Schedule.Location = new System.Drawing.Point(436, 320);
            this.DataGridView_Schedule.Name = "DataGridView_Schedule";
            this.DataGridView_Schedule.Size = new System.Drawing.Size(445, 392);
            this.DataGridView_Schedule.TabIndex = 3;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ID";
            this.Column2.HeaderText = "Mã Nhân Viên";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "StartSchedule";
            this.Column4.HeaderText = "Giờ bắt đầu";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "EndSchedule";
            this.Column5.HeaderText = "Giờ kết thúc";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "DateWork";
            this.Column6.HeaderText = "Ngày làm việc";
            this.Column6.Name = "Column6";
            // 
            // TB_End
            // 
            this.TB_End.BackColor = System.Drawing.Color.Linen;
            this.TB_End.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TB_End.Location = new System.Drawing.Point(432, 247);
            this.TB_End.Multiline = true;
            this.TB_End.Name = "TB_End";
            this.TB_End.Size = new System.Drawing.Size(200, 30);
            this.TB_End.TabIndex = 79;
            // 
            // TB_Start
            // 
            this.TB_Start.BackColor = System.Drawing.Color.Linen;
            this.TB_Start.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TB_Start.Location = new System.Drawing.Point(431, 207);
            this.TB_Start.Multiline = true;
            this.TB_Start.Name = "TB_Start";
            this.TB_Start.Size = new System.Drawing.Size(200, 30);
            this.TB_Start.TabIndex = 80;
            // 
            // DTP_Schedule
            // 
            this.DTP_Schedule.Location = new System.Drawing.Point(432, 287);
            this.DTP_Schedule.Name = "DTP_Schedule";
            this.DTP_Schedule.Size = new System.Drawing.Size(200, 20);
            this.DTP_Schedule.TabIndex = 81;
            // 
            // Button_Add
            // 
            this.Button_Add.BackColor = System.Drawing.Color.Tan;
            this.Button_Add.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Add.Location = new System.Drawing.Point(661, 278);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(100, 35);
            this.Button_Add.TabIndex = 93;
            this.Button_Add.Text = "Thêm";
            this.Button_Add.UseVisualStyleBackColor = false;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // IDcomboBox
            // 
            this.IDcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.IDcomboBox.FormattingEnabled = true;
            this.IDcomboBox.Location = new System.Drawing.Point(432, 177);
            this.IDcomboBox.Name = "IDcomboBox";
            this.IDcomboBox.Size = new System.Drawing.Size(200, 24);
            this.IDcomboBox.TabIndex = 94;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tan;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(767, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 95;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button_Edit_Click);
            // 
            // Form_Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Management_Hotel.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IDcomboBox);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.DTP_Schedule);
            this.Controls.Add(this.TB_Start);
            this.Controls.Add(this.TB_End);
            this.Controls.Add(this.DataGridView_Schedule);
            this.Name = "Form_Salary";
            this.Text = "Form_Salary";
            this.Load += new System.EventHandler(this.Form_Salary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Schedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DataGridView_Schedule;
        private System.Windows.Forms.TextBox TB_End;
        private System.Windows.Forms.TextBox TB_Start;
        private System.Windows.Forms.DateTimePicker DTP_Schedule;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.ComboBox IDcomboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button button1;
    }
}