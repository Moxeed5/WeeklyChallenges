using MoreLinq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null || words.Count() == 0)
            {
                return false;
            }

            if (ignoreCase)
            {
                bool doesContain = words.Where(x => x != null && x.Equals(word, StringComparison.OrdinalIgnoreCase)).Any();
                return doesContain;
            }
            else
            {
                bool doesContain = words.Where(x => x != null && x.Equals(word)).Any();
                return doesContain;
            }
        }


        public bool IsPrimeNumber(int num)
        {
            if(num < 0)
            {
                return false;
            }
            if(num == 1 || num == 0)
            {
                return false;
            }

            for(int i = 2; i < num; i++)
            {
                if(num % i ==0)
                {
                    return false;
                }
                
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str.Count(c => c == str[i]) == 1)
                {
                    return i;
                }
            }
            return -1;
        }


        public int MaxConsecutiveCount(int[] numbers)
        {
            int maxCount = 0;
            int currentCount = 1;
            int currentNum = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (currentNum == numbers[i])
                {
                    currentCount++;
                }
                else
                {
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }
                    currentNum = numbers[i];
                    currentCount = 1;
                }
            }
            return Math.Max(maxCount, currentCount);
        }


        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var myList = new List<double>();

            if (elements == null || elements.Count == 0 || n <= 0)
            {
                return new Double[0];
            }
            

            for(int i = n-1; i < elements.Count; i+=n)
            {
                
                myList.Add(elements[i]);   
                
            }

            return myList.ToArray();

           
        }
    }
}
