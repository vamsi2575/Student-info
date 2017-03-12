namespace studentinfo
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
            this.cmda = new System.Windows.Forms.Label();
            this.cmdb = new System.Windows.Forms.Label();
            this.textBoxregno = new System.Windows.Forms.TextBox();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.cmdc = new System.Windows.Forms.Label();
            this.textBoxsem = new System.Windows.Forms.TextBox();
            this.cmdd = new System.Windows.Forms.Label();
            this.cmde = new System.Windows.Forms.Label();
            this.cmdf = new System.Windows.Forms.Label();
            this.textBoxm1 = new System.Windows.Forms.TextBox();
            this.textBoxm2 = new System.Windows.Forms.TextBox();
            this.textBoxm3 = new System.Windows.Forms.TextBox();
            this.cmdres = new System.Windows.Forms.Button();
            this.cmdg = new System.Windows.Forms.Label();
            this.cmdgrade = new System.Windows.Forms.Label();
            this.cmdavg = new System.Windows.Forms.Label();
            this.textBoxavg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmda
            // 
            this.cmda.AutoSize = true;
            this.cmda.Location = new System.Drawing.Point(28, 42);
            this.cmda.Name = "cmda";
            this.cmda.Size = new System.Drawing.Size(37, 13);
            this.cmda.TabIndex = 0;
            this.cmda.Text = "regno:";
            // 
            // cmdb
            // 
            this.cmdb.AutoSize = true;
            this.cmdb.Location = new System.Drawing.Point(29, 73);
            this.cmdb.Name = "cmdb";
            this.cmdb.Size = new System.Drawing.Size(36, 13);
            this.cmdb.TabIndex = 1;
            this.cmdb.Text = "name:";
            // 
            // textBoxregno
            // 
            this.textBoxregno.Location = new System.Drawing.Point(91, 35);
            this.textBoxregno.Name = "textBoxregno";
            this.textBoxregno.Size = new System.Drawing.Size(100, 20);
            this.textBoxregno.TabIndex = 2;
            this.textBoxregno.TextChanged += new System.EventHandler(this.textBoxregno_TextChanged);
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(91, 66);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(100, 20);
            this.textBoxname.TabIndex = 3;
            this.textBoxname.TextChanged += new System.EventHandler(this.textBoxname_TextChanged);
            // 
            // cmdc
            // 
            this.cmdc.AutoSize = true;
            this.cmdc.Location = new System.Drawing.Point(35, 108);
            this.cmdc.Name = "cmdc";
            this.cmdc.Size = new System.Drawing.Size(29, 13);
            this.cmdc.TabIndex = 4;
            this.cmdc.Text = "sem:";
            // 
            // textBoxsem
            // 
            this.textBoxsem.Location = new System.Drawing.Point(91, 105);
            this.textBoxsem.Name = "textBoxsem";
            this.textBoxsem.Size = new System.Drawing.Size(100, 20);
            this.textBoxsem.TabIndex = 5;
            this.textBoxsem.TextChanged += new System.EventHandler(this.textBoxsem_TextChanged);
            // 
            // cmdd
            // 
            this.cmdd.AutoSize = true;
            this.cmdd.Location = new System.Drawing.Point(25, 149);
            this.cmdd.Name = "cmdd";
            this.cmdd.Size = new System.Drawing.Size(39, 13);
            this.cmdd.TabIndex = 6;
            this.cmdd.Text = "mark1:";
            // 
            // cmde
            // 
            this.cmde.AutoSize = true;
            this.cmde.Location = new System.Drawing.Point(25, 181);
            this.cmde.Name = "cmde";
            this.cmde.Size = new System.Drawing.Size(39, 13);
            this.cmde.TabIndex = 7;
            this.cmde.Text = "mark2:";
            // 
            // cmdf
            // 
            this.cmdf.AutoSize = true;
            this.cmdf.Location = new System.Drawing.Point(25, 209);
            this.cmdf.Name = "cmdf";
            this.cmdf.Size = new System.Drawing.Size(39, 13);
            this.cmdf.TabIndex = 8;
            this.cmdf.Text = "mark3:";
            // 
            // textBoxm1
            // 
            this.textBoxm1.Location = new System.Drawing.Point(91, 146);
            this.textBoxm1.Name = "textBoxm1";
            this.textBoxm1.Size = new System.Drawing.Size(100, 20);
            this.textBoxm1.TabIndex = 9;
            this.textBoxm1.TextChanged += new System.EventHandler(this.textBoxm1_TextChanged);
            // 
            // textBoxm2
            // 
            this.textBoxm2.Location = new System.Drawing.Point(91, 172);
            this.textBoxm2.Name = "textBoxm2";
            this.textBoxm2.Size = new System.Drawing.Size(100, 20);
            this.textBoxm2.TabIndex = 10;
            this.textBoxm2.TextChanged += new System.EventHandler(this.textBoxm2_TextChanged);
            // 
            // textBoxm3
            // 
            this.textBoxm3.Location = new System.Drawing.Point(91, 202);
            this.textBoxm3.Name = "textBoxm3";
            this.textBoxm3.Size = new System.Drawing.Size(100, 20);
            this.textBoxm3.TabIndex = 11;
            this.textBoxm3.TextChanged += new System.EventHandler(this.textBoxm3_TextChanged);
            // 
            // cmdres
            // 
            this.cmdres.Location = new System.Drawing.Point(28, 296);
            this.cmdres.Name = "cmdres";
            this.cmdres.Size = new System.Drawing.Size(146, 34);
            this.cmdres.TabIndex = 12;
            this.cmdres.Text = "RESULT";
            this.cmdres.UseVisualStyleBackColor = true;
            this.cmdres.Click += new System.EventHandler(this.cmdres_Click);
            // 
            // cmdg
            // 
            this.cmdg.AutoSize = true;
            this.cmdg.Location = new System.Drawing.Point(271, 317);
            this.cmdg.Name = "cmdg";
            this.cmdg.Size = new System.Drawing.Size(48, 13);
            this.cmdg.TabIndex = 13;
            this.cmdg.Text = "GRADE:";
            // 
            // cmdgrade
            // 
            this.cmdgrade.AutoSize = true;
            this.cmdgrade.Location = new System.Drawing.Point(338, 317);
            this.cmdgrade.Name = "cmdgrade";
            this.cmdgrade.Size = new System.Drawing.Size(27, 13);
            this.cmdgrade.TabIndex = 14;
            this.cmdgrade.Text = "res1";
            this.cmdgrade.Click += new System.EventHandler(this.cmdgrade_Click);
            // 
            // cmdavg
            // 
            this.cmdavg.AutoSize = true;
            this.cmdavg.Location = new System.Drawing.Point(25, 239);
            this.cmdavg.Name = "cmdavg";
            this.cmdavg.Size = new System.Drawing.Size(49, 13);
            this.cmdavg.TabIndex = 15;
            this.cmdavg.Text = "average:";
            // 
            // textBoxavg
            // 
            this.textBoxavg.Location = new System.Drawing.Point(91, 239);
            this.textBoxavg.Name = "textBoxavg";
            this.textBoxavg.Size = new System.Drawing.Size(100, 20);
            this.textBoxavg.TabIndex = 16;
            this.textBoxavg.TextChanged += new System.EventHandler(this.textBoxavg_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 342);
            this.Controls.Add(this.textBoxavg);
            this.Controls.Add(this.cmdavg);
            this.Controls.Add(this.cmdgrade);
            this.Controls.Add(this.cmdg);
            this.Controls.Add(this.cmdres);
            this.Controls.Add(this.textBoxm3);
            this.Controls.Add(this.textBoxm2);
            this.Controls.Add(this.textBoxm1);
            this.Controls.Add(this.cmdf);
            this.Controls.Add(this.cmde);
            this.Controls.Add(this.cmdd);
            this.Controls.Add(this.textBoxsem);
            this.Controls.Add(this.cmdc);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.textBoxregno);
            this.Controls.Add(this.cmdb);
            this.Controls.Add(this.cmda);
            this.Name = "Form1";
            this.Text = "Student Info";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cmda;
        private System.Windows.Forms.Label cmdb;
        private System.Windows.Forms.TextBox textBoxregno;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.Label cmdc;
        private System.Windows.Forms.TextBox textBoxsem;
        private System.Windows.Forms.Label cmdd;
        private System.Windows.Forms.Label cmde;
        private System.Windows.Forms.Label cmdf;
        private System.Windows.Forms.TextBox textBoxm1;
        private System.Windows.Forms.TextBox textBoxm2;
        private System.Windows.Forms.TextBox textBoxm3;
        private System.Windows.Forms.Button cmdres;
        private System.Windows.Forms.Label cmdg;
        private System.Windows.Forms.Label cmdgrade;
        private System.Windows.Forms.Label cmdavg;
        private System.Windows.Forms.TextBox textBoxavg;
    }
}

