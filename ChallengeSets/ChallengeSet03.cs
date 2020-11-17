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
            throw new NotImplementedException();
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
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
            var odd = Enumerable.Range(1, 100).Where(i => i % 2 == 0);

            throw new NotImplementedException();
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
    

