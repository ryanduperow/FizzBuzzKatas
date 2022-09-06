
namespace FizzBuzz090622
{
    [TestClass]
    public class FizzBuzzTests
    {
        private FIzzBuzz fb = new FIzzBuzz();

        [TestMethod]
        public void Convert_2_ShouldReturn_String2()
        {
            List<string> expected = new List<string> { "2" };
            List<int> input = new List<int> { 2 };

            List<string> actual = fb.Convert(input);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
