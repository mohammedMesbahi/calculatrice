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
            userInputText.Text += button1.Text; 
        }
        
        private void button11_Click(object sender, EventArgs e)
        {
            userInputText.Text = "";
            lblResult.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            userInputText.Text = userInputText.Text.Substring(0, userInputText.Text.Length - 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userInputText.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userInputText.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userInputText.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            userInputText.Text += button5.Text;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            userInputText.Text += button6.Text;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            userInputText.Text += button7.Text;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            userInputText.Text += button8.Text;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            userInputText.Text += button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            userInputText.Text += button10.Text;

        }

        private void button16_Click(object sender, EventArgs e)
        {
            userInputText.Text += button16.Text;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            userInputText.Text += button15.Text;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            userInputText.Text += button14.Text;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            userInputText.Text += button13.Text;

        }

        private void button19_Click(object sender, EventArgs e)
        {
            userInputText.Text += button19.Text;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            userInputText.Text += button17.Text;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try{
                var v = dt.Compute(userInputText.Text, "");
                lblResult.Text = v.ToString();
            }
            catch (SyntaxErrorException ex)
            {
                lblResult.Text = "Error";
            }
            catch(InvalidOperationException ex)
            {
                lblResult.Text = "Error";
            }
            catch(EvaluateException ex)
            {
                lblResult.Text = "Error";
            }
            
        }

        private void userInputText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
