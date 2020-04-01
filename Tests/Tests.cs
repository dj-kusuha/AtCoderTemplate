using AtCoder.Problems;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase(null, null)]
        public void TestA(string s, string expected)
        {
            var solve = new SolveA();
            Assert.AreEqual(expected, solve.GetAnswer(s));
        }

        [TestCase(null, null)]
        public void TestB(string s, string expected)
        {
            var solve = new SolveB();
            Assert.AreEqual(expected, solve.GetAnswer(s));
        }

        [TestCase(null, null)]
        public void TestC(string s, string expected)
        {
            var solve = new SolveC();
            Assert.AreEqual(expected, solve.GetAnswer(s));
        }

        [TestCase(null, null)]
        public void TestD(string s, string expected)
        {
            var solve = new SolveD();
            Assert.AreEqual(expected, solve.GetAnswer(s));
        }

        [TestCase(null, null)]
        public void TestE(string s, string expected)
        {
            var solve = new SolveE();
            Assert.AreEqual(expected, solve.GetAnswer(s));
        }

        [TestCase(null, null)]
        public void TestF(string s, string expected)
        {
            var solve = new SolveF();
            Assert.AreEqual(expected, solve.GetAnswer(s));
        }
    }
}