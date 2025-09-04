namespace User_Management
{
    partial class formAudit
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
            this.dgvAudit = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel = new System.Windows.Forms.Panel();
            this.ActiontextBox = new System.Windows.Forms.TextBox();
            this.ObjtextBox = new System.Windows.Forms.TextBox();
            this.timetextBox = new System.Windows.Forms.TextBox();
            this.Actionlabel = new System.Windows.Forms.Label();
            this.usertextBox = new System.Windows.Forms.TextBox();
            this.Objlabel = new System.Windows.Forms.Label();
            this.Timelabel = new System.Windows.Forms.Label();
            this.Userlabel = new System.Windows.Forms.Label();
            this.button_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudit)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAudit
            // 
            this.dgvAudit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAudit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvAudit.Location = new System.Drawing.Point(814, 250);
            this.dgvAudit.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAudit.Name = "dgvAudit";
            this.dgvAudit.RowHeadersVisible = false;
            this.dgvAudit.RowHeadersWidth = 82;
            this.dgvAudit.RowTemplate.Height = 33;
            this.dgvAudit.Size = new System.Drawing.Size(418, 353);
            this.dgvAudit.TabIndex = 121;
            this.dgvAudit.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAudit_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.DataPropertyName = "USERNAME";
            this.Column1.HeaderText = "USERNAME";
            this.Column1.MinimumWidth = 100;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column2.DataPropertyName = "TIMESTAMP";
            this.Column2.HeaderText = "TIMESTAMP";
            this.Column2.MinimumWidth = 100;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column3.DataPropertyName = "OBJ_NAME";
            this.Column3.HeaderText = "OBJ_NAME";
            this.Column3.MinimumWidth = 100;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column4.DataPropertyName = "ACTION_NAME";
            this.Column4.HeaderText = "ACTION_NAME";
            this.Column4.MinimumWidth = 100;
            this.Column4.Name = "Column4";
            this.Column4.Width = 109;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Controls.Add(this.ActiontextBox);
            this.panel.Controls.Add(this.ObjtextBox);
            this.panel.Controls.Add(this.timetextBox);
            this.panel.Controls.Add(this.Actionlabel);
            this.panel.Controls.Add(this.usertextBox);
            this.panel.Controls.Add(this.Objlabel);
            this.panel.Controls.Add(this.Timelabel);
            this.panel.Controls.Add(this.Userlabel);
            this.panel.Location = new System.Drawing.Point(379, 250);
            this.panel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(356, 353);
            this.panel.TabIndex = 120;
            // 
            // ActiontextBox
            // 
            this.ActiontextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ActiontextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActiontextBox.Location = new System.Drawing.Point(154, 242);
            this.ActiontextBox.Name = "ActiontextBox";
            this.ActiontextBox.Size = new System.Drawing.Size(168, 29);
            this.ActiontextBox.TabIndex = 109;
            // 
            // ObjtextBox
            // 
            this.ObjtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ObjtextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObjtextBox.Location = new System.Drawing.Point(154, 170);
            this.ObjtextBox.Name = "ObjtextBox";
            this.ObjtextBox.Size = new System.Drawing.Size(168, 29);
            this.ObjtextBox.TabIndex = 108;
            // 
            // timetextBox
            // 
            this.timetextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timetextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timetextBox.Location = new System.Drawing.Point(154, 86);
            this.timetextBox.Name = "timetextBox";
            this.timetextBox.Size = new System.Drawing.Size(168, 29);
            this.timetextBox.TabIndex = 107;
            // 
            // Actionlabel
            // 
            this.Actionlabel.AutoSize = true;
            this.Actionlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actionlabel.ForeColor = System.Drawing.Color.White;
            this.Actionlabel.Location = new System.Drawing.Point(10, 243);
            this.Actionlabel.Name = "Actionlabel";
            this.Actionlabel.Size = new System.Drawing.Size(102, 21);
            this.Actionlabel.TabIndex = 106;
            this.Actionlabel.Text = "Action name";
            // 
            // usertextBox
            // 
            this.usertextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usertextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertextBox.Location = new System.Drawing.Point(154, 18);
            this.usertextBox.Name = "usertextBox";
            this.usertextBox.Size = new System.Drawing.Size(168, 29);
            this.usertextBox.TabIndex = 95;
            // 
            // Objlabel
            // 
            this.Objlabel.AutoSize = true;
            this.Objlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Objlabel.ForeColor = System.Drawing.Color.White;
            this.Objlabel.Location = new System.Drawing.Point(8, 162);
            this.Objlabel.Name = "Objlabel";
            this.Objlabel.Size = new System.Drawing.Size(103, 21);
            this.Objlabel.TabIndex = 86;
            this.Objlabel.Text = "Object name";
            // 
            // Timelabel
            // 
            this.Timelabel.AutoSize = true;
            this.Timelabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timelabel.ForeColor = System.Drawing.Color.White;
            this.Timelabel.Location = new System.Drawing.Point(8, 86);
            this.Timelabel.Name = "Timelabel";
            this.Timelabel.Size = new System.Drawing.Size(46, 21);
            this.Timelabel.TabIndex = 87;
            this.Timelabel.Text = "Time";
            // 
            // Userlabel
            // 
            this.Userlabel.AutoSize = true;
            this.Userlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Userlabel.ForeColor = System.Drawing.Color.White;
            this.Userlabel.Location = new System.Drawing.Point(8, 19);
            this.Userlabel.Name = "Userlabel";
            this.Userlabel.Size = new System.Drawing.Size(72, 21);
            this.Userlabel.TabIndex = 87;
            this.Userlabel.Text = "Tên User";
            this.Userlabel.UseMnemonic = false;
            // 
            // button_Back
            // 
            this.button_Back.BackgroundImage = global::User_Management.Properties.Resources.button_Back;
            this.button_Back.Location = new System.Drawing.Point(1232, 674);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(120, 50);
            this.button_Back.TabIndex = 122;
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // formAudit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::User_Management.Properties.Resources.backgroundNormal;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.dgvAudit);
            this.Controls.Add(this.panel);
            this.Name = "formAudit";
            this.Text = "formAudit";
            this.Load += new System.EventHandler(this.FormAudit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudit)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAudit;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox ActiontextBox;
        private System.Windows.Forms.TextBox ObjtextBox;
        private System.Windows.Forms.TextBox timetextBox;
        private System.Windows.Forms.Label Actionlabel;
        private System.Windows.Forms.TextBox usertextBox;
        private System.Windows.Forms.Label Objlabel;
        private System.Windows.Forms.Label Timelabel;
        private System.Windows.Forms.Label Userlabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button button_Back;
    }
}