namespace baitap2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.soA = new System.Windows.Forms.TextBox();
            this.amu2 = new System.Windows.Forms.Label();
            this.soB = new System.Windows.Forms.TextBox();
            this.x = new System.Windows.Forms.Label();
            this.soC = new System.Windows.Forms.TextBox();
            this.ketQua = new System.Windows.Forms.Label();
            this.Ans = new System.Windows.Forms.TextBox();
            this.tinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // soA
            // 
            this.soA.Location = new System.Drawing.Point(58, 68);
            this.soA.Name = "soA";
            this.soA.Size = new System.Drawing.Size(41, 22);
            this.soA.TabIndex = 0;
            this.soA.TextChanged += new System.EventHandler(this.soA_TextChanged);
            // 
            // amu2
            // 
            this.amu2.Location = new System.Drawing.Point(113, 74);
            this.amu2.Name = "amu2";
            this.amu2.Size = new System.Drawing.Size(47, 15);
            this.amu2.TabIndex = 1;
            this.amu2.Text = "x^2";
            // 
            // soB
            // 
            this.soB.Location = new System.Drawing.Point(226, 73);
            this.soB.Name = "soB";
            this.soB.Size = new System.Drawing.Size(53, 22);
            this.soB.TabIndex = 2;
            this.soB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // x
            // 
            this.x.Location = new System.Drawing.Point(285, 76);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(38, 16);
            this.x.TabIndex = 3;
            this.x.Text = "x";
            this.x.Click += new System.EventHandler(this.x_Click);
            // 
            // soC
            // 
            this.soC.Location = new System.Drawing.Point(368, 71);
            this.soC.Name = "soC";
            this.soC.Size = new System.Drawing.Size(60, 22);
            this.soC.TabIndex = 4;
            this.soC.TextChanged += new System.EventHandler(this.soC_TextChanged);
            // 
            // ketQua
            // 
            this.ketQua.Location = new System.Drawing.Point(58, 118);
            this.ketQua.Name = "ketQua";
            this.ketQua.Size = new System.Drawing.Size(82, 36);
            this.ketQua.TabIndex = 5;
            this.ketQua.Text = "ketQua";
            // 
            // Ans
            // 
            this.Ans.Location = new System.Drawing.Point(150, 116);
            this.Ans.Name = "Ans";
            this.Ans.Size = new System.Drawing.Size(135, 22);
            this.Ans.TabIndex = 6;
            this.Ans.TextChanged += new System.EventHandler(this.Ans_TextChanged);
            // 
            // tinh
            // 
            this.tinh.Location = new System.Drawing.Point(67, 162);
            this.tinh.Name = "tinh";
            this.tinh.Size = new System.Drawing.Size(83, 29);
            this.tinh.TabIndex = 7;
            this.tinh.Text = "tinh";
            this.tinh.UseVisualStyleBackColor = true;
            this.tinh.Click += new System.EventHandler(this.tinh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tinh);
            this.Controls.Add(this.Ans);
            this.Controls.Add(this.ketQua);
            this.Controls.Add(this.soC);
            this.Controls.Add(this.x);
            this.Controls.Add(this.soB);
            this.Controls.Add(this.amu2);
            this.Controls.Add(this.soA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox Ans;
        private System.Windows.Forms.Button tinh;

        private System.Windows.Forms.TextBox soC;
        private System.Windows.Forms.Label ketQua;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Label x;

        private System.Windows.Forms.TextBox soA;
        private System.Windows.Forms.Label amu2;
        private System.Windows.Forms.TextBox soB;

        #endregion
    }
}