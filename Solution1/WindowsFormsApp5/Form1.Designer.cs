namespace WindowsFormsApp5
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
            this.label1 = new System.Windows.Forms.Label();
            this.soN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ketQua = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(54, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // soN
            // 
            this.soN.Location = new System.Drawing.Point(122, 43);
            this.soN.Name = "soN";
            this.soN.Size = new System.Drawing.Size(231, 22);
            this.soN.TabIndex = 1;
            this.soN.TextChanged += new System.EventHandler(this.soN_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(59, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "ketqua";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ketQua
            // 
            this.ketQua.Location = new System.Drawing.Point(130, 89);
            this.ketQua.Name = "ketQua";
            this.ketQua.Size = new System.Drawing.Size(276, 22);
            this.ketQua.TabIndex = 3;
            this.ketQua.TextChanged += new System.EventHandler(this.ketqua_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "tinh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ketQua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.soN);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox ketQua;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.TextBox soN;

        #endregion
    }
}