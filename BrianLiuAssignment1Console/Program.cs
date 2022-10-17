using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using BrianLiuAssignment1Console.ServiceReference;
using BrianLiuAssignment1Console;

namespace BrianLiuAssignment1Console
{
    public class Program
    {
        private static ServiceClient client = new ServiceClient();
        static void Main(string[] args)
        {            
            bool keepRunning = true;
            string message = "\t\t\t\t\t\tBrian Liu Assignment 1\n\n" +
            "1. Prime number\n" +
            "2. Sum of digits\n" +
            "3. Reverse a string\n" +
            "4. Print HTML tags\n" +
            "5. Sort 5 numbers\n" +
            "6. Exit\n" +
            "\nEnter your choice: ";  

            while(keepRunning)
            {
                int input = GetIntInput(message);

                if (input == 1)
                {
                    int number = GetIntInput("Enter a number: ");
                    bool isPrime = client.IsPrimeNumber(number);
                    if (isPrime)                    
                        Console.WriteLine(number + " is a prime number!");
                    else
                        Console.WriteLine(number + " is not a prime number!");
                    PressKeyToContinue();
                }
                else if (input == 2)
                {
                    int number = GetIntInput("Enter an integer: ");
                    int sum = client.SumOfDigits(number);
                    Console.WriteLine("The sum of each digit is " + sum + "!");
                    PressKeyToContinue();
                }
                else if (input == 3)
                {
                    string stringInput = GetStringInput("Enter a string: ", null);
                    string reversedInput = client.ReverseOfString(stringInput);
                    Console.WriteLine("The reverse is " + "\"" + reversedInput + "\"!");
                    PressKeyToContinue();
                }
                else if (input == 4)
                {                   
                    string htmlTag = GetStringInput("Enter an HTML tag. Eg. \"h1\": ", null);
                    string data = GetStringInput("Enter some string data: ", null);
                    string htmlDataOutput = client.WrapInHTMLTags(htmlTag, data);
                    Console.WriteLine("Your data wrapped in html tags is " + htmlDataOutput);
                    PressKeyToContinue();
                }
                else if (input == 5)
                {
                    List<double> numberList = new List<double>();
                    string[] ascendingValues = new string[] { "Y", "y", "" };
                    bool ascending = true;
                    for (int i = 0; i < 5; i++)
                    {
                        numberList.Add(GetDoubleInput("Enter double input #" + (i + 1) + ": "));
                    }
                    string ascendingStr = GetStringInput("Would you like this to sort ascending? [Y/n]: ", new string[] { "y", "Y", "n", "N", "" });
                    if (!ascendingValues.Contains(ascendingStr))
                        ascending = false;

                    Console.WriteLine("Your sorted list is: " + client.SortNumbers(ascending, numberList.ToArray()));
                    PressKeyToContinue();
                }
                else if (input == 6)
                    keepRunning = false;
            }
        }

        public static int GetIntInput(string message)
        {
            int input = 0;
            bool keepRunning = true;

            while (keepRunning)
            {
                try
                {
                    Console.Write(message);
                    input = int.Parse(Console.ReadLine());
                    keepRunning = false;
                }
                catch
                {
                    Console.WriteLine("There was an issue with your input. Please try again");
                }
            }

            return input;
        }

        public static double GetDoubleInput(string message)
        {
            double input = 0;
            bool keepRunning = true;

            while (keepRunning)
            {
                try
                {
                    Console.Write(message);
                    input = double.Parse(Console.ReadLine());
                    keepRunning = false;
                }
                catch
                {
                    Console.WriteLine("There was an issue with your input. Please try again");
                }
            }

            return input;
        }

        public static string GetStringInput(string message, string[] expectedStrings)
        {
            string input = "";
            bool keepRunning = true;
            
            while (keepRunning)
            {
                try
                {
                    Console.Write(message);
                    input = Console.ReadLine();
                    if (expectedStrings == null && string.IsNullOrWhiteSpace(input))
                        throw new Exception();
                    else if (expectedStrings != null)
                    {
                        if (!expectedStrings.Contains(input))
                            throw new Exception();
                    }
                    keepRunning = false;
                }
                catch
                {
                    Console.WriteLine("There was an issue with your input. Please try again");
                }
                
            }             
            
            return input;
        }

        public static void PressKeyToContinue()
        {
            Console.Write("Press any key to continue\n");
            Console.ReadKey();
        }
    }
}
