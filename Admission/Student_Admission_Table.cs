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
    public partial class Student_Admission_Table : Form
    {
        public Student_Admission_Table()
        {
            InitializeComponent();
        }

        private void Student_Admission_Table_Load(object sender, EventArgs e)
        {
            //Show_Admission_GRD();
            FillGrid();

        }

        public void FillGrid()
        {
            DataTable dt = new DataTable();
            DBAccess.DBGenral obj = new DBAccess.DBGenral();
            dt = obj.ShowRecords("Select Admission_ID as [Admission ID],Name as [Student Name],FName as [Fater Name],Class_ID as [Class Name],Section_ID as [Section Name], Amount,Discount,Total,Date ,User_History as [User] from Admission_Table_View order by S_ID DESC");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    Admission_List.DataSource = dt;
                    Admission_List.Columns[0].Width = 130;
                    Admission_List.Columns[1].Width = 150;
                    Admission_List.Columns[2].Width = 150;
                    Admission_List.Columns[3].Width = 120;
                    Admission_List.Columns[4].Width = 120;
                    Admission_List.Columns[5].Width = 100;
                    Admission_List.Columns[6].Width = 100;
                    Admission_List.Columns[7].Width = 150;
                    Admission_List.Columns[8].Width = 120;
                    Admission_List.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else
                {
                    Admission_List.DataSource = null;

                }
            }
            else
            {
                Admission_List.DataSource = null;
            }
        }


        //public void Show_Admission_GRD()
        //{
        //    DBAccess.DBGenral obj = new DBAccess.DBGenral();
        //    DataTable dt = new DataTable();
        //    dt = obj.ShowRecords("select * from Admission_Table_View order by Admission_ID DESC");
        //    Admission_List.DataSource = dt;
        //}

        private void By_ID_TextChanged(object sender, EventArgs e)
        {
           
            dt = obj.ShowRecords("Select Admission_ID as [Admission ID],Name as [Student Name],FName as [Fater Name],Class_ID as [Class Name],Section_ID as [Section Name], Amount,Discount,Total,Date ,User_History as [User] from Admission_Table_View where Admission_ID Like '%" + By_ID.Text + "%' order by S_ID DESC");

            Admission_List.DataSource = dt;
            

        }
        DBAccess.DBGenral obj = new DBAccess.DBGenral();
        DataTable dt = new DataTable();
        private void By_Name_TextChanged(object sender, EventArgs e)
        {
           
            dt = obj.ShowRecords("Select Admission_ID as [Admission ID],Name as [Student Name],FName as [Fater Name],Class_ID as [Class Name],Section_ID as [Section Name], Amount,Discount,Total,Date ,User_History as [User] from Admission_Table_View where Name Like '%" + By_Name.Text + "%' order by S_ID DESC");

            Admission_List.DataSource = dt;
           

        }

        private void Admission_List_MouseClick(object sender, MouseEventArgs e)
        {
            
           
        }
        DBAccess.DBGenral Log = new DBAccess.DBGenral();
        private void button1_Click(object sender, EventArgs e)
        {
           
            if(Selected_ID.Text=="")
            {
                ep.SetError(button1,"Please Select a Student and Then Click the Recipt Button !!! ");
                MessageBox.Show("Please Select a Student and Then Click the Recipt Button !!! ","Al-Khabar Private High School Management System",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                Admission_List.Focus();
            }
            else
            {
                Admission.Addmission_Recipt_Form obj = new Admission.Addmission_Recipt_Form();
                obj.idx =int.Parse(Selected_ID.Text.ToString());
                obj.Show();
                Log.Genral_Queries("insert Into Log_Info (User_History,Date,Time,Operation) Values ('" + LB_addmission.Text + "','" + System.DateTime.Now + "','" + System.DateTime.Now.ToString("HH:mm") + "',' A Recipt Form Studetnt " + Student_Name.Text + " is Generated Sucessfully By User " + LB_addmission.Text + " in Student Admission Table')");

            }

           
        }

        private void Admission_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if(Admission_List.DataSource!=null)
            {
                if(Admission_List.Rows.Count>0)
                {
                    if(Admission_List.SelectedRows.Count==1)
                    {
                        //ID = int.Parse(Admission_List.SelectedRows[0].Cells[0].FormattedValue.ToString());
                        Selected_ID.Text = Admission_List.SelectedRows[0].Cells[0].FormattedValue.ToString();
                        Student_Name.Text = Admission_List.SelectedRows[0].Cells[1].FormattedValue.ToString();
                        FillGrid();
                    }
                    else
                    {
                        MessageBox.Show("Please Select One Record !!!","Al-Khabar Private High SchoolManagement System",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("The List is Empty", "Al-Khabar Private High School Management System", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }

           
        }

        private void By_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void By_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void By_ID_Leave(object sender, EventArgs e)
        {
            Log.Genral_Queries("insert Into Log_Info (User_History,Date,Time,Operation) Values ('" + LB_addmission.Text + "','" + System.DateTime.Now + "','" + System.DateTime.Now.ToString("HH:mm") + "','The User " + LB_addmission.Text + " Sucessfully Searched About a Student By ID in Student Admission Table')");

        }

        private void By_Name_Leave(object sender, EventArgs e)
        {
            Log.Genral_Queries("insert Into Log_Info (User_History,Date,Time,Operation) Values ('" + LB_addmission.Text + "','" + System.DateTime.Now + "','" + System.DateTime.Now.ToString("HH:mm") + "','The User " + LB_addmission.Text + " Sucessfully Searched About a Student By Name in Student Admission Table')");

        }
    }
}
