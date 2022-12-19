namespace baitap
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
            this.n = new System.Windows.Forms.Label();
            this.soN = new System.Windows.Forms.TextBox();
            this.ktran = new System.Windows.Forms.Label();
            this.kiemtran = new System.Windows.Forms.TextBox();
            this.ktrasonto = new System.Windows.Forms.Label();
            this.checkSonto = new System.Windows.Forms.TextBox();
            this.ktra = new System.Windows.Forms.Button();
            this.hiensonto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(36, 48);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(46, 37);
            this.n.TabIndex = 0;
            this.n.Text = "n";
            // 
            // soN
            // 
            this.soN.Location = new System.Drawing.Point(88, 45);
            this.soN.Name = "soN";
            this.soN.Size = new System.Drawing.Size(315, 22);
            this.soN.TabIndex = 1;
            this.soN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ktran
            // 
            this.ktran.Location = new System.Drawing.Point(36, 85);
            this.ktran.Name = "ktran";
            this.ktran.Size = new System.Drawing.Size(82, 35);
            this.ktran.TabIndex = 2;
            this.ktran.Text = "ktran";
            // 
            // kiemtran
            // 
            this.kiemtran.Location = new System.Drawing.Point(122, 88);
            this.kiemtran.Name = "kiemtran";
            this.kiemtran.Size = new System.Drawing.Size(309, 22);
            this.kiemtran.TabIndex = 3;
            this.kiemtran.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ktrasonto
            // 
            this.ktrasonto.Location = new System.Drawing.Point(37, 146);
            this.ktrasonto.Name = "ktrasonto";
            this.ktrasonto.Size = new System.Drawing.Size(124, 28);
            this.ktrasonto.TabIndex = 4;
            this.ktrasonto.Text = "so nguyen to tu 1 -> n";
            // 
            // checkSonto
            // 
            this.checkSonto.Location = new System.Drawing.Point(178, 143);
            this.checkSonto.Name = "checkSonto";
            this.checkSonto.Size = new System.Drawing.Size(349, 22);
            this.checkSonto.TabIndex = 5;
            this.checkSonto.TextChanged += new System.EventHandler(this.checkSonto_TextChanged);
            // 
            // ktra
            // 
            this.ktra.Location = new System.Drawing.Point(86, 194);
            this.ktra.Name = "ktra";
            this.ktra.Size = new System.Drawing.Size(104, 36);
            this.ktra.TabIndex = 6;
            this.ktra.Text = "ktra";
            this.ktra.UseVisualStyleBackColor = true;
            this.ktra.Click += new System.EventHandler(this.ktra_Click);
            // 
            // hiensonto
            // 
            this.hiensonto.Location = new System.Drawing.Point(301, 198);
            this.hiensonto.Name = "hiensonto";
            this.hiensonto.Size = new System.Drawing.Size(161, 31);
            this.hiensonto.TabIndex = 7;
            this.hiensonto.Text = "hiensonto";
            this.hiensonto.UseVisualStyleBackColor = true;
            this.hiensonto.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hiensonto);
            this.Controls.Add(this.ktra);
            this.Controls.Add(this.checkSonto);
            this.Controls.Add(this.ktrasonto);
            this.Controls.Add(this.kiemtran);
            this.Controls.Add(this.ktran);
            this.Controls.Add(this.soN);
            this.Controls.Add(this.n);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label ktrasonto;
        private System.Windows.Forms.TextBox checkSonto;
        private System.Windows.Forms.Button ktra;
        private System.Windows.Forms.Button hiensonto;

        private System.Windows.Forms.Label ktran;
        private System.Windows.Forms.TextBox kiemtran;

        private System.Windows.Forms.Label n;
        private System.Windows.Forms.TextBox soN;

        #endregion
    }
}