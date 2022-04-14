using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "3,4";
            textBox2.Text = "0,74";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double m = double.Parse(textBox1.Text);
            textBox4.Text += Environment.NewLine +"m=" + m.ToString();
            double v = double.Parse(textBox2.Text);
            textBox4.Text += Environment.NewLine + "v=" + v.ToString();

            
            double u = (m*v*v)/2;

            textBox4.Text += Environment.NewLine + "Eкин = " + u.ToString();


        }
    }
}
