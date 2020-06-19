using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateCalculation
{
    public partial class Calendar : Form
    {
        Form1 form;
        public Calendar(Form1 form1)
        {
            InitializeComponent();
            form = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            this.DialogResult = DialogResult.OK;
            this.Close();
            form.Show();
        }

        public String getYear()
        {
            string year = monthCalendar1.SelectionStart.Year.ToString();
            return year;
        }
        public String getMonth()
        {
            string month = monthCalendar1.SelectionStart.Month.ToString();
            return month;
        }
        public String getDay()
        {
            string day = monthCalendar1.SelectionStart.Day.ToString();
            return day;
        }
    }
}
