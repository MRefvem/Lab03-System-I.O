using System;
using System.Collections.Immutable;
using System.Diagnostics.Tracing;
using System.IO;

namespace CSharpReview
{
    public class Program
    {
        static void Main(string[] args)
        {
            userInterface();
        }

        static void userInterface()
        {
            Console.WriteLine("Please supply 3 numbers by spaces, i.e.: 1 2 3");
            string userChoice = Console.ReadLine();
            MultiplyInputNumber(userChoice);

            Console.WriteLine("Please enter a number between 2-10");
            string inputtedAmount = Console.ReadLine();
            int numberAmount = Convert.ToInt32(inputtedAmount);
            int[] enterNumbersArray = new int[numberAmount];
            for (int i = 0; i < numberAmount; i++)
            {
                Console.WriteLine($"{i+1} of {numberAmount} - Enter a number: ");
                string selectedNumber = Console.ReadLine();
                enterNumbersArray[i] = Convert.ToInt32(selectedNumber);
            }
            FindAverageOfInputtedNumbers(enterNumbersArray, numberAmount);

            DiamondPattern();

            MostCommonNumberInArray(new int[] { 1,1,2,2,3,3,3,1,1,5,5,6,7,8,2,1,1});

            ArrayMaximumValue(new int[] {5,25,99,123,78,96,555,108,4});

            string path = "../words.txt";
            FileWriteAllText(path);
            ReadTextFromFile(path);
            RemoveWordFromFile(path);

            Console.WriteLine("Please write a sentence");
            string userSentence = Console.ReadLine();
            WordsAndLengths(userSentence);

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
        /// Challenge 2 - Create a method that asks the user to enter a number between 2-10. Then, prompt the user that number of times for random numbers.
        /// </summary>
        /// <param name="array">int</param>
        /// <param name="value">int</param>
        /// <returns></returns>
        public static int FindAverageOfInputtedNumbers(int[] array, int value)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            int average = 1;
            average = sum / value;
            Console.WriteLine($"The average of your {value} values is {average}");

            return average;
        }

        /// <summary>
        /// Challenge 3 - Create a method that will output to the console a Diamond Pattern design
        /// </summary>
        static void DiamondPattern()
        {
            string[] diamondArray = new string[] {"    *","","   ***","","  *****",""," *******","","*********",""," *******","","  *****","","   ***","","    *"};
            for (int i = 0; i < diamondArray.Length; i++)
            {
                Console.WriteLine(diamondArray[i]);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static void MostCommonNumberInArray(int[] array)
        {
            
            Console.WriteLine(string.Join(',', array));

            Array.Sort(array);
            Console.WriteLine(string.Join(',', array));

            int mostCommon = 0;


            for (int i = 0; i < array.Length; i++)
            {
                int counter = 0;
                if (i == i + 1)
                {
                    counter++;
                    Console.WriteLine(counter);
                }
                else
                {
                    counter = 0;
                }
                Console.WriteLine(counter);
            }
            
                
                

            

            for (int i = 0; i < array.Length; i++)
            {
                if (i == i+1)
                {
                    mostCommon = i;
                }
            }

                

            

            Console.WriteLine(mostCommon);

            //return mostCommon;
        }

        /// <summary>
        /// Challenge 5 - Write a method that finds the maximum value in an array
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public static int ArrayMaximumValue(int[] array)
        {
            int max = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i > i+1)
                {
                    max = i;

                }
            }

            Console.WriteLine($"The biggest number in the given array was {max}");
            return max;
        }

        /// <summary>
        /// Challenge 6 - Write a method that asks the user to input a word, and then saves that word into an external file named words.txt
        /// </summary>
        /// <param name="path">string</param>
        static void FileWriteAllText(string path)
        {
            Console.WriteLine("Please list your favorite Pokemon");
            
            string pokemon = Console.ReadLine();

            File.WriteAllText(path, pokemon);
        }

        /// <summary>
        /// Challenge 7 - Write a method that reads the file in from Challenge 6, and outputs the contents to the console
        /// </summary>
        /// <param name="path">string</param>
        static void ReadTextFromFile(string path)
        {
            string result = File.ReadAllText(path);
            Console.WriteLine(result);
        }

        /// <summary>
        /// Challenge 8 - Write a method that reads in the file from Challenge 6, removes one of the words, and rewrites it back to the file.
        /// </summary>
        /// <param name="path">string</param>
        static void RemoveWordFromFile(string path)
        {
            string result = File.ReadAllText(path);
            //File.
        }

        /// <summary>
        /// Challenge 9 - Write a method that asks the user to input a sentence and returns an array that with the word and number of characters each word has
        /// </summary>
        /// <param name="sentence">string</param>
        /// <returns></returns>
        static string[] WordsAndLengths(string sentence)
        {
            string[] splitSentence = sentence.Split(' ');
            Console.WriteLine(String.Join(',', splitSentence));

            int[] numberArray = new int[splitSentence.Length];

            // Need a way to count the length of the words
            foreach (string word in splitSentence)
            {
                int counter = 0;
                for (int i = 0; i < word.Length; i++)
                {
                    counter++;
                }

                Console.WriteLine(counter);

                // HAVING AN ISSUE WITH THE NEXT LINE WHEN UNCOMMENTED
                //numberArray[i] = counter;
            }

            Console.WriteLine($"This is our numberArray: {string.Join(',', numberArray)}");

            string[] finalArray = new string[splitSentence.Length];

            for (int i = 0; i < splitSentence.Length; i++)
            {
                finalArray[i] = $"{string.Join(',', splitSentence[i])}: {string.Join(',', numberArray[i])}";
            }

            Console.WriteLine($"This is our finalArray: {string.Join(',', finalArray)}");

            return finalArray;
        }
    }
}
