﻿
namespace FizzBuzz083122
{
    public class FizzBuzz
    {
        public string Convert(int num)
        {
            string result = string.Empty;

            if (num == 0) result = "0";
            else if (num % 3 == 0) result = "Fizz";
            else if (num % 5 == 0) result = "Buzz";
            else result = num.ToString();

            return result;
        }
    }
}
