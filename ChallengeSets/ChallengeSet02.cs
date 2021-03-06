﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengeSets
{
    public class ChallengeSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (Char.IsLetter(c))
            {
                return true;
            }
            else
            {
                return false;
            }
            //throw new NotImplementedException();
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            //throw new NotImplementedException();
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

            //throw new NotImplementedException();
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

            //throw new NotImplementedException();
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            double min = double.MaxValue;
            double max = double.MinValue;
            double sum = 0;
            foreach (double i in numbers)
            {
                //Console.WriteLine(i);
                min = Math.Min(min, i);
                max = Math.Max(max, i);
                sum += i;
            }
            return max + min;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
            //throw new NotImplementedException();
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                int sum = 0;
                foreach (int item in numbers)
                {
                    sum += item;
                }
                return sum;
            }

            //throw new NotImplementedException();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                int sumOfEvens = 0;
                foreach (int item in numbers)
                {
                    if (item % 2 == 0)
                        sumOfEvens += item;
                }
                return sumOfEvens;
            }
            //throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
 
            
            }
            return (numbers.Sum() % 2 != 0);

                    
        }
   
      
        public long CountOfPositiveOddsBelowNumber(long number)
        {
            int odds = 0;
            for (int i = 0; i < number; i++)
            {
                if (i % 2 != 0)
                {
                    odds++;
                }
            }
            return odds;
            //throw new NotImplementedException();
        }

    }
}

