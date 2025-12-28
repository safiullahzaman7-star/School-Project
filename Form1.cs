using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySchoolProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newStudentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Student_Section.Student_Regestration obj = new Student_Section.Student_Regestration();
            obj.LB_Std_Reg.Text = LBUser.Text.ToString();
            obj.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Student_Section.Student_Regestration obj = new Student_Section.Student_Regestration();
            obj.LB_Std_Reg.Text = LBUser.Text.ToString();
            obj.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Student_Section.Edit_Student obj = new Student_Section.Edit_Student();
            obj.LB_Std_Edit.Text = LBUser.Text.ToString();
            obj.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Fee_Section.Fee_Section_Form2 fee = new Fee_Section.Fee_Section_Form2();
            fee.LB_Fee.Text = LBUser.Text;
            fee.ShowDialog();
        }

        private void feeSection2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Student_Section.Edit_Student edit = new Student_Section.Edit_Student();
            edit.LB_Std_Edit.Text = LBUser.Text.ToString();
            edit.ShowDialog();

        }

        private void feeListToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Employee_Section.Employee_form EF = new Employee_Section.Employee_form();
            EF.LB_New_Emp.Text = LBUser.Text.ToString();
            EF.ShowDialog();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Employee_Section.Employee_Edit_Form ED = new Employee_Section.Employee_Edit_Form();
            ED.LB_Emp_Edit.Text = LBUser.Text.ToString();
            ED.ShowDialog();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Employee_Section.Employee_Search_Form Search = new Employee_Section.Employee_Search_Form();
            Search.LB_Emp_Search.Text = LBUser.Text.ToString();
            Search.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login_Form log = new Login_Form();
            obj.Genral_Queries("insert into Log_Info (User_History,Date,Time,Operation) values ('" + LBUser.Text + "','" + System.DateTime.Now + "','" +System.DateTime.Now.ToString("HH:mm") + "','A User " + LBUser.Text + " is Logged Out Sucessfully By " + LBUser.Text + "')");

            this.Close();
            log.Show();


        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            Admission.Admission_From Form = new Admission.Admission_From();
            Form.LB_addmission.Text = LBUser.Text.ToString();
            Form.ShowDialog();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton9_Click_1(object sender, EventArgs e)
        {
            Salary_Section.PayRoll_Form pay = new Salary_Section.PayRoll_Form();
            pay.LB_PayRoll.Text = LBUser.Text;
            pay.ShowDialog();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            Admission.Class_Form form = new Admission.Class_Form();
            form.LB_Class.Text = LBUser.Text.ToString();
            form.ShowDialog();
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            Admission.Admission_Section Form = new Admission.Admission_Section();
            Form.LB_Section.Text = LBUser.Text.ToString();
            Form.ShowDialog();
        }

        private void examTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void shiftTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void subjectTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            Exam.Exam_Details_Form obj = new Exam.Exam_Details_Form();
            obj.LB_Exam_Entry.Text = LBUser.Text.ToString();
            obj.Show();
        }

        private void examForm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
        }

        private void feeDetaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void editExamToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void studentSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void newEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_Section.Employee_form form = new Employee_Section.Employee_form();
            form.LB_New_Emp.Text = LBUser.Text.ToString();
            form.ShowDialog();
        }

        private void examTypeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Exam.Exam_Type type = new Exam.Exam_Type();
            //type.LB_Exam_Type.Text = LBUser.Text.ToString();
            //type.ShowDialog();
        }

        private void newShiftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exam.Shift_Form shift = new Exam.Shift_Form();
            shift.LB_Shift.Text = LBUser.Text.ToString();
            shift.ShowDialog();
        }

        private void newSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Exam.Subject_Form form = new Exam.Subject_Form();
            //form.ShowDialog();
        }

        private void newClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admission.Class_Form classs = new Admission.Class_Form();
            classs.LB_Class.Text = LBUser.Text.ToString();
            classs.ShowDialog();
        }

        private void newSectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admission.Admission_Section section = new Admission.Admission_Section();
            section.LB_Section.Text = LBUser.Text.ToString();
            section.ShowDialog();
        }

        private void newStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_Section.Add_Status_form st = new Employee_Section.Add_Status_form();
            st.LB_Status.Text = LBUser.Text.ToString();
            st.ShowDialog();
        }

        private void newEmployeeTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_Section.Employee_Type_Form type = new Employee_Section.Employee_Type_Form();
            type.LB_Emp_Type.Text = LBUser.Text.ToString();
            type.ShowDialog();
        }

        private void feeTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fee_Section.Fee_Type type = new Fee_Section.Fee_Type();
            type.LB_Fee_Type.Text = LBUser.Text.ToString();
            type.ShowDialog();
        }

        private void monthNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fee_Section.Month_Name Name = new Fee_Section.Month_Name();
            Name.LB_Month.Text = LBUser.Text.ToString();
            Name.ShowDialog();

        }

        private void editEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_Section.Employee_Edit_Form edit = new Employee_Section.Employee_Edit_Form();
            edit.LB_Emp_Edit.Text = LBUser.Text.ToString();
            edit.ShowDialog();
        }

        private void employeeSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_Section.Employee_Search_Form search = new Employee_Section.Employee_Search_Form();
            search.ShowDialog();
        }

        private void employeeSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void salaryTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_Section.Salary_Table table = new Employee_Section.Salary_Table();
            table.ShowDialog();
        }

        private void feePayingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fee_Section.Fee_Section_Form2 section = new Fee_Section.Fee_Section_Form2();
            section.LB_Fee.Text = LBUser.Text;
            section.Show();
        }

        private void feeListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void studentAddmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admission.Admission_From form = new Admission.Admission_From();
            form.LB_addmission.Text = LBUser.Text.ToString();
            form.ShowDialog();
        }

        private void addmissionListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admission.Student_Admission_Table table = new Admission.Student_Admission_Table();
            table.ShowDialog();
        }

        private void examMarksEnteryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void userToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            User_Grants.Check_Password ch = new User_Grants.Check_Password();
            ch.Your_ID.Text = LBID.Text.ToString();
            ch.Your_Name.Text = LBUser.Text.ToString();
            ch.User_Right.Text = User_Type_Now.Text.ToString();
            ch.Show();

            //User_Grants.User_Grants user = new User_Grants.User_Grants();
            //user.LB_User_Rights.Text = LBUser.Text.ToString();
            //user.ShowDialog();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            //dt = obj.ShowRecords("select * from Login_Info where UserName='"+LBUser.Text+"' and ID='"+LBID.Text+"'");
            User_Grants.Check_Password ch = new User_Grants.Check_Password();
            ch.Your_ID.Text = LBID.Text.ToString();
            ch.Your_Name.Text = LBUser.Text.ToString();
            ch.User_Right.Text = User_Type_Now.Text.ToString();
            ch.Show();


            
        }

        public void Back_Image()
        {

            DBAccess.My_Other_Funtion My_obj = new DBAccess.My_Other_Funtion();
            My_obj.Browse_Image(Back_PIC);


            if (MetroFramework.MetroMessageBox.Show(this, "Do You Want to Update the Backgruond Picture", "Backgruond Picture UpDating Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DBAccess.DBGenral obj = new DBAccess.DBGenral();
                DBAccess.My_Other_Funtion obj_other = new DBAccess.My_Other_Funtion();
                SqlCommand cmd = new SqlCommand("update BackImage set BackImage=@img where ID='1'", obj.conn);
                cmd.Parameters.Add("@img", SqlDbType.Image).Value = obj_other.Image_To_Byte(Back_PIC.Image);
                obj.Insert_with_SQLCommand(cmd);
                //MessageBox.Show("Back Image is Updated Successfully","Back Image Message",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);

                //MetroFramework.MetroMessageBox.Show(this, "Record Number is Deleted Sucessfully", "Record Deleting Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {
                //MetroFramework.MetroMessageBox.Show(this, "Deleting Operation is Cancelled", "Operation Cancelled", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                //MessageBox.Show("Opreation is Canceled ", "Back Image Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            }
        }


        public void S_Back_Image()
        {
            DBAccess.My_Other_Funtion obj_other = new DBAccess.My_Other_Funtion();
            DBAccess.DBGenral obj = new DBAccess.DBGenral();
            DataTable dt = new DataTable();
            dt = obj.ShowRecords("select * from BackImage where ID ='1'");
            Back_PIC.Image = obj_other.Byte_To_Image((Byte[])dt.Rows[0]["BackImage"]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Back_Image();

            obj.Genral_Queries("insert into Log_Info (User_History,Date,Time,Operation) Values ('"+LBUser.Text+"','"+System.DateTime.Now+"','"+System.DateTime.Now.ToString("HH:mm")+"','A Background Image is Changed By User "+LBUser.Text+" Sucessfully')");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Section.New_User_ChPassword ch = new User_Section.New_User_ChPassword();


           // User_Section.Check_Password ch = new User_Section.Check_Password();
            ch.Your_ID.Text = LBID.Text.ToString();
            ch.Your_Name.Text = LBUser.Text.ToString();
            ch.Show();

            //User_Section.New_User_Form obj = new User_Section.New_User_Form();
            //obj.LBUser_Reg.Text = LBUser.Text.ToString();
            //obj.ShowDialog();
        }

        private void userTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Section.User_Type obj = new User_Section.User_Type();
            obj.LB_User_Type.Text = LBUser.Text.ToString();
            obj.ShowDialog();
        }

        private void questionTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Section.Questions_Form q = new User_Section.Questions_Form();
            q.LB_question.Text = LBUser.Text.ToString();
            q.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DBAccess.My_Other_Funtion Other = new DBAccess.My_Other_Funtion();
            DBAccess.DBGenral obj = new DBAccess.DBGenral();
            DataTable dt = new DataTable();
            dt = obj.ShowRecords("select * from Login_Info where ID='" + LBID.Text + "'");

            User_Section.User_Profile profile = new User_Section.User_Profile();
            profile.Profile_FullName.Text = LBUser.Text.ToString();
            profile.Profile_ID.Text = LBID.Text.ToString();
            profile.Profile_Pic.Image = Other.Byte_To_Image((Byte[])dt.Rows[0]["Image"]);
            profile.Profile_UserName.Text = dt.Rows[0]["UserName"].ToString();
            profile.Profile_UserType.Text = dt.Rows[0]["UserType"].ToString();
            profile.Profile_Gender.Text = dt.Rows[0]["Gender"].ToString();
            profile.ShowDialog();

            obj.Genral_Queries("insert into Log_Info (User_History,Date,Operation) values ('" + profile.Profile_FullName.Text + "','" + System.DateTime.Now + "','A User " + profile.Profile_FullName.Text + "  Profile is Viewed Sucessfully By " + profile.Profile_FullName.Text + "')");

        }

        private void upDateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Section.Check_Password ch = new User_Section.Check_Password();
            ch.Your_ID.Text = LBID.Text.ToString();
            ch.Your_Name.Text = LBUser.Text.ToString();
            ch.Show();
        }


        public void Show_User_Type_CMB()
        {
            
            //dt = obj.ShowRecords("select * from User_Type order by ID DESC");
            //User_Type_CMB.DataSource = dt;
            //User_Type_CMB.DisplayMember = "Type";
            //User_Type_CMB.ValueMember = "ID";
        }

        public void Show_Form_Name_CMB()
        {
            //dt = obj.ShowRecords("select * from Form_Info");
            //Cmb_FormName.DataSource = dt;
            //Cmb_FormName.DisplayMember = "Form";
            //Cmb_FormName.ValueMember = "ID";
        }

        DBAccess.DBGenral obj = new DBAccess.DBGenral();
        DataTable dt = new DataTable();

        public void Show_Status_CMB()
        {
           
            //dt = obj.ShowRecords("select * from Status_Info order by A_ID DESC");
            //CMB_Status.DataSource = dt;
            //CMB_Status.DisplayMember = "Status";
            //CMB_Status.ValueMember = "A_ID";
        }
        public string user;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Show_Status_CMB();
            //Show_User_Type_CMB();
            //Show_Form_Name_CMB();
            //Refrech_My_Ch_Box();
            //Show_Back_Image.Checked = true;
            Active_Disactive();
            S_Back_Image();
           
            
        }

        public void Active_Disactive()
        {
            DataTable dt_Log_Tab = new DataTable();
            dt_Log_Tab = obj.ShowRecords("select * from User_Rights where Rights_ID='62' and UserType='" + User_Type_Now.Text + "'");

            if (dt_Log_Tab.Rows.Count > 0)
            {

                if (dt_Log_Tab.Rows[0]["Status"].ToString() == "Active")
                {
                   Logs.Enabled = true;
                }
                else
                {
                    Logs.Enabled = false;
                }


            }
            else
            {

            }




            DataTable dt_Account = new DataTable();
            dt_Account = obj.ShowRecords("select * from User_Rights where Rights_ID='64' and UserType='" + User_Type_Now.Text + "'");

            if (dt_Account.Rows.Count > 0)
            {

                if (dt_Account.Rows[0]["Status"].ToString() == "Active")
                {
                    Account_Tab.Enabled = true;
                }
                else
                {
                    Account_Tab.Enabled = false;
                }


            }
            else
            {

            }


            DataTable dt_Promote = new DataTable();
            dt_Promote = obj.ShowRecords("select * from User_Rights where Rights_ID='63' and UserType='" + User_Type_Now.Text + "'");

            if (dt_Promote.Rows.Count > 0)
            {

                if (dt_Promote.Rows[0]["Status"].ToString() == "Active")
                {
                    Promote.Enabled = true;
                }
                else
                {
                   Promote.Enabled = false;
                }


            }
            else
            {

            }


            DataTable dt_Master_Entery = new DataTable();
            dt_Master_Entery = obj.ShowRecords("select * from User_Rights where Rights_ID='19' and UserType='" + User_Type_Now.Text + "'");
            if (dt_Master_Entery.Rows.Count > 0)
            {

                if (dt_Master_Entery.Rows[0]["Status"].ToString() == "Active")
                {
                    Master_Entery.Enabled = true;
                }
                else
                {
                    Master_Entery.Enabled = false;
                }


            }
            DataTable dt_New_User = new DataTable();
            dt_New_User = obj.ShowRecords("select * from User_Rights where Rights_ID='20' and UserType='" + User_Type_Now.Text + "'");

            if (dt_New_User.Rows.Count > 0)
            {
                if (dt_New_User.Rows[0]["Status"].ToString() == "Active")
                {
                    New_User_Form.Enabled = true;
                }
                else
                {
                    New_User_Form.Enabled = false;
                }

            }

            DataTable dt_UpDate_User = new DataTable();
            dt_UpDate_User = obj.ShowRecords("select * from User_Rights where Rights_ID='21' and UserType='" + User_Type_Now.Text + "'");
            if (dt_UpDate_User.Rows.Count > 0)
            {
                if (dt_UpDate_User.Rows[0]["Status"].ToString() == "Active")
                {
                    UpDate_User_Form.Enabled = true;
                }
                else
                {
                    UpDate_User_Form.Enabled = false;
                }

            }

            DataTable dt_UserType = new DataTable();
            dt_UserType = obj.ShowRecords("select * from User_Rights where Rights_ID='22' and UserType='" + User_Type_Now.Text + "'");
            if (dt_UserType.Rows.Count > 0)
            {
                if (dt_UserType.Rows[0]["Status"].ToString() == "Active")
                {
                    User_Type_Form.Enabled = true;

                }
                else
                {
                    User_Type_Form.Enabled = false;
                }
            }

            DataTable dt_Question_Type = new DataTable();
            dt_Question_Type = obj.ShowRecords("select * from User_Rights where Rights_ID='23' and UserType='" + User_Type_Now.Text + "'");
            if (dt_Question_Type.Rows.Count > 0)
            {
                if (dt_Question_Type.Rows[0]["Status"].ToString() == "Active")
                {
                    Question_Type_Form.Enabled = true;

                }
                else
                {
                    Question_Type_Form.Enabled = false;
                }
            }


            DataTable dt_Profile = new DataTable();
            dt_Profile = obj.ShowRecords("select * from User_Rights where Rights_ID='24' and UserType='" + User_Type_Now.Text + "'");
            if (dt_Profile.Rows.Count > 0)
            {
                if (dt_Profile.Rows[0]["Status"].ToString() == "Active")
                {
                    Profile_Form.Enabled = true;
                }
                else
                {
                    Profile_Form.Enabled = false;
                }
            }

            DataTable dt_New_Student = new DataTable();
            dt_New_Student = obj.ShowRecords("select * from User_Rights where Rights_ID='25' and UserType='" + User_Type_Now.Text + "'");
            if (dt_New_Student.Rows.Count > 0)
            {
                if (dt_New_Student.Rows[0]["Status"].ToString() == "Active")
                {
                    New_Student_Form.Enabled = true;
                }
                else
                {
                    New_Student_Form.Enabled = false;
                }
            }


            DataTable dt_User_Tab = new DataTable();
            dt_User_Tab = obj.ShowRecords("select * from User_Rights where Rights_ID='26' and UserType='" + User_Type_Now.Text + "'");
            if (dt_User_Tab.Rows.Count > 0)
            {
                if (dt_User_Tab.Rows[0]["Status"].ToString() == "Active")
                {
                    User_Tab_Menu.Enabled = true;
                }
                else
                {
                    User_Tab_Menu.Enabled = false;
                }
            }


            DataTable dt_New_Emp = new DataTable();
            dt_New_Emp = obj.ShowRecords("select * from User_Rights where Rights_ID='27' and UserType='" + User_Type_Now.Text + "'");
            if (dt_New_Emp.Rows.Count > 0)
            {
                if (dt_New_Emp.Rows[0]["Status"].ToString() == "Active")
                {
                    New_Emp_Form.Enabled = true;
                }
                else
                {
                    New_Emp_Form.Enabled = false;
                }
            }


            DataTable dt_New_Subject = new DataTable();
            dt_New_Subject = obj.ShowRecords("select * from User_Rights where Rights_ID='28' and UserType='" + User_Type_Now.Text + "'");
            if (dt_New_Subject.Rows.Count > 0)
            {
                if (dt_New_Subject.Rows[0]["Status"].ToString() == "Active")
                {
                    New_Subject_Form.Enabled = true;
                }
                else
                {
                    New_Subject_Form.Enabled = false;
                }
            }



            DataTable dt_New_Calss = new DataTable();
            dt_New_Calss = obj.ShowRecords("select * from User_Rights where Rights_ID='29' and UserType='" + User_Type_Now.Text + "'");
            if (dt_New_Calss.Rows.Count > 0)
            {
                if (dt_New_Calss.Rows[0]["Status"].ToString() == "Active")
                {
                    New_Class_Form.Enabled = true;

                }
                else
                {
                    New_Class_Form.Enabled = false;
                }
            }


            DataTable dt_New_Section = new DataTable();
            dt_New_Section = obj.ShowRecords("select * from User_Rights where Rights_ID='30' and UserType='" + User_Type_Now.Text + "'");
            if (dt_New_Section.Rows.Count > 0)
            {
                if (dt_New_Section.Rows[0]["Status"].ToString() == "Active")
                {
                    New_Section_Form.Enabled = true;

                }
                else
                {
                    New_Section_Form.Enabled = false;
                }
            }


            DataTable dt_New_Status = new DataTable();
            dt_New_Status = obj.ShowRecords("select * from User_Rights where Rights_ID='31' and UserType='" + User_Type_Now.Text + "'");
            if (dt_New_Status.Rows.Count > 0)
            {
                if (dt_New_Status.Rows[0]["Status"].ToString() == "Active")
                {
                    New_Status_Form.Enabled = true;

                }
                else
                {
                    New_Status_Form.Enabled = false;
                }
            }


            DataTable dt_New_Emp_Type = new DataTable();
            dt_New_Emp_Type = obj.ShowRecords("select * from User_Rights where Rights_ID='32' and UserType='" + User_Type_Now.Text + "'");
            if (dt_New_Emp_Type.Rows.Count > 0)
            {
                if (dt_New_Emp_Type.Rows[0]["Status"].ToString() == "Active")
                {
                    Emp_Type.Enabled = true;

                }
                else
                {
                    Emp_Type.Enabled = false;
                }
            }



            DataTable dt_Fee_Type = new DataTable();
            dt_Fee_Type = obj.ShowRecords("select * from User_Rights where Rights_ID='33' and UserType='" + User_Type_Now.Text + "'");
            if (dt_Fee_Type.Rows.Count > 0)
            {
                if (dt_Fee_Type.Rows[0]["Status"].ToString() == "Active")
                {
                    Fee_Type_Form.Enabled = true;
                }
                else
                {
                    Fee_Type_Form.Enabled = false;
                }
            }



            DataTable dt_Month_Name = new DataTable();
            dt_Month_Name = obj.ShowRecords("select * from User_Rights where Rights_ID='37' and UserType='" + User_Type_Now.Text + "'");
            if (dt_Month_Name.Rows.Count > 0)
            {
                if (dt_Month_Name.Rows[0]["Status"].ToString() == "Active")
                {
                    Month_Name_Form.Enabled = true;
                }
                else
                {
                    Month_Name_Form.Enabled = false;
                }
            }




            DataTable dt_New_Shift = new DataTable();
            dt_New_Shift = obj.ShowRecords("select * from User_Rights where Rights_ID='38' and UserType='" + User_Type_Now.Text + "'");
            if (dt_New_Shift.Rows.Count > 0)
            {
                if (dt_New_Shift.Rows[0]["Status"].ToString() == "Active")
                {
                    New_Shift_Form.Enabled = true;
                }
                else
                {
                    New_Shift_Form.Enabled = false;
                }
            }



            DataTable dt_Exam_Type = new DataTable();
            dt_Exam_Type = obj.ShowRecords("select * from User_Rights where Rights_ID='39' and UserType='" + User_Type_Now.Text + "'");
            if (dt_Exam_Type.Rows.Count > 0)
            {
                if (dt_Exam_Type.Rows[0]["Status"].ToString() == "Active")
                {
                    Exam_Type_Form.Enabled = true;
                }
                else
                {
                    Exam_Type_Form.Enabled = false;
                }
            }



            //DataTable dt_Marks_Entry = new DataTable();
            //dt_Marks_Entry = obj.ShowRecords("select * from User_Rights where Rights_ID='40' and UserType='" + User_Type_Now.Text + "'");
            //if (dt_Marks_Entry.Rows.Count > 0)
            //{
            //    if (dt_Marks_Entry.Rows[0]["Status"].ToString() == "Active")
            //    {
            //        Marks_Entry_Form.Enabled = true;
            //    }
            //    else
            //    {
            //        Marks_Entry_Form.Enabled = false;
            //    }
            //}



            DataTable dt_Year_Name = new DataTable();
            dt_Year_Name = obj.ShowRecords("select * from User_Rights where Rights_ID='41' and UserType='" + User_Type_Now.Text + "'");
            if (dt_Year_Name.Rows.Count > 0)
            {
                if (dt_Year_Name.Rows[0]["Status"].ToString() == "Active")
                {
                    Year_Name_Form.Enabled = true;
                }
                else
                {
                    Year_Name_Form.Enabled = false;
                }
            }


            DataTable dt_Form_Name = new DataTable();
            dt_Form_Name = obj.ShowRecords("select * from User_Rights where Rights_ID='42' and UserType='" + User_Type_Now.Text + "'");
            if (dt_Form_Name.Rows.Count > 0)
            {
                if (dt_Form_Name.Rows[0]["Status"].ToString() == "Active")
                {
                    Year_Name_Form.Enabled = true;
                }
                else
                {
                    Year_Name_Form.Enabled = false;
                }
            }




            DataTable dt_Edit_Student = new DataTable();
            dt_Edit_Student = obj.ShowRecords("select * from User_Rights where Rights_ID='43' and UserType='" + User_Type_Now.Text + "'");
            if (dt_Edit_Student.Rows.Count > 0)
            {
                if (dt_Edit_Student.Rows[0]["Status"].ToString() == "Active")
                {
                    Edit_Student_Form.Enabled = true;
                }
                else
                {
                    Edit_Student_Form.Enabled = false;
                }
            }



            DataTable dt_Edit_Emp = new DataTable();
            dt_Edit_Emp = obj.ShowRecords("select * from User_Rights where Rights_ID='44' and UserType='" + User_Type_Now.Text + "'");
            if (dt_Edit_Emp.Rows.Count > 0)
            {
                if (dt_Edit_Emp.Rows[0]["Status"].ToString() == "Active")
                {
                    Edit_Emp_Form.Enabled = true;
                }
                else
                {
                    Edit_Emp_Form.Enabled = false;
                }
            }



            DataTable dt_Disactive_Emp = new DataTable();
            dt_Disactive_Emp = obj.ShowRecords("select * from User_Rights where Rights_ID='45' and UserType='" + User_Type_Now.Text + "'");
            if (dt_Disactive_Emp.Rows.Count > 0)
            {
                if (dt_Disactive_Emp.Rows[0]["Status"].ToString() == "Active")
                {
                    Disactive_Emp_Form.Enabled = true;

                }
                else
                {
                    Disactive_Emp_Form.Enabled = false;
                }
            }



            DataTable dt_Pay_Roll = new DataTable();
            dt_Pay_Roll = obj.ShowRecords("select * from User_Rights where Rights_ID='46' and UserType='" + User_Type_Now.Text + "'");
            if (dt_Pay_Roll.Rows.Count > 0)
            {
                if (dt_Pay_Roll.Rows[0]["Status"].ToString() == "Active")
                {
                    PayRoll_Form.Enabled = true;

                }
                else
                {
                    PayRoll_Form.Enabled = false;
                }
            }



            DataTable dt_Avial_Amount = new DataTable();
            dt_Avial_Amount = obj.ShowRecords("select * from User_Rights where Rights_ID='47' and UserType='" + User_Type_Now.Text + "'");
            if (dt_Avial_Amount.Rows.Count > 0)
            {
                if (dt_Avial_Amount.Rows[0]["Status"].ToString() == "Active")
                {
                    Avilable_Amount_Form.Enabled = true;

                }
                else
                {
                    Avilable_Amount_Form.Enabled = false;
                }
            }




            DataTable dt_Paid_Amount = new DataTable();
            dt_Paid_Amount = obj.ShowRecords("select * from User_Rights where Rights_ID='48' and UserType='" + User_Type_Now.Text + "'");
            if (dt_Paid_Amount.Rows.Count > 0)
            {
                if (dt_Paid_Amount.Rows[0]["Status"].ToString() == "Active")
                {
                    Paid_Amount_Form.Enabled = true;

                }
                else
                {
                    Paid_Amount_Form.Enabled = false;
                }
            }






            DataTable dt_Fee_Paying = new DataTable();
            dt_Fee_Paying = obj.ShowRecords("select * from User_Rights where Rights_ID='49' and UserType='" + User_Type_Now.Text + "'");
            if (dt_Fee_Paying.Rows.Count > 0)
            {
                if (dt_Fee_Paying.Rows[0]["Status"].ToString() == "Active")
                {
                    Fee_Paying_Form.Enabled = true;

                }
                else
                {
                    Fee_Paying_Form.Enabled = false;
                }
            }



            DataTable dt_Student_Tab = new DataTable();
            dt_Student_Tab = obj.ShowRecords("select * from User_Rights where Rights_ID='50' and UserType='" + User_Type_Now.Text + "'");
            if (dt_Student_Tab.Rows.Count > 0)
            {
                if (dt_Student_Tab.Rows[0]["Status"].ToString() == "Active")
                {
                    New_Student_Tab.Enabled = true;

                }
                else
                {
                    New_Student_Tab.Enabled = false;
                }
            }




            DataTable dt_Emp_Tab = new DataTable();
            dt_Emp_Tab = obj.ShowRecords("select * from User_Rights where Rights_ID='51' and UserType='" + User_Type_Now.Text + "'");
            if (dt_Emp_Tab.Rows.Count > 0)
            {
                if (dt_Emp_Tab.Rows[0]["Status"].ToString() == "Active")
                {
                    Emp_Menu.Enabled = true;

                }
                else
                {
                    Emp_Menu.Enabled = false;
                }
            }




            DataTable dt_Salary_Tab = new DataTable();
            dt_Salary_Tab = obj.ShowRecords("select * from User_Rights where Rights_ID='52' and UserType='" + User_Type_Now.Text + "'");
            if (dt_Salary_Tab.Rows.Count > 0)
            {
                if (dt_Salary_Tab.Rows[0]["Status"].ToString() == "Active")
                {
                    Salary_Menu.Enabled = true;

                }
                else
                {
                    Salary_Menu.Enabled = false;
                }
            }




            DataTable dt_Student_Fee_Tab = new DataTable();
            dt_Student_Fee_Tab = obj.ShowRecords("select * from User_Rights where Rights_ID='53' and UserType='" + User_Type_Now.Text + "'");
            if (dt_Student_Fee_Tab.Rows.Count > 0)
            {
                if (dt_Student_Fee_Tab.Rows[0]["Status"].ToString() == "Active")
                {
                    Student_Fee_Menu.Enabled = true;

                }
                else
                {
                    Student_Fee_Menu.Enabled = false;
                }
            }



            DataTable dt_Admission_Tab = new DataTable();
            dt_Admission_Tab = obj.ShowRecords("select * from User_Rights where Rights_ID='54' and UserType='" + User_Type_Now.Text + "'");
            if (dt_Admission_Tab.Rows.Count > 0)
            {
                if (dt_Admission_Tab.Rows[0]["Status"].ToString() == "Active")
                {
                    Admission_Menu.Enabled = true;

                }
                else
                {
                    Admission_Menu.Enabled = false;
                }
            }





            DataTable dt_Exam_Tab = new DataTable();
            dt_Exam_Tab = obj.ShowRecords("select * from User_Rights where Rights_ID='55' and UserType='" + User_Type_Now.Text + "'");
            if (dt_Exam_Tab.Rows.Count > 0)
            {
                if (dt_Exam_Tab.Rows[0]["Status"].ToString() == "Active")
                {
                    Exam_Menu.Enabled = true;

                }
                else
                {
                    Exam_Menu.Enabled = false;
                }
            }



            DataTable dt_Expence_Tab = new DataTable();
            dt_Expence_Tab = obj.ShowRecords("select * from User_Rights where Rights_ID='56' and UserType='" + User_Type_Now.Text + "'");
            if (dt_Expence_Tab.Rows.Count > 0)
            {
                if (dt_Expence_Tab.Rows[0]["Status"].ToString() == "Active")
                {
                    Expence_Menu.Enabled = true;

                }
                else
                {
                    Expence_Menu.Enabled = false;
                }
            }



            DataTable dt_BackUp_Restore_Tab = new DataTable();
            dt_BackUp_Restore_Tab = obj.ShowRecords("select * from User_Rights where Rights_ID='57' and UserType='" + User_Type_Now.Text + "'");
            if (dt_BackUp_Restore_Tab.Rows.Count > 0)
            {
                if (dt_BackUp_Restore_Tab.Rows[0]["Status"].ToString() == "Active")
                {
                    Backup_and_Restore.Enabled = true;

                }
                else
                {
                    Backup_and_Restore.Enabled = false;
                }
            }

        }

        private void salaryEditingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBAccess.My_Other_Funtion Other = new DBAccess.My_Other_Funtion();
            DBAccess.DBGenral obj = new DBAccess.DBGenral();
            DataTable dt = new DataTable();
            dt = obj.ShowRecords("select * from Login_Info where ID='" + LBID.Text + "'");

            User_Section.User_Profile profile = new User_Section.User_Profile();
            profile.Profile_FullName.Text = LBUser.Text.ToString();
            profile.Profile_ID.Text = LBID.Text.ToString();
            profile.Profile_Pic.Image = Other.Byte_To_Image((Byte[])dt.Rows[0]["Image"]);
            profile.Profile_UserName.Text = dt.Rows[0]["UserName"].ToString();
            profile.Profile_UserType.Text = dt.Rows[0]["UserType"].ToString();
            profile.Profile_Gender.Text = dt.Rows[0]["Gender"].ToString();
            profile.ShowDialog();

            obj.Genral_Queries("insert into Log_Info (User_History,Date,Operation) values ('" + profile.Profile_FullName.Text + "','" + System.DateTime.Now + "','A User " + profile.Profile_FullName.Text + "  Profile is Viewed Sucessfully By " + profile.Profile_FullName.Text + "')");

        }

        private void backUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackUp_And_Restore.BackUp up = new BackUp_And_Restore.BackUp();
            up.LB_BackUp.Text = LBUser.Text.ToString();
            up.ShowDialog();
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackUp_And_Restore.Restore re = new BackUp_And_Restore.Restore();
            re.LB_BackUp.Text = LBUser.Text.ToString();
            re.ShowDialog();
        }

        private void newUserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            User_Section.New_User_Form obj = new User_Section.New_User_Form();
            obj.LBUser_Reg.Text = LBUser.Text.ToString();
            obj.ShowDialog();
        }

        private void Back_PIC_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void userRightsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void formNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Grants.Form_Name Name = new User_Grants.Form_Name();
            Name.ShowDialog();
        }

        private void Right_Save_Click(object sender, EventArgs e)
        {
            //DBAccess.DBGenral obj = new DBAccess.DBGenral();
            //DataTable dt = new DataTable();
            //dt = obj.ShowRecords("select * from User_Rights where Form_Name='" + Cmb_FormName.Text + "' and UserType='" + User_Type_CMB.Text + "'");
            //if (dt.Rows.Count > 0)
            //{
            //    obj.Genral_Queries("Update User_Rights set Status='" + CMB_Status.Text + "', User_History='" + LBUser.Text + "' where UserType='" + User_Type_CMB.Text + "' and Form_Name='" + Cmb_FormName.Text + "'");
            //    MessageBox.Show("Your User Old Rights are UpDated Successfully");

            //}
            //else
            //{
            //    obj.Genral_Queries("insert into User_Rights (Form_Name, Status, Date, User_History,UserType) Values ('" + Cmb_FormName.Text + "','" + CMB_Status.Text + "','" + System.DateTime.Now + "','" + LBUser.Text + "','" + User_Type_CMB.Text + "')");
            //    MessageBox.Show("User Rights Entred Suucessfully");
            //}

            ////obj.Genral_Queries("insert into User_Rights (Form_Name, Status, Date, User_History,UserType) Values ('" +Cmb_FormName.Text+ "','" +Ch_Form.Text + "','" + System.DateTime.Now + "','" + LBUser.Text + "','" + User_Type_CMB.Text + "')");

            ////Ch_Refreshing();
            //Refrech_My_Ch_Box();
        }

        private void Show_Back_Image_CheckedChanged(object sender, EventArgs e)
        {
            ////Ch_Refreshing();

            //if (Show_Back_Image.Checked)
            //{
            //    P_User_Rights.Hide();

            //    Back_PIC.Show();
            //    Show_Back_Image.Text = "Show";
            //    LB_Back_Image.Text = "Show User Rights Penal";
            //    Back_Browes.Show();
            //    Change_Back_PIC.Show();

            //}
            //else
            //{
            //    P_User_Rights.Show();
            //    Back_Browes.Hide();
            //    Change_Back_PIC.Hide();
            //    LB_Back_Image.Text = "Show Background Image";
            //    Show_Back_Image.Text = "Hide";

            //}

        }


        public void cheacked_Change()
        {

        }


        private void Ch_New_User_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void feePaying2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void payRollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salary_Section.PayRoll_Form pay = new Salary_Section.PayRoll_Form();
            pay.LB_PayRoll.Text = LBUser.Text.ToString();
            pay.Show();
        }

        private void avilableAmountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salary_Section.Avilable_Amount_Form amount = new Salary_Section.Avilable_Amount_Form();
            amount.LB_Avail_Amount.Text = LBUser.Text.ToString();
            amount.Show();
        }

        private void paidAmountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salary_Section.Paid_Info_From paid = new Salary_Section.Paid_Info_From();
            paid.LB_Paid_Salary.Text = LBUser.Text.ToString();
            paid.Show();
        }

        private void yearNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salary_Section.Year_Name Name = new Salary_Section.Year_Name();
            Name.LB_Emp_Type.Text = LBUser.Text.ToString();
            Name.Show();
        }

        private void attendenceToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void employeeAttendenceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void formNameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void expenceEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expence_Section.Expence_Form obj = new Expence_Section.Expence_Form();
            obj.LB_Fee.Text = LBUser.Text.ToString();
            obj.Show();
        }

        private void dissctiveEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_Section.Fair_Employee obj = new Employee_Section.Fair_Employee();
            obj.LB_Fair_User.Text = LBUser.Text.ToString();

            obj.Show();
        }

        private void Ch_User_Tab_CheckedChanged(object sender, EventArgs e)
        {
            //if (Ch_User_Tab.Checked)
            //{
            //    Ch_User_Tab.Text = "Active";
            //}
            //else
            //{
            //    Ch_User_Tab.Text = "Disactive";
            //}
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Ch_New_User_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }

        private void Ch_UpDate_User_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void User_Type_CMB_DisplayMemberChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void User_Type_CMB_ValueMemberChanged(object sender, EventArgs e)
        {
            
        }

        private void User_Type_CMB_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            User_Grants.User_Rights_GRD obj = new User_Grants.User_Rights_GRD();
            obj.ShowDialog();
        }

        private void exam2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exam.Exam_Details_Form obj = new Exam.Exam_Details_Form();
            obj.LB_Exam_Entry.Text = LBUser.Text.ToString();
            obj.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

           
        }

        private void Logged_PIC_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            DBAccess.DBGenral objec = new DBAccess.DBGenral();
            Login_Form obj = new Login_Form();
            objec.Genral_Queries("insert into Log_Info (User_History,Date,Time,Operation) values ('" + LBUser.Text + "','" + System.DateTime.Now + "','" + System.DateTime.Now.ToString("HH:mm") + "','A User " + LBUser.Text + " is Logged Out Sucessfully By " + LBUser.Text + "')");

            this.Close();
            obj.ShowDialog();
        }

        private void coloToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void Rights_UpDate_Click(object sender, EventArgs e)
        {
            //DBAccess.DBGenral obj = new DBAccess.DBGenral();
            //DataTable dt = new DataTable();
            //dt = obj.ShowRecords("select * from User_Rights where Form_Name='" + Cmb_FormName.Text + "' and UserType='" + User_Type_CMB.Text + "'");
            //if (dt.Rows.Count > 0)
            //{
            //    obj.Genral_Queries("Update User_Rights set Status='" + CMB_Status.Text + "', User_History='" + LBUser.Text + "' where UserType='" + User_Type_CMB.Text + "' and Form_Name='" + Cmb_FormName.Text + "'");
            //    MessageBox.Show("Your User Old Rights are UpDated Successfully");

            //}
            //else
            //{
            //    obj.Genral_Queries("insert into User_Rights (Form_Name, Status, Date, User_History,UserType) Values ('" + Cmb_FormName.Text + "','" + CMB_Status.Text + "','" + System.DateTime.Now + "','" + LBUser.Text + "','" + User_Type_CMB.Text + "')");
            //    MessageBox.Show("User Rights Entred Suucessfully");
            //}

            //obj.Genral_Queries("insert into User_Rights (Form_Name, Status, Date, User_History,UserType) Values ('" +Cmb_FormName.Text+ "','" +Ch_Form.Text + "','" + System.DateTime.Now + "','" + LBUser.Text + "','" + User_Type_CMB.Text + "')");

            
            //Refrech_My_Ch_Box();
            //Active_Disactive();
        }

        private void Show_Back_Image_CheckedChanged_1(object sender, EventArgs e)
        {
            
            ////Refrech_My_Ch_Box();
            //Active_Disactive();
            //if (Show_Back_Image.Checked==true)
            //{
            //    P_User_Rights.Hide();

            //    Back_PIC.Show();
                
            //    Show_Back_Image.Text = "Show User Rights Penal";
            //    Back_Browes.Show();
            //    Change_Back_PIC.Show();

            //}
            //else
            //{
            //    P_User_Rights.Show();
            //    Back_Browes.Hide();
            //    Change_Back_PIC.Hide();
                
            //    Show_Back_Image.Text = "Hide User Rights Panel";

            //}
        }

        private void toolStripButton2_Click_2(object sender, EventArgs e)
        {
            Account_Section.Account_Form obj = new Account_Section.Account_Form();
            obj.LB_Account.Text = LBUser.Text.ToString();
            obj.ShowDialog();
        }

        private void allLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log_Section.User_Log_Form obj = new Log_Section.User_Log_Form();
            obj.LB_Log.Text = LBUser.Text.ToString();
            obj.ShowDialog();
        }

        private void User_Type_CMB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void studentBorrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrow_Section.Admission_Borrow_Form obj = new Borrow_Section.Admission_Borrow_Form();
            obj.LB_addmission.Text = LBUser.Text.ToString();
            obj.ShowDialog();
        }

        private void classesToTeachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class_To_Teacher.Classes_to_Teachers obj = new Class_To_Teacher.Classes_to_Teachers();
            obj.LB_addmission.Text = LBUser.Text.ToString();
            obj.ShowDialog();
        }

        private void attendenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Atendence.Student_Info obj = new Atendence.Student_Info();
            obj.LB_Attendence.Text = LBUser.Text.ToString();
            obj.Show();
        }

        private void attendenceToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Atendence.Employee_Attendenc obj = new Atendence.Employee_Attendenc();
            obj.LB_Std_Reg.Text = LBUser.Text.ToString();
            obj.Show();
        }

        private void promotSingleStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_Promotion.Single_Student_Promotion obj = new Student_Promotion.Single_Student_Promotion();
            obj.LB_Student_Pro.Text = LBUser.Text.ToString();
            obj.Show();
        }

        private void promotAllStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_Promotion.All_Class_Promotion obj = new Student_Promotion.All_Class_Promotion();
            obj.LB_Student_Pro.Text = LBUser.Text.ToString();
            obj.Show();
        }

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void borrowListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrow_Section.Admission_Borrow_Form obj = new Borrow_Section.Admission_Borrow_Form();
            obj.Show();
        }

        private void borrowReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Borrow_Section.Borrow_Return obj = new Borrow_Section.Borrow_Return();
            //obj.LB_addmission.Text = LBUser.Text.ToString();
            //obj.Show();
        }

        private void aboutMeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About_Me.About_Me obj = new About_Me.About_Me();
            obj.LB_Fair_User.Text = LBUser.Text.ToString();
            obj.Show();
        }

        private void examMarksListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exam.Exam_Table_form obj = new Exam.Exam_Table_form();
            obj.LB_Exam_View.Text = LBUser.Text.ToString();
            obj.Show();
        }

        private void newUnformToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stationary.New_Uniform obj = new Stationary.New_Uniform();
            obj.LB_User.Text = LBUser.Text.ToString();
            obj.Show();
        }

        private void newBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stationary.New_Books obj = new Stationary.New_Books();
            obj.LB_User.Text = LBUser.Text.ToString();
            obj.Show();
        }

        private void newNotebooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Stationary.New_Notebooks obj = new Stationary.New_Notebooks();
            //obj.LB_User.Text = LBUser.Text.ToString();
            //obj.Show();
        }

        private void newShoseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Stationary.New_Shose obj = new Stationary.New_Shose();
            //obj.LB_User.Text = LBUser.Text.ToString();
            //obj.Show();
        }

        private void newSweetetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stationary.New_Sweeter obj = new Stationary.New_Sweeter();
            obj.LB_User.Text = LBUser.Text.ToString();
            obj.Show();
        }

        private void newStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stationary.Stationary_Form obj = new Stationary.Stationary_Form();
            obj.LB_User.Text = LBUser.Text.ToString();
            obj.Show();
        }

        private void stationaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statinary_Sale.Sale_Form obj = new Statinary_Sale.Sale_Form();
            obj.LB_Sale_User.Text = LBUser.Text.ToString();
            obj.Show();
        }
    }

}
