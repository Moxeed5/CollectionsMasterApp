using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] numbers = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50

            Populater(numbers);

            //TODO: Print the first number of the array

            Console.WriteLine($"{numbers[0]}");

            //TODO: Print the last number of the array
            //

            Console.WriteLine($"{numbers[numbers.Length - 1]}");


            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");

            ReverseArray(numbers);



            Console.WriteLine("---------REVERSE CUSTOM------------");

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");

            ThreeKiller(numbers);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");

            Array.Sort(numbers);
            NumberPrinter(numbers);

            //Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List

            List<int> numberList = new List<int>();


            //TODO: Print the capacity of the list to the console

            Console.WriteLine(numberList.Capacity);

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            

            Populater(numberList);

            //TODO: Print the new capacity

            NumberPrinter(numberList);

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!


            //bool userSearch = int.TryParse(Console.ReadLine(), out);

            bool isANumber;

            int userSearch;

            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                isANumber = int.TryParse(Console.ReadLine(), out userSearch);
                if(!isANumber)
                {
                    Console.WriteLine("Nope, enter a number");
                }

            } while (!isANumber);

            NumberChecker(numberList, userSearch);

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numberList);

            NumberPrinter(numbers);

            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");

            OddKiller(numberList);

            NumberPrinter(numberList);

            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");

            numberList.Sort();
            NumberPrinter(numberList);

            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            var array = numbers.ToArray();

            //TODO: Clear the list

            numberList.Clear();

            NumberPrinter(numberList);

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]}");
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i]! % 2 == 0)
                {
                    numberList[i] = 0;
                }
            }
            for (int i = 0; i < numberList.Count - 1; i++)
            {
                Console.Write($"{numberList[i]}");
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine($"Yes, {searchNumber} is in the list");
            }
            else
            {
                Console.WriteLine($"{searchNumber} is not in the list");
            }
        }

            private static void Populater(List<int> numberList)
            {
                Random rng = new Random();
                for (int i = 0; i < numberList.Count; i++)
                {
                    numberList[i] = rng.Next(0, 50);
                }

            }

            static void Populater(int[] numbers)
            {
                Random rng = new Random();
                for (int i = 0; i < numbers.Length; i++)
                {

                    numbers[i] = rng.Next(0, 50);
                }


            }

            private static void ReverseArray(int[] array)
            {

                for (int i = array.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine($"{array[i]}");
                }

            }

            /// <summary>
            /// Generic print method will iterate over any collection that implements IEnumerable<T>
            /// </summary>
            /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
            /// <param name="collection"></param>
            private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
            {
                //STAY OUT DO NOT MODIFY!!
                foreach (var item in collection)
                {
                    Console.WriteLine(item);
                }
            }
        
    }
}