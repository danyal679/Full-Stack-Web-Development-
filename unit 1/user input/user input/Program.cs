using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_input
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) // Loop indefinitely
            { 
            Console.WriteLine("Enter input:"); // Prompt the user 
            String userInput = Console.ReadLine(); // Get string from user
            if (userInput == "exit") // Check string
            {
                break;
            }
            Console.Write("you typed"); // Report output
            Console.Write(userInput.Length);
            Console.WriteLine(" character(s) ");
            Console.ReadKey();
            break;
        } 
    }
    }
}
