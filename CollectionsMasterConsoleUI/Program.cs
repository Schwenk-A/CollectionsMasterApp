using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Arrays
            // Create an integer Array of size 50
            int[] newArray = new int[50];

            //Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(newArray);

            //Print the first number of the array 
            Console.WriteLine(newArray[0]);

            //Print the last number of the array
            Console.WriteLine(newArray[newArray.Length -1]);

            Console.WriteLine("All Numbers Original");
            NumberPrinter(newArray);
            //Ustse this method to print out your numbers from arrays or lis
            //NumberPrinter();
            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */

            ReverseArray(newArray);

            Console.WriteLine("All Numbers Reversed:");
            NumberPrinter(newArray);
            


            Console.WriteLine("---------REVERSE CUSTOM------------");

            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            ThreeKiller(newArray);

           

            Console.WriteLine("-------------------");

            //Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(newArray);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            List<int> newInt = new List<int>();

            //Print the capacity of the list to the console
            Console.WriteLine("Capacity Is:" +newInt.Capacity);

            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(newInt);

            //Print the new capacity
            Console.WriteLine("Capacity Is:" + newInt.Capacity);

            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            var searchNumber = int.Parse(Console.ReadLine()); 
            NumberChecker(newInt,searchNumber);
           

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            
            NumberPrinter(newInt);
            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(newInt);
            NumberPrinter(newInt);
           


            Console.WriteLine("------------------");

            newInt.Sort();
            NumberPrinter(newInt);

            Console.WriteLine("Sorted Evens!!");
            
            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
             
            
            var switchedList = newInt.ToArray();
            
            newInt.Clear();
            NumberPrinter(switchedList);
            //Clear the list


            #endregion
        }



        private static void ThreeKiller(int[] numbers)
        {
            var counter = 0;
            foreach (var number in numbers)
            {
                
                if (number % 3 == 0)
                {
                    counter++;
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(number);
                }
            }
            Console.WriteLine($"Deleted {counter}  3's");


        }

        private static void OddKiller(List<int> numberList)
        {

            numberList.RemoveAll(n => n % 2 != 0);

        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
           
            if (numberList.Contains(searchNumber)) 
            {
                Console.WriteLine("It is here");
            }
            else
            {
                Console.WriteLine("Not in the list");
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
            {
                var randomNumber = rng.Next(1, 50);
                numberList.Add(randomNumber);
            }

        }

        private static void Populater(int[] numbers)
        {
            var rand = new Random();

            for (var i = 0; i < numbers.Length; i++)
            {
                var randomNumber = rand.Next(1, 50);
                numbers[i] = randomNumber;
            }
        }        

        private static void ReverseArray(int[] array)
        {
             Array.Reverse(array);
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
