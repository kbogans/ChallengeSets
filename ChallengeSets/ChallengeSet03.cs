using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ChallengeSets
{
    public class ChallengeSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Contains(false);
            throw new NotImplementedException();
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            return (numbers.Sum() % 2 != 0);

            throw new NotImplementedException();
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            return password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsNumber);
        }


        public char GetFirstLetterOfString(string val)
        {
            return val[0];
            throw new NotImplementedException();
        }


        public char GetLastLetterOfString(string val)
        {
            var lastLetter = val[val.Length - 1];
            return lastLetter;
            //throw new NotImplementedException();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            var dec = dividend / divisor;
            return dec;
            throw new NotImplementedException();
        }

        public int LastMinusFirst(int[] nums)
        {
            var number = nums[nums.Length - 1] - nums[0];
            return number;
            //throw new NotImplementedException();
        }
        public int[] GetOddsBelow100()
        {

            List<int> oddsBelow100 = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if(i % 2 != 0)
                {
                    oddsBelow100.Add(i);
                }
            }
            return oddsBelow100.ToArray();
          
        }



        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
            //throw new NotImplementedException();
        }
    }
}
    

