using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            var Falsey =  vals.Where(x => x == false);

            return Falsey.Any();
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            var numSum = numbers.Sum(x => x);

            return (numSum % 2 == 0 || numbers == null) ? false : true;
            
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool result = password.Any(x => char.IsDigit(x) && char.IsUpper(x));

            return result;

        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] array = Enumerable.Range(1, 100).ToArray();


            int[] oddNumbers = array.Where(n => n % 2 != 0).ToArray();

            return oddNumbers;


        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            string[] wordsToUpper = words.Select(s => s.ToUpper()).ToArray();

        }
    }
}
