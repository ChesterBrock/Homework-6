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
/// 3) 
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
            foreach(int element in numbers)
            {
                Console.Write(element + ", ");
            }
            Console.ReadLine();
            //Reverse(numbers);
            //Printnumber(numbers);
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

    }
}
