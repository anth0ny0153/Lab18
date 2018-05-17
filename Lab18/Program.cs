﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    class Program
    {
        static void Main(string[] args)
        {
            // []Find the max value
            //   foreach(int number in numbers)
            //{
            //    if (number > max)
            //    {
            //        max = number;
            //    }
            //}
            //   int max = 0;
            //   int[] freq = new int[max+1]

            //   can do it one for loop dont need nested

            // []Find the frequency of numbers in array
            //   int[] freq go through array find whats the biggest number and then initialize freq array
            //   freq[numbers[i]]++;
            int[] numbers = { 1, 2, 3, 2, 2, 4, 5, 5, 7, 8, 4, 4, 1, 0, 10 };
            int max = 0;
            
            //GoogleList google = new GoogleList();
            //google.Add("Mike");
            //google.Add("Mike");
            //google.Add("James");
            //google.Add("Anthony");
            //google.Add("Mike");
            //google.Add("John");
            //google.RemoveAll("Mike");
            //google.PrintInfo();

            max = FindMax(numbers);
            int[] freq = new int[max + 1];
            for (int i = 0; i < numbers.Length; i++)
            {
                freq[numbers[i]]++;
            }
            for (int i = 0; i < freq.Length; i++)
            {
                if (freq[i] != 0)
                {
                    Console.WriteLine($"[{i}]:{freq[i]}");
                }
            }

        }
        public static int FindMax(int[] numbs)
        {
            int max =0;
            for (int i = 0; i < numbs.Length; i++)
            {
                if (numbs[i] > max)
                {
                    max = numbs[i];
                }
            }
            return max;
        }
    }
}
