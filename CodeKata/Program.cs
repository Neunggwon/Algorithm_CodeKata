﻿using System.Linq;
using System.Security.Cryptography;

namespace CodeKata
{
    internal class Program
    {
        public class Solution
        {
            public double solution(int[] numbers)
            {
                double sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
                double answer = sum / numbers.Length;
                Console.WriteLine(answer);
                return Math.Round(answer);
            }
        }
        static void Main(string[] args)
        {

        }
    }
}