using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Xfrog.Net;

namespace UnitConversion
{
    public partial class ConversionForm : Form
    {
        JsonObject transformer { get; set; }
        public ConversionForm()
        {
            InitializeComponent();
            transformer = CurrencyAPI.getInformation();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "温度")
                label2.Text = "";
            this.comboBox2.Items.Clear();
            string a = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            switch (a)
            {
                case "进制":
                    this.comboBox2.Items.Add("二进制");
                    this.comboBox2.Items.Add("八进制");
                    this.comboBox2.Items.Add("十进制");
                    this.comboBox2.Items.Add("十六进制");
                    break;

                case "容量":
                    this.comboBox2.Items.Add("毫升");
                    this.comboBox2.Items.Add("立方厘米");
                    this.comboBox2.Items.Add("升");
                    this.comboBox2.Items.Add("立方米");
                    break;


                case "长度":
                    this.comboBox2.Items.Add("毫米");
                    this.comboBox2.Items.Add("厘米");
                    this.comboBox2.Items.Add("米");
                    this.comboBox2.Items.Add("公里");
                    this.comboBox2.Items.Add("英寸");
                    this.comboBox2.Items.Add("英尺");
                    break;

                case "重量":
                    this.comboBox2.Items.Add("克拉");
                    this.comboBox2.Items.Add("毫克");
                    this.comboBox2.Items.Add("克");
                    this.comboBox2.Items.Add("千克");
                    this.comboBox2.Items.Add("盎司");
                    this.comboBox2.Items.Add("磅");
                    break;

                case "温度":
                    this.comboBox2.Items.Add("摄氏度");
                    this.comboBox2.Items.Add("华氏度");
                    this.comboBox2.Items.Add("开尔文");
                    break;

                case "能量":
                    this.comboBox2.Items.Add("焦耳");
                    this.comboBox2.Items.Add("千焦耳");
                    this.comboBox2.Items.Add("热卡路里");
                    break;

                case "面积":
                    this.comboBox2.Items.Add("平方厘米");
                    this.comboBox2.Items.Add("平方米");
                    this.comboBox2.Items.Add("公顷");
                    this.comboBox2.Items.Add("英亩");
                    break;

                case "速度":
                    this.comboBox2.Items.Add("米/秒");
                    this.comboBox2.Items.Add("公里/小时");
                    this.comboBox2.Items.Add("节");
                    this.comboBox2.Items.Add("马赫");
                    break;

                case "时间":
                    this.comboBox2.Items.Add("秒");
                    this.comboBox2.Items.Add("分钟");
                    this.comboBox2.Items.Add("小时");
                    this.comboBox2.Items.Add("天");
                    this.comboBox2.Items.Add("周");
                    this.comboBox2.Items.Add("年");
                    break;

                case "功率":
                    this.comboBox2.Items.Add("瓦特");
                    this.comboBox2.Items.Add("千瓦");
                    break;

                case "数据":
                    this.comboBox2.Items.Add("KB");
                    this.comboBox2.Items.Add("Mb");
                    this.comboBox2.Items.Add("MB");
                    this.comboBox2.Items.Add("Gb");
                    this.comboBox2.Items.Add("GB");
                    break;

                case "压力":
                    this.comboBox2.Items.Add("大气压");
                    this.comboBox2.Items.Add("千帕");
                    this.comboBox2.Items.Add("毫米汞柱");
                    break;

                case "角度":
                    this.comboBox2.Items.Add("度");
                    this.comboBox2.Items.Add("弧度");
                    this.comboBox2.Items.Add("百分度");
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;//下拉框不可编辑，只可选择
            //comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox1.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
        }

        private TextBox textBox;
        private Label label;

        //检查文本框是否为0或-0，判断能不能输入
        private bool check()
        {
            if (textBox.Text == "0" || textBox.Text == "-0")
                return false;
            else
                return true;
        }

        //判断输入是否达到上限
        private bool IsFull()
        {
            if (textBox.Text.Length == 12)
            {
                label.Text = "输入已达到上限";
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button(string i)
        {
            try
            {
                if (!IsFull())
                {
                    if (!check())
                        textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
                    textBox.Text += i;
                }
            }
            catch
            {
                MessageBox.Show("请选择要输入的文本框");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            button("0");
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            button("A");
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            button("B");
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            button("C");
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            button("D");
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            button("E");
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            button("F");
        }

        private void buttonpoint_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox.Text.Last() == '.' || textBox.Text == "-")
                    textBox.Text = textBox.Text;
                else
                    textBox.Text += '.';
            }
            catch
            {
                MessageBox.Show("请选择要输入的文本框");
            }
        }

        private void buttonnegative_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox.Text.First() == '-')
                    textBox.Text = textBox.Text.Substring(1);
                else
                    textBox.Text = "-" + textBox.Text;
            }
            catch
            {
                MessageBox.Show("请选择要输入的文本框");
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            try
            {
                textBox.Text = "0";
            }
            catch
            {
                MessageBox.Show("请选择要输入的文本框");
            }
        }

        private void buttonreset_Click(object sender, EventArgs e)
        {
            if (!check())
                textBox.Text = "0";
            else if (textBox.Text.Length == 1)
                textBox.Text = "0";
            else
                textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.textBox1.Focus();
            this.textBox1.Select(this.textBox1.TextLength, 0);
            Calculate();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox = textBox1;
            label = label2;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        //阻止键盘输入
        private void TextBoxKeyPress(object sender, KeyPressEventArgs e, Label label)
        {
            //阻止从键盘输入键
            e.Handled = true;
            //当输入为0-9的数字、小数点、A\B\C\D\E\F和退格键时不阻止
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '.' || e.KeyChar >= 65 && e.KeyChar <= 70 || e.KeyChar == (char)8)
            {
                switch (e.KeyChar)
                {
                    case '0':
                        button0.PerformClick(); break;
                    case '1':
                        button1.PerformClick(); break;
                    case '2':
                        button2.PerformClick(); break;
                    case '3':
                        button3.PerformClick(); break;
                    case '4':
                        button4.PerformClick(); break;
                    case '5':
                        button5.PerformClick(); break;
                    case '6':
                        button6.PerformClick(); break;
                    case '7':
                        button7.PerformClick(); break;
                    case '8':
                        button8.PerformClick(); break;
                    case '9':
                        button9.PerformClick(); break;
                    case '.':
                        buttonpoint.PerformClick(); break;
                    case (char)65:
                        buttonA.PerformClick(); break;
                    case (char)66:
                        buttonB.PerformClick(); break;
                    case (char)67:
                        buttonC.PerformClick(); break;
                    case (char)68:
                        buttonD.PerformClick(); break;
                    case (char)69:
                        buttonE.PerformClick(); break;
                    case (char)70:
                        buttonF.PerformClick(); break;
                    case (char)8:
                        buttonreset.PerformClick(); break;
                }
            }
            else
                label.Text = "无法输入";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxKeyPress(sender, e, label2);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //光标定位到文本最后
        private void TextBoxKeyDown(object sender, KeyEventArgs e, TextBox textBox)
        {
            if (e.KeyCode == Keys.Left)
            {
                e.Handled = true;
            }
            this.textBox.Focus();
            this.textBox.Select(this.textBox.TextLength, 0);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxKeyDown(sender, e, textBox1);
        }

        //单位/进制的换算
        private void Calculate()
        {
            label2.Text = "";
            if (comboBox1.Text == "进制")
            {
                try
                {
                    switch (comboBox2.Text)
                    {
                        case "二进制":
                            label1.Text = "八进制  " + Convert.ToString(Convert.ToInt32(textBox1.Text, 2), 8) + "\r\n十进制  " +
                                Convert.ToInt32(textBox1.Text, 2) + "\r\n十六进制  " + Convert.ToString(Convert.ToInt32(textBox1.Text, 2), 16); break;
                        case "八进制":
                            label1.Text = "二进制  " + Convert.ToString(Convert.ToInt32(textBox1.Text, 8), 2) + "\r\n十进制  " +
                                Convert.ToInt32(textBox1.Text, 8) + "\r\n十六进制  " + Convert.ToString(Convert.ToInt32(textBox1.Text, 8), 16); break;
                        case "十进制":
                            label1.Text = "二进制  " + Convert.ToString(Convert.ToInt32(textBox1.Text), 2) + "\r\n八进制  "
                                + Convert.ToString(Convert.ToInt32(textBox1.Text), 8) + "\r\n十六进制  " + Convert.ToString(Convert.ToInt32(textBox1.Text), 16); break;
                        case "十六进制":
                            label1.Text = "二进制  " + Convert.ToString(Convert.ToInt32(textBox1.Text, 16), 2) + "\r\n八进制  " +
                                Convert.ToString(Convert.ToInt32(textBox1.Text, 16), 8) + "\r\n十进制  " + Convert.ToInt32(textBox1.Text, 16); break;
                    }
                }
                catch
                {
                    label2.Text = "输入不合法";
                }
            }
            else
            {
                double num = 0;
                try { num = Convert.ToDouble(textBox1.Text); } catch { label2.Text = "输入不合法"; }
                if (comboBox1.Text != "温度" && num < 0)
                {
                    label2.Text = "请输入非负数";
                }
                else
                {
                    switch (comboBox2.Text)
                    {
                        case "毫升": label1.Text = "立方厘米  " + num + "\r\n" + "升  " + num / 1000 + "\r\n" + "立方米  " + num / 1000; break;
                        case "立方厘米": label1.Text = "毫升  " + num + "\r\n" + "升  " + num / 1000 + "\r\n" + "立方米  " + num / 1000; break;
                        case "升": label1.Text = "立方厘米  " + num * 1000 + "\r\n" + "毫升  " + num * 1000 + "\r\n" + "立方米  " + num; break;
                        case "立方米": label1.Text = "立方厘米  " + num * 1000 + "\r\n" + "毫升  " + num * 1000 + "\r\n" + "升  " + num; break;

                        case "毫米":
                            label1.Text = "厘米  " + num / 10 + "\r\n" + "米  " + num / 1000 + "\r\n" + "公里  " + num / 1000000 + "\r\n"
                             + "英寸  " + num / 25.4 + "\r\n" + "英尺  " + num / 304.8; break;
                        case "厘米":
                            label1.Text = "毫米  " + num * 10 + "\r\n" + "米  " + num / 100 + "\r\n" + "公里  " + num / 100000 + "\r\n"
                             + "英寸  " + num / 2.54 + "\r\n" + "英尺  " + num / 30.48; break;
                        case "米":
                            label1.Text = "毫米  " + num * 1000 + "\r\n" + "厘米  " + num * 100 + "\r\n" + "公里  " + num / 1000 + "\r\n"
                              + "英寸  " + num / 0.0254 + "\r\n" + "英尺  " + num / 0.3048; break;
                        case "公里":
                            label1.Text = "毫米  " + num * 1000000 + "\r\n" + "厘米  " + num * 100000 + "\r\n" + "米  " + num * 1000 + "\r\n"
                             + "英寸  " + num / 0.0000254 + "\r\n" + "英尺  " + num / 0.0003048; break;
                        case "英寸":
                            label1.Text = "毫米  " + num * 25.4 + "\r\n" + "厘米  " + num * 2.54 + "\r\n" + "米  " + num * 0.0254 + "\r\n"
                            + "公里  " + num * 0.0000254 + "\r\n" + "英尺  " + num / 12; break;
                        case "英尺":
                            label1.Text = "毫米  " + num * 304.8 + "\r\n" + "厘米  " + num * 30.48 + "\r\n" + "米  " + num * 0.3048 + "\r\n"
                             + "公里  " + num * 0.0003048 + "\r\n" + "英尺  " + num * 12; break;

                        case "克拉":
                            label1.Text = "毫克  " + num * 200 + "\r\n" + "克  " + num / 5 + "\r\n" + "千克  " + num / 5000 + "\r\n"
                             + "盎司  " + num * 0.0070548 + "\r\n" + "磅  " + num * 0.00044092; break;
                        case "毫克":
                            label1.Text = "克拉  " + num * 0.005 + "\r\n" + "克  " + num * 0.001 + "\r\n" + "千克  " + num * 0.000001 + "\r\n"
                             + "盎司  " + num * 0.000035274 + "\r\n" + "磅  " + num * 0000022046; break;
                        case "克":
                            label1.Text = "克拉  " + num * 5 + "\r\n" + "毫克  " + num * 1000 + "\r\n" + "千克  " + num * 0.001 + "\r\n"
                              + "盎司  " + num * 0.035274 + "\r\n" + "磅  " + num * 0.0022046; break;
                        case "千克":
                            label1.Text = "克拉  " + num * 5000 + "\r\n" + "毫克  " + num * 1000000 + "\r\n" + "克  " + num * 0.1000 + "\r\n"
                             + "盎司  " + num * 35.274 + "\r\n" + "磅  " + num * 2.2046; break;
                        case "盎司":
                            label1.Text = "克拉  " + num / 0.0070548 + "\r\n" + "毫克  " + num / 0.000035274 + "\r\n" + "克  " + num / 0.035274 + "\r\n"
                             + "千克  " + num / 35.274 + "\r\n" + "磅  " + num / 16; break;
                        case "磅":
                            label1.Text = "克拉  " + num / 0.00044092 + "\r\n" + "毫克  " + num / 0000022046 + "\r\n" + "克  " + num / 0.0022046 + "\r\n"
                              + "千克  " + num / 2.2046 + "\r\n" + "盎司  " + num * 16; break;

                        case "摄氏度": label1.Text = "华氏度  " + (num * 1.8 + 32) + "\r\n" + "开尔文  " + (num + 273.16); break;
                        case "华氏度": label1.Text = "摄氏度  " + ((num - 32) * 5 / 9) + "\r\n" + "开尔文  " + (273.16 + (num - 32) * 5 / 9); break;
                        case "开尔文": label1.Text = "华氏度  " + ((num - 273.16) * 1.8 + 32) + "\r\n" + "摄氏度  " + (num - 273.16); break;

                        case "焦耳": label1.Text = "千焦耳  " + num / 1000 + "\r\n" + "热卡路里  " + num * 0.239006; break;
                        case "千焦耳": label1.Text = "焦耳  " + num * 1000 + "\r\n" + "热卡路里  " + num * 239.006; break;
                        case "热卡路里": label1.Text = "焦耳  " + num / 0.239006 + "\r\n" + "千焦耳  " + num / 239.006; break;

                        case "平方厘米":
                            label1.Text = "平方米  " + num * 0.0001 + "\r\n" + "公顷 " + num * 0.00000001 + "\r\n"
                                + "英亩  " + num / 40468564; break;
                        case "平方米":
                            label1.Text = "平方厘米  " + num * 10000 + "\r\n" + "公顷 " + num * 0.0001 + "\r\n"
                                 + "英亩  " + num / 4046.8564; break;
                        case "公顷":
                            label1.Text = "平方厘米  " + num * 100000000 + "\r\n" + "平方米 " + num * 10000 + "\r\n"
                                  + "英亩  " + num * 2.471054; break;
                        case "英亩":
                            label1.Text = "平方厘米  " + num * 40468564 + "\r\n" + "平方米 " + num * 4046.8564 + "\r\n"
                                  + "公顷  " + num * 0.404686; break;

                        case "米/秒": label1.Text = "公里/小时  " + num * 3.6 + "\r\n" + "节  " + num / 0.5144 + "\r\n" + "马赫  " + num / 340.3; break;
                        case "公里/小时": label1.Text = "米/秒  " + num / 3.6 + "\r\n" + "节  " + num / 1.85184 + "\r\n" + "马赫  " + num / 1225.08; break;
                        case "节": label1.Text = "米/秒  " + num * 0.5144 + "\r\n" + "公里/小时  " + num * 1.85184 + "\r\n" + "马赫  " + num * 0.00151161; break;
                        case "马赫": label1.Text = "米/秒  " + num * 340.3 + "\r\n" + "公里/小时  " + num * 1225.08 + "\r\n" + "节  " + num * 661.5474; break;

                        case "秒":
                            label1.Text = "分钟  " + num / 60 + "\r\n" + "小时  " + num / 3600 + "\r\n" + "天  " + num / 86400 + "\r\n"
                             + "周  " + num / 604800 + "\r\n" + "年  " + num / 31557600; break;
                        case "分钟":
                            label1.Text = "秒  " + num * 60 + "\r\n" + "小时  " + num / 60 + "\r\n" + "天  " + num / 1440 + "\r\n"
                            + "周  " + num / 10080 + "\r\n" + "年  " + num / 525960; break;
                        case "小时":
                            label1.Text = "秒  " + num * 3600 + "\r\n" + "分钟  " + num * 60 + "\r\n" + "天  " + num / 24 + "\r\n"
                            + "周  " + num / 168 + "\r\n" + "年  " + num / 8766; break;
                        case "天":
                            label1.Text = "秒  " + num * 86400 + "\r\n" + "分钟  " + num * 1440 + "\r\n" + "小时  " + num * 24 + "\r\n"
                             + "周  " + num / 7 + "\r\n" + "年  " + num / 365.25; break;
                        case "周":
                            label1.Text = "秒  " + num * 604800 + "\r\n" + "分钟  " + num * 10080 + "\r\n" + "小时  " + num * 168 + "\r\n"
                            + "天  " + num * 7 + "\r\n" + "年  " + num / 52.17857; break;
                        case "年":
                            label1.Text = "秒  " + num * 31557600 + "\r\n" + "分钟  " + num * 525960 + "\r\n" + "小时  " + num * 8766 + "\r\n"
                             + "周  " + num * 52.17857 + "\r\n" + "天  " + num * 365.25; break;

                        case "瓦特": label1.Text = "千瓦  " + num / 1000 + "\r\n"; break;
                        case "千瓦": label1.Text = "千瓦  " + num * 1000; break;

                        case "KB":
                            label1.Text = "Mb  " + num * 0.008 + "\r\n" + "MB  " + num * 0.001 + "\r\n" + "Gb " + num * 0.000008 + "\r\n"
                           + "GB  " + num * 0.000001; break;
                        case "Mb":
                            label1.Text = "KB  " + num * 125 + "\r\n" + "MB  " + num / 8 + "\r\n" + "Gb " + num * 0.001 + "\r\n"
                           + "GB  " + num * 0.000125; break;
                        case "MB":
                            label1.Text = "KB  " + num * 1000 + "\r\n" + "Mb  " + num * 8 + "\r\n" + "Gb " + num * 0.008 + "\r\n"
                            + "GB  " + num * 0.001; break;
                        case "Gb":
                            label1.Text = "KB  " + num * 125000 + "\r\n" + "Mb  " + num * 1000 + "\r\n" + "MB " + num * 125 + "\r\n"
                            + "GB  " + num / 8; break;
                        case "GB":
                            label1.Text = "KB  " + num * 1000000 + "\r\n" + "Mb  " + num * 8000 + "\r\n" + "MB " + num * 1000 + "\r\n"
                           + "Gb  " + num * 8; break;

                        case "大气压": label1.Text = "千帕  " + num * 101.325 + "\r\n" + "毫米汞柱  " + num * 760; break;
                        case "千帕": label1.Text = "大气压  " + num / 101.325 + "\r\n" + "毫米汞柱  " + (num / 101.35) * 760; break;
                        case "毫米汞柱": label1.Text = "千帕  " + (num / 760) * 101.35 + "\r\n" + "大气压  " + num / 760; break;

                        case "度": label1.Text = "弧度  " + num * 3.1415 / 180 + "\r\n" + "百分度  " + num * 760; break;
                        case "弧度": label1.Text = "度  " + num * 180 / 3.1415 + "\r\n" + "百分度  " + (num / 101.35) * 760; break;
                        case "百分度": label1.Text = "度  " + num * 0.9 + "\r\n" + "弧度  " + num * 0.9 * 3.1415 / 180; break;
                    }
                }
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            this.textBox6.Focus();
            this.textBox6.Select(this.textBox6.TextLength, 0);
            RMBChange();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            this.textBox7.Focus();
            this.textBox7.Select(this.textBox7.TextLength, 0);
            ForeignCurrencyChange();
        }

        private void textBox6_MouseClick(object sender, MouseEventArgs e)
        {
            textBox = textBox6;
            label = label16;
        }

        private void textBox7_MouseClick(object sender, MouseEventArgs e)
        {
            textBox = textBox7;
            label = label17;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxKeyPress(sender, e, label16);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxKeyPress(sender, e, label17);
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxKeyDown(sender, e, textBox6);
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxKeyDown(sender, e, textBox7);
        }

        //转外币
        private void RMBChange()
        {
            try
            {
                label16.Text = "";
                double money = 0;
                try { money = Convert.ToDouble(textBox6.Text); } catch { label16.Text = "输入不合法"; }
                double rate = Double.Parse(CurrencyAPI.searchInformation(transformer, comboBox3.SelectedIndex, "bankConversionPri"));
                double result = money * 100 / rate;
                label13.Text = Math.Round(result, 2).ToString();
            }
            catch
            {
                MessageBox.Show("发生错误");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            RMBChange();
        }

        //转人民币
        private void ForeignCurrencyChange()
        {
            try
            {
                label17.Text = "";
                double money = 0;
                try { money = Convert.ToDouble(textBox7.Text); } catch { label17.Text = "输入不合法"; }
                double rate = Double.Parse(CurrencyAPI.searchInformation(transformer, comboBox4.SelectedIndex, "bankConversionPri"));
                double result = money * rate / 100;
                label14.Text = Math.Round(result, 2).ToString();
            }
            catch
            {
                MessageBox.Show("发生错误");
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ForeignCurrencyChange();
        }

        //显示汇率详情
        private void ShowRate(ComboBox comboBox)
        {
            try
            {
                string currency = CurrencyAPI.searchInformation(transformer, comboBox.SelectedIndex, "name");
                string date = CurrencyAPI.searchInformation(transformer, comboBox.SelectedIndex, "date");
                string bankconversion = CurrencyAPI.searchInformation(transformer, comboBox.SelectedIndex, "bankConversionPri");
                string time = CurrencyAPI.searchInformation(transformer, comboBox.SelectedIndex, "time");
                ExchangeRate form = new ExchangeRate(currency, date, bankconversion, time);
                form.Show();
            }
            catch
            {
                MessageBox.Show("发生错误");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ShowRate(comboBox3);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ShowRate(comboBox4);
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
