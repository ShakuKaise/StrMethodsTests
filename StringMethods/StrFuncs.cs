using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    public class StrFuncs
    {
        public string FindShortestWord(string input)
        {
            string[] words = input.Split(' ');
            string shortestWord = words[0];

            foreach (string word in words)
            {
                if (word.Length < shortestWord.Length)
                {
                    shortestWord = word;
                }
            }

            return shortestWord;
        }
        public int CountWords(string input)
        {
            string[] words = input.Split(' ');
            return words.Length;
        }
        public int CountCharacters(string input)
        {
            return input.Length;
        }
        public char GetNinthCharacter(string input)
        {
            if (input.Length >= 9)
            {
                return input[8];
            }

            return ' ';
        }
        public int CountDigits(string input)
        {
            int digitCount = 0;

            foreach (char c in input)
            {
                if (Char.IsDigit(c))
                {
                    digitCount++;
                }
            }

            return digitCount;
        }
        public int FindLongestDigitSequence(string input)
        {
            int currentSequenceLength = 0;
            int maxSequenceLength = 0;

            foreach (char c in input)
            {
                if (Char.IsDigit(c))
                {
                    currentSequenceLength++;
                }
                else
                {
                    if (currentSequenceLength > maxSequenceLength)
                    {
                        maxSequenceLength = currentSequenceLength;
                    }

                    currentSequenceLength = 0;
                }
            }

            if (currentSequenceLength > maxSequenceLength)
            {
                maxSequenceLength = currentSequenceLength;
            }

            return maxSequenceLength;
        }
        public int CountAMCombinations(string input)
        {
            int combinationCount = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == 'а' && input[i + 1] == 'м')
                {
                    combinationCount++;
                }
            }

            return combinationCount;
        }
    }
}
