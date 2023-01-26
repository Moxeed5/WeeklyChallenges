using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {

            return (char.IsLetter(c));

        }


        public bool CountOfElementsIsEven(string[] vals)
        {
        return (vals.Length % 2 == 0);

        }

        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0);
        }

        public bool IsNumberOdd(int num)
        {
           
            return (num % 2 != 0);
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            if(numbers.Count() == 0)
            {
                return 0;
            }
            var min = numbers.Min();

            var max = numbers.Max();

            var sumMinMax = min + max;

            return sumMinMax;


        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            
            return (str1.Length > str2.Length) ? str2.Length : str1.Length;
        }

        public int Sum(int[] numbers)
        {

            if(numbers == null)
            {
                return 0;
            }

            int sumOfNums = 0;

            foreach(var item in numbers)
            {
                sumOfNums += item;
            }

            return sumOfNums; 
        }

        public int SumEvens(int[] numbers)
        {
            if(numbers ==null)
            {
                return 0; 
            }

            int sumOfEvens = 0;

            foreach(var item in numbers)
            {
                if(item % 2 == 0)
                {
                    sumOfEvens += item;
                }

            }

            return sumOfEvens;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if(numbers == null)
            {
                return false;
            }

            int result = 0;

            foreach(int item in numbers)
            {
                result += item;
            }

            return (result % 2 != 0);
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long oddsTracker = 0; 

            if (number <= 1)
            {
                return 0;
            }
            for(long i = number -1; i >= 0; i-- )
            {
                if(i % 2 != 0)
                {
                    oddsTracker++;
                }

            }

            return oddsTracker;
        }

    }
}
