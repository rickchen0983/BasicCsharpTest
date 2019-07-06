using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double l = 0;
        private void Button2_Click(object sender, EventArgs e)
        {
            double? x=0;
            double? y=0;
            if (x == null | y == null)
            {
                MessageBox.Show("failed");
            }
            else
            {
                x = double.Parse(textBox2.Text);
                lineShape2.X2 = (int)x ;
                y = double.Parse(textBox3.Text);
                lineShape2.Y2 = (int)y ;
            }
                
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            l = lineShape2.Y2;
        }

    }
}
