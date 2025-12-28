
namespace MySchoolProject
{
    partial class Color
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Color));
            this.My_Panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblday = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblsecond = new System.Windows.Forms.Label();
            this.lblhiur = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.LB_Student_Pro = new System.Windows.Forms.Label();
            this.LB_Head = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.Get_Data = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Admission_List = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.S_Shift = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Contact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.S_id = new System.Windows.Forms.TextBox();
            this.S_Name = new System.Windows.Forms.TextBox();
            this.S_FName = new System.Windows.Forms.TextBox();
            this.S_Section = new System.Windows.Forms.TextBox();
            this.S_Class = new System.Windows.Forms.TextBox();
            this.RMale = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.RFemale = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Student_pic = new System.Windows.Forms.PictureBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.U_Section = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.U_Class = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.U_Shift = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Seclect_Class = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Admission_List)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Student_pic)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // My_Panel
            // 
            this.My_Panel.BackColor = System.Drawing.Color.Maroon;
            this.My_Panel.Location = new System.Drawing.Point(98, 55);
            this.My_Panel.Name = "My_Panel";
            this.My_Panel.Size = new System.Drawing.Size(190, 33);
            this.My_Panel.TabIndex = 0;
            this.My_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.My_Panel_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblday);
            this.groupBox1.Controls.Add(this.lbldate);
            this.groupBox1.Controls.Add(this.lblsecond);
            this.groupBox1.Controls.Add(this.lblhiur);
            this.groupBox1.Location = new System.Drawing.Point(12, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 34);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblday
            // 
            this.lblday.AutoSize = true;
            this.lblday.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblday.Location = new System.Drawing.Point(142, 256);
            this.lblday.Name = "lblday";
            this.lblday.Size = new System.Drawing.Size(99, 31);
            this.lblday.TabIndex = 0;
            this.lblday.Text = "Sunday";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(79, 193);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(137, 31);
            this.lbldate.TabIndex = 0;
            this.lbldate.Text = "3/jan/2020";
            // 
            // lblsecond
            // 
            this.lblsecond.AutoSize = true;
            this.lblsecond.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsecond.Location = new System.Drawing.Point(199, 96);
            this.lblsecond.Name = "lblsecond";
            this.lblsecond.Size = new System.Drawing.Size(42, 31);
            this.lblsecond.TabIndex = 0;
            this.lblsecond.Text = "22";
            // 
            // lblhiur
            // 
            this.lblhiur.AutoSize = true;
            this.lblhiur.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhiur.Location = new System.Drawing.Point(114, 65);
            this.lblhiur.Name = "lblhiur";
            this.lblhiur.Size = new System.Drawing.Size(79, 31);
            this.lblhiur.TabIndex = 0;
            this.lblhiur.Text = "22:22";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.LB_Student_Pro);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.LB_Head);
            this.panel2.Controls.Add(this.label49);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.panel2.Location = new System.Drawing.Point(12, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(979, 42);
            this.panel2.TabIndex = 675478;
            // 
            // LB_Student_Pro
            // 
            this.LB_Student_Pro.AutoSize = true;
            this.LB_Student_Pro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Student_Pro.ForeColor = System.Drawing.Color.White;
            this.LB_Student_Pro.Location = new System.Drawing.Point(734, 13);
            this.LB_Student_Pro.Name = "LB_Student_Pro";
            this.LB_Student_Pro.Size = new System.Drawing.Size(0, 19);
            this.LB_Student_Pro.TabIndex = 17;
            // 
            // LB_Head
            // 
            this.LB_Head.AutoSize = true;
            this.LB_Head.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Head.ForeColor = System.Drawing.Color.White;
            this.LB_Head.Location = new System.Drawing.Point(28, 2);
            this.LB_Head.Name = "LB_Head";
            this.LB_Head.Size = new System.Drawing.Size(369, 36);
            this.LB_Head.TabIndex = 0;
            this.LB_Head.Text = "&Single Student Promotion";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.ForeColor = System.Drawing.Color.White;
            this.label49.Location = new System.Drawing.Point(626, 13);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(102, 19);
            this.label49.TabIndex = 16;
            this.label49.Text = "Current User:";
            // 
            // Get_Data
            // 
            this.Get_Data.BackColor = System.Drawing.Color.DodgerBlue;
            this.Get_Data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Get_Data.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Get_Data.ForeColor = System.Drawing.Color.White;
            this.Get_Data.Location = new System.Drawing.Point(899, 176);
            this.Get_Data.Name = "Get_Data";
            this.Get_Data.Size = new System.Drawing.Size(92, 32);
            this.Get_Data.TabIndex = 675481;
            this.Get_Data.Text = "&GetData";
            this.Get_Data.UseVisualStyleBackColor = false;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.DodgerBlue;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.Location = new System.Drawing.Point(899, 96);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(92, 32);
            this.Save.TabIndex = 675480;
            this.Save.Text = "&Update";
            this.Save.UseVisualStyleBackColor = false;
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClean.Location = new System.Drawing.Point(899, 135);
            this.btnClean.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(92, 32);
            this.btnClean.TabIndex = 675479;
            this.btnClean.Text = "&Clean";
            this.btnClean.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(899, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 32);
            this.button2.TabIndex = 675484;
            this.button2.Text = "&GetData";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button3.Location = new System.Drawing.Point(887, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 32);
            this.button3.TabIndex = 675483;
            this.button3.Text = "&Close";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(899, 216);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 32);
            this.button4.TabIndex = 675482;
            this.button4.Text = "&Clean";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Admission_List);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Location = new System.Drawing.Point(750, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 193);
            this.groupBox2.TabIndex = 675485;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student List";
            // 
            // Admission_List
            // 
            this.Admission_List.AllowUserToAddRows = false;
            this.Admission_List.AllowUserToDeleteRows = false;
            this.Admission_List.AllowUserToResizeColumns = false;
            this.Admission_List.AllowUserToResizeRows = false;
            this.Admission_List.BackgroundColor = System.Drawing.Color.White;
            this.Admission_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Admission_List.DefaultCellStyle = dataGridViewCellStyle7;
            this.Admission_List.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Admission_List.Location = new System.Drawing.Point(6, 25);
            this.Admission_List.Name = "Admission_List";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Admission_List.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.Admission_List.RowHeadersVisible = false;
            this.Admission_List.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Admission_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Admission_List.Size = new System.Drawing.Size(124, 162);
            this.Admission_List.TabIndex = 16;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.S_Shift);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.Contact);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.S_id);
            this.groupBox4.Controls.Add(this.S_Name);
            this.groupBox4.Controls.Add(this.S_FName);
            this.groupBox4.Controls.Add(this.S_Section);
            this.groupBox4.Controls.Add(this.S_Class);
            this.groupBox4.Controls.Add(this.RMale);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.RFemale);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(12, 134);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(683, 149);
            this.groupBox4.TabIndex = 675486;
            this.groupBox4.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(355, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "Section :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Shift :";
            // 
            // S_Shift
            // 
            this.S_Shift.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_Shift.ForeColor = System.Drawing.Color.DodgerBlue;
            this.S_Shift.Location = new System.Drawing.Point(442, 114);
            this.S_Shift.Name = "S_Shift";
            this.S_Shift.Size = new System.Drawing.Size(199, 26);
            this.S_Shift.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name :";
            // 
            // Contact
            // 
            this.Contact.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Contact.Location = new System.Drawing.Point(123, 114);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(199, 26);
            this.Contact.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "F / Name :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(37, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 19);
            this.label14.TabIndex = 11;
            this.label14.Text = "Contct : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(355, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Gender :";
            // 
            // S_id
            // 
            this.S_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_id.ForeColor = System.Drawing.Color.DodgerBlue;
            this.S_id.Location = new System.Drawing.Point(123, 15);
            this.S_id.Name = "S_id";
            this.S_id.Size = new System.Drawing.Size(199, 26);
            this.S_id.TabIndex = 0;
            // 
            // S_Name
            // 
            this.S_Name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_Name.ForeColor = System.Drawing.Color.DodgerBlue;
            this.S_Name.Location = new System.Drawing.Point(123, 47);
            this.S_Name.Name = "S_Name";
            this.S_Name.Size = new System.Drawing.Size(199, 26);
            this.S_Name.TabIndex = 1;
            // 
            // S_FName
            // 
            this.S_FName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_FName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.S_FName.Location = new System.Drawing.Point(123, 79);
            this.S_FName.Name = "S_FName";
            this.S_FName.Size = new System.Drawing.Size(199, 26);
            this.S_FName.TabIndex = 2;
            // 
            // S_Section
            // 
            this.S_Section.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_Section.ForeColor = System.Drawing.Color.DodgerBlue;
            this.S_Section.Location = new System.Drawing.Point(442, 80);
            this.S_Section.Name = "S_Section";
            this.S_Section.Size = new System.Drawing.Size(199, 26);
            this.S_Section.TabIndex = 9;
            // 
            // S_Class
            // 
            this.S_Class.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_Class.ForeColor = System.Drawing.Color.DodgerBlue;
            this.S_Class.Location = new System.Drawing.Point(442, 48);
            this.S_Class.Name = "S_Class";
            this.S_Class.Size = new System.Drawing.Size(199, 26);
            this.S_Class.TabIndex = 8;
            // 
            // RMale
            // 
            this.RMale.AutoSize = true;
            this.RMale.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RMale.Location = new System.Drawing.Point(442, 21);
            this.RMale.Name = "RMale";
            this.RMale.Size = new System.Drawing.Size(63, 23);
            this.RMale.TabIndex = 4;
            this.RMale.TabStop = true;
            this.RMale.Text = "Male";
            this.RMale.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(355, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Class :";
            // 
            // RFemale
            // 
            this.RFemale.AutoSize = true;
            this.RFemale.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RFemale.Location = new System.Drawing.Point(565, 19);
            this.RFemale.Name = "RFemale";
            this.RFemale.Size = new System.Drawing.Size(76, 23);
            this.RFemale.TabIndex = 5;
            this.RFemale.TabStop = true;
            this.RFemale.Text = "Female";
            this.RFemale.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Student_pic);
            this.groupBox5.Location = new System.Drawing.Point(791, 295);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 162);
            this.groupBox5.TabIndex = 675487;
            this.groupBox5.TabStop = false;
            // 
            // Student_pic
            // 
            this.Student_pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Student_pic.Image = ((System.Drawing.Image)(resources.GetObject("Student_pic.Image")));
            this.Student_pic.Location = new System.Drawing.Point(6, 15);
            this.Student_pic.Name = "Student_pic";
            this.Student_pic.Size = new System.Drawing.Size(188, 129);
            this.Student_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Student_pic.TabIndex = 3;
            this.Student_pic.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.U_Section);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.U_Class);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.U_Shift);
            this.groupBox7.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox7.Location = new System.Drawing.Point(12, 295);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(683, 62);
            this.groupBox7.TabIndex = 675488;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Operation";
            // 
            // U_Section
            // 
            this.U_Section.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.U_Section.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.U_Section.ForeColor = System.Drawing.Color.DodgerBlue;
            this.U_Section.FormattingEnabled = true;
            this.U_Section.Location = new System.Drawing.Point(359, 21);
            this.U_Section.Name = "U_Section";
            this.U_Section.Size = new System.Drawing.Size(188, 27);
            this.U_Section.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Class :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(590, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "Shift :";
            // 
            // U_Class
            // 
            this.U_Class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.U_Class.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.U_Class.ForeColor = System.Drawing.Color.DodgerBlue;
            this.U_Class.FormattingEnabled = true;
            this.U_Class.Location = new System.Drawing.Point(62, 21);
            this.U_Class.Name = "U_Class";
            this.U_Class.Size = new System.Drawing.Size(188, 27);
            this.U_Class.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(294, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Section :";
            // 
            // U_Shift
            // 
            this.U_Shift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.U_Shift.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.U_Shift.ForeColor = System.Drawing.Color.DodgerBlue;
            this.U_Shift.FormattingEnabled = true;
            this.U_Shift.Location = new System.Drawing.Point(645, 21);
            this.U_Shift.Name = "U_Shift";
            this.U_Shift.Size = new System.Drawing.Size(181, 27);
            this.U_Shift.TabIndex = 6;
            // 
            // groupBox6
            // 
            this.groupBox6.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox6.Location = new System.Drawing.Point(12, 363);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(263, 62);
            this.groupBox6.TabIndex = 675489;
            this.groupBox6.TabStop = false;
            // 
            // Seclect_Class
            // 
            this.Seclect_Class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Seclect_Class.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seclect_Class.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Seclect_Class.FormattingEnabled = true;
            this.Seclect_Class.Location = new System.Drawing.Point(360, 379);
            this.Seclect_Class.Name = "Seclect_Class";
            this.Seclect_Class.Size = new System.Drawing.Size(199, 27);
            this.Seclect_Class.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(299, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Class :";
            // 
            // Color
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 469);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Seclect_Class);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Get_Data);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.My_Panel);
            this.Name = "Color";
            this.Text = "Color";
            this.Load += new System.EventHandler(this.Color_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Admission_List)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Student_pic)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel My_Panel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblday;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblsecond;
        private System.Windows.Forms.Label lblhiur;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label LB_Student_Pro;
        private System.Windows.Forms.Label LB_Head;
        private System.Windows.Forms.Label label49;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button Get_Data;
        public System.Windows.Forms.Button Save;
        internal System.Windows.Forms.Button btnClean;
        public System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Admission_List;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox S_Shift;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Contact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox S_id;
        private System.Windows.Forms.TextBox S_Name;
        private System.Windows.Forms.TextBox S_FName;
        private System.Windows.Forms.TextBox S_Section;
        private System.Windows.Forms.TextBox S_Class;
        private System.Windows.Forms.RadioButton RMale;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton RFemale;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox Student_pic;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox U_Section;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox U_Class;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox U_Shift;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox Seclect_Class;
        private System.Windows.Forms.Label label5;
    }
}