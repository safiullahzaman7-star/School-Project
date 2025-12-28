namespace MySchoolProject.Admission
{
    partial class Student_Admission_Table
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Admission_Table));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.By_ID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.By_Name = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LB_addmission = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Admission_List = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.Selected_ID = new System.Windows.Forms.TextBox();
            this.Student_Name = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Admission_List)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.By_ID);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.By_Name);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox4.Location = new System.Drawing.Point(6, 48);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1290, 56);
            this.groupBox4.TabIndex = 675494;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search By";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(80, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // By_ID
            // 
            this.By_ID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.By_ID.Location = new System.Drawing.Point(616, 18);
            this.By_ID.Name = "By_ID";
            this.By_ID.Size = new System.Drawing.Size(294, 26);
            this.By_ID.TabIndex = 16;
            this.By_ID.TabStop = false;
            this.By_ID.TextChanged += new System.EventHandler(this.By_ID_TextChanged);
            this.By_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.By_ID_KeyPress);
            this.By_ID.Leave += new System.EventHandler(this.By_ID_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(568, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 19);
            this.label14.TabIndex = 0;
            this.label14.Text = "ID";
            // 
            // By_Name
            // 
            this.By_Name.ForeColor = System.Drawing.Color.DodgerBlue;
            this.By_Name.Location = new System.Drawing.Point(1017, 18);
            this.By_Name.Name = "By_Name";
            this.By_Name.Size = new System.Drawing.Size(267, 26);
            this.By_Name.TabIndex = 17;
            this.By_Name.TabStop = false;
            this.By_Name.TextChanged += new System.EventHandler(this.By_Name_TextChanged);
            this.By_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.By_Name_KeyPress);
            this.By_Name.Leave += new System.EventHandler(this.By_Name_Leave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(944, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 19);
            this.label15.TabIndex = 0;
            this.label15.Text = "Name ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.LB_addmission);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1308, 46);
            this.panel1.TabIndex = 675493;
            // 
            // LB_addmission
            // 
            this.LB_addmission.AutoSize = true;
            this.LB_addmission.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_addmission.ForeColor = System.Drawing.Color.White;
            this.LB_addmission.Location = new System.Drawing.Point(1000, 17);
            this.LB_addmission.Name = "LB_addmission";
            this.LB_addmission.Size = new System.Drawing.Size(0, 19);
            this.LB_addmission.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(888, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 19);
            this.label11.TabIndex = 27;
            this.label11.Text = "Current User:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Admission List";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Admission_List);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox3.Location = new System.Drawing.Point(6, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1290, 398);
            this.groupBox3.TabIndex = 675492;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Student Admission List";
            // 
            // Admission_List
            // 
            this.Admission_List.AllowUserToAddRows = false;
            this.Admission_List.BackgroundColor = System.Drawing.Color.White;
            this.Admission_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Admission_List.ContextMenuStrip = this.contextMenuStrip1;
            this.Admission_List.GridColor = System.Drawing.Color.DodgerBlue;
            this.Admission_List.Location = new System.Drawing.Point(6, 25);
            this.Admission_List.Name = "Admission_List";
            this.Admission_List.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Admission_List.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Admission_List.RowHeadersVisible = false;
            this.Admission_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Admission_List.Size = new System.Drawing.Size(1278, 367);
            this.Admission_List.TabIndex = 0;
            this.Admission_List.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Admission_List_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(106, 26);
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.selectToolStripMenuItem.Text = "Select";
            this.selectToolStripMenuItem.Click += new System.EventHandler(this.selectToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1145, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 35);
            this.button1.TabIndex = 675495;
            this.button1.Text = "Recipt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // Selected_ID
            // 
            this.Selected_ID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Selected_ID.Location = new System.Drawing.Point(957, 169);
            this.Selected_ID.Name = "Selected_ID";
            this.Selected_ID.Size = new System.Drawing.Size(182, 20);
            this.Selected_ID.TabIndex = 17;
            this.Selected_ID.TabStop = false;
            this.Selected_ID.Visible = false;
            this.Selected_ID.TextChanged += new System.EventHandler(this.By_Name_TextChanged);
            // 
            // Student_Name
            // 
            this.Student_Name.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Student_Name.Location = new System.Drawing.Point(769, 169);
            this.Student_Name.Name = "Student_Name";
            this.Student_Name.Size = new System.Drawing.Size(182, 20);
            this.Student_Name.TabIndex = 17;
            this.Student_Name.TabStop = false;
            this.Student_Name.Visible = false;
            this.Student_Name.TextChanged += new System.EventHandler(this.By_Name_TextChanged);
            // 
            // Student_Admission_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1308, 593);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Student_Name);
            this.Controls.Add(this.Selected_ID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Student_Admission_Table";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Student_Admission_Table_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Admission_List)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox By_Name;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox By_ID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Admission_List;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.TextBox Selected_ID;
        public System.Windows.Forms.Label LB_addmission;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Student_Name;
    }
}