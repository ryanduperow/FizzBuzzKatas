
namespace FizzBuzz083122
{
    [TestClass]
    public class FizzBuzzTests
    {
        private FizzBuzz fb = new FizzBuzz();

        [TestMethod]
        public void Convert_0_ShouldReturn_String0()
        {
            string expected = "0";

            string actual = fb.Convert(0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Convert_1_ShouldReturn_String1()
        {
            string expected = "1";

            string actual = fb.Convert(1);

            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(2, "2")]
        [DataRow(4, "4")]
        [DataRow(127, "127")]
        public void Convert_UnknowNum_ShouldReturn_UnknownNumString(int input, string expected)
        {
            string actual = fb.Convert(input);

            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(3, "Fizz")]
        [DataRow(9, "Fizz")]
        [DataRow(33, "Fizz")]
        public void Convert_DivisibleByThree_ShouldReturn_Fizz(int input, string expected)
        {
            string acutal = fb.Convert(input);

            Assert.AreEqual(expected, acutal);
        }

        [DataTestMethod]
        [DataRow(5, "Buzz")]
        [DataRow(10, "Buzz")]
        [DataRow(35, "Buzz")]
        public void Convert_DivisibleByFive_ShouldReturn_Buzz(int input, string expected)
        {
            string acutal = fb.Convert(input);

            Assert.AreEqual(expected, acutal);
        }


    }
}
