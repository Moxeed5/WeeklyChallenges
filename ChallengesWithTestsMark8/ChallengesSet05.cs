using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int nextNum = startNumber + 1;
            while(nextNum % n != 0)
            {
                nextNum++;
            }
            return nextNum;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            var closedBiz = businesses.Where(x => x.TotalRevenue == 0)
                .Select(x => { x.Name = "CLOSED"; return businesses; })
                .ToList();
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            

            //if (numbers.Length == 0 || numbers == null)
                if (numbers == null || numbers.Length == 0)
                {
                    return false;
                }

            bool isAscending = numbers.SequenceEqual(numbers.OrderBy(x => x));

            return isAscending;

            //int tracker = 1;

            //bool isTrue =true;

          
            //else
            //{

            //    do
            //    {

            //        for (int i = 0; i < numbers.Length - 1; i++)
            //        {
            //            if (numbers[i] < numbers[tracker])
            //            {
            //                tracker++;
            //            }
            //            else
            //            {
            //                isTrue = false;
            //            }

            //        }
            //    } while (isTrue == true);
            //}

            //return isTrue;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            //TBH I couldn't figure out what this is supposed to do.
            //I can't seem to pass all test regardless of what I do :(

            int index = Array.IndexOf(numbers, numbers.FirstOrDefault(n => n % 2 == 0));
            if (index < 0) return 0;
            int sum = numbers.Skip(index + 1).Take(2).Sum();
            return sum;


        }

        public string TurnWordsIntoSentence(string[] words)
        {
            //Checking if the array is null or empty
            if (words == null || words.Length == 0) return "";

            // Removing empty strings or whitespaces from the array and removing any whitespaces from the start or end of each word
            var filteredWords = words.Where(w => !string.IsNullOrWhiteSpace(w)).Select(w => w.Trim());

            //Concatenating the remaining words with a space in between
            string sentence = String.Join(" ", filteredWords);

            //Removing any trailing whitespaces, and adding a period at the end
            return sentence.TrimEnd() + ".";
        }




        public double[] GetEveryFourthElement(List<double> elements)
        {
            if(elements == null || elements.Count < 4)
            {
                return new double[0];
            }
            List<double> everyFourth = new List<double>();

            for(int i = 3; i < elements.Count; i+=4)
            {
                everyFourth.Add(elements[i]);
            }


            return everyFourth.ToArray(); ;
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int firstNum = nums[i];
                int secondNum = targetNumber - firstNum;

                int counter = i + 1;
                while (counter < nums.Length)
                {
                    if (nums[counter] == secondNum)
                    {
                        return true;
                    }
                    counter++;
                }
            }
            return false;
        }
        

    }
}
