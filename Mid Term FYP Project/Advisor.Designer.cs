namespace Mid_Term_FYP_Project
{
    partial class Advisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Advisor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxdesignation = new System.Windows.Forms.ComboBox();
            this.textBoxsalary = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonexit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridViewstudentdetail = new System.Windows.Forms.DataGridView();
            this.buttnupdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btndel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEmailAddress = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.textBoxMobileNo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewstudentdetail)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxdesignation);
            this.groupBox1.Controls.Add(this.textBoxsalary);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 77);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Advisor";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBoxdesignation
            // 
            this.comboBoxdesignation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxdesignation.FormattingEnabled = true;
            this.comboBoxdesignation.Items.AddRange(new object[] {
            "Proffessor",
            "Associate Proffessor",
            "Lecturar",
            "Industry Professional"});
            this.comboBoxdesignation.Location = new System.Drawing.Point(107, 32);
            this.comboBoxdesignation.Name = "comboBoxdesignation";
            this.comboBoxdesignation.Size = new System.Drawing.Size(121, 21);
            this.comboBoxdesignation.TabIndex = 40;
            // 
            // textBoxsalary
            // 
            this.textBoxsalary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxsalary.Location = new System.Drawing.Point(360, 32);
            this.textBoxsalary.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textBoxsalary.Name = "textBoxsalary";
            this.textBoxsalary.Size = new System.Drawing.Size(133, 20);
            this.textBoxsalary.TabIndex = 39;
            this.textBoxsalary.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(283, 35);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Salery";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Designation";
            // 
            // buttonexit
            // 
            this.buttonexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonexit.Location = new System.Drawing.Point(574, 173);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(83, 23);
            this.buttonexit.TabIndex = 46;
            this.buttonexit.Text = "Exit";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(574, 119);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 23);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridViewstudentdetail
            // 
            this.dataGridViewstudentdetail.AllowUserToOrderColumns = true;
            this.dataGridViewstudentdetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewstudentdetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewstudentdetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewstudentdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewstudentdetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buttnupdate,
            this.btndel});
            this.dataGridViewstudentdetail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewstudentdetail.Location = new System.Drawing.Point(12, 202);
            this.dataGridViewstudentdetail.Name = "dataGridViewstudentdetail";
            this.dataGridViewstudentdetail.RowHeadersVisible = false;
            this.dataGridViewstudentdetail.Size = new System.Drawing.Size(711, 257);
            this.dataGridViewstudentdetail.TabIndex = 49;
            this.dataGridViewstudentdetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewstudentdetail_CellContentClick);
            // 
            // buttnupdate
            // 
            this.buttnupdate.HeaderText = "Update";
            this.buttnupdate.Name = "buttnupdate";
            this.buttnupdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.buttnupdate.Text = "Update";
            this.buttnupdate.ToolTipText = "Update";
            this.buttnupdate.UseColumnTextForButtonValue = true;
            // 
            // btndel
            // 
            this.btndel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btndel.HeaderText = "Delete";
            this.btndel.Name = "btndel";
            this.btndel.Text = "Delete";
            this.btndel.ToolTipText = "Delete";
            this.btndel.UseColumnTextForButtonValue = true;
            // 
            // buttonupdate
            // 
            this.buttonupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonupdate.Location = new System.Drawing.Point(574, 144);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(83, 23);
            this.buttonupdate.TabIndex = 50;
            this.buttonupdate.Text = "Update";
            this.buttonupdate.UseVisualStyleBackColor = true;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(89, 25);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(125, 20);
            this.textBoxFirstName.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Last Name";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(307, 25);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(115, 20);
            this.textBoxLastName.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Date of Birth";
            // 
            // textBoxEmailAddress
            // 
            this.textBoxEmailAddress.Location = new System.Drawing.Point(538, 68);
            this.textBoxEmailAddress.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textBoxEmailAddress.Name = "textBoxEmailAddress";
            this.textBoxEmailAddress.Size = new System.Drawing.Size(115, 20);
            this.textBoxEmailAddress.TabIndex = 56;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(538, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(115, 20);
            this.dateTimePicker1.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(461, 71);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "Email Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Mobile No";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(89, 67);
            this.comboBoxGender.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(125, 21);
            this.comboBoxGender.TabIndex = 60;
            // 
            // textBoxMobileNo
            // 
            this.textBoxMobileNo.Location = new System.Drawing.Point(307, 68);
            this.textBoxMobileNo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textBoxMobileNo.Name = "textBoxMobileNo";
            this.textBoxMobileNo.Size = new System.Drawing.Size(115, 20);
            this.textBoxMobileNo.TabIndex = 59;
            // 
            // Advisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxEmailAddress);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.textBoxMobileNo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonupdate);
            this.Controls.Add(this.dataGridViewstudentdetail);
            this.Controls.Add(this.buttonexit);
            this.Name = "Advisor";
            this.Text = "Advisor";
            this.Load += new System.EventHandler(this.Advisor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewstudentdetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textBoxsalary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridViewstudentdetail;
        private System.Windows.Forms.DataGridViewButtonColumn buttnupdate;
        private System.Windows.Forms.DataGridViewButtonColumn btndel;
        private System.Windows.Forms.ComboBox comboBoxdesignation;
        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEmailAddress;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.TextBox textBoxMobileNo;
    }
}