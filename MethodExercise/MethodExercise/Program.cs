using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            char sign = ' ';
            double result = 0;

            Console.WriteLine("This program will do simple arithmetic for you if you enter 2 numbers");
            Console.WriteLine("Please enter your first number:");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your second number:");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the sign:");
            sign = Convert.ToChar(Console.ReadLine());

            switch (sign)
            {
                case '+':
                    result = Add(firstNumber, secondNumber);
                    Console.WriteLine("Addition is " + result);
                    break;
                case '-':
                    result = Subtract(firstNumber, secondNumber);
                    Console.WriteLine("Addition is " + result);
                    break;
                case '*':
                case 'x':
                    result = Multiply(firstNumber, secondNumber);
                    Console.WriteLine("Addition is " + result);
                    break;
                case '/':
                    result = Divide(firstNumber, secondNumber);
                    Console.WriteLine("Addition is " + result);
                    break;
                default:
                    Console.WriteLine("YOu didn't enter a valid sign.");
                    break;
            }

            Console.WriteLine(firstNumber + " " + sign + " " + secondNumber + " = " + result);

        }

            static double Add(int firstNumber, int secondNumber)
            {
                double answer = 0;

                answer = firstNumber + secondNumber;

                return answer;
            }

            static double Subtract(int firstNumber, int secondNumber)
            {
                double answer = 0;

                answer = firstNumber - secondNumber;

                return answer;
            }

            static double Multiply(int firstNumber, int secondNumber)
            {
                double answer = 0;

                answer = firstNumber * secondNumber;

                return answer;
            }

            static double Divide(int firstNumber, int secondNumber)
            {
                double answer = 0;

                answer = firstNumber / secondNumber;

                return answer;
            }

    }
}
