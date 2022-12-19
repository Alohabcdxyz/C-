using System;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void tinh_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
        
        private void tinh_Click(object sender, EventArgs e)
        {
            int n = int.Parse(soN.Text);
            int giaiThua = 1;
            for(int i=1;i<=n;i++){  
                giaiThua = giaiThua*i;
            }
            
            ketQua.Text = "" + giaiThua;
        }
    }
}