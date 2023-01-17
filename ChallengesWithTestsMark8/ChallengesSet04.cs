using System;
using System.Collections.Generic;
using System.Data;
using System.Linq; 

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int evenSum = numbers.Where(x => x % 2 == 0).Sum();
            int oddSum = numbers.Where(x => x % 2 != 0).Sum();

            return evenSum - oddSum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int length1 = str1.Length;
            int length2 = str2.Length;
            int length3 = str3.Length;
            int length4 = str4.Length;

            var list = new List<int>();

            list.AddRange(new int[] { length1, length2, length3, length4});

            return list.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var list = new List<int>();

            list.AddRange(new int[] { number1, number2, number3, number4 });

            return list.Min();

        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            //var myBiz = new Business();

            //myBiz.Name = "TrueCoders";

            //myBiz.Name = biz.Name;

            biz.Name = "TrueCoders";

        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if(sideLength1 + sideLength2 <= sideLength3 || sideLength1 + sideLength3 <= sideLength2 || sideLength2 + sideLength3 <= sideLength1)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        public bool IsStringANumber(string input)
        {
            bool isNum = double.TryParse(input, out double x);

            return isNum;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var nonNullCounter = 0;
            var nullCounter = 0;

            foreach(var item in objs)
            {
                if(item == null)
                {
                    nullCounter++;
                }
                if(item != null)
                {
                    nonNullCounter++;
                }
               
            }
            if(nullCounter > nonNullCounter)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            
            double EvenCounter = 0;
            double EvenSum = 0;
            //double zero = 0;

            if(numbers == null)
            {
                return 0;
            }

            foreach (var item in numbers)
            {

                if(item % 2 == 0)
                {
                    EvenSum += item;
                    EvenCounter++;
                }
                
            }

            if(EvenCounter > 0)
            {
                return EvenSum / EvenCounter; 
            }
            else
            {
                return 0;
            }

        }

        public int Factorial(int number)
        {
            var fact = 1;

            if(number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            for(int i = number; i > 0; i--)
            {
                fact *= i;
            }

            return fact;
        }
    }
}
