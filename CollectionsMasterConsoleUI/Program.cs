using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

           #region Arrays
           var numbers = new int [50];                         //Create an integer Array of size 50

           Console.WriteLine("Random numbers: ");
              Populater(numbers);                              //Create a method to populate the number array with 50 random numbers that are between 0 and 50 - from below method
                          
           Console.WriteLine($"{numbers[0]}");                 //Print the first number of the array - this populates the first number in the random order sequence
           Console.WriteLine($"{numbers[numbers.Length-1]}");  //Print the last number of the arrayy - this populates the last number in the random order sequence
            
           Console.WriteLine("-------------------");


           Console.WriteLine("All Numbers Original");          //This is pulling from Random list which is ok, because steps request the array to be random
              NumberPrinter(numbers);                          //call line Use this method to print out your numbers from arrays or lists - this populates all the numbers in the random sequence, 
                                                               //NumberPrinter provided  - this is from last method at bottom of list

           Console.WriteLine("-------------------");
                                                 
           
           Console.WriteLine("All Numbers Reversed:");         //Reverse the contents of the array and then print the array out to the console.  Try for 2 different ways   Hint: Array._____(); Create a custom method        
              ReverseArray(numbers);                           //call line
           
           Console.WriteLine("---------REVERSE CUSTOM------------");
            
           
           Console.WriteLine("Multiple of three = 0: ");       //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
              ThreeKiller(numbers);                            //call line

           Console.WriteLine("-------------------");

                       
           Console.WriteLine("Sorted numbers:");               //Sort the array in order now   /*      Hint: Array.____()      */
              Array.Sort(numbers);                             //This occurs after the numbers divisible by 3, to those numbers are still 0
              NumberPrinter(numbers);
                

           Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            

            //Print the capacity of the list to the console
            

            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            

            //Print the new capacity
            

            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            //NumberPrinter();
            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Odds Only!!");
            
            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted Odds!!");
            
            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
            

            //Clear the list
            

            #endregion
        }

        private static void ThreeKiller(int[] numbers)         //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
        {  
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            } 
         NumberPrinter(numbers);
        }

        private static void OddKiller(List<int> numberList)
        {
            
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
        }

        private static void Populater(int[] numbers)    //Create a method to populate the number array with 50 random numbers that are between 0 and 50
        {
            for (int i = 0; i < numbers.Length; i++)  // put value in the 50 spots
            {
                Random rng = new Random();
                numbers [i] = rng.Next(0, 50);        //  (0,50) - this is the range
            }
        }        

        private static void ReverseArray(int[] array)   //Reverse the contents of the array and then print the array out to the console.
        {
           Array.Reverse(array);
            //foreach (var number in array)
            //{
            //    Console.WriteLine($"{number}");
            //}
           NumberPrinter(array);  //  this will work the same as the foreach loop
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
