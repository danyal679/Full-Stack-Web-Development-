using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integer
{
    class SecondaryClass
    {
        public static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            int answer;
            //string operand;

            Console.Write("Please enter the first integer: ");

            firstNumber = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Please enter an operand (+, -, /, *): ");

            //operand = Console.ReadLine();

            Console.Write("Please enter the second integer: ");

            secondNumber = Convert.ToInt32(Console.ReadLine());

            answer = firstNumber * secondNumber;

            Console.WriteLine(firstNumber.ToString() + " " + "*" + " " + secondNumber.ToString() + " = " + answer.ToString());
            Console.ReadLine();
        }
    }
}
