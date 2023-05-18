using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rectangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lenght, breadth, area, perimeter;

            lenght = Convert.ToInt32(textBox1.Text);
            breadth = Convert.ToInt32(textBox2.Text);

            area = lenght * breadth;
            textBox3.Text = area.ToString();
            perimeter = 2 *(lenght + breadth);
            textBox4.Text = perimeter.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
