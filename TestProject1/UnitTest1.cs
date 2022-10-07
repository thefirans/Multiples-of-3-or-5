using ConsoleApp1;
namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(23, Kata.Solution(10));
        }
    }
}