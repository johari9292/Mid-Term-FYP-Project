namespace Mid_Term_FYP_Project
{
    partial class fypmanger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fypmanger));
            this.buttonstudent = new System.Windows.Forms.Button();
            this.buttonadvisorinfo = new System.Windows.Forms.Button();
            this.buttonevalvation = new System.Windows.Forms.Button();
            this.buttonproject = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonstudent
            // 
            this.buttonstudent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonstudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonstudent.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonstudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonstudent.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonstudent.Location = new System.Drawing.Point(12, 304);
            this.buttonstudent.Name = "buttonstudent";
            this.buttonstudent.Size = new System.Drawing.Size(119, 61);
            this.buttonstudent.TabIndex = 0;
            this.buttonstudent.Text = "Student Info center";
            this.buttonstudent.UseVisualStyleBackColor = false;
            this.buttonstudent.Click += new System.EventHandler(this.buttonstudent_Click);
            // 
            // buttonadvisorinfo
            // 
            this.buttonadvisorinfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonadvisorinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonadvisorinfo.Location = new System.Drawing.Point(187, 304);
            this.buttonadvisorinfo.Name = "buttonadvisorinfo";
            this.buttonadvisorinfo.Size = new System.Drawing.Size(138, 61);
            this.buttonadvisorinfo.TabIndex = 1;
            this.buttonadvisorinfo.Text = "Advisor Info Center";
            this.buttonadvisorinfo.UseVisualStyleBackColor = false;
            this.buttonadvisorinfo.Click += new System.EventHandler(this.buttonadvisorinfo_Click);
            // 
            // buttonevalvation
            // 
            this.buttonevalvation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonevalvation.Location = new System.Drawing.Point(482, 305);
            this.buttonevalvation.Name = "buttonevalvation";
            this.buttonevalvation.Size = new System.Drawing.Size(126, 61);
            this.buttonevalvation.TabIndex = 2;
            this.buttonevalvation.Text = "Project Eelvation";
            this.buttonevalvation.UseVisualStyleBackColor = true;
            this.buttonevalvation.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonproject
            // 
            this.buttonproject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonproject.Image = ((System.Drawing.Image)(resources.GetObject("buttonproject.Image")));
            this.buttonproject.Location = new System.Drawing.Point(664, 305);
            this.buttonproject.Name = "buttonproject";
            this.buttonproject.Size = new System.Drawing.Size(124, 61);
            this.buttonproject.TabIndex = 3;
            this.buttonproject.Text = "Project information";
            this.buttonproject.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonproject.UseVisualStyleBackColor = true;
            this.buttonproject.Click += new System.EventHandler(this.buttonproject_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(379, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Exit";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(804, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Pristina", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(645, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Department of Computer Science UET Final Year Project Management System";
            // 
            // fypmanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 365);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonproject);
            this.Controls.Add(this.buttonevalvation);
            this.Controls.Add(this.buttonadvisorinfo);
            this.Controls.Add(this.buttonstudent);
            this.MaximumSize = new System.Drawing.Size(816, 404);
            this.Name = "fypmanger";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonstudent;
        private System.Windows.Forms.Button buttonadvisorinfo;
        private System.Windows.Forms.Button buttonevalvation;
        private System.Windows.Forms.Button buttonproject;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}