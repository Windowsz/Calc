using System;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            string operand;
            int answer;

            // enter value to calculator
            Console.WriteLine("Please Enter Number 1 : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Operand ( + , - , * , / ) : ");
            operand = Console.ReadLine();

            Console.WriteLine("Please Enter Number 2 : ");
            b = Convert.ToInt32(Console.ReadLine());

            //operand + - * / 
            switch (operand)
            {
                case "+":
                    answer = a + b;
                    break;
                case "-":
                    answer = a - b;
                    break;
                case "*":
                    answer = a * b;
                    break;
                case "/":
                    answer = a / b;
                    break;
                default:
                    answer = 0;
                    break;
            }
            //answer
            Console.WriteLine(a.ToString() + " " + operand + " " + b.ToString() + " = " + answer.ToString());
            Console.ReadLine();
        }
    }
}
