using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void x_Click(object sender, EventArgs e)
        {
            float a = float.Parse(soA.Text);
            float b = float.Parse(soB.Text);
            float c = float.Parse(soC.Text);
            float delta = b * b - (4 * a * c);
            if (delta < 0)
            {
                ketQua.Text = "Phuong trinh vo nghiem";
            }
            else if (delta == 0)
            {
                float x = -b / (2 * a);
                ketQua.Text = "" + x;
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                ketQua.Text = "" + x1 + "" + x2;
            }

        }

        private void soA_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void soC_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void Ans_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void tinh_Click(object sender, EventArgs e)
        {
            float a = float.Parse(soA.Text);
            float b = float.Parse(soB.Text);
            float c = float.Parse(soC.Text);
            float delta = b * b - (4 * a * c);
            if (delta < 0)
            {
                Ans.Text = "Phuong trinh vo nghiem";
            }
            else if (delta == 0)
            {
                float x = (-b / (2 * a));
                Ans.Text = "" + x;
            }
            else
            {
                double x1 = ((-b + Math.Sqrt(delta)) / (2 * a));
                double x2 = ((-b - Math.Sqrt(delta)) / (2 * a));
                Ans.Text = "" + x1 + "" + x2;
            }
        }
    }
}