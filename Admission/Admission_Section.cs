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
    public partial class Admission_Section : Form
    {
        public Admission_Section()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        DBAccess.DBGenral obj = new DBAccess.DBGenral();
        DataTable dt = new DataTable();

        public void Show_Class_GRD()
        {

            dt = obj.ShowRecords("Select Section_ID as [Section ID], Section_Name as [Section Name] from Section_Info order by Section_ID DESC");
            Section_List.DataSource = dt;
        }

        private void New_Click(object sender, EventArgs e)
        {
            Add_New();
            Clean_Box();
            ep.Clear();
           
        }

        public void Add_New()
        {
            dt = obj.ShowRecords("Select isnull(Max(Section_ID),0)+1 as maxid from Section_Info");
            Section_ID.Text = dt.Rows[0]["maxid"].ToString();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (Section_ID.Text.Trim() == "")
            {
                ep.SetError(Section_ID, "Please Click New Button to Continue !!!");
                New.Focus();
            }
            else if (Section_Name.Text.Trim() == "")
            {
                ep.SetError(Section_Name, "Please Enter Section Name to Contiue !!!");
                Section_Name.Focus();
            }
            else
            {
                obj.Genral_Queries("insert into Section_Info (Section_Name) Values  ('" + Section_Name.Text + "')");
                MessageBox.Show("New Section Name is Added Successfullu");
                Show_Class_GRD();
                obj.Genral_Queries("insert Into Log_Info (User_History,Date,Time,Operation) Values ('" + LB_Section.Text + "','" + System.DateTime.Now + "','" + System.DateTime.Now.ToString("HH:mm") + "',' A New " + Section_Name.Text + " Section is Created Sucessfully By User " + LB_Section.Text + "')");
                Clean_Box();
                Add_New();
                ep.Clear();  
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Section_ID.Text.Trim() == "" || Section_Name.Text.Trim()=="")
            {
                ep.SetError(Section_ID, "Please Select a Section to Update and to Continue !!!");
                ep.SetError(Section_Name, "Please Select a Section Name to Contiue !!!");


            }
            else
            {

                obj.Genral_Queries("update Section_Info set Section_Name='" + Section_Name.Text + "' Where Section_ID='" + Section_ID.Text + "'");
                MessageBox.Show("Record is UpDated Successfully");
                Show_Class_GRD();
                obj.Genral_Queries("insert Into Log_Info (User_History,Date,Time,Operation) Values ('" + LB_Section.Text + "','" + System.DateTime.Now + "','" + System.DateTime.Now.ToString("HH:mm") + "',' An Old " + Section_Name.Text + " Section is Updated Sucessfully By User " + LB_Section.Text + "')");
                Clean_Box();
                Add_New();
                ep.Clear();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Section_ID.Text.Trim() == "" || Section_Name.Text.Trim()=="")
            {
                ep.SetError(Section_ID, "Please Select a Section to Delete and to Continue !!!");
                ep.SetError(Section_Name, "Please Select a Section Name to Contiue !!!");
                //ep.SetError(Class_CMB, "Please Select a Class to Continue !!!");

            }
            else
            {

                obj.Genral_Queries("Delete from Section_Info where Section_ID ='" + Section_ID.Text + "'");
                MessageBox.Show("Record is Deleted Successfully");
                Show_Class_GRD();
                obj.Genral_Queries("insert Into Log_Info (User_History,Date,Time,Operation) Values ('" + LB_Section.Text + "','" + System.DateTime.Now + "','" + System.DateTime.Now.ToString("HH:mm") + "',' An Old " + Section_Name.Text + " Section is Deleted Sucessfully By User " + LB_Section.Text + "')");
                Clean_Box();
                Add_New();
                ep.Clear();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Clean_Box();
            Add_New();
        }

        public void Clean_Box()
        {
             Section_Name.Text = "";
        }

        private void Admission_Section_Load(object sender, EventArgs e)
        {
            Show_Class_GRD();

        }

        private void Class_List_MouseClick(object sender, MouseEventArgs e)
        {

        }

        //public void Show_Class()
        //{
        //    dt = obj.ShowRecords("select * from Class_Info order by Class_ID DESC");
        //    Class_CMB.DataSource = dt;
        //    Class_CMB.DisplayMember = "CName";
        //    Class_CMB.ValueMember = "Class_ID";
        //}

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Section_List_MouseClick(object sender, MouseEventArgs e)
        {
            dt = obj.ShowRecords("select * from Section_Info where Section_ID ='" + Section_List.CurrentRow.Cells[0].Value + "'");
            Section_ID.Text = dt.Rows[0]["Section_ID"].ToString();
            Section_Name.Text = dt.Rows[0]["Section_Name"].ToString();
            ep.Clear();

        }

        private void Section_Name_TextChanged(object sender, EventArgs e)
        {
            ep.Clear();
        }
    }
}