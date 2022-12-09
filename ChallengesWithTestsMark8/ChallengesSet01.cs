using System;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            double sum = minuend - subtrahend;
            return sum;
        }

        public int Add(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            return (number1 < number2) ? number1 : number2;
           
        }

        public long Multiply(long factor1, long factor2)
        {
            long sum = factor1 * factor2;
            return sum;
        }

        public string GetGreeting(string nameOfPerson)
        {
            //Console.WriteLine($"Hi {nameOfPerson}");
            
            if(nameOfPerson == "")
            {
                return "Hello!";
            }
            else
            {
                return $"Hello, {nameOfPerson}!";
            }
        }

        public string GetHey()
        {
            return "HEY!";
        }
    }
}
