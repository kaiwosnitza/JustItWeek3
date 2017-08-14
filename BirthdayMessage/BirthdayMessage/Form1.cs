using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirthdayMessage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now.Date;
            TimeSpan ageDays = today - dtpBirthdate.Value;
            int years = (int)ageDays.TotalDays / 365;

            int day = dtpBirthdate.Value.Day;
            string month = dtpBirthdate.Value.ToString("MMMM");

            lblMessage.Text = "Hello," + tbName.Text + "! You will be " + (years + 1) + " years old on " + day + " " + month + ".";
        }

        private void bSubmit_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now.Date;
            TimeSpan ageDays = today - dtpBirthdate.Value;
            int years = (int)ageDays.TotalDays / 365;

            int day = dtpBirthdate.Value.Day;
            string month = dtpBirthdate.Value.ToString("MMMM");

            lblMessage.Text = "Hello," + tbName.Text + "! You will be " + (years + 1) + " years old on " + day + " " + month + ".";
        }
    }
}
