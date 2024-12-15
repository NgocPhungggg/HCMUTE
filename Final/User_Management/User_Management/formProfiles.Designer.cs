namespace User_Management
{
    partial class formProfiles
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
            this.button_Back = new System.Windows.Forms.Button();
            this.uSERPROFILEINFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetOracle = new User_Management.DataSetOracle();
            this.uSER_PROFILE_INFOTableAdapter = new User_Management.DataSetOracleTableAdapters.USER_PROFILE_INFOTableAdapter();
            this.dgvListProfile = new System.Windows.Forms.DataGridView();
            this.PROFILE2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInfoProfile = new System.Windows.Forms.DataGridView();
            this.PROFILE1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RESOURCE_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LIMIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUserProfile = new System.Windows.Forms.DataGridView();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROFILE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.IdleDefaultradioButton = new System.Windows.Forms.RadioButton();
            this.IdleUnlimitradioButton = new System.Windows.Forms.RadioButton();
            this.IdletextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ConDefaultradioButton = new System.Windows.Forms.RadioButton();
            this.ConUnlimitradioButton = new System.Windows.Forms.RadioButton();
            this.ContextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SesDefaultradioButton = new System.Windows.Forms.RadioButton();
            this.SesUnlimitradioButton = new System.Windows.Forms.RadioButton();
            this.SestextBox = new System.Windows.Forms.TextBox();
            this.Reloadbutton = new System.Windows.Forms.Button();
            this.huyButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.IdleTimelabel = new System.Windows.Forms.Label();
            this.txtprofile = new System.Windows.Forms.TextBox();
            this.ConnectTimelabel = new System.Windows.Forms.Label();
            this.Sessionlabel = new System.Windows.Forms.Label();
            this.Profilelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uSERPROFILEINFOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOracle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserProfile)).BeginInit();
            this.panel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Back
            // 
            this.button_Back.BackgroundImage = global::User_Management.Properties.Resources.button_Back;
            this.button_Back.Location = new System.Drawing.Point(1227, 676);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(120, 50);
            this.button_Back.TabIndex = 8;
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // uSERPROFILEINFOBindingSource
            // 
            this.uSERPROFILEINFOBindingSource.DataMember = "USER_PROFILE_INFO";
            this.uSERPROFILEINFOBindingSource.DataSource = this.dataSetOracle;
            // 
            // dataSetOracle
            // 
            this.dataSetOracle.DataSetName = "DataSetOracle";
            this.dataSetOracle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSER_PROFILE_INFOTableAdapter
            // 
            this.uSER_PROFILE_INFOTableAdapter.ClearBeforeFill = true;
            // 
            // dgvListProfile
            // 
            this.dgvListProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListProfile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PROFILE2});
            this.dgvListProfile.Location = new System.Drawing.Point(759, 223);
            this.dgvListProfile.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListProfile.Name = "dgvListProfile";
            this.dgvListProfile.RowHeadersVisible = false;
            this.dgvListProfile.RowHeadersWidth = 82;
            this.dgvListProfile.RowTemplate.Height = 33;
            this.dgvListProfile.Size = new System.Drawing.Size(158, 196);
            this.dgvListProfile.TabIndex = 125;
            this.dgvListProfile.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // PROFILE2
            // 
            this.PROFILE2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PROFILE2.DataPropertyName = "PROFILE";
            this.PROFILE2.HeaderText = "PROFILE";
            this.PROFILE2.MinimumWidth = 120;
            this.PROFILE2.Name = "PROFILE2";
            this.PROFILE2.Width = 120;
            // 
            // dgvInfoProfile
            // 
            this.dgvInfoProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoProfile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PROFILE1,
            this.RESOURCE_NAME,
            this.LIMIT});
            this.dgvInfoProfile.Location = new System.Drawing.Point(759, 423);
            this.dgvInfoProfile.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInfoProfile.Name = "dgvInfoProfile";
            this.dgvInfoProfile.RowHeadersVisible = false;
            this.dgvInfoProfile.RowHeadersWidth = 82;
            this.dgvInfoProfile.RowTemplate.Height = 33;
            this.dgvInfoProfile.Size = new System.Drawing.Size(491, 215);
            this.dgvInfoProfile.TabIndex = 124;
            this.dgvInfoProfile.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfoProfile_CellContentClick);
            // 
            // PROFILE1
            // 
            this.PROFILE1.DataPropertyName = "PROFILE";
            this.PROFILE1.HeaderText = "PROFILE";
            this.PROFILE1.MinimumWidth = 120;
            this.PROFILE1.Name = "PROFILE1";
            this.PROFILE1.Width = 120;
            // 
            // RESOURCE_NAME
            // 
            this.RESOURCE_NAME.DataPropertyName = "RESOURCE_NAME";
            this.RESOURCE_NAME.HeaderText = "RESOURCE_NAME";
            this.RESOURCE_NAME.MinimumWidth = 200;
            this.RESOURCE_NAME.Name = "RESOURCE_NAME";
            this.RESOURCE_NAME.Width = 200;
            // 
            // LIMIT
            // 
            this.LIMIT.DataPropertyName = "LIMIT";
            this.LIMIT.HeaderText = "LIMIT";
            this.LIMIT.MinimumWidth = 120;
            this.LIMIT.Name = "LIMIT";
            this.LIMIT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.LIMIT.Width = 120;
            // 
            // dgvUserProfile
            // 
            this.dgvUserProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserProfile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User,
            this.PROFILE});
            this.dgvUserProfile.Location = new System.Drawing.Point(921, 223);
            this.dgvUserProfile.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUserProfile.Name = "dgvUserProfile";
            this.dgvUserProfile.RowHeadersVisible = false;
            this.dgvUserProfile.RowHeadersWidth = 82;
            this.dgvUserProfile.RowTemplate.Height = 33;
            this.dgvUserProfile.Size = new System.Drawing.Size(329, 196);
            this.dgvUserProfile.TabIndex = 123;
            // 
            // User
            // 
            this.User.DataPropertyName = "USERNAME";
            this.User.HeaderText = "USERNAME";
            this.User.MinimumWidth = 120;
            this.User.Name = "User";
            this.User.Width = 120;
            // 
            // PROFILE
            // 
            this.PROFILE.DataPropertyName = "PROFILE";
            this.PROFILE.FillWeight = 200F;
            this.PROFILE.HeaderText = "PROFILE";
            this.PROFILE.MinimumWidth = 200;
            this.PROFILE.Name = "PROFILE";
            this.PROFILE.Width = 200;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Controls.Add(this.groupBox3);
            this.panel.Controls.Add(this.groupBox2);
            this.panel.Controls.Add(this.groupBox1);
            this.panel.Controls.Add(this.Reloadbutton);
            this.panel.Controls.Add(this.huyButton);
            this.panel.Controls.Add(this.saveButton);
            this.panel.Controls.Add(this.addButton);
            this.panel.Controls.Add(this.removeButton);
            this.panel.Controls.Add(this.editButton);
            this.panel.Controls.Add(this.IdleTimelabel);
            this.panel.Controls.Add(this.txtprofile);
            this.panel.Controls.Add(this.ConnectTimelabel);
            this.panel.Controls.Add(this.Sessionlabel);
            this.panel.Controls.Add(this.Profilelabel);
            this.panel.Location = new System.Drawing.Point(284, 244);
            this.panel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(436, 394);
            this.panel.TabIndex = 122;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.IdleDefaultradioButton);
            this.groupBox3.Controls.Add(this.IdleUnlimitradioButton);
            this.groupBox3.Controls.Add(this.IdletextBox);
            this.groupBox3.Location = new System.Drawing.Point(145, 229);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(261, 52);
            this.groupBox3.TabIndex = 151;
            this.groupBox3.TabStop = false;
            // 
            // IdleDefaultradioButton
            // 
            this.IdleDefaultradioButton.AutoSize = true;
            this.IdleDefaultradioButton.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdleDefaultradioButton.ForeColor = System.Drawing.Color.White;
            this.IdleDefaultradioButton.Location = new System.Drawing.Point(12, 16);
            this.IdleDefaultradioButton.Margin = new System.Windows.Forms.Padding(2);
            this.IdleDefaultradioButton.Name = "IdleDefaultradioButton";
            this.IdleDefaultradioButton.Size = new System.Drawing.Size(76, 24);
            this.IdleDefaultradioButton.TabIndex = 127;
            this.IdleDefaultradioButton.TabStop = true;
            this.IdleDefaultradioButton.Text = "Default";
            this.IdleDefaultradioButton.UseVisualStyleBackColor = true;
            this.IdleDefaultradioButton.CheckedChanged += new System.EventHandler(this.IdleDefaultradioButton_CheckedChanged);
            // 
            // IdleUnlimitradioButton
            // 
            this.IdleUnlimitradioButton.AutoSize = true;
            this.IdleUnlimitradioButton.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdleUnlimitradioButton.ForeColor = System.Drawing.Color.White;
            this.IdleUnlimitradioButton.Location = new System.Drawing.Point(90, 16);
            this.IdleUnlimitradioButton.Margin = new System.Windows.Forms.Padding(2);
            this.IdleUnlimitradioButton.Name = "IdleUnlimitradioButton";
            this.IdleUnlimitradioButton.Size = new System.Drawing.Size(92, 24);
            this.IdleUnlimitradioButton.TabIndex = 128;
            this.IdleUnlimitradioButton.TabStop = true;
            this.IdleUnlimitradioButton.Text = "Unlimited";
            this.IdleUnlimitradioButton.UseVisualStyleBackColor = true;
            this.IdleUnlimitradioButton.CheckedChanged += new System.EventHandler(this.IdleUnlimitradioButton_CheckedChanged);
            // 
            // IdletextBox
            // 
            this.IdletextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdletextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdletextBox.Location = new System.Drawing.Point(180, 12);
            this.IdletextBox.Name = "IdletextBox";
            this.IdletextBox.Size = new System.Drawing.Size(54, 29);
            this.IdletextBox.TabIndex = 129;
            this.IdletextBox.TextChanged += new System.EventHandler(this.IdletextBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ConDefaultradioButton);
            this.groupBox2.Controls.Add(this.ConUnlimitradioButton);
            this.groupBox2.Controls.Add(this.ContextBox);
            this.groupBox2.Location = new System.Drawing.Point(145, 145);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(261, 57);
            this.groupBox2.TabIndex = 150;
            this.groupBox2.TabStop = false;
            // 
            // ConDefaultradioButton
            // 
            this.ConDefaultradioButton.AutoSize = true;
            this.ConDefaultradioButton.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConDefaultradioButton.ForeColor = System.Drawing.Color.White;
            this.ConDefaultradioButton.Location = new System.Drawing.Point(8, 16);
            this.ConDefaultradioButton.Margin = new System.Windows.Forms.Padding(2);
            this.ConDefaultradioButton.Name = "ConDefaultradioButton";
            this.ConDefaultradioButton.Size = new System.Drawing.Size(76, 24);
            this.ConDefaultradioButton.TabIndex = 124;
            this.ConDefaultradioButton.TabStop = true;
            this.ConDefaultradioButton.Text = "Default";
            this.ConDefaultradioButton.UseVisualStyleBackColor = true;
            this.ConDefaultradioButton.CheckedChanged += new System.EventHandler(this.ConDefaultradioButton_CheckedChanged);
            // 
            // ConUnlimitradioButton
            // 
            this.ConUnlimitradioButton.AutoSize = true;
            this.ConUnlimitradioButton.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConUnlimitradioButton.ForeColor = System.Drawing.Color.White;
            this.ConUnlimitradioButton.Location = new System.Drawing.Point(88, 16);
            this.ConUnlimitradioButton.Margin = new System.Windows.Forms.Padding(2);
            this.ConUnlimitradioButton.Name = "ConUnlimitradioButton";
            this.ConUnlimitradioButton.Size = new System.Drawing.Size(92, 24);
            this.ConUnlimitradioButton.TabIndex = 125;
            this.ConUnlimitradioButton.TabStop = true;
            this.ConUnlimitradioButton.Text = "Unlimited";
            this.ConUnlimitradioButton.UseVisualStyleBackColor = true;
            this.ConUnlimitradioButton.CheckedChanged += new System.EventHandler(this.ConUnlimitradioButton_CheckedChanged);
            // 
            // ContextBox
            // 
            this.ContextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContextBox.Location = new System.Drawing.Point(178, 12);
            this.ContextBox.Name = "ContextBox";
            this.ContextBox.Size = new System.Drawing.Size(54, 29);
            this.ContextBox.TabIndex = 126;
            this.ContextBox.TextChanged += new System.EventHandler(this.ContextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SesDefaultradioButton);
            this.groupBox1.Controls.Add(this.SesUnlimitradioButton);
            this.groupBox1.Controls.Add(this.SestextBox);
            this.groupBox1.Location = new System.Drawing.Point(145, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(261, 53);
            this.groupBox1.TabIndex = 149;
            this.groupBox1.TabStop = false;
            // 
            // SesDefaultradioButton
            // 
            this.SesDefaultradioButton.AutoSize = true;
            this.SesDefaultradioButton.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SesDefaultradioButton.ForeColor = System.Drawing.Color.White;
            this.SesDefaultradioButton.Location = new System.Drawing.Point(9, 16);
            this.SesDefaultradioButton.Margin = new System.Windows.Forms.Padding(2);
            this.SesDefaultradioButton.Name = "SesDefaultradioButton";
            this.SesDefaultradioButton.Size = new System.Drawing.Size(76, 24);
            this.SesDefaultradioButton.TabIndex = 121;
            this.SesDefaultradioButton.TabStop = true;
            this.SesDefaultradioButton.Text = "Default";
            this.SesDefaultradioButton.UseVisualStyleBackColor = true;
            this.SesDefaultradioButton.CheckedChanged += new System.EventHandler(this.SesDefaultradioButton_CheckedChanged);
            // 
            // SesUnlimitradioButton
            // 
            this.SesUnlimitradioButton.AutoSize = true;
            this.SesUnlimitradioButton.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SesUnlimitradioButton.ForeColor = System.Drawing.Color.White;
            this.SesUnlimitradioButton.Location = new System.Drawing.Point(90, 16);
            this.SesUnlimitradioButton.Margin = new System.Windows.Forms.Padding(2);
            this.SesUnlimitradioButton.Name = "SesUnlimitradioButton";
            this.SesUnlimitradioButton.Size = new System.Drawing.Size(92, 24);
            this.SesUnlimitradioButton.TabIndex = 122;
            this.SesUnlimitradioButton.TabStop = true;
            this.SesUnlimitradioButton.Text = "Unlimited";
            this.SesUnlimitradioButton.UseVisualStyleBackColor = true;
            this.SesUnlimitradioButton.CheckedChanged += new System.EventHandler(this.SesUnlimitradioButton_CheckedChanged);
            // 
            // SestextBox
            // 
            this.SestextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SestextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SestextBox.Location = new System.Drawing.Point(180, 14);
            this.SestextBox.Name = "SestextBox";
            this.SestextBox.Size = new System.Drawing.Size(54, 29);
            this.SestextBox.TabIndex = 123;
            this.SestextBox.TextChanged += new System.EventHandler(this.SestextBox_TextChanged);
            // 
            // Reloadbutton
            // 
            this.Reloadbutton.BackColor = System.Drawing.Color.CadetBlue;
            this.Reloadbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reloadbutton.ForeColor = System.Drawing.Color.White;
            this.Reloadbutton.Location = new System.Drawing.Point(293, 346);
            this.Reloadbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Reloadbutton.Name = "Reloadbutton";
            this.Reloadbutton.Size = new System.Drawing.Size(84, 37);
            this.Reloadbutton.TabIndex = 148;
            this.Reloadbutton.Text = "Reload";
            this.Reloadbutton.UseVisualStyleBackColor = false;
            this.Reloadbutton.Click += new System.EventHandler(this.Reloadbutton_Click);
            // 
            // huyButton
            // 
            this.huyButton.BackColor = System.Drawing.Color.IndianRed;
            this.huyButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huyButton.ForeColor = System.Drawing.Color.White;
            this.huyButton.Location = new System.Drawing.Point(173, 346);
            this.huyButton.Margin = new System.Windows.Forms.Padding(2);
            this.huyButton.Name = "huyButton";
            this.huyButton.Size = new System.Drawing.Size(84, 37);
            this.huyButton.TabIndex = 147;
            this.huyButton.Text = "Hủy";
            this.huyButton.UseVisualStyleBackColor = false;
            this.huyButton.Click += new System.EventHandler(this.huyButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.CadetBlue;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(39, 346);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(84, 37);
            this.saveButton.TabIndex = 146;
            this.saveButton.Text = "Lưu";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.addButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(39, 305);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(84, 37);
            this.addButton.TabIndex = 145;
            this.addButton.Text = "Thêm";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.IndianRed;
            this.removeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.Color.White;
            this.removeButton.Location = new System.Drawing.Point(293, 305);
            this.removeButton.Margin = new System.Windows.Forms.Padding(2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(84, 37);
            this.removeButton.TabIndex = 144;
            this.removeButton.Text = "Xóa";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.CadetBlue;
            this.editButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(173, 305);
            this.editButton.Margin = new System.Windows.Forms.Padding(2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(84, 37);
            this.editButton.TabIndex = 143;
            this.editButton.Text = "Sửa";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // IdleTimelabel
            // 
            this.IdleTimelabel.AutoSize = true;
            this.IdleTimelabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdleTimelabel.ForeColor = System.Drawing.Color.White;
            this.IdleTimelabel.Location = new System.Drawing.Point(10, 243);
            this.IdleTimelabel.Name = "IdleTimelabel";
            this.IdleTimelabel.Size = new System.Drawing.Size(78, 21);
            this.IdleTimelabel.TabIndex = 106;
            this.IdleTimelabel.Text = "Idle_time";
            // 
            // txtprofile
            // 
            this.txtprofile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprofile.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprofile.Location = new System.Drawing.Point(154, 18);
            this.txtprofile.Name = "txtprofile";
            this.txtprofile.Size = new System.Drawing.Size(168, 29);
            this.txtprofile.TabIndex = 95;
            // 
            // ConnectTimelabel
            // 
            this.ConnectTimelabel.AutoSize = true;
            this.ConnectTimelabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectTimelabel.ForeColor = System.Drawing.Color.White;
            this.ConnectTimelabel.Location = new System.Drawing.Point(8, 162);
            this.ConnectTimelabel.Name = "ConnectTimelabel";
            this.ConnectTimelabel.Size = new System.Drawing.Size(111, 21);
            this.ConnectTimelabel.TabIndex = 86;
            this.ConnectTimelabel.Text = "Connect_time";
            // 
            // Sessionlabel
            // 
            this.Sessionlabel.AutoSize = true;
            this.Sessionlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sessionlabel.ForeColor = System.Drawing.Color.White;
            this.Sessionlabel.Location = new System.Drawing.Point(8, 86);
            this.Sessionlabel.Name = "Sessionlabel";
            this.Sessionlabel.Size = new System.Drawing.Size(142, 21);
            this.Sessionlabel.TabIndex = 87;
            this.Sessionlabel.Text = "Sessions_per_user";
            // 
            // Profilelabel
            // 
            this.Profilelabel.AutoSize = true;
            this.Profilelabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profilelabel.ForeColor = System.Drawing.Color.White;
            this.Profilelabel.Location = new System.Drawing.Point(8, 19);
            this.Profilelabel.Name = "Profilelabel";
            this.Profilelabel.Size = new System.Drawing.Size(87, 21);
            this.Profilelabel.TabIndex = 87;
            this.Profilelabel.Text = "Tên Profile";
            this.Profilelabel.UseMnemonic = false;
            // 
            // formProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::User_Management.Properties.Resources.backgroundProfiles;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.dgvListProfile);
            this.Controls.Add(this.dgvInfoProfile);
            this.Controls.Add(this.dgvUserProfile);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.button_Back);
            this.Name = "formProfiles";
            this.Text = "formProfiles";
            this.Load += new System.EventHandler(this.formProfiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uSERPROFILEINFOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOracle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserProfile)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Back;
        private DataSetOracle dataSetOracle;
        private System.Windows.Forms.BindingSource uSERPROFILEINFOBindingSource;
        private DataSetOracleTableAdapters.USER_PROFILE_INFOTableAdapter uSER_PROFILE_INFOTableAdapter;
        private System.Windows.Forms.DataGridView dgvListProfile;
        private System.Windows.Forms.DataGridView dgvInfoProfile;
        private System.Windows.Forms.DataGridView dgvUserProfile;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.RadioButton IdleDefaultradioButton;
        public System.Windows.Forms.RadioButton IdleUnlimitradioButton;
        private System.Windows.Forms.TextBox IdletextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.RadioButton ConDefaultradioButton;
        public System.Windows.Forms.RadioButton ConUnlimitradioButton;
        private System.Windows.Forms.TextBox ContextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton SesDefaultradioButton;
        public System.Windows.Forms.RadioButton SesUnlimitradioButton;
        private System.Windows.Forms.TextBox SestextBox;
        private System.Windows.Forms.Button Reloadbutton;
        private System.Windows.Forms.Button huyButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label IdleTimelabel;
        private System.Windows.Forms.TextBox txtprofile;
        private System.Windows.Forms.Label ConnectTimelabel;
        private System.Windows.Forms.Label Sessionlabel;
        private System.Windows.Forms.Label Profilelabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROFILE2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROFILE1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RESOURCE_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn LIMIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROFILE;
    }
}