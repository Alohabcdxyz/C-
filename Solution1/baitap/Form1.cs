using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count;
            int n = int.Parse(soN.Text);
            for(int k = 2; k <= n; k++){
                count = 0;
                for(int o = 2;o<= k/2; o++){
                    if(k % o == 0){
                        count++;
                    }
                }        
                if(count == 0){
                    checkSonto.Text = "" + k;
                }
            }
            
        }

        private void ktra_Click(object sender, EventArgs e)
        {
            int n = int.Parse(soN.Text);
            int count = 0;
            
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                kiemtran.Text = "Day la SNT";
               
            }
            else
            {
                kiemtran.Text = "Day khong phai So Nguyen To !";
            }
        }
        
        private void checkSonto_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}