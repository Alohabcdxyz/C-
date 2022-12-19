namespace tinh
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
            this.tinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(34, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // soN
            // 
            this.soN.Location = new System.Drawing.Point(93, 50);
            this.soN.Name = "soN";
            this.soN.Size = new System.Drawing.Size(342, 22);
            this.soN.TabIndex = 1;
            this.soN.TextChanged += new System.EventHandler(this.soN_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(35, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "ngiaithua";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ketQua
            // 
            this.ketQua.Location = new System.Drawing.Point(152, 100);
            this.ketQua.Name = "ketQua";
            this.ketQua.Size = new System.Drawing.Size(341, 22);
            this.ketQua.TabIndex = 3;
            this.ketQua.TextChanged += new System.EventHandler(this.ketQua_TextChanged);
            // 
            // tinh
            // 
            this.tinh.Location = new System.Drawing.Point(105, 158);
            this.tinh.Name = "tinh";
            this.tinh.Size = new System.Drawing.Size(113, 45);
            this.tinh.TabIndex = 4;
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
            this.Controls.Add(this.ketQua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.soN);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox soN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ketQua;
        private System.Windows.Forms.Button tinh;

        #endregion
    }
}