using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblInput.Text += button1.Text; 
        }
        
        private void button11_Click(object sender, EventArgs e)
        {
            lblInput.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            lblInput.Text = lblInput.Text.Substring(0, lblInput.Text.Length - 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblInput.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblInput.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblInput.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblInput.Text += button5.Text;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            lblInput.Text += button6.Text;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            lblInput.Text += button7.Text;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            lblInput.Text += button8.Text;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            lblInput.Text += button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            lblInput.Text += button10.Text;

        }

        private void button16_Click(object sender, EventArgs e)
        {
            lblInput.Text += button16.Text;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            lblInput.Text += button15.Text;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            lblInput.Text += button14.Text;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            lblInput.Text += button13.Text;

        }

        private void button19_Click(object sender, EventArgs e)
        {
            lblInput.Text += button19.Text;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            lblInput.Text += button17.Text;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try{
                var v = dt.Compute(lblInput.Text, "");
                lblInput.Text = v.ToString();
            }
            catch (SyntaxErrorException ex)
            {
                lblInput.Text = "Error";
            }
            catch(InvalidOperationException ex)
            {
                lblInput.Text = "Error";
            }
            catch(EvaluateException ex)
            {
                lblInput.Text = "Error";
            }
            
        }
    }
}
