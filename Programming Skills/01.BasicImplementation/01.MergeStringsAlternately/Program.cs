﻿using System.Text;

namespace _01.MergeStringsAlternately
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            You are given two strings "word1" and "word2".
            Merge the strings by adding letters in alternating order, starting with "word1".
            If a string is longer than the other, append the additional letters onto the end of the merged string.
            Return the merged string.
            */

            // Input 1:
            string word1 = "abc";
            string word2 = "pqr";
            // Expected Output: apbqcr

            // Input 2:
            //string word1 = "ab";
            //string word2 = "pqrs";
            // Expected Output: apbqrs

            // Input 3:
            //string word1 = "abcd";
            //string word2 = "pq";
            // Expected Output: apbqcd;

            Console.WriteLine(MergeAlternately(word1, word2));
        }

        public static string MergeAlternately(string word1, string word2)
        {
            StringBuilder result = new StringBuilder();

            string longerWord = word1.Length > word2.Length ? word1 : word2;

            for (int i = 0; i < longerWord.Length; i++)
            {
                if (word1.Length > i)
                {
                    result.Append(word1[i]);
                }
                if (word2.Length > i)
                {
                    result.Append(word2[i]);
                }
            }

            return result.ToString();
        }
    }
}