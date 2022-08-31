
namespace FizzBuzz083122
{
    public class FizzBuzz
    {
        public string Convert(int num)
        {
            string result = string.Empty;

            if (num == 0) result = "0";
            else result = num.ToString();

            return result;
        }
    }
}
