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
    public partial class Admission_From : Form
    {
        public Admission_From()
        {
            InitializeComponent();
        }

        private void Admission_From_Load(object sender, EventArgs e)
        {
           // MessageBox.Show(DateTime.Now.ToString("HH:mm"));

            Cmb_Class.Text = "Select Your Class";
            Cmb_Section.Text = "Select Your Section";
            //Show_Student_GRD();
            Show_Class_Name();
            Show_Section_Name();
            Admission_ID.Focus();
           
            Show_Shift();
            //Extra_Exp.Text = "0";
            Extra.Text = "0";
            Remining_Amount.Text = "0";
            FillGrid();
             
            if(Admission_ID.Text.Trim()!="")
            {
                btn_Report.Text = "Recipt";

            }
            else
            {
                btn_Report.Text = "Print";
            }
        }

        public void Show_Teacher()
        {
            //dt = obj.ShowRecords("select * from Employee_Info order by Emp_ID DESC");
            //Teacher_CMB.DataSource = dt;
            //Teacher_CMB.DisplayMember = "Emp_Name";
            //Teacher_CMB.ValueMember = "Emp_ID";
        }

        public void Show_Shift()
        {
            dt = obj.ShowRecords("select * from Shift_Info order by Shift_ID DESC");
            Shift_CMB.DataSource = dt;
            Shift_CMB.DisplayMember = "Shift_Name";
            Shift_CMB.ValueMember = "Shift_ID";
        }

        public void Show_Class_Name()
        {
           
            dt = obj.ShowRecords("Select * from Class_Info order by Class_ID DESC");
            Cmb_Class.DataSource = dt;
            Cmb_Class.DisplayMember = "CName";
            Cmb_Class.ValueMember = "Class_ID";
        }


        public void Show_Section_Name()
        {
           
            dt = obj.ShowRecords("select * from Section_Info order by Section_ID DESC");
            Cmb_Section.DataSource = dt;
            Cmb_Section.DisplayMember = "Section_Name";
            Cmb_Section.ValueMember = "Section_ID";
        }


        public void FillGrid()
        {
            
            dt = obj.ShowRecords("Select S_ID as [Student ID],Name,FName as [Fater Name],Gender,Date,Status,Image2 as Image ,User_History as [User] from Student_Info where IsAdmited='NotAdmited' order by S_ID DESC");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    Student_List.DataSource = dt;
                    Student_List.Columns[0].Width = 130;
                    Student_List.Columns[1].Width = 120;
                    Student_List.Columns[2].Width = 150;
                    Student_List.Columns[3].Visible = false;
                    Student_List.Columns[4].Width = 120;
                    Student_List.Columns[5].Width = 100;
                    Student_List.Columns[6].Width = 100;
                    Student_List.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                   
                }
                else
                {
                    Student_List.DataSource = null;

                }
            }
            else
            {
                Student_List.DataSource = null;
            }
        }
         

        public void Show_Student_GRD()
        {
            dt = obj.ShowRecords("select * from Student_Info order by S_ID DESC");
            Student_List.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Show_Class_Name();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Show_Section_Name();
        }

       

        private void By_ID_TextChanged(object sender, EventArgs e)
        {

            dt = obj.ShowRecords("Select S_ID as [Student ID],Name,FName as [Fater Name],Gender,Date,Status,Image2 as Image ,User_History as [User] from Student_Info where IsAdmited='NotAdmited' and S_ID like '%" + By_ID.Text + "%' order by S_ID DESC");
            Student_List.DataSource = dt;
        }

        private void By_Name_TextChanged(object sender, EventArgs e)
        {
            dt = obj.ShowRecords("Select S_ID as [Student ID],Name,FName as [Fater Name],Gender,Date,Status,Image2 as Image ,User_History as [User] from Student_Info where IsAdmited='NotAdmited' and Name Like '%" + By_Name.Text + "%' order by S_ID DESC");
            Student_List.DataSource = dt;
        }

        private void New_Click(object sender, EventArgs e)
        {
           
           
        }

        public void Add_New()
        {
           
            dt = obj.ShowRecords("Select Max(Admission_ID) as maxid from Admission_Info");
            Admission_ID.Text = dt.Rows[0]["maxid"].ToString();
        }
        //int std_ID;
        private void Student_List_MouseClick(object sender, MouseEventArgs e)
        {
            //ep.Clear();
            //try
            //{

            //    std_ID = int.Parse(Student_List.SelectedRows[0].Cells[0].FormattedValue.ToString());
            //    Student_ID.Text = Student_List.SelectedRows[0].Cells[0].FormattedValue.ToString();
            //    Student_Name.Text = Student_List.SelectedRows[0].Cells[1].FormattedValue.ToString();

            //    DBAccess.My_Other_Funtion obj_other = new DBAccess.My_Other_Funtion();

            //    DBAccess.DBGenral obj = new DBAccess.DBGenral();
            //    DataTable dt = new DataTable();

            //    dt = obj.ShowRecords("select * from Student_Info where S_ID='" + std_ID + "'");
            //    Admi_Pic.Image = obj_other.Byte_To_Image((Byte[])dt.Rows[0]["Image2"]);
            //   // MetroFramework.MetroMessageBox.Show(this, "Record Number ( " + Student_ID.Text + " ) is Selected Sucessfully ", "AL-Khabar Private High School........ Selection Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);


            //}
            //catch (Exception ex)
            //{
            //   // MetroFramework.MetroMessageBox.Show(this, "Sorry in This Row Picture is Not Avilable ", "AL-Khabar Private High School........ Selection Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            //    MessageBox.Show("You Seleted an Empty Row ... Pleae Select a Record to Continue" + ex);
            //}

        }

        private void Save_Click(object sender, EventArgs e)
        {            ep.Clear();

             if(Student_ID.Text.Trim()=="")
            {
                ep.SetError(Student_ID, "Please Select A Student to Continue !!!");
                Student_List.Focus();
            }else if(Student_Name.Text.Trim()=="")
            {
                ep.SetError(Student_ID, "Please Select A Student to Continue !!!");
                Student_List.Focus();
            }else if(Amount.Text.Trim()=="")
            {
                ep.SetError(Amount, "Please Enter Admission Amount To Continue !!!");
                Amount.Focus();
            }else if(Extra_Exp.Text.Trim()=="")
            {
                ep.SetError(Extra_Exp, "Please Enter The Extra Expence Of Student !!!");
                Extra_Exp.Focus();

            }else if(Extra.Text.Trim()=="")
            {
                ep.SetError(Extra,"Please Enter Any Discount For The Student If Student is Valide For Discount !!!");
                Extra.Focus();
            }else if(Cmb_Class.Text.Trim()=="")
            {
                ep.SetError(Cmb_Class,"Please Select a Class to The Current Student !!!");
                Cmb_Class.Focus();
            }else if(Cmb_Section.Text.Trim()=="")
            {
                ep.SetError(Cmb_Section, "Please Select a Section to the Current Student !!!");
                Cmb_Section.Focus();
            }else if(DESC.Text.Trim()=="")
            {
                ep.SetError(DESC,"Please Enter Any Description to this Student !!!");
                DESC.Focus();
            }
            else
            {
                dt = obj.ShowRecords("select * from Admission_Info where S_ID='"+Student_ID.Text+"'");
                if(dt.Rows.Count>0)
                {
                    MessageBox.Show("Sorry !!! The Student you have Selected for Admission is Already Admited Sucessfully");
                }
                else
                {
                    obj.Genral_Queries("insert into Admission_Info (S_ID,Amount,Date,Class_ID,Section_ID,Discount,Extra,Total,User_History,Description,Class_Fee,Shift_ID) values ('" + int.Parse(Student_ID.Text) + "','" + float.Parse(Amount.Text) + "','" +System.DateTime.Now + "','" + Cmb_Class.Text + "','" + Cmb_Section.Text + "','" + float.Parse(Extra.Text) + "','" + float.Parse(Extra_Exp.Text) + "','" + float.Parse(Total.Text) + "','" + LB_addmission.Text + "','" + DESC.Text + "','"+Class_Fee.Text+"','"+Shift_CMB.Text+"')");
                    obj.Genral_Queries("insert into Account_Info (Admission_ID,Debit,Description,Date,User_History) values ('" + Admission_ID.Text + "','" + Total.Text + "','" + DESC.Text + "{Addmission Amount}','" +System.DateTime.Now + "','" + LB_addmission.Text + "')");

                    DataTable dt_search = new DataTable();
                    dt_search = obj.ShowRecords("select * from Borrow_Info where S_ID ='" + Student_ID .Text+ "'");
                    if(dt_search.Rows.Count>0)
                    {
                        float old = float.Parse(dt_search.Rows[0]["Borrow_Amount"].ToString());
                        float New = float.Parse(Remining_Amount.Text.ToString());
                        float All = old + New;

                        obj.Genral_Queries("update Borrow_Info set Borrow_Amount='" + All + "', Debit_Credit='Credit', Date='" + System.DateTime.Now + "',Description='" + DESC.Text + "',User_History='" + LB_addmission.Text + "' where S_ID='"+Student_ID.Text+"'");

                    }else
                    {
                        obj.Genral_Queries("insert into Borrow_Info (S_ID,Borrow_Amount,Debit_Credit,Date,Description,User_History) values ('"+int.Parse(Student_ID.Text)+"','"+float.Parse(Remining_Amount.Text)+"','Credit','"+System.DateTime.Now+"','"+DESC.Text+"','"+LB_addmission.Text+"')");
                    }

                    MessageBox.Show("Student Admission is Done !!!! ");
                    obj.Genral_Queries("insert Into Log_Info (User_History,Date,Operation) values ('" + LB_addmission.Text + "','" + System.DateTime.Now + "',' New Student " + Student_Name.Text + " is Admited in Class " + Cmb_Class.Text + " Section " + Cmb_Section.Text + " Sucessfully by " + LB_addmission.Text + " User')");
                    obj.Genral_Queries("update Student_Info set IsAdmited='Admited' where S_ID='" + Student_ID .Text+ "'");
                    FillGrid();
                    //Clean_Box();
                }
            }
        }

        public void Clean_Box()
        {
             Student_ID.Text = Student_Name.Text = Amount.Text = Total.Text = "";
            Cmb_Class.Text = "Select Your Class";
            Cmb_Section.Text = "Select Your Section";
            DESC.Text = "";
            Remining_Amount.Text = "0";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            if(Clear.Text=="Borrow")
            {
                Borrow_Section.Admission_Borrow_Form Borrow = new Borrow_Section.Admission_Borrow_Form();
                Borrow.LB_addmission.Text = LB_addmission.Text.ToString();
                Borrow.B_Student_ID.Text = Student_ID.Text.ToString();
                Borrow.B_Student_Name.Text = Student_Name.Text.ToString();
                Borrow.B_Amount.Text = Remining_Amount.Text.ToString();
                Borrow.B_Student_pic.Image = Admi_Pic.Image;
                Borrow.Show();
            }
            else if (Remining_Amount.Text == "0" || Remining_Amount.Text=="")
            {
                Clean_Box();
                Admission_ID.Text = "";
                btn_Report.Text = "Print All Addmissions";

                //Add New Button Functions
                //Add_New();
                //btn_Report.Text = "Recipt";
                Extra.Text = "0";
                Extra_Exp.Text = "0";
                Stationary.Enabled = false;
            }


           
        }

        private void GetData_Click(object sender, EventArgs e)
        {
            DBAccess.DBGenral Obj = new DBAccess.DBGenral();
             Admission.Student_Admission_Table Table = new Admission.Student_Admission_Table();
             Table.LB_addmission.Text = LB_addmission.Text.ToString();
             Obj.Genral_Queries("insert Into Log_Info (User_History,Date,Time,Operation) Values ('" + LB_addmission.Text + "','" + System.DateTime.Now + "','" + System.DateTime.Now.ToString("HH:mm") + "','The User " + LB_addmission.Text + " Sucessfully Opened the Student Admission Table')");

            Table.ShowDialog();
        }

        private void Amount_TextChanged(object sender, EventArgs e)
        {
            ep.Clear();

            if(Amount.Text!="")
            {
                Total.Text = Amount.Text.ToString();
            }
            else
            {
                Total.Text = "0";
            }
        }

        private void Extra_TextChanged(object sender, EventArgs e)
        {
            ep.Clear();
        }

        private void Browes_Click(object sender, EventArgs e)
        {

        }

        private void Extra_Exp_TextChanged(object sender, EventArgs e)
        {
            ep.Clear();
        }

        private void Extra_Exp_Leave(object sender, EventArgs e)
        {
            if(Amount.Text.Trim()=="")
            {
                ep.SetError(Amount, "Please Enter Your Admission Amount to Continue !!!");
                Amount.Focus();
            }
            else
            {
                if (Extra_Exp.Text != "")
                {
                    int My_total = int.Parse(Total.Text.ToString());
                    int My_E_Exp = int.Parse(Extra_Exp.Text.ToString());
                    int My_All = My_total + My_E_Exp;
                    Total.Text = My_All.ToString();
                }
                else
                {
                    //Total.Text = Total.Text.ToString();
                }
            }

           
        }

        private void Extra_Leave(object sender, EventArgs e)
        {
            if(Amount.Text.Trim()=="")
            {
                ep.SetError(Amount, "Please Enter Your Admission Amount to Continue !!!");
                Amount.Focus();
            }

            if (Extra.Text != "")
            {
               // int Amo = int.Parse(Amount.Text.ToString());
              
                int  All_Total = int.Parse(Total.Text.ToString());
                int DIs = int.Parse(Extra.Text.ToString());

                int tot = All_Total - DIs;
                Total.Text = tot.ToString();
            }
            else
            {
                Total.Text = Amount.Text.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //DBAccess.DBGenral obj = new DBAccess.DBGenral();
            //obj.Genral_Queries("Delete from Admission_Info where Admission_ID='" + Admission_ID .Text+ "'");
            //MessageBox.Show("Record Number( "+Admission_ID.Text +" ) is Deleted Successfully");

        }

        private void Update_Click(object sender, EventArgs e)
        {
            DBAccess.DBGenral Log = new DBAccess.DBGenral();
            if(Admission_ID.Text!="")
            {
                if(Amount.Text.Trim()=="")
                {
                    ep.SetError(Amount, "Please Fill all Boxes then Print the Slip !!!");
                    Amount.Focus();
                }else if(Cmb_Class.Text.Trim()=="")
                {
                    ep.SetError(Cmb_Class, "Please Fill all Boxes then Print the Slip !!!");
                    Cmb_Class.Focus();
                }else
                {
                    Admission.Addmission_Recipt_Form obj = new Admission.Addmission_Recipt_Form();
                    obj.idx = int.Parse(Admission_ID.Text.ToString());
                    obj.Show();
                    Log.Genral_Queries("insert Into Log_Info (User_History,Date,Time,Operation) Values ('" + LB_addmission.Text + "','" + System.DateTime.Now + "','" + System.DateTime.Now.ToString("HH:mm") + "',' A Recipt Form Studetnt " + Student_Name.Text + " is Generated Sucessfully By User " + LB_addmission.Text + "')");
                }
            }
            else
            {
                Admission.All_Addmission_Report_Form all = new Admission.All_Addmission_Report_Form();
                all.Show();
                Log.Genral_Queries("insert Into Log_Info (User_History,Date,Time,Operation) Values ('" + LB_addmission.Text + "','" + System.DateTime.Now + "','" + System.DateTime.Now.ToString("HH:mm") + "',' A Recipt Form All Students is Generated Sucessfully By User " + LB_addmission.Text + "')");

            }


            

        }

        private void Cmb_Class_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DBAccess.DBGenral obj = new DBAccess.DBGenral();
            //DataTable dt = new DataTable();
            //dt = obj.ShowRecords("select Fee as fee from Class_Info where CName='" + Cmb_Class.Text.Trim() + "'");
            //Fee_Amount.Text = dt.Rows[0]["fee"].ToString();
            ep.Clear();
        }

        private void Cmb_Section_SelectedIndexChanged(object sender, EventArgs e)
        {
            ep.Clear();
        }


        DBAccess.DBGenral obj = new DBAccess.DBGenral();
        DataTable dt = new DataTable();
        DBAccess.My_Other_Funtion obj_other = new DBAccess.My_Other_Funtion();
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ep.Clear();

            if(Student_List.DataSource!=null)
            {
                if(Student_List.Rows.Count > 0)
                {
                    if(Student_List.SelectedRows.Count==1)
                    {
                        try
                        {
                            Student_ID.Text = Convert.ToString(Student_List.CurrentRow.Cells[0].Value);
                            Student_Name.Text = Convert.ToString(Student_List.CurrentRow.Cells[1].Value);


                            
                            dt = obj.ShowRecords("select * from Student_Info where S_ID='" + Student_List.CurrentRow.Cells[0].Value + "'");
                            Admi_Pic.Image = obj_other.Byte_To_Image((Byte[])dt.Rows[0]["Image2"]);
                            Add_New();
                            btn_Report.Text = "Recipt";
                            Stationary.Enabled = true;

                        }
                        catch
                        {

                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Select One Record !!! ", "Al-Khabar Private High School Management System", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    }
                }
                else
                {
                    MessageBox.Show("The List is Empty", "Al-Khabar Private High School Management System", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                }
                
            }
        }

        private void Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void Extra_Exp_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void Extra_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void DESC_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
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

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void Cmb_Class_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
            dt = obj.ShowRecords("select Fee as fee from Class_Info where CName='" + Cmb_Class.Text.Trim() + "'");
            Class_Fee.Text = dt.Rows[0]["fee"].ToString();
            Amount.Text = Class_Fee.Text.ToString();
        }

        private void Remining_Amount_TextChanged(object sender, EventArgs e)
        {
            if(Remining_Amount.Text=="" || Remining_Amount.Text=="0" || Amount.Text.Trim()=="")
            {
                Clear.Text = "Clean";
               
            }
            else
            {
                Clear.Text = "Borrow";
               
            }


           

        }

        private void Total_TextChanged(object sender, EventArgs e)
        {

        }

        private void Remining_Amount_Leave(object sender, EventArgs e)
        {
            if(Total.Text.Trim()=="")
            {
                ep.SetError(Total,"Please Enter Your Admission Amount to Continue !!!");
                Student_List.Focus();
            }
            else
            {

                if (Remining_Amount.Text != "" || Remining_Amount.Text == "0")
                {
                    int M_Total = int.Parse(Total.Text.ToString());
                    int Remin = int.Parse(Remining_Amount.Text.ToString());
                    int All = M_Total - Remin;
                    Total.Text = All.ToString();
                }
                else
                {
                    Total.Text = Total.Text.ToString();
                }
            }

        }

        private void Teacher_CMB_SelectionChangeCommitted(object sender, EventArgs e)
        {
           // dt = obj.ShowRecords("select * from Class_to_Teacher where Emp_ID='"+Teacher_CMB.SelectedIndex+"'");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Stationary_Click(object sender, EventArgs e)
        {
            Statinary_Sale.Sale_Form Sale = new Statinary_Sale.Sale_Form();

            dt = obj.ShowRecords("select * from Student_Info where S_ID='" + Student_ID.Text + "'");
            Sale.S_ID.Text = dt.Rows[0]["S_ID"].ToString();
            Sale.LB_S.Text = Student_Name.Text.ToString();
            Sale.Class_Name.Text = Cmb_Class.Text.ToString();
            Sale.image.Image = obj_other.Byte_To_Image((Byte[])dt.Rows[0]["Image2"]);
            Sale.LB_Sale_User.Text = LB_addmission.Text.ToString();
            Sale.Show();

        }
       
        public void Student_Data()
        {
            //dt = obj.ShowRecords("select * from Student_Info where S_ID='" + S_ID.Text + "'");
            //S_ID.Text = dt.Rows[0]["S_ID"].ToString();
            //Class_Name.Text = dt.Rows[0]["Class_ID"].ToString();
            //image.Image = obj_other.Byte_To_Image((Byte[])dt.Rows[0]["Image2"]);
        }
    }
}
