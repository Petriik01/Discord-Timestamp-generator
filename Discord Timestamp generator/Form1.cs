using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discord_Timestamp_generator
{
    public partial class Form1 : Form
    {
        DateTime time;
        DateTime date;
        string type;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Choose your timestamp type";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            time = dateTimePicker2.Value;

            type = comboBox1.Text;

            Int32 unixTimestamp = (int)time.Subtract(new DateTime(1970, 1, 1, 2, 0, 0)).TotalSeconds;

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    textBoxOutput.Text = "<t:" + unixTimestamp.ToString() + ":R>";
                    break;
                case 1:
                    textBoxOutput.Text = "<t:" + unixTimestamp.ToString() + ":f>";
                    break;
                case 2:
                    textBoxOutput.Text = "<t:" + unixTimestamp.ToString() + ":F>";
                    break; 
                case 3:
                    textBoxOutput.Text = "<t:" + unixTimestamp.ToString() + ":d>";
                    break;
                case 4:
                    textBoxOutput.Text = "<t:" + unixTimestamp.ToString() + ":D>";
                    break;
                case 5:
                    textBoxOutput.Text = "<t:" + unixTimestamp.ToString() + ":t>";
                    break;
                case 6:
                    textBoxOutput.Text = "<t:" + unixTimestamp.ToString() + ":T>";
                    break;
                default:
                    textBoxOutput.Text = "Your output will be there";
                    break;
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxOutput.Text);
            labelCopy.Text = "Copied";
        }
    }
}