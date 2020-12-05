using System;
using System.Collections.Generic;
using System.Linq;
namespace ChallengeSets
{
    public class ChallengeSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
                else
                {
                    sum -= i;
                }
            }
            return sum;

            //throw new NotImplementedException();
        }


        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var list = new List<int> { str1.Length, str2.Length, str3.Length, str4.Length };
            return list.Min();

            //throw new NotImplementedException();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var list = new List<int> { number1, number2, number3, number4 };
            return list.Min();

            throw new NotImplementedException();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
            //throw new NotImplementedException();
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            throw new NotImplementedException();
        }

        public bool IsStringANumber(string input)
        {
           Double result;
            return Double.TryParse(input, out result);
            //throw new NotImplementedException();
        }


        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int itemCount = objs.Length;
            int nullCount = 0;
            foreach (object obj in objs)
            {
                if (obj == null) nullCount++;
            }
            if (nullCount > itemCount / 2)
            {
                return true;
            }
            return false;
           

            //throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            if(numbers == null)
            {
                return 0;
            }
            else
            {
                int evens = 0;
                int AverageOfEvens = 0;
                foreach (int item in numbers)
                {
                    if(item % 2 == 0)
                    {
                        evens += item;
                        AverageOfEvens++;

                    }
                }
                if (AverageOfEvens == 0)
                {
                    return 0;
                }
                return (double)evens / AverageOfEvens;
            }
            
            //throw new NotImplementedException();
        }

        public int Factorial(int number)
        {
            if (number == 0)
                return 1;
            else
                return number * Factorial(number - 1);
            //throw new NotImplementedException();
        }

    }
}