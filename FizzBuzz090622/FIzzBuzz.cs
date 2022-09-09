
namespace FizzBuzz090622
{
    public class FizzBuzz
    {
        public List<string> Convert(List<int> nums)
        {
            List<string> result = new List<string>();

            foreach (var num in nums)
            {
                if (num == 0)
                {
                    result.Add(num.ToString());
                }
                else if (num % 3 == 0 && num % 5 == 0)
                {
                    result.Add("FizzBuzz");
                }
                else if (num % 3 == 0)
                {
                    result.Add("Fizz");
                }
                else if (num % 5 == 0)
                {
                    result.Add("Buzz");
                }
                else
                {
                    result.Add(num.ToString());
                }
            }

            return result;
        }
    }
}
