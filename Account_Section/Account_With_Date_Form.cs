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
    public partial class Account_With_Date_Form : Form
    {
        public Account_With_Date_Form()
        {
            InitializeComponent();
        }

        private void Account_With_Date_Form_Load(object sender, EventArgs e)
        {
            Account_Section.Account_With_Date rpt = new Account_Section.Account_With_Date();
            rpt.RecordSelectionFormula = "{Account_Info.Date}>='" + From_Date.Value.ToString("yyyy-MM-dd") + "' and {Account_Info.Date}<= '" + To_Date.Value.ToString("yyyy-MM-dd") + "'";
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.RefreshReport();
        }
    }
}
