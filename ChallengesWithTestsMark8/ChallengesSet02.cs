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
            return (num % 2 == 0);
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            var min = numbers.Min();

            var max = numbers.Max();

            var sumMinMax = min + max;

            return sumMinMax;


        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            //int resultofStr1 = Int32.TryParse(str1);

            //int resultofStr2 = Int32.TryParse(str2);

            //var arr1 = str1.ToArray();

            //var arr2 = str2.ToArray();

            return (str1.Length > str2.Length) ? str1.Length : str2.Length;

           // int arr1Counter = 0;

           // int arr2Counter = 0;

           // foreach(var item in arr1)
           // {
           //     arr1Counter++;
           // }

           //foreach(var item in arr2)
           // {
           //     arr2Counter++;
           // }

           //if(arr1Counter > arr2Counter)
           // {
           //     return arr1Counter;
           // }
           // else
           // {
           //     return arr2Counter;
           // }

        }

        public int Sum(int[] numbers)
        {
            int sumOfNums = 0;

            foreach(var item in numbers)
            {
                sumOfNums += item;
            }

            return sumOfNums; 
        }

        public int SumEvens(int[] numbers)
        {
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
            int result = 0;

            foreach(int item in numbers)
            {
                result += item;
            }

            return (result % 2 == 0);
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long oddCount = 0;

            for(long i = number; i >= 0; i--)
            {
                if(i % 2 != 0)
                {
                    oddCount++;
                }
            }
            return oddCount;
        }
    }
}
