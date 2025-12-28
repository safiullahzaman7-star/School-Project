namespace MySchoolProject.Account_Section
{
    partial class Account_With_Date_Form
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Account_With_Date1 = new MySchoolProject.Account_Section.Account_With_Date();
            this.From_Date = new System.Windows.Forms.DateTimePicker();
            this.To_Date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.Account_With_Date1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1127, 630);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // From_Date
            // 
            this.From_Date.Enabled = false;
            this.From_Date.Location = new System.Drawing.Point(12, 38);
            this.From_Date.Name = "From_Date";
            this.From_Date.Size = new System.Drawing.Size(181, 20);
            this.From_Date.TabIndex = 1;
            // 
            // To_Date
            // 
            this.To_Date.Enabled = false;
            this.To_Date.Location = new System.Drawing.Point(12, 64);
            this.To_Date.Name = "To_Date";
            this.To_Date.Size = new System.Drawing.Size(181, 20);
            this.To_Date.TabIndex = 2;
            // 
            // Account_With_Date_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 630);
            this.Controls.Add(this.To_Date);
            this.Controls.Add(this.From_Date);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Account_With_Date_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Account_With_Date_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Account_With_Date Account_With_Date1;
        public System.Windows.Forms.DateTimePicker From_Date;
        public System.Windows.Forms.DateTimePicker To_Date;
    }
}