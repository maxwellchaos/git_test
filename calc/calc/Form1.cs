using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                label1.Text = "Error";
                return;
            }

            double Odin;
            Odin = Convert.ToDouble(textBox2.Text);

            double Dva;
            Dva = Convert.ToDouble(textBox1.Text);

            double Result = Odin * Dva;
            label1.Text = Convert.ToString(Result);

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                label1.Text = "Error";
                return;
            }
            if (textBox1.Text == "")
            {
                label1.Text = "Error";
                return;
            }

            double Odin;
            Odin = Convert.ToDouble(textBox2.Text);

            double Dva;
            Dva = Convert.ToDouble(textBox1.Text);

            double Result = Odin / Dva;
            label1.Text = Convert.ToString(Result);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "7";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + ".";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ((Button)sender).Text;
        }
    }
}



