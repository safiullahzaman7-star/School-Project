namespace MySchoolProject.Account_Section
{
    partial class Account_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account_Form));
            this.panel2 = new System.Windows.Forms.Panel();
            this.LB_Account = new System.Windows.Forms.Label();
            this.LB_Head = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.Emp_List = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectAnAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            this.Emp_By_Name = new System.Windows.Forms.TextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label51 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CashOnHand = new System.Windows.Forms.TextBox();
            this.Debit = new System.Windows.Forms.TextBox();
            this.Credit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Ch_User = new System.Windows.Forms.CheckBox();
            this.LB_Credit = new System.Windows.Forms.Label();
            this.LB_ID = new System.Windows.Forms.Label();
            this.Lb_Debit = new System.Windows.Forms.Label();
            this.LBDebit = new System.Windows.Forms.Label();
            this.LBCredit = new System.Windows.Forms.Label();
            this.LBID = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Ch_Date = new System.Windows.Forms.CheckBox();
            this.Get_Data = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.To_Date = new System.Windows.Forms.DateTimePicker();
            this.From_Date = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_List)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.LB_Account);
            this.panel2.Controls.Add(this.LB_Head);
            this.panel2.Controls.Add(this.label49);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1171, 42);
            this.panel2.TabIndex = 675476;
            // 
            // LB_Account
            // 
            this.LB_Account.AutoSize = true;
            this.LB_Account.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Account.ForeColor = System.Drawing.Color.White;
            this.LB_Account.Location = new System.Drawing.Point(888, 16);
            this.LB_Account.Name = "LB_Account";
            this.LB_Account.Size = new System.Drawing.Size(0, 19);
            this.LB_Account.TabIndex = 17;
            // 
            // LB_Head
            // 
            this.LB_Head.AutoSize = true;
            this.LB_Head.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Head.ForeColor = System.Drawing.Color.White;
            this.LB_Head.Location = new System.Drawing.Point(147, 2);
            this.LB_Head.Name = "LB_Head";
            this.LB_Head.Size = new System.Drawing.Size(214, 36);
            this.LB_Head.TabIndex = 0;
            this.LB_Head.Text = "Account Form";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.ForeColor = System.Drawing.Color.White;
            this.label49.Location = new System.Drawing.Point(776, 16);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(102, 19);
            this.label49.TabIndex = 16;
            this.label49.Text = "Current User:";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.Emp_List);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox11.Location = new System.Drawing.Point(0, 267);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(1171, 344);
            this.groupBox11.TabIndex = 675503;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Employee List";
            // 
            // Emp_List
            // 
            this.Emp_List.AllowUserToAddRows = false;
            this.Emp_List.BackgroundColor = System.Drawing.Color.White;
            this.Emp_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Emp_List.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Emp_List.DefaultCellStyle = dataGridViewCellStyle1;
            this.Emp_List.GridColor = System.Drawing.Color.DodgerBlue;
            this.Emp_List.Location = new System.Drawing.Point(6, 25);
            this.Emp_List.Name = "Emp_List";
            this.Emp_List.RowHeadersVisible = false;
            this.Emp_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Emp_List.Size = new System.Drawing.Size(1159, 313);
            this.Emp_List.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAnAccountToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(170, 26);
            // 
            // selectAnAccountToolStripMenuItem
            // 
            this.selectAnAccountToolStripMenuItem.Name = "selectAnAccountToolStripMenuItem";
            this.selectAnAccountToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.selectAnAccountToolStripMenuItem.Text = "Select an Account";
            this.selectAnAccountToolStripMenuItem.Click += new System.EventHandler(this.selectAnAccountToolStripMenuItem_Click);
            // 
            // groupBox28
            // 
            this.groupBox28.Controls.Add(this.button3);
            this.groupBox28.Controls.Add(this.Emp_By_Name);
            this.groupBox28.Controls.Add(this.pictureBox7);
            this.groupBox28.Controls.Add(this.label51);
            this.groupBox28.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox28.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox28.Location = new System.Drawing.Point(6, 48);
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.Size = new System.Drawing.Size(1153, 74);
            this.groupBox28.TabIndex = 675502;
            this.groupBox28.TabStop = false;
            this.groupBox28.Text = "Search By";
            // 
            // Emp_By_Name
            // 
            this.Emp_By_Name.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Emp_By_Name.Location = new System.Drawing.Point(449, 30);
            this.Emp_By_Name.Name = "Emp_By_Name";
            this.Emp_By_Name.Size = new System.Drawing.Size(682, 26);
            this.Emp_By_Name.TabIndex = 20;
            this.Emp_By_Name.TextChanged += new System.EventHandler(this.Emp_By_Name_TextChanged);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(107, 13);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(73, 58);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 18;
            this.pictureBox7.TabStop = false;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(302, 33);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(102, 19);
            this.label51.TabIndex = 0;
            this.label51.Text = "&Search in All :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CashOnHand);
            this.groupBox1.Controls.Add(this.Debit);
            this.groupBox1.Controls.Add(this.Credit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(6, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 133);
            this.groupBox1.TabIndex = 675504;
            this.groupBox1.TabStop = false;
            // 
            // CashOnHand
            // 
            this.CashOnHand.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CashOnHand.Location = new System.Drawing.Point(164, 95);
            this.CashOnHand.Name = "CashOnHand";
            this.CashOnHand.ReadOnly = true;
            this.CashOnHand.Size = new System.Drawing.Size(286, 26);
            this.CashOnHand.TabIndex = 1;
            // 
            // Debit
            // 
            this.Debit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Debit.Location = new System.Drawing.Point(164, 60);
            this.Debit.Name = "Debit";
            this.Debit.ReadOnly = true;
            this.Debit.Size = new System.Drawing.Size(286, 26);
            this.Debit.TabIndex = 1;
            // 
            // Credit
            // 
            this.Credit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Credit.Location = new System.Drawing.Point(164, 25);
            this.Credit.Name = "Credit";
            this.Credit.ReadOnly = true;
            this.Credit.Size = new System.Drawing.Size(286, 26);
            this.Credit.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(16, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cash On Hand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(16, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Debit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Credit";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Location = new System.Drawing.Point(469, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(690, 133);
            this.groupBox2.TabIndex = 675505;
            this.groupBox2.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox5.Location = new System.Drawing.Point(607, 15);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(77, 110);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(20, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 29);
            this.button3.TabIndex = 1;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(5, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 29);
            this.button2.TabIndex = 0;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(5, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Recipts";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Ch_User);
            this.groupBox4.Controls.Add(this.LB_Credit);
            this.groupBox4.Controls.Add(this.LB_ID);
            this.groupBox4.Controls.Add(this.Lb_Debit);
            this.groupBox4.Controls.Add(this.LBDebit);
            this.groupBox4.Controls.Add(this.LBCredit);
            this.groupBox4.Controls.Add(this.LBID);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox4.Location = new System.Drawing.Point(6, 88);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(595, 39);
            this.groupBox4.TabIndex = 5449;
            this.groupBox4.TabStop = false;
            // 
            // Ch_User
            // 
            this.Ch_User.AutoSize = true;
            this.Ch_User.Location = new System.Drawing.Point(573, 19);
            this.Ch_User.Name = "Ch_User";
            this.Ch_User.Size = new System.Drawing.Size(15, 14);
            this.Ch_User.TabIndex = 5;
            this.Ch_User.UseVisualStyleBackColor = true;
            this.Ch_User.CheckedChanged += new System.EventHandler(this.Ch_User_CheckedChanged);
            // 
            // LB_Credit
            // 
            this.LB_Credit.AutoSize = true;
            this.LB_Credit.Enabled = false;
            this.LB_Credit.Location = new System.Drawing.Point(231, 18);
            this.LB_Credit.Name = "LB_Credit";
            this.LB_Credit.Size = new System.Drawing.Size(0, 15);
            this.LB_Credit.TabIndex = 4;
            // 
            // LB_ID
            // 
            this.LB_ID.AutoSize = true;
            this.LB_ID.Enabled = false;
            this.LB_ID.Location = new System.Drawing.Point(36, 18);
            this.LB_ID.Name = "LB_ID";
            this.LB_ID.Size = new System.Drawing.Size(0, 15);
            this.LB_ID.TabIndex = 4;
            // 
            // Lb_Debit
            // 
            this.Lb_Debit.AutoSize = true;
            this.Lb_Debit.Enabled = false;
            this.Lb_Debit.Location = new System.Drawing.Point(419, 18);
            this.Lb_Debit.Name = "Lb_Debit";
            this.Lb_Debit.Size = new System.Drawing.Size(0, 15);
            this.Lb_Debit.TabIndex = 4;
            // 
            // LBDebit
            // 
            this.LBDebit.AutoSize = true;
            this.LBDebit.Enabled = false;
            this.LBDebit.Location = new System.Drawing.Point(377, 18);
            this.LBDebit.Name = "LBDebit";
            this.LBDebit.Size = new System.Drawing.Size(36, 15);
            this.LBDebit.TabIndex = 4;
            this.LBDebit.Text = "Debit";
            // 
            // LBCredit
            // 
            this.LBCredit.AutoSize = true;
            this.LBCredit.Enabled = false;
            this.LBCredit.Location = new System.Drawing.Point(183, 18);
            this.LBCredit.Name = "LBCredit";
            this.LBCredit.Size = new System.Drawing.Size(42, 15);
            this.LBCredit.TabIndex = 4;
            this.LBCredit.Text = "Credit";
            // 
            // LBID
            // 
            this.LBID.AutoSize = true;
            this.LBID.Enabled = false;
            this.LBID.Location = new System.Drawing.Point(6, 18);
            this.LBID.Name = "LBID";
            this.LBID.Size = new System.Drawing.Size(24, 15);
            this.LBID.TabIndex = 4;
            this.LBID.Text = "ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Ch_Date);
            this.groupBox3.Controls.Add(this.Get_Data);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.To_Date);
            this.groupBox3.Controls.Add(this.From_Date);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox3.Location = new System.Drawing.Point(6, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(595, 67);
            this.groupBox3.TabIndex = 5448;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search By Date";
            // 
            // Ch_Date
            // 
            this.Ch_Date.AutoSize = true;
            this.Ch_Date.Location = new System.Drawing.Point(573, 35);
            this.Ch_Date.Name = "Ch_Date";
            this.Ch_Date.Size = new System.Drawing.Size(15, 14);
            this.Ch_Date.TabIndex = 6;
            this.Ch_Date.UseVisualStyleBackColor = true;
            this.Ch_Date.CheckedChanged += new System.EventHandler(this.Ch_Date_CheckedChanged);
            // 
            // Get_Data
            // 
            this.Get_Data.BackColor = System.Drawing.Color.DodgerBlue;
            this.Get_Data.Enabled = false;
            this.Get_Data.ForeColor = System.Drawing.Color.White;
            this.Get_Data.Location = new System.Drawing.Point(465, 28);
            this.Get_Data.Name = "Get_Data";
            this.Get_Data.Size = new System.Drawing.Size(81, 29);
            this.Get_Data.TabIndex = 5;
            this.Get_Data.Text = "&Get Data";
            this.Get_Data.UseVisualStyleBackColor = false;
            this.Get_Data.Click += new System.EventHandler(this.Get_Data_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "To Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "From Date";
            // 
            // To_Date
            // 
            this.To_Date.Enabled = false;
            this.To_Date.Location = new System.Drawing.Point(244, 32);
            this.To_Date.Name = "To_Date";
            this.To_Date.Size = new System.Drawing.Size(215, 22);
            this.To_Date.TabIndex = 1;
            // 
            // From_Date
            // 
            this.From_Date.Enabled = false;
            this.From_Date.Location = new System.Drawing.Point(6, 32);
            this.From_Date.Name = "From_Date";
            this.From_Date.Size = new System.Drawing.Size(219, 22);
            this.From_Date.TabIndex = 0;
            // 
            // Account_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1171, 611);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox28);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Account_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Account_Form_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Emp_List)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox28.ResumeLayout(false);
            this.groupBox28.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label LB_Account;
        private System.Windows.Forms.Label LB_Head;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.DataGridView Emp_List;
        private System.Windows.Forms.GroupBox groupBox28;
        private System.Windows.Forms.TextBox Emp_By_Name;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CashOnHand;
        private System.Windows.Forms.TextBox Debit;
        private System.Windows.Forms.TextBox Credit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox Ch_Date;
        private System.Windows.Forms.Button Get_Data;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker To_Date;
        private System.Windows.Forms.DateTimePicker From_Date;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox Ch_User;
        private System.Windows.Forms.Label LBID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectAnAccountToolStripMenuItem;
        private System.Windows.Forms.Label LB_Credit;
        private System.Windows.Forms.Label LB_ID;
        private System.Windows.Forms.Label Lb_Debit;
        private System.Windows.Forms.Label LBDebit;
        private System.Windows.Forms.Label LBCredit;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}