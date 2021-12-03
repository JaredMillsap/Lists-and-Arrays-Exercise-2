using System;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            {
                int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                foreach (var item in array)
                {
                    Console.WriteLine(item);
                }

                /* Create two Lists of type int.
                 * Name one List "evens"
                 * Name the other List "odds"
                 */
                int i = 0;
                //declaring array of integers
                int[] arr = new int[5];

                //reading the elements
                Console.WriteLine("Enter array elements : ");
                for (i = 0; i < arr.Length; i++)
                {
                    Console.Write("Element[" + (i + 1) + "]: ");
                    arr[i] = int.Parse(Console.ReadLine());
                }

                //checking and printing all odd numbers
                Console.WriteLine("List of odd  numbers : ");
                for (i = 0; i < arr.Length; i++)
                {
                    //condition to check ODD number
                    if (arr[i] % 2 != 0)
                        Console.Write(arr[i] + " ");
                }
                Console.WriteLine();





                /* Using either a foreach or for loop,
                 * nest an if statement to check to see
                 *  if a number is even or odd.
                 * Then add those numbers to either the evens List
                 * or the odds List
                 */

                /* Now using foeach or for loops,
                 * display each List of even and odd numbers
                 *
                 * Try to be creative in your display
              */
            }
        }
    }

}      
