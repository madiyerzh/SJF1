namespace SJF
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtrata = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.LV = new System.Windows.Forms.ListView();
            this.txtJlhproses = new System.Windows.Forms.TextBox();
            this.LJlhProses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "SJF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtrata
            // 
            this.txtrata.Location = new System.Drawing.Point(393, 335);
            this.txtrata.Name = "txtrata";
            this.txtrata.Size = new System.Drawing.Size(77, 20);
            this.txtrata.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ratio TA";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(81, 338);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(77, 20);
            this.txttotal.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Total TA";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(187, 301);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(37, 57);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(60, 29);
            this.btnGenerate.TabIndex = 13;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // LV
            // 
            this.LV.Location = new System.Drawing.Point(6, 92);
            this.LV.Name = "LV";
            this.LV.Size = new System.Drawing.Size(464, 203);
            this.LV.TabIndex = 12;
            this.LV.UseCompatibleStateImageBehavior = false;
            // 
            // txtJlhproses
            // 
            this.txtJlhproses.Location = new System.Drawing.Point(37, 19);
            this.txtJlhproses.Multiline = true;
            this.txtJlhproses.Name = "txtJlhproses";
            this.txtJlhproses.Size = new System.Drawing.Size(60, 32);
            this.txtJlhproses.TabIndex = 11;
            this.txtJlhproses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LJlhProses
            // 
            this.LJlhProses.AutoSize = true;
            this.LJlhProses.BackColor = System.Drawing.SystemColors.Control;
            this.LJlhProses.Location = new System.Drawing.Point(3, 3);
            this.LJlhProses.Name = "LJlhProses";
            this.LJlhProses.Size = new System.Drawing.Size(108, 13);
            this.LJlhProses.TabIndex = 10;
            this.LJlhProses.Text = "Number of Processes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 365);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtrata);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.LV);
            this.Controls.Add(this.txtJlhproses);
            this.Controls.Add(this.LJlhProses);
            this.Name = "Form1";
            this.Text = "SJF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtrata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ListView LV;
        private System.Windows.Forms.TextBox txtJlhproses;
        private System.Windows.Forms.Label LJlhProses;
    }
}

