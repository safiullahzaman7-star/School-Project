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
    public partial class Color : Form
    {
        public Color()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog obj = new ColorDialog();
            if(obj.ShowDialog()==DialogResult.OK)
            {
                My_Panel.BackColor = obj.Color;
            }
        }

        private void My_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblhiur.Text = DateTime.Now.ToString("hh:mm");
            lblsecond.Text = DateTime.Now.ToString("ss");
            lbldate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblday.Text = DateTime.Now.ToString("ddd");
            lblsecond.Location = new Point(lblhiur.Location.X + lblhiur.Width, lblsecond.Location.Y);
        }

        private void Color_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
