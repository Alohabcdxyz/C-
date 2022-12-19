using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void soN_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void ketQua_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
        
        private void tinh_Click(object sender, EventArgs e)
        {
            double n = double.Parse(soN.Text);
            int m = 1;
            for(int i=1;i<=n;i++){  
                m = m*i;
            }

            ketQua.Text = "" + m;
        }
    }
}