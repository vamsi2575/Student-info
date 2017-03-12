using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace studentinfo
{
    public partial class Form1 : Form
    {
        long regno;
        string name; 
        int sem;
        double m1,m2,m3,res=0.0;
        char gra;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxregno_TextChanged(object sender, EventArgs e)
        {
            string s5;
            s5 = textBoxregno.Text;
            long.TryParse(s5, out regno);
        }

        private void textBoxname_TextChanged(object sender, EventArgs e)
        {
            name = textBoxname.Text;
        }

        private void textBoxsem_TextChanged(object sender, EventArgs e)
        {
            string s1;
            s1 = textBoxsem.Text;
            int.TryParse(s1, out sem);
        }

        private void textBoxm1_TextChanged(object sender, EventArgs e)
        {
            string s2;
            s2 = textBoxm1.Text;
            double.TryParse(s2, out m1);
        }

        private void textBoxm2_TextChanged(object sender, EventArgs e)
        {
            string s3;
            s3 = textBoxm2.Text;
            double.TryParse(s3, out m2);
        }

        private void textBoxm3_TextChanged(object sender, EventArgs e)
        {
            string s4;
            s4 = textBoxm3.Text;
            double.TryParse(s4, out m3);
        }

        private void textBoxavg_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmdgrade_Click(object sender, EventArgs e)
        {
           
        }

        private void cmdres_Click(object sender, EventArgs e)
        {
            res = (m1 + m2 + m3) / 3;
            textBoxavg.Text = res.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        


    }
}
