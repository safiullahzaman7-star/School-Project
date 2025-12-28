namespace MySchoolProject.Admission
{
    partial class Class_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_Class = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Class_List = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.C_Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Fee = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.C_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Class_ID = new System.Windows.Forms.TextBox();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Class_List)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 55);
            this.panel1.TabIndex = 675475;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class Registration Form";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LB_Class
            // 
            this.LB_Class.AutoSize = true;
            this.LB_Class.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Class.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LB_Class.Location = new System.Drawing.Point(123, 32);
            this.LB_Class.Name = "LB_Class";
            this.LB_Class.Size = new System.Drawing.Size(0, 19);
            this.LB_Class.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label13.Location = new System.Drawing.Point(11, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 19);
            this.label13.TabIndex = 3;
            this.label13.Text = "Current User:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Class_List);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox3.Location = new System.Drawing.Point(12, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(468, 179);
            this.groupBox3.TabIndex = 675487;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Class List";
            // 
            // Class_List
            // 
            this.Class_List.AllowUserToAddRows = false;
            this.Class_List.AllowUserToDeleteRows = false;
            this.Class_List.AllowUserToOrderColumns = true;
            this.Class_List.AllowUserToResizeColumns = false;
            this.Class_List.AllowUserToResizeRows = false;
            this.Class_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Class_List.BackgroundColor = System.Drawing.Color.White;
            this.Class_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Class_List.DefaultCellStyle = dataGridViewCellStyle3;
            this.Class_List.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Class_List.GridColor = System.Drawing.Color.DodgerBlue;
            this.Class_List.Location = new System.Drawing.Point(0, 25);
            this.Class_List.Name = "Class_List";
            this.Class_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Class_List.Size = new System.Drawing.Size(459, 143);
            this.Class_List.TabIndex = 0;
            this.Class_List.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Class_List_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LB_Class);
            this.groupBox1.Controls.Add(this.C_Update);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.Delete);
            this.groupBox1.Controls.Add(this.New);
            this.groupBox1.Controls.Add(this.Clear);
            this.groupBox1.Controls.Add(this.Save);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Fee);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.C_Name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Class_ID);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 210);
            this.groupBox1.TabIndex = 675488;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class Registration";
            // 
            // C_Update
            // 
            this.C_Update.BackColor = System.Drawing.Color.DodgerBlue;
            this.C_Update.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_Update.ForeColor = System.Drawing.Color.White;
            this.C_Update.Location = new System.Drawing.Point(372, 95);
            this.C_Update.Name = "C_Update";
            this.C_Update.Size = new System.Drawing.Size(87, 33);
            this.C_Update.TabIndex = 23;
            this.C_Update.Text = "UpDate";
            this.C_Update.UseVisualStyleBackColor = false;
            this.C_Update.Click += new System.EventHandler(this.Update_Click_1);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.DodgerBlue;
            this.Delete.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(372, 134);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(87, 32);
            this.Delete.TabIndex = 22;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click_1);
            // 
            // New
            // 
            this.New.BackColor = System.Drawing.Color.DodgerBlue;
            this.New.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New.ForeColor = System.Drawing.Color.White;
            this.New.Location = new System.Drawing.Point(372, 18);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(87, 33);
            this.New.TabIndex = 21;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = false;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.DodgerBlue;
            this.Clear.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.Location = new System.Drawing.Point(372, 172);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(87, 32);
            this.Clear.TabIndex = 20;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click_1);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.DodgerBlue;
            this.Save.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.Location = new System.Drawing.Point(372, 57);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(87, 32);
            this.Save.TabIndex = 19;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Class Fee";
            // 
            // Fee
            // 
            this.Fee.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fee.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Fee.Location = new System.Drawing.Point(124, 134);
            this.Fee.Name = "Fee";
            this.Fee.Size = new System.Drawing.Size(229, 25);
            this.Fee.TabIndex = 5;
            this.Fee.TextChanged += new System.EventHandler(this.Fee_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Class Name";
            // 
            // C_Name
            // 
            this.C_Name.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_Name.ForeColor = System.Drawing.Color.DodgerBlue;
            this.C_Name.Location = new System.Drawing.Point(124, 100);
            this.C_Name.Name = "C_Name";
            this.C_Name.Size = new System.Drawing.Size(229, 25);
            this.C_Name.TabIndex = 3;
            this.C_Name.TextChanged += new System.EventHandler(this.C_Name_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Class ID";
            // 
            // Class_ID
            // 
            this.Class_ID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class_ID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Class_ID.Location = new System.Drawing.Point(124, 66);
            this.Class_ID.Name = "Class_ID";
            this.Class_ID.ReadOnly = true;
            this.Class_ID.Size = new System.Drawing.Size(229, 25);
            this.Class_ID.TabIndex = 1;
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // Class_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(486, 468);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Class_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Class_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Class_List)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView Class_List;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Fee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox C_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Class_ID;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button C_Update;
        private System.Windows.Forms.Button Delete;
        public System.Windows.Forms.Label LB_Class;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ErrorProvider ep;
    }
}