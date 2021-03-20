using System;

namespace GCF_assignment
{
    public class Program
    {
        public static int GCD(int arg1, int arg2) 
        {
            // If arg2 is exactly 0 we know that we have found the GCD and the code will return input1 as the answer.
            if (arg2 == 0)
            {
                return arg1;
            }

            /* If arg2 is not exactly 0 we run 'GCD' recursively until it is. 
             * We do that by returning the recursive modulo of the 2 inputs until the condition is met. */
            else
            {
                return GCD(arg2, arg1 % arg2);
            }
        }

        static void Main(string[] args)
        {
            // Intro
            Console.WriteLine("This program gives you the Greatest Common Factor of 2 numbers");
            Console.WriteLine("");
            
            // Label used in 'goto' on line 45
            Input1:
            Console.WriteLine("Please input the first number: ");

            string Input1 = Console.ReadLine();
            int one;

            // Checks if input is valid or not
            if (!int.TryParse(Input1, out one))
            {
                Console.WriteLine("Not a valid input, try again.");
                Console.WriteLine("");
                goto Input1;
            }

            else if (one == 0)
            {
                Console.WriteLine("Input can't be 0. Please input numbers higher than 0");
                goto Input1;
            }

            // Label used in 'goto' on line 66
            Input2:
            Console.WriteLine("Please input the second number: ");

            string Input2 = Console.ReadLine();
            int two;

            // Checks if input is valid or not
            if (!int.TryParse(Input2, out two))
            {
                Console.WriteLine("Not a valid input, try again.");
                Console.WriteLine("");
                goto Input2;
            }

            else if (two == 0)
            {
                Console.WriteLine("Input can't be 0. Please input numbers higher than 0");
                goto Input2;
            }

            int output = GCD(one, two);
            Console.WriteLine("The GCF is: " + output);
            Console.ReadLine();
        }


    }
}