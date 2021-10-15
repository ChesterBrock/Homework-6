/// Chapter No. 6		Exercise No. 2
/// File Name: Program.cs
/// @author: Chester Brock 
/// Date:  Oct 14, 2021
///
/// Problem Statement: take an array and reverse the contents of it.
/// 
/// 
/// 
/// Overall Plan:
/// 1) Create three meathods : create array, reverse array, print array
/// 2) The GenerateNumbers method should return an array of 10 numbers.
/// 3) The PrintNumber method should simply use a for or foreach loop to go down the array,
/// 4) the reverse method - Use a for loop, starting at 0 and going up the length of the array / 2.
/// 5) The number you use in the for loop will be the index of the first number to swap
/// 6) swapping array[index] with array[arrayLength - index - 1].
///
///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers();
            Printnumber(numbers);
            Reverse(numbers);
        }
        // end of main method 

        // The GenerateNumbers() should return a array of 10 numbers 
        public static int[] GenerateNumbers()
        {
            int[] tempArray = new int[10];
            Random rand = new Random();
            for(int i = 0; i < tempArray.Length; i++)
            {
                tempArray[i] = rand.Next(0, 100);
            }
            return tempArray;
        }

        // The PrintNumber method should simply use a for or foreach loop to go down the array, one at a time,
        // and print out the items in it.
        public static void Printnumber(int[] numbers)
        {
            foreach(int element in numbers)
            {
                Console.Write(element + " ");
            }
        }

        //The Reverse method
        public static void Reverse(int[] array)
        {
            // hint- temporary location to make the swap:
            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp;
            }

            Console.WriteLine("\nReversed array ~~ ");
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.ReadLine();

        }
        
        

    }
}
