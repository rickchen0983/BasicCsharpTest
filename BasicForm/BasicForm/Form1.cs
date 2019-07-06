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
        double lx1 = 0;
        double ly1 = 0;
        double lx2 = 0;
        double ly2 = 0;
        private void Button2_Click(object sender, EventArgs e)
        {
            double? x1 = 0;
            double? y1 = 0;
            double? x2 = 0;
            double? y2 = 0;
            if (x1 == null | y1 == null | x2 == null | y2 == null)
            {
                MessageBox.Show("failed");
            }
            else
            {
                x1 = double.Parse(textBox5.Text);
                lineShape2.X1 = (int)x1;
                y1 = double.Parse(textBox4.Text);
                lineShape2.Y1 = (int)y1;
                x2 = double.Parse(textBox2.Text);
                lineShape2.X2 = (int)x2 + 270;
                y2 = double.Parse(textBox3.Text);
                lineShape2.Y2 = (int)y2 + 150;
            }
                
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            lx1 = lineShape2.X1;
            ly1 = lineShape2.Y1;
            lx2 = lineShape2.X2;
            ly2 = lineShape2.Y2;
        }

    }
}
