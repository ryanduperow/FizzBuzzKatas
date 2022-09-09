
namespace FizzBuzz090622
{
    [TestClass]
    public class FizzBuzzTests
    {
        private FizzBuzz fb = new FizzBuzz();
        private List<int> input = new List<int>();
        private List<string> expected = new List<string>();
        private List<string> actual = new List<string>();

        [TestMethod]
        public void Convert_2_ShouldReturn_String2()
        {
            expected = new List<string> { "2" };
            input = new List<int> { 2 };

            actual = fb.Convert(input);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Convert_0_ShouldReturn_String0()
        {
            expected = new List<string> { "0" };
            input = new List<int> { 0 };

            actual = fb.Convert(input);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Convert_MultipleNonFizzBuzzNums_ShouldReturn_ListOfStringNums()
        {
            expected = new List<string> { "0", "1", "2" };
            input = new List<int> { 0, 1, 2 };

            actual = fb.Convert(input);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Convert_3_ShouldReturn_Fizz()
        {
            expected = new List<string> { "Fizz" };
            input = new List<int> { 3 };

            actual = fb.Convert(input);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Convert_6_ShouldReturn_Fizz()
        {
            expected = new List<string> { "Fizz" };
            input = new List<int> { 6 };

            actual = fb.Convert(input);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Convert_10_ShouldReturn_Buzz()
        {
            expected = new List<string> { "Buzz" };
            input = new List<int> { 10 };

            actual = fb.Convert(input);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Convert_15_ShouldReturn_FizzBuzz()
        {
            expected = new List<string> { "FizzBuzz" };
            input = new List<int> { 15 };

            actual = fb.Convert(input);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Convert_VariousNums_ShouldReturn_CorrectStringList()
        {
            expected = new List<string> { "1", "FizzBuzz", "Fizz", "7", "Buzz", "0", "Buzz"};
            input = new List<int> { 1, 30, 12, 7, 20, 0, 125};

            actual = fb.Convert(input);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
