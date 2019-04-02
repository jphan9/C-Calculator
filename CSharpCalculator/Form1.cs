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
        private double s1 = 0.0;
        private double s2 = 0.0;
        private double total = 0.0;
        private Boolean addition, subtraction, division, multiplication, hasNumber = false;
        private int count, firstCount = 0;

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
            if (solutionTextBox.Text == "0" || solutionTextBox.Text == "" || hasNumber == true)
            {
                solutionTextBox.Text = "1";
            }
            else
                solutionTextBox.Text = solutionTextBox.Text + "1";
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            if (solutionTextBox.Text == "0" || solutionTextBox.Text == "" || hasNumber == true)
            {
                solutionTextBox.Text = "2";
            }
            else
                solutionTextBox.Text = solutionTextBox.Text + "2";
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            if (solutionTextBox.Text == "0" || solutionTextBox.Text == "" || hasNumber == true)
            {
                solutionTextBox.Text = "3";
            }
            else
                solutionTextBox.Text = solutionTextBox.Text + "3";
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            if (solutionTextBox.Text == "0" || solutionTextBox.Text == "" || hasNumber == true)
            {
                solutionTextBox.Text = "4";
            }
            else
                solutionTextBox.Text = solutionTextBox.Text + "4";
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            if (solutionTextBox.Text == "0" || solutionTextBox.Text == "" || hasNumber == true)
            {
                solutionTextBox.Text = "5";
            }
            else
                solutionTextBox.Text = solutionTextBox.Text + "5";
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            if (solutionTextBox.Text == "0" || solutionTextBox.Text == "" || hasNumber == true)
            {
                solutionTextBox.Text = "6";
            }
            else
                solutionTextBox.Text = solutionTextBox.Text + "6";
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            if (solutionTextBox.Text == "0" || solutionTextBox.Text == "" || hasNumber == true)
            {
                solutionTextBox.Text = "7";
            }
            else
                solutionTextBox.Text = solutionTextBox.Text + "7";
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            if (solutionTextBox.Text == "0" || solutionTextBox.Text == "" || hasNumber == true)
            {
                solutionTextBox.Text = "8";
            }
            else
                solutionTextBox.Text = solutionTextBox.Text + "8";
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            if (solutionTextBox.Text == "0" || solutionTextBox.Text == "" || hasNumber == true)
            {
                solutionTextBox.Text = "9";
            }
            else
                solutionTextBox.Text = solutionTextBox.Text + "9";
        }

        private void acButton_Click(object sender, EventArgs e)
        {
            total = 0;
            if (solutionTextBox.Text == "0" || solutionTextBox.Text == "" || hasNumber == true)
            {
                return;
            }
            else
                solutionTextBox.Text = "0";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            count++;
            s1 = Double.Parse(solutionTextBox.Text);
            total = total + s1;
            Console.WriteLine(total.ToString());
            addition = true;

            solutionTextBox.Text = "";

            if (count > 1)
            {
                solutionTextBox.Text = total.ToString();
                hasNumber = true;
            }
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if (total == 0)
            {
                total = s1;
            }
            count++;
            s1 = Double.Parse(solutionTextBox.Text);
            total = total - s1;
            Console.WriteLine(total.ToString());
            subtraction = true;

            solutionTextBox.Text = "";

            if (count > 1)
            {
                solutionTextBox.Text = total.ToString();
                hasNumber = true;
            }
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            // Counter to check the first time hitting this button.
            firstCount++;
            // If the initial total amount is 0 then set the amount to s1.
            if (total == 0)
            {
                total = s1;
                Console.WriteLine("here");
                Console.WriteLine("First Total: " + total.ToString());
            }
            count++;
            s1 = Double.Parse(solutionTextBox.Text);

            // If this is the first time that the button has been hit, set the total to the number in the text field. Else set the old total and divide by the number in the text field.
            if (firstCount == 1)
            {
                total = s1;
            }
            else
                total = total / s1;
            Console.WriteLine("Total: " + total.ToString());
            Console.WriteLine("S1: " + s1.ToString());
            division = true;

            solutionTextBox.Text = "";

            if (count > 1)
            {
                solutionTextBox.Text = total.ToString();
                hasNumber = true;
            }
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            if (total == 0)
            {
                total = s1;
                Console.WriteLine("here");
                Console.WriteLine("First Total: " + total.ToString());
            }
            count++;
            s1 = Double.Parse(solutionTextBox.Text);
            total = total * s1;
            Console.WriteLine("Total: " + total.ToString());
            Console.WriteLine("S1: " + s1.ToString());
            multiplication = true;

            solutionTextBox.Text = "";

            if (count > 1)
            {
                solutionTextBox.Text = total.ToString();
                hasNumber = true;
            }
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            s2 = Double.Parse(solutionTextBox.Text);
            if (addition == true)
            {
                total = total + s2;
            }
            if (subtraction == true)
            {
                total = total - s2;
            }
            if (multiplication == true)
            {
                total = total * s2;
            }
            if (division == true)
            {
                total = total / s2;
                Console.WriteLine("S2: " + s2.ToString());
                Console.WriteLine("Real Total: " + total.ToString());
            }
            solutionTextBox.Text = total.ToString();
            count = 0;
            firstCount = 0;
            hasNumber = false;
            
        }
        
    }
}
