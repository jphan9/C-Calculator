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
        private int count, addCount, minusCount, divideCount, multiplyCount = 0;

        mathFunctionality mathFunc = new mathFunctionality();

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
            /*
            if (solutionTextBox.Text == "0" || solutionTextBox.Text == "" || hasNumber == true)
            {
                return;
            }
            else
            */
            solutionTextBox.Text = "0";

            count = 0;
            addCount = 0;
            minusCount = 0;
            divideCount = 0;
            multiplyCount = 0;
            hasNumber = false;
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            count++;
            addCount++;
            total = mathFunc.add(solutionTextBox.Text,addCount);
            
            /*            
            s1 = Double.Parse(solutionTextBox.Text);
            //solutionTextBox.Text = total.ToString();

            // If this is the first time that the button has been hit, set the total to the number in the text field. Else set the old total and divide by the number in the text field.
            if (firstCount == 1)
            {
                total = s1;
            }
            else
                total = total + s1;
            Console.WriteLine("plus s1: " + s1.ToString());
            Console.WriteLine("plus total: " + total.ToString());
            */
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
            minusCount++;
            count++;

            total = mathFunc.minus(solutionTextBox.Text, minusCount);

            /*s1 = Double.Parse(solutionTextBox.Text);

            // If this is the first time that the button has been hit, set the total to the number in the text field. Else set the old total and divide by the number in the text field.
            if (firstCount == 1)
            {
                total = s1;
            }
            else
                total = total - s1;

            subtraction = true;
            */

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
            divideCount++;

            // If the initial total amount is 0 then set the amount to s1.
            /*
            if (total == 0)
            {
                total = s1;
                Console.WriteLine("here");
                Console.WriteLine("First Total: " + total.ToString());
            }
             * */
            count++;

            total = mathFunc.divide(solutionTextBox.Text, divideCount);
            /*
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
            */
            solutionTextBox.Text = "";

            if (count > 1)
            {
                solutionTextBox.Text = total.ToString();
                hasNumber = true;
            }
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            multiplyCount++;
            /*
            if (total == 0)
            {
                total = s1;
                Console.WriteLine("here");
                Console.WriteLine("First Total: " + total.ToString());
            }
             */

            count++;
            total = mathFunc.multiply(solutionTextBox.Text, multiplyCount);
            /*
            s1 = Double.Parse(solutionTextBox.Text);

            // If this is the first time that the button has been hit, set the total to the number in the text field. Else set the old total and divide by the number in the text field.
            if (firstCount == 1)
            {
                total = s1;
            }
            else
                total = total * s1;
            Console.WriteLine("Total: " + total.ToString());
            Console.WriteLine("S1: " + s1.ToString());
            multiplication = true;
            */

            solutionTextBox.Text = "";
            
            if (count > 1)
            {
                solutionTextBox.Text = total.ToString();
                hasNumber = true;
            }
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            /*
            s2 = Double.Parse(solutionTextBox.Text);
            if (addition == true)
            {
                total = total + s2;
                Console.WriteLine("Addition S2: " + s2.ToString());
                Console.WriteLine("Addition Real Total: " + total.ToString());
                addition = false;
            }
            else if (subtraction == true)
            {
                total = total - s2;
                subtraction = false;
            }
            else if (multiplication == true)
            {
                total = total * s2;
                multiplication = false;
            }
            else if (division == true)
            {
                total = total / s2;
                Console.WriteLine("S2: " + s2.ToString());
                Console.WriteLine("Real Total: " + total.ToString());
                division = false;
            }
            */

            total = mathFunc.equals(solutionTextBox.Text);
            solutionTextBox.Text = total.ToString();
            Console.WriteLine("Text: " + solutionTextBox.Text);
            count = 0;
            addCount = 0;
            minusCount = 0;
            divideCount = 0;
            multiplyCount = 0;
            hasNumber = false;
        }
        
    }
}
