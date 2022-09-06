
namespace FizzBuzz090622
{
    public class FizzBuzz
    {
        public List<string> Convert(List<int> nums)
        {
            List<string> result = new List<string>();

            foreach (var num in nums)
            {
                result.Add(num.ToString());
            }

            return result;
        }
    }
}
