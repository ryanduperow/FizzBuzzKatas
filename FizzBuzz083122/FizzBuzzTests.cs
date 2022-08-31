
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

    }
}
