using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySchoolProject
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            Password.UseSystemPasswordChar = true;
            Show_Password.Text = "Show Password";
            Show_User_Type();
            UserName.Focus();
        }

        public void Show_User_Type()
        {
            DBAccess.DBGenral obj = new DBAccess.DBGenral();
            DataTable dt = new DataTable();
            dt = obj.ShowRecords("select * from User_Type ");
            User_Type_CMB.DataSource = dt;
            User_Type_CMB.DisplayMember = "Type";
            User_Type_CMB.ValueMember = "ID";
        }

        private void Show_Password_CheckedChanged(object sender, EventArgs e)
        {
            if (!Show_Password.Checked == true)
            {
                Password.UseSystemPasswordChar = true;
                Show_Password.Text = "Show Password";
            }
            else
            {
                Password.UseSystemPasswordChar = false;
                Show_Password.Text = "Hide Password";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(UserName.Text=="")
            {
                ep.SetError(UserName,"Please Enter User Name !!!");
                UserName.Focus();
                UserName.Text = "";
            }else if(Password.Text=="")
            {
                ep.SetError(Password,"Please Enter Password to Continue !!!");
                Password.Focus();
                Password.Text = "";
            }
            else
            {
                Form1 my_user = new Form1();
                my_user.user = User_Type_CMB.Text;


                Form1 form = new Form1();
                DBAccess.My_Other_Funtion Other = new DBAccess.My_Other_Funtion();
                DBAccess.DBGenral obj = new DBAccess.DBGenral();
                DataTable dt = new DataTable();

                dt = obj.ShowRecords("select * from Login_Info where UserName='" + UserName.Text + "' and Password='" + Password.Text + "' and UserType='" + User_Type_CMB.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    if (User_Type_CMB.Text == "Admin")
                    {

                        form.LBUser.Text = dt.Rows[0]["UserName"].ToString();
                        form.Logged_PIC.Image = Other.Byte_To_Image((Byte[])dt.Rows[0]["Image"]);
                        form.LBID.Text = dt.Rows[0]["ID"].ToString();

                        User_Section.New_User_Form user = new User_Section.New_User_Form();
                        User_Section.User_UpDate Update = new User_Section.User_UpDate();
                        DBAccess.DBGenral ob = new DBAccess.DBGenral();
                        DataTable User_dt = new DataTable();
                        User_dt = ob.ShowRecords("select * from Login_Info where UserName='" + UserName.Text + "' and Password='" + Password.Text + "'");
                        user.LBUser_Reg.Text = User_dt.Rows[0]["UserName"].ToString();
                        Update.LB_UpDate_User.Text = User_dt.Rows[0]["UserName"].ToString();

                        //form.P_User_Rights.Show();
                        form.Back_PIC.Show();
                        form.Change_Back_PIC.Show();
                        form.Back_Browes.Show();
                        //form.Grop_Rights.Show();
                        //form.P_User_Rights.Hide();
                        form.User_Type_Now.Text = User_dt.Rows[0]["UserType"].ToString();
                        obj.Genral_Queries("insert into Log_Info (User_History,Date,Time,Operation) values ('" + UserName.Text + "','" + System.DateTime.Now + "','" + DateTime.Now.ToString("HH:mm") + "','A User " + UserName.Text + " is Logged In Sucessfully By " + UserName.Text + "')");

                        this.Hide();
                        form.Show();

                    }
                    else
                    {

                        form.LBUser.Text = dt.Rows[0]["FullName"].ToString();
                        form.Logged_PIC.Image = Other.Byte_To_Image((Byte[])dt.Rows[0]["Image"]);
                        form.LBID.Text = dt.Rows[0]["ID"].ToString();

                        User_Section.New_User_Form user = new User_Section.New_User_Form();
                        User_Section.User_UpDate Update = new User_Section.User_UpDate();
                        DBAccess.DBGenral ob = new DBAccess.DBGenral();
                        DataTable User_dt = new DataTable();
                        User_dt = ob.ShowRecords("select * from Login_Info where UserName='" + UserName.Text + "' and Password='" + Password.Text + "'");
                        user.LBUser_Reg.Text = User_dt.Rows[0]["UserName"].ToString();


                        Update.LB_UpDate_User.Text = User_dt.Rows[0]["UserName"].ToString();


                        form.User_Type_Now.Text = User_dt.Rows[0]["UserType"].ToString();

                        //form.P_User_Rights.Hide();
                        form.Back_PIC.Show();
                        form.Change_Back_PIC.Show();
                        form.Back_Browes.Show();
                        //form.Grop_Rights.Hide();
                        //form.Rights_Tab.Enabled = false;
                        form.Rights_Tab.Visible = false;
                        form.userToolStripMenuItem1.Visible = false;
                        form.Account_Tab.Visible = false;
                        obj.Genral_Queries("insert into Log_Info (User_History,Date,Time,Operation) values ('" + UserName.Text + "','" + System.DateTime.Now + "','" + DateTime.Now.ToString("HH:mm") + "','A User " + UserName.Text + " is Logged In Sucessfully By " + UserName.Text + "')");

                        this.Hide();
                        form.Show();

                    }
                }
                else
                {
                   // obj.Genral_Queries("insert into Log_Info (User_History,Date,Time,Operation) values ('" + UserName.Text + "','" + System.DateTime.Now + "','" + DateTime.Now.ToString("HH:mm") + "','This User " + UserName.Text + " Tried Many Time to login But Couldn't ... By " + UserName.Text + "')");

                    MessageBox.Show("The Password and User Name You Enterd Are Not Valid!!!");

                    UserName.Focus();
                    UserName.Text = "";
                    Password.Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserName.Text = "";
            Password.Text = "";

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (UserName.Text == "" || User_Type_CMB.Text=="")
            {
                MessageBox.Show("Please Enter Your Current User Name , Password And Select Your User Type");
            }
            else 
            {
                DBAccess.My_Other_Funtion Other=new DBAccess.My_Other_Funtion();
                DBAccess.DBGenral obj = new DBAccess.DBGenral();
                DataTable dt = new DataTable();
                dt = obj.ShowRecords("select * from Login_Info where UserName='"+UserName.Text+"' and UserType='"+User_Type_CMB.Text+"'");
                if(dt.Rows.Count>0)
                {
                    ForgotPassword.ForGotPassword pass = new ForgotPassword.ForGotPassword();
                    pass.Change_ID.Text = dt.Rows[0]["ID"].ToString();
                    pass.Change_FullName.Text = dt.Rows[0]["FullName"].ToString();
                    pass.Change_UserName.Text = dt.Rows[0]["UserName"].ToString();
                    pass.Change_UserType.Text = dt.Rows[0]["UserType"].ToString();
                    pass.QOne.Text = dt.Rows[0]["Q1"].ToString();
                    pass.QTwo.Text = dt.Rows[0]["Q2"].ToString();
                    pass.Change_Pic.Image = Other.Byte_To_Image((Byte[])dt.Rows[0]["Image"]);

                    pass.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sorry !!! The User Name You Entred is Not Found !!!");
                } 
            }
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {
            ep.Clear();
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            ep.Clear();
        }
    }
}
