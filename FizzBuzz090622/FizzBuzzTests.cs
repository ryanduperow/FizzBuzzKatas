﻿
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
    }
}
