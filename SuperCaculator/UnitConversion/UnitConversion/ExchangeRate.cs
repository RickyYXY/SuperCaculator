using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConversion
{
    public partial class ExchangeRate : Form
    {
        public ExchangeRate(string currency, string date, string bankconversion, string time)
        {
            InitializeComponent();
            label2.Text = "100" + currency;
            label6.Text = bankconversion + "人民币";
            label4.Text = date;
            label8.Text = time;
        }
    }
}
