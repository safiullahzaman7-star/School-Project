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
    public partial class Addmission_Recipt_Form : MetroFramework.Forms.MetroForm
    {
        public Addmission_Recipt_Form()
        {
            InitializeComponent();
        }

        public int idx;

        private void Addmission_Recipt_Form_Load(object sender, EventArgs e)
        {
            Admission.Addmission_Recipt rpt = new Admission.Addmission_Recipt();
            rpt.RecordSelectionFormula = "{Addmission_Recipt_View.Admission_ID}=" + idx;
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.RefreshReport();
        }
    }
}
