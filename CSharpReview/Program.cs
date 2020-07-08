using System;
using System.IO;

namespace CSharpReview
{
    public class Program
    {
        static void Main(string[] args)
        {
            userInterface();

            string path = "../words.txt";
            FileWriteAllText(path);
            ReadTextFromFile(path);
        }

        static void userInterface()
        {
            Console.WriteLine("Please supply 3 numbers by spaces, i.e.: 1 2 3");
            string userChoice = Console.ReadLine();
            MultiplyInputNumber(userChoice);

        }

        /// <summary>
        /// Challenge 1 - Write a program that asks the user for 3 numbers. Return the product of these 3 numbers multiplied together. If the user puts in less than 3 numbers, return 0; If the user puts in more than 3 numbers, only multiply the first 3. If the number is not a number, default that value to 1.
        /// </summary>
        /// <param name="input">string</param>
        /// <returns>int</returns>
        public static int MultiplyInputNumber(string input)
        {
            string[] stringArray = input.Split(' ');

            if (stringArray.Length < 3)
            {
                return 0;
            }
            int product = 1;

            for (int i = 0; i < 3; i++)
            {
                // convert string to an int
                if (int.TryParse(stringArray[i], out int returnValue))
                {
                    // if its true
                    product *= returnValue;
                }
                else
                {
                    product *= 1;
                }
            }

            Console.WriteLine($"The product of these 3 numbers is: {product}");
            return product;
        }

        /// <summary>
        /// Write a method that asks the user to input a word, and then saves that word into an external file named words.txt
        /// </summary>
        /// <param name="path">string</param>
        static void FileWriteAllText(string path)
        {
            Console.WriteLine("Please list your favorite Pokemon");
            
            string pokemon = Console.ReadLine();

            File.WriteAllText(path, pokemon);
        }

        /// <summary>
        /// Write a method that reads the file in from Challenge 6, and outputs the contents to the console
        /// </summary>
        /// <param name="path">string</param>
        static void ReadTextFromFile(string path)
        {
            string result = File.ReadAllText(path);
            Console.WriteLine(result);
        }
    }
}
