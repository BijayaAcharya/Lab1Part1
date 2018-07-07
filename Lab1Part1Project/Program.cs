using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Part1Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask user for First number
            Console.WriteLine("\nEnter the first number");

            // converting user's input in to  int and reading it from the console
            int userFirstInput = int.Parse(Console.ReadLine());

            // converting number's digit in to array so that we can add each digit of two numbers
            var firstNumberDigits = userFirstInput.ToString().Select(t => int.Parse(t.ToString())).ToArray();

            // ask user for second number
            Console.WriteLine("\nEnter the second number");

            // converting user's input in to  int and reading it from the console
            int userSecondInput = int.Parse(Console.ReadLine());

            // converting number's digit in to array so that we can add each digit of two numbers
            var secondNumberDigits = userSecondInput.ToString().Select(t => int.Parse(t.ToString())).ToArray();

            // calling CalculateTheSum method and passing the parameters 
            CalculateTheSum(firstNumberDigits, secondNumberDigits);

            Console.ReadKey();
        }
        // This method calculates the sum of the digits in the two array
        public static void CalculateTheSum(int[] firstNumber, int[] secondNumber)
        {
            // creating the instance of the array
            int[] arr = new int[firstNumber.Length];

            // using for loop to loop through the elements in two array
            for (int i = 0; i < firstNumber.Length && i < secondNumber.Length; i++)

            {
                // adding the first digits, second digits ... of each array and  saving it so array so that we can compare if the are unique or same
                arr[i] = firstNumber[i] + secondNumber[i];
            }
            // Looping through the sum array
            for (int j = 0; j < arr.Length; j++)
            {

                for (int k = j; k < arr.Length - 1; k++)
                {
                    // if elements are equal, the output is true
                    if (arr[k] == arr[k + 1])
                    {
                        Console.WriteLine("true");
                        Console.ReadKey();
                    }
                    else
                    {
                        // if elements are different, the output is false
                        Console.WriteLine("false");
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}

        
        
    

