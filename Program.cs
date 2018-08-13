/*
Word Frequency Counter from Coding Challenges
by Silvio Duka

Last modified date: 2018-02-24

Write a program to find how many times a given word occurs in a given string. 

For Example: 
Input: "this is a sample text", "is" 
Output: 1 

Input: "Some long text with some words.","some" 
Output: 2
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordFrequencyCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Some long text with some words."; // Insert your text here
            string word = "some"; // Insert a word to count

            string[] words = text.ToLower().Split(' ');
            int count = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Trim(new Char[] { ',', '.', '\'', '\"', '!', '?' }) == word.ToLower()) count++;
            }

            Console.WriteLine($"Input: \"{text}\",\"{word}\"");
            Console.WriteLine($"Output: {count}");
        }
    }
}