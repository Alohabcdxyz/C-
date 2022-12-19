using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator
{
    public partial class Form1 : Form
    {
        string sign;
        double val1;
        double val2;
        int trackkeypoint=0;
        public Form1()
        {
            InitializeComponent();
        }
        

        private void btn1_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text+btn1.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text+btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text+btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text+btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text+btn5.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text+btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text+btn9.Text;
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text+btn10.Text;
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text+btn11.Text;
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text+btn12.Text;
        }


        private void btn6_Click(object sender, EventArgs e)
        {
            val2 =double.Parse(txtBox.Text);
            double result;
            if (sign == "+")
            {
                result = val1 + val2;
                txtBox.Text =result.ToString();
            }
            else if (sign == "-")
            {
                result = val1 - val2;
                txtBox.Text = result.ToString();
            }
            else if (sign == "*")
            {
                result = val1 * val2;
                txtBox.Text = result.ToString();
            }
            else
            {
                result = val1 / val2;
                txtBox.Text = result.ToString();
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtBox.Text = "";
            val1 = 0;
            val2 = 0;
            sign = "";
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            sign = "+";
            val1 = double.Parse(txtBox.Text);
            txtBox.Text = "";
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            sign = "-";
            val1 = double.Parse(txtBox.Text);
            txtBox.Text = "";
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            sign = "*";
            val1 = double.Parse(txtBox.Text);
            txtBox.Text = "";
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            sign = "/";
            val1 = double.Parse(txtBox.Text);
            txtBox.Text = "";
        }
        
        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            
        }
 
        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keycode;
            keycode = e.KeyChar;
          
            if (keycode >= 48 && keycode <= 57 || keycode==8 || keycode==32 || keycode==46) 
            {   
                if (keycode == 46) ++trackkeypoint;
                if (trackkeypoint > 1) { e.Handled = true; --trackkeypoint; }
            }
            else e.Handled = true;
        }
 
        private void txtBox_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            double v;
            v = double.Parse(txtBox.Text);
            txtBox.Text = Math.Pow(v,2).ToString();
        }


        private void btn16_Click(object sender, EventArgs e)
        {
            double v;
            v = double.Parse(txtBox.Text);
            txtBox.Text = Math.Sin(v).ToString();
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            double v;
            v = double.Parse(txtBox.Text);
            txtBox.Text=Math.Cos(v).ToString();
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            double v;
            v = double.Parse(txtBox.Text);
            txtBox.Text = Math.Tan(v).ToString();
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            double v;
            v = double.Parse(txtBox.Text);
            txtBox.Text = Math.Sqrt(v).ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Length > 0)
            {
                txtBox.Text = txtBox.Text.Remove(txtBox.Text.Length - 1, 1);
            }
            if (txtBox.Text == "")
            {
                txtBox.Text = "0";
            }
        }
    }
}