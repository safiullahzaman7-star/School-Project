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
    public partial class Account_Form : Form
    {
        public Account_Form()
        {
            InitializeComponent();
        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void Account_Form_Load(object sender, EventArgs e)
        {
            FillGrid();
            Show_Credit();
            Show_Debit();
            Cash_On_Hand();
        }
        DBAccess.DBGenral obj = new DBAccess.DBGenral();
        DataTable dt = new DataTable();
     
        //public void Show_Credit()
        //{
        //    obj.ShowRecords("select Sum(Cridet) as All_Cridet from Account_Info");
        //    Credit.Text = dt.Rows[0]["All_Cridet"].ToString();
        //}


        public void Show_Credit()
        {

            dt = obj.ShowRecords("select sum(Cridet) as Cridet from Account_Info");
            Credit.Text = dt.Rows[0]["Cridet"].ToString();
        }

        public void Show_Debit()
        {
            dt = obj.ShowRecords("select sum(Debit) as Debit from Account_Info");
            Debit.Text = dt.Rows[0]["Debit"].ToString();
        }

        public void Cash_On_Hand()
        {
            if(Credit.Text.Trim()=="" || Debit.Text.Trim()=="")
            {

            }
            else
            {
                int C = int.Parse(Credit.Text.ToString());
                int d = int.Parse(Debit.Text.ToString());
                int My_ALL = C - d;
                CashOnHand.Text = My_ALL.ToString();
            }

          


        }

        public void FillGrid()
        {

            dt = obj.ShowRecords("Select Account_ID as [Account ID], Cridet, Debit, Date, User_History as [User], Description from Account_Info order by Account_ID DESC");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    Emp_List.DataSource = dt;
                    Emp_List.Columns[0].Width = 120;
                    Emp_List.Columns[1].Width = 150;
                    Emp_List.Columns[2].Width = 150;
                    Emp_List.Columns[3].Width = 100;
                    Emp_List.Columns[4].Width = 100;
                    Emp_List.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                }
                else
                {
                    Emp_List.DataSource = null;

                }
            }
            else
            {
                Emp_List.DataSource = null;
            }
        }

        private void Get_Data_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DBAccess.DBGenral obj = new DBAccess.DBGenral();
            dt = obj.ShowRecords("Select Account_ID as [Account ID], Cridet, Debit, Date, User_History as [User], Description from Account_Info where Date between '"+From_Date.Value+"' and '"+To_Date.Value+"' order by Account_ID DESC");
            Emp_List.DataSource = dt;
            Sum_Between_Date();
        }


        public void Sum_Between_Date()
        {

            dt = obj.ShowRecords("select sum(Cridet) as Cridet from Account_Info where Date between '" + From_Date.Value + "' and '" + To_Date.Value + "'");
            Credit.Text = dt.Rows[0]["Cridet"].ToString();

            dt = obj.ShowRecords("select sum(Debit) as Debit from Account_Info where Date between '" + From_Date.Value + "' and '" + To_Date.Value + "'");
            Debit.Text = dt.Rows[0]["Debit"].ToString();

            //Cash_On_Hand();
        }

        private void selectAnAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
             if(Emp_List.DataSource!=null)
            {
                if(Emp_List.Rows.Count>0)
                {
                    if(Emp_List.SelectedRows.Count==1)
                    {
                        LB_ID.Text = Convert.ToString(Emp_List.CurrentRow.Cells[0].Value);
                        LB_Credit.Text = Convert.ToString(Emp_List.CurrentRow.Cells["Cridet"].Value);
                        Lb_Debit.Text = Convert.ToString(Emp_List.CurrentRow.Cells["Debit"].Value);
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

        private void Ch_Date_CheckedChanged(object sender, EventArgs e)
        {
            if(Ch_User.Checked==true)
            {
                MessageBox.Show("Sorry !!! ... Check Box Lable is Checked !!!");
                Ch_Date.Checked = false;
            }
            else
            {
                if (Ch_Date.Checked == true)
                {
                    From_Date.Enabled = true;
                    To_Date.Enabled = true;
                    Get_Data.Enabled = true;
                }
                else
                {
                    From_Date.Enabled = false;
                    To_Date.Enabled = false;
                    Get_Data.Enabled = false;
                }
            }

          

           
        }

        private void Ch_User_CheckedChanged(object sender, EventArgs e)
        {
            if(Ch_Date.Checked==true)
            {
                MessageBox.Show("Sorry !!! ... Check Box Date is Checked !!!");
                Ch_User.Checked = false;
            }
            else
            {
                if(Ch_User.Checked==true)
                {
                    LBID.Enabled = true;
                    LBDebit.Enabled = true;
                    LBCredit.Enabled = true;
                    LB_ID.Enabled = true;
                    Lb_Debit.Enabled = true;
                    LB_Credit.Enabled = true;
                }
                else
                {
                    LBID.Enabled = false;
                    LBDebit.Enabled = false;
                    LBCredit.Enabled = false;
                    LB_ID.Enabled = false;
                    Lb_Debit.Enabled = false;
                    LB_Credit.Enabled = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            From_Date.Value = System.DateTime.Now;
            To_Date.Value = System.DateTime.Now;
           
           LB_ID.Text = ""; ;
           Lb_Debit.Text = ""; ;
           LB_Credit.Text = ""; ;
           FillGrid();

           Ch_Date.Checked = false;
           Ch_User.Checked = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Ch_Date.Checked==true)
            {
                Account_Section.Account_With_Date_Form Date = new Account_Section.Account_With_Date_Form();
                Date.From_Date.Value = From_Date.Value;
                Date.To_Date.Value = To_Date.Value;
                Date.Show();
            }else if(Ch_User.Checked==true)
            {
                Account_Section.Account_Single_Record_Form single = new Account_Section.Account_Single_Record_Form();
                single.single =int.Parse( LB_ID.Text.ToString());
                single.Show();
            }
            else
            {
                MessageBox.Show("Please Check one Check Box to Search and then Genereate a Report !!!");
            }
        }

        private void Emp_By_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Emp_By_Name_TextChanged(object sender, EventArgs e)
        {
            dt = obj.ShowRecords("Select Account_ID as [Account ID], Cridet, Debit, Date, User_History as [User], Description from Account_Info where User_History like '%" + Emp_By_Name.Text + "%' or Description like '%" + Emp_By_Name.Text + "%' or Cridet like '%" + Emp_By_Name.Text + "%' or Debit like '%" + Emp_By_Name.Text + "%' or Account_ID like '%" + Emp_By_Name.Text + "%'  order by Account_ID DESC");

           // obj.ShowRecords("select * from Account_Info where User_History like '%" + Emp_By_Name.Text + "%' or Description like '%"+Emp_By_Name.Text+"%'");
            Emp_List.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
