using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCalculator
{
    public partial class Form1 : Form
    {
        private int s1 = 0;
        private int s2 = 0;
        private int total = 0;
        private Boolean addition, subtraction, division, multiplication = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            if (solutionTextBox.Text == "0" || solutionTextBox.Text == "")
            {
                return;
            }
            else
                solutionTextBox.Text = solutionTextBox.Text + "0";
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            if (solutionTextBox.Text == "0" || solutionTextBox.Text == "")
            {
                solutionTextBox.Text = "1";
            }
            else
                solutionTextBox.Text = solutionTextBox.Text + "1";
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            if (solutionTextBox.Text == "0" || solutionTextBox.Text == "")
            {
                solutionTextBox.Text = "2";
            }
            else
                solutionTextBox.Text = solutionTextBox.Text + "2";
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            if (solutionTextBox.Text == "0" || solutionTextBox.Text == "")
            {
                solutionTextBox.Text = "3";
            }
            else
                solutionTextBox.Text = solutionTextBox.Text + "3";
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            if (solutionTextBox.Text == "0" || solutionTextBox.Text == "")
            {
                solutionTextBox.Text = "4";
            }
            else
                solutionTextBox.Text = solutionTextBox.Text + "4";
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            if (solutionTextBox.Text == "0" || solutionTextBox.Text == "")
            {
                solutionTextBox.Text = "5";
            }
            else
                solutionTextBox.Text = solutionTextBox.Text + "5";
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            if (solutionTextBox.Text == "0" || solutionTextBox.Text == "")
            {
                solutionTextBox.Text = "6";
            }
            else
                solutionTextBox.Text = solutionTextBox.Text + "6";
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            if (solutionTextBox.Text == "0" || solutionTextBox.Text == "")
            {
                solutionTextBox.Text = "7";
            }
            else
                solutionTextBox.Text = solutionTextBox.Text + "7";
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            if (solutionTextBox.Text == "0" || solutionTextBox.Text == "")
            {
                solutionTextBox.Text = "8";
            }
            else
                solutionTextBox.Text = solutionTextBox.Text + "8";
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            if (solutionTextBox.Text == "0" || solutionTextBox.Text == "")
            {
                solutionTextBox.Text = "9";
            }
            else
                solutionTextBox.Text = solutionTextBox.Text + "9";
        }

        private void acButton_Click(object sender, EventArgs e)
        {
            if (solutionTextBox.Text == "0" || solutionTextBox.Text == "")
            {
                return;
            }
            else
                solutionTextBox.Text = "0";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            s1 = Int32.Parse(solutionTextBox.Text);
            addition = true;

            solutionTextBox.Text = "";

        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            s2 = Int32.Parse(solutionTextBox.Text);
            if (addition == true)
            {
                total = total + s1 + s2;
            }
            solutionTextBox.Text = total.ToString();
        }
        
        
    }
}
