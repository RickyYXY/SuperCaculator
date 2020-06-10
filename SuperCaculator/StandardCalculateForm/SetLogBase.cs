using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandardCalculateForm
{
    public partial class SetLogBase : Form
    {
        public Log Somelog { get; set; }
        public SetLogBase()
        {
            InitializeComponent();
        }

        public SetLogBase(Log log) : this(){
            Somelog = log;
            bindingSourceLogbase.DataSource = log;
        }

        private void NumberInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar)&&e.KeyChar!=(char)8)
            {
                e.Handled = true;
            }
        }
    }
}
