using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySchoolProject.Account_Section
{
    public partial class Account_Single_Record_Form : Form
    {
        public Account_Single_Record_Form()
        {
            InitializeComponent();
        }

        public int single;

        private void Account_Single_Record_Form_Load(object sender, EventArgs e)
        {
            Account_Section.Account_Single_Record rpt = new Account_Section.Account_Single_Record();
            rpt.RecordSelectionFormula = "{Account_Info.Account_ID}=" + single;
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.RefreshReport();
        }
    }
}
