using Interview.Problems02;
using NUnit.Framework;
// ReSharper disable StringLiteralTypo

namespace InterviewTests.Problems02
{
    [TestFixture]
    public class Problem020Tests
    {
        [TestCase("ab", "acb", "ab")]
        [TestCase("BDCABA", "ABCBDAB", "BDAB")]
        public void SolveTest(string x, string y, string expected)
        {
            string lcs = Problem020.Solve(x, y);
            Assert.AreEqual(expected, lcs);
        }
    }
}
