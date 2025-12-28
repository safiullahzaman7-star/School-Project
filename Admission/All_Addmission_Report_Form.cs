using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySchoolProject.Admission
{
    public partial class All_Addmission_Report_Form : MetroFramework.Forms.MetroForm
    {
        public All_Addmission_Report_Form()
        {
            InitializeComponent();
        }

        private void All_Addmission_Report_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admission.All_Add obj = new Admission.All_Add();
            obj.RecordSelectionFormula = "{Addmission_Recipt_View.Date}>='" + FromDate.Value.ToString("yyyy-MM-dd") + "' and {Addmission_Recipt_View.Date}<='" + ToDate.Value.ToString("yyyy-MM-dd") + "' ";
            crystalReportViewer1.ReportSource = obj;
            crystalReportViewer1.RefreshReport();
        }
    }
}
