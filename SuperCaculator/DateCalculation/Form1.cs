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
    public partial class DateCalculation : Form
    {
        public DateCalculation()
        {
            InitializeComponent();
        }

        private ComboBox FocusTextBox;

        private void comboBoxyear1_MouseClick(object sender, MouseEventArgs e)
        {
            FocusTextBox = comboBoxyear1;
        }

        private void comboBoxmonth1_MouseClick(object sender, MouseEventArgs e)
        {
            FocusTextBox = comboBoxmonth1;
        }

        private void comboBoxdate1_MouseClick(object sender, MouseEventArgs e)
        {
            FocusTextBox = comboBoxdate1;
        }

        private void comboBoxyear2_MouseClick(object sender, MouseEventArgs e)
        {
            FocusTextBox = comboBoxyear2;
        }

        private void comboBoxmonth2_MouseClick(object sender, MouseEventArgs e)
        {
            FocusTextBox = comboBoxmonth2;
        }

        private void comboBoxdate2_MouseClick(object sender, MouseEventArgs e)
        {
            FocusTextBox = comboBoxdate2;
        }

        private bool check()
        {
            if (FocusTextBox.Text=="0")
                return false;
            else
                return true;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1601; i < 2551; i++)
            {
                this.comboBoxyear1.Items.Add(i);
                this.comboBoxyear2.Items.Add(i);
                this.comboBoxyear3.Items.Add(i);
                this.comboBoxyear5.Items.Add(i);
            }
            for(int j = 0; j < 1000; j++)
            {
                this.comboBoxyear4.Items.Add(j);
                this.comboBoxmonth4.Items.Add(j);
                this.comboBoxdate4.Items.Add(j);
            }
            comboBoxyear1.Text = DateTime.Now.Year.ToString();
            comboBoxyear2.Text = DateTime.Now.Year.ToString();
            comboBoxyear3.Text = DateTime.Now.Year.ToString();
            comboBoxyear5.Text = DateTime.Now.Year.ToString();
            comboBoxmonth1.Text = DateTime.Now.Month.ToString();
            comboBoxmonth2.Text = DateTime.Now.Month.ToString();
            comboBoxmonth3.Text = DateTime.Now.Month.ToString();
            comboBoxmonth5.Text = DateTime.Now.Month.ToString();
            comboBoxdate1.Text = DateTime.Now.Date.ToString("%d");
            comboBoxdate2.Text = DateTime.Now.Date.ToString("%d");
            comboBoxdate3.Text = DateTime.Now.Date.ToString("%d");
            comboBoxdate5.Text = DateTime.Now.Date.ToString("%d");
            DateDiff();
            WeekQuery();
        }


        private ComboBox comboboxyear;
        private ComboBox comboboxmonth;
        private ComboBox comboboxdate;
        private void DateSelect()
        {
            try
            {
                comboboxdate.Items.Clear();
                for (int i = 1; i < 29; i++)
                {
                    this.comboboxdate.Items.Add(i);
                }
                if (comboboxmonth.Text == "2")
                {
                    if (Convert.ToInt32(comboboxyear.Text) % 4 == 0)
                        comboboxdate.Items.Add(29);
                }
                else if (comboboxmonth.Text == "1" || comboboxmonth.Text == "3" || comboboxmonth.Text == "5" || comboboxmonth.Text == "7"
                        || comboboxmonth.Text == "8" || comboboxmonth.Text == "10" || comboboxmonth.Text == "12")
                {
                    comboboxdate.Items.Add(29); comboboxdate.Items.Add(30); comboboxdate.Items.Add(31);
                }
                else
                {
                    comboboxdate.Items.Add(29); comboboxdate.Items.Add(30);
                }
            }
            catch
            {
                MessageBox.Show("请输入合法日期");
            }
        }

        private void DateDiff()
        {
            try
            {
                if (comboBoxdate1.Text != "" && comboBoxyear1.Text != "" && comboBoxmonth1.Text != "" &&
                    comboBoxdate2.Text != "" && comboBoxyear2.Text != "" && comboBoxmonth2.Text != "")
                {
                    DateTime starttime = Convert.ToDateTime(comboBoxyear1.Text + "-" + comboBoxmonth1.Text + "-" + comboBoxdate1.Text);
                    DateTime endtime = Convert.ToDateTime(comboBoxyear2.Text + "-" + comboBoxmonth2.Text + "-" + comboBoxdate2.Text);
                    TimeSpan sp = endtime.Subtract(starttime);
                    label8.Text = Convert.ToString(sp.Days) + "天";
                }
            }
            catch
            {
                MessageBox.Show("请输入合法日期");
            }
        }

        private void DateCalculate()
        {
            try
            {
                if (comboBoxdate3.Text != "" && comboBoxyear3.Text != "" && comboBoxmonth3.Text != "" &&
                   comboBoxdate4.Text != "" && comboBoxyear4.Text != "" && comboBoxmonth4.Text != "" &&
                   (radioButton1.Text != "" || radioButton2.Text != ""))
                {
                    int year = Convert.ToInt32(comboBoxyear4.Text);
                    int month = Convert.ToInt32(comboBoxmonth4.Text);
                    int day = Convert.ToInt32(comboBoxdate4.Text);
                    if (radioButton1.Checked)
                    {
                        year = year * -1;
                        month = month * -1;
                        day = day * -1;
                    }
                    DateTime dt = DateTime.Parse(comboBoxyear3.Text + "/" + comboBoxmonth3.Text + "/" + comboBoxdate3.Text);
                    DateTime time1 = dt.AddYears(year);
                    DateTime time2 = time1.AddMonths(month);
                    string time = time2.AddDays(day).ToString();
                    label16.Text = DateTime.Parse(time).ToLongDateString().ToString();
                }
            }
            catch
            {
                MessageBox.Show("请输入合法日期");
            }
        }

        private void WeekQuery()
        {
            try
            {
                if (comboBoxdate5.Text != "" && comboBoxyear5.Text != "" && comboBoxmonth5.Text != "")
                {
                    string time = comboBoxyear5.Text + "/" + comboBoxmonth5.Text + "/" + comboBoxdate5.Text;
                    string[] Day = new string[] { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };
                    string week = Day[Convert.ToInt32(DateTime.Parse(time).DayOfWeek.ToString("d"))].ToString();
                    label20.Text = week;
                }
            }
            catch
            {
                MessageBox.Show("请输入合法日期");
            }
        }

        private void comboBoxmonth1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxyear = comboBoxyear1;
            comboboxmonth = comboBoxmonth1;
            comboboxdate = comboBoxdate1;
            DateSelect();
            DateDiff();
        }

        private void comboBoxmonth2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxyear = comboBoxyear2;
            comboboxmonth = comboBoxmonth2;
            comboboxdate = comboBoxdate2;
            DateSelect();
            DateDiff();
        }

        private void comboBoxmonth3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxyear = comboBoxyear3;
            comboboxmonth = comboBoxmonth3;
            comboboxdate = comboBoxdate3;
            DateSelect();
            DateCalculate();
        }

        private void comboBoxmonth5_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxyear = comboBoxyear5;
            comboboxmonth = comboBoxmonth5;
            comboboxdate = comboBoxdate5;
            DateSelect();
            WeekQuery();
        }

        private void comboBoxyear1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxyear = comboBoxyear1;
            comboboxmonth = comboBoxmonth1;
            comboboxdate = comboBoxdate1;
            DateSelect();
            DateDiff();
        }

        private void comboBoxdate1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateDiff();
        }

        private void comboBoxdate2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateDiff();
        }

        private void comboBoxyear2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxyear = comboBoxyear2;
            comboboxmonth = comboBoxmonth2;
            comboboxdate = comboBoxdate2;
            DateSelect();
            DateDiff();
        }

        private void comboBoxyear5_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxyear = comboBoxyear5;
            comboboxmonth = comboBoxmonth5;
            comboboxdate = comboBoxdate5;
            DateSelect();
            WeekQuery();
        }

        private void comboBoxdate5_SelectedIndexChanged(object sender, EventArgs e)
        {
            WeekQuery();
        }

        private void comboBoxyear3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxyear = comboBoxyear3;
            comboboxmonth = comboBoxmonth3;
            comboboxdate = comboBoxdate3;
            DateSelect();
            DateCalculate();
        }

        private void comboBoxdate3_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateCalculate();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DateCalculate();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            DateCalculate();
        }

        private void comboBoxyear4_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateCalculate();
        }

        private void comboBoxmonth4_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateCalculate();
        }

        private void comboBoxdate4_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateCalculate();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar(this);
            if (calendar.ShowDialog() == DialogResult.OK)
            {
                calendar.Close();
                comboBoxyear1.Text = calendar.getYear();
                comboBoxmonth1.Text = calendar.getMonth();
                comboBoxdate1.Text = calendar.getDay();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar(this);
            if (calendar.ShowDialog() == DialogResult.OK)
            {
                calendar.Close();
                comboBoxyear2.Text = calendar.getYear();
                comboBoxmonth2.Text = calendar.getMonth();
                comboBoxdate2.Text = calendar.getDay();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar(this);
            if (calendar.ShowDialog() == DialogResult.OK)
            {
                calendar.Close();
                comboBoxyear3.Text = calendar.getYear();
                comboBoxmonth3.Text = calendar.getMonth();
                comboBoxdate3.Text = calendar.getDay();
            }
        }

        private void comboBoxyear4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxmonth4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxdate4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxyear5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxmonth5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxdate5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
