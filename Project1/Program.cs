/// Chapter No. 6		Exercise No. 1
/// File Name: Program.cs
/// @author: Chester Brock 
/// Date:  Oct 14, 2021
///
/// Problem Statement: Write code to create a copy of an array.
/// 
/// 
/// 
/// Overall Plan:
/// 1)  First, start by creating an initial array. 
/// 2)  start with 10 items.
/// 3)  Declare an array variable and assign it a new
/// 4)  create a second array variable.
/// 5)  Give it a new array with the same length as the first.  
/// 6)  use the Length property to get the size of the original array.
/// 7)  Use a loop to read values from the original array and place them in the new array.
/// 8)  print out the contents of both arrays, to be sure everything copied correctly.
///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create original array 
            double[] score = new double[10];
            
            for (int i = 0; i < score.Length; i++)
            {
                // prompting to fill the 10 elements 
                Console.Write("Array slot #" + (i+1) + ":  ");
                score[i] = double.Parse(Console.ReadLine());
            }
            // Alerting the array has been filled 
            Console.WriteLine("The array has been filled ( Press Enter) ");

            Console.ReadLine();

            // creating new array
            double[] newScore = new double[score.Length];

            //copying the contents to a new array 
            for(int x = 0; x < newScore.Length; x++)
            {
                newScore[x] = score[x];
            }

            // printing out both arrays to see if they match.
            foreach(double element in score)
            {
                Console.Write(element + ", ");
            }
            // creating seperation 
            Console.WriteLine("\n");

            // printing out both arrays to see if they match.
            foreach (double element in newScore)
            {
                Console.Write(element + ", ");
            }

            // pausing program
            Console.ReadLine();
        }
    }
}
