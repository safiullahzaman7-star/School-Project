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
    public partial class Class_Form : Form
    {
        public Class_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Class_Form_Load(object sender, EventArgs e)
        {
            Show_Class_GRD();
            Add_New();
           
        }

       

        DBAccess.DBGenral obj = new DBAccess.DBGenral();
        DataTable dt = new DataTable();

        public void Show_Class_GRD()
        {

            dt = obj.ShowRecords("Select Class_ID as [Class ID], CName [Class Name], Fee as [Fee] from Class_Info order by Class_ID DESC");
            Class_List.DataSource = dt;
        }

        private void New_Click(object sender, EventArgs e)
        {
            Add_New();
            ep.Clear();
        }

        public void Add_New()
        {
            dt = obj.ShowRecords("select Max(Class_ID) as maxid from Class_Info");
            Class_ID.Text = dt.Rows[0]["maxid"].ToString();
        }


       

        private void Save_Click(object sender, EventArgs e)
        {
            

        }



        public void Clean_Box()
        {
            Class_ID.Text = C_Name.Text = Fee.Text = "";
          
        }

        private void Update_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
           



        }

        private void Clear_Click(object sender, EventArgs e)
        {
            
        }

        private void Save_Click_1(object sender, EventArgs e)
        {
            if(Class_ID.Text.Trim()=="")
            {
                ep.SetError(Class_ID, "Please Click New Button to Continue !!!");
                New.Focus();
            }else if(C_Name.Text.Trim()=="")
            {
                ep.SetError(C_Name, "Please Enter Class Name to Continue !!!");
                C_Name.Focus();
            }else if(Fee.Text.Trim()=="")
            {
                ep.SetError(Fee, "Please Enter Class Fee to Continue !!!");
                Fee.Focus();
            }
            else
            {
                obj.Genral_Queries("insert into Class_Info (CName,Class_Fee) values ('" + C_Name.Text + "','" + Fee.Text + "')");
                MetroFramework.MetroMessageBox.Show(this, "Record Number ( " + Class_ID.Text + " ) is Inserted Sucessfully ", "Insertion Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                obj.Genral_Queries("insert Into Log_Info (User_History,Date,Time,Operation) Values ('" + LB_Class.Text + "','" + System.DateTime.Now + "','" + System.DateTime.Now.ToString("HH:mm") + "',' A New " + C_Name.Text + " Class is Created Sucessfully By User " + LB_Class.Text + "')");

                Clean_Box();
                Show_Class_GRD();
                Add_New();
            }
           
        }

        private void Update_Click_1(object sender, EventArgs e)
        {
             if(Class_ID.Text.Trim()=="")
            {
                ep.SetError(Class_ID, "Please a Class to Continue !!!");
                New.Focus();
            }else if(C_Name.Text.Trim()=="")
            {
                ep.SetError(C_Name, "Please Select a Class Name to Continue !!!");
                C_Name.Focus();
            }
             else if (Fee.Text.Trim() == "")
             {
                 ep.SetError(Fee, "Please Select a Class Fee to Continue !!!");
                 Fee.Focus();
             }
             else
             {

                 obj.Genral_Queries("Update Class_Info set CName='" + C_Name.Text + "', Class_Fee='" + Fee.Text + "' where Class_ID='" + Class_ID.Text + "'");
                 MetroFramework.MetroMessageBox.Show(this, "Record Number ( " + Class_ID.Text + " ) is Updated Sucessfully ", "UpDating Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                 obj.Genral_Queries("insert Into Log_Info (User_History,Date,Time,Operation) Values ('" + LB_Class.Text + "','" + System.DateTime.Now + "','" + System.DateTime.Now.ToString("HH:mm") + "',' An Old " + C_Name.Text + " Class is Updated Sucessfully By User " + LB_Class.Text + "')");
                 ep.Clear();
                 Clean_Box();
                 Show_Class_GRD();
                 Add_New();
             }
        }

        private void Delete_Click_1(object sender, EventArgs e)
        {    
            if(Class_ID.Text.Trim()=="" || C_Name.Text.Trim()=="" || Fee.Text.Trim()=="")
            {
                ep.SetError(Class_ID, "Please Select a Class to Delete !!!");
                ep.SetError(C_Name, "Please Select a Class to Delete !!!");
                ep.SetError(Fee, "Please Select a Class to Delete !!!");

            }
            else
            {
                obj.Genral_Queries("Delete from Class_Info where Class_ID='" + Class_ID.Text + "'");
                Show_Class_GRD();
                obj.Genral_Queries("insert Into Log_Info (User_History,Date,Time,Operation) Values ('" + LB_Class.Text + "','" + System.DateTime.Now + "','" + System.DateTime.Now.ToString("HH:mm") + "',' An Old " + C_Name.Text + " Class is Deleted Sucessfully By User " + LB_Class.Text + "')");

                Clean_Box();
                Add_New();
                ep.Clear();
            }
                
        }

        private void Clear_Click_1(object sender, EventArgs e)
        {
            Clean_Box();
            Add_New();
        }

        private void Class_List_MouseClick(object sender, MouseEventArgs e)
        {
           
            dt = obj.ShowRecords("select * from Class_Info where Class_ID='" + Class_List.CurrentRow.Cells[0].Value + "'");
           
            Class_ID.Text = dt.Rows[0]["Class_ID"].ToString();
            C_Name.Text = dt.Rows[0]["CName"].ToString();
            Fee.Text = dt.Rows[0]["Fee"].ToString();
            ep.Clear();
        }

        private void C_Name_TextChanged(object sender, EventArgs e)
        {
            ep.Clear();
        }

        private void Fee_TextChanged(object sender, EventArgs e)
        {
            ep.Clear();
        }
    }
}
