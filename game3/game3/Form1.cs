using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game3
{
    public partial class Form1 : Form
    {
        private Form2 form1;
        private Form3 form2;
        private Form10 form3;
        private Form4 form4;
        private Form5 form5;
       

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1 = new Form2(); 
            form1.Show();
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            form1 = new Form2();
            form1.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            form2 = new Form3();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form2 = new Form3();
            form2.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            form3 = new Form10();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form3 = new Form10();
            form3.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            form4 = new Form4();
            form4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            form4 = new Form4();
            form4.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            form5 = new Form5();
            form5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form5 = new Form5();
            form5.Show();
        }
    }
}
