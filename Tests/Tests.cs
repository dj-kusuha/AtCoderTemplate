using AtCoder.Problems;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase(null, null)]
        public void TestA(string s, string expectd)
        {
            var solve = new SolveA();
            Assert.AreEqual(expectd, solve.GetAnswer(s));
        }

        [TestCase(null, null)]
        public void TestB(string s, string expectd)
        {
            var solve = new SolveB();
            Assert.AreEqual(expectd, solve.GetAnswer(s));
        }

        [TestCase(null, null)]
        public void TestC(string s, string expectd)
        {
            var solve = new SolveC();
            Assert.AreEqual(expectd, solve.GetAnswer(s));
        }

        [TestCase(null, null)]
        public void TestD(string s, string expectd)
        {
            var solve = new SolveD();
            Assert.AreEqual(expectd, solve.GetAnswer(s));
        }

        [TestCase(null, null)]
        public void TestE(string s, string expectd)
        {
            var solve = new SolveE();
            Assert.AreEqual(expectd, solve.GetAnswer(s));
        }

        [TestCase(null, null)]
        public void TestF(string s, string expectd)
        {
            var solve = new SolveF();
            Assert.AreEqual(expectd, solve.GetAnswer(s));
        }
    }
}