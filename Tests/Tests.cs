using AtCoder.Problems;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase(0, null)]
        public void TestA(long n, string expected)
        {
            var solve = new SolveA();
            // Assert.AreEqual(expected, solve.GetAnswer(n));
        }

        [TestCase(0, null)]
        public void TestB(long n, string expected)
        {
            var solve = new SolveB();
            // Assert.AreEqual(expected, solve.GetAnswer(n));
        }

        [TestCase(0, null)]
        public void TestC(long n, string expected)
        {
            var solve = new SolveC();
            Assert.AreEqual(expected, solve.GetAnswer(n));
        }

        [TestCase(0, null)]
        public void TestD(long n, string expected)
        {
            var solve = new SolveD();
            Assert.AreEqual(expected, solve.GetAnswer(n));
        }

        [TestCase(0, null)]
        public void TestE(long n, string expected)
        {
            var solve = new SolveE();
            Assert.AreEqual(expected, solve.GetAnswer(n));
        }

        [TestCase(0, null)]
        public void TestF(long n, string expected)
        {
            var solve = new SolveF();
            Assert.AreEqual(expected, solve.GetAnswer(n));
        }
    }
}