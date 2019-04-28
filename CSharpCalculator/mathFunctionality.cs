using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCalculator
{
    class mathFunctionality
    {
        public double firstNumber = 0.0;
        public double secondNumber = 0.0;
        public double total = 0.0;
        public Boolean addition, subtraction, division, multiplication, hasNumber = false;
        public int count, firstCount = 0;

        public double add(string solution, int addCount)
        {
            firstNumber = Double.Parse(solution);
            //solution = total.ToString();

            // If this is the first time that the button has been hit, set the total to the number in the text field. Else set the old total and divide by the number in the text field.
            if (addCount == 1)
            {
                total = firstNumber;
            }
            else
                total = total + firstNumber;
            Console.WriteLine("plus s1: " + firstNumber.ToString());
            Console.WriteLine("plus total: " + total.ToString());
            Console.WriteLine("firstCount : " + firstCount.ToString());
            addition = true;

            return total;
            /*
            solutionTextBox.Text = "";

            if (count > 1)
            {
                solutionTextBox.Text = total.ToString();
                hasNumber = true;
            }
             */
        }

        public double minus(string solution, int minusCount)
        {
            firstNumber = Double.Parse(solution);

            // If this is the first time that the button has been hit, set the total to the number in the text field. Else set the old total and divide by the number in the text field.
            if (minusCount == 1)
            {
                total = firstNumber;
            }
            else
                total = total - firstNumber;

            subtraction = true;

            return total;
        }

        public double divide(string solution, int divideCount)
        {
            firstNumber = Double.Parse(solution);

            // If this is the first time that the button has been hit, set the total to the number in the text field. Else set the old total and divide by the number in the text field.
            if (divideCount == 1)
            {
                total = firstNumber;
            }
            else
                total = total / firstNumber;
            Console.WriteLine("Total: " + total.ToString());
            Console.WriteLine("firstNumber: " + firstNumber.ToString());
            division = true;

            return total;
        }

        public double multiply(string solution, int multiplyCount)
        {
            firstNumber = Double.Parse(solution);

            // If this is the first time that the button has been hit, set the total to the number in the text field. Else set the old total and divide by the number in the text field.
            if (multiplyCount == 1)
            {
                total = firstNumber;
            }
            else
                total = total * firstNumber;
            Console.WriteLine("Total: " + total.ToString());
            Console.WriteLine("firstNUmber: " + firstNumber.ToString());
            multiplication = true;

            return total;
        }

        public double equals(string solution)
        {
            secondNumber = Double.Parse(solution);
            if (addition == true)
            {
                total = total + secondNumber;
                Console.WriteLine("Addition S2: " + secondNumber.ToString());
                Console.WriteLine("Addition Real Total: " + total.ToString());
                addition = false;
            }
            else if (subtraction == true)
            {
                total = total - secondNumber;
                subtraction = false;
            }
            else if (multiplication == true)
            {
                total = total * secondNumber;
                multiplication = false;
            }
            else if (division == true)
            {
                total = total / secondNumber;
                Console.WriteLine("S2: " + secondNumber.ToString());
                Console.WriteLine("Real Total: " + total.ToString());
                division = false;
            }

            return total;
        }
    }
}
