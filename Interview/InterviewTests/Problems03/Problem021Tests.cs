using Interview.Problems03;
using NUnit.Framework;
using System.Text;

// ReSharper disable StringLiteralTypo

namespace InterviewTests.Problems03
{
    [TestFixture]
    public class Problem021Tests
    {
        [TestCase("abcdef", 2, "cdefab")]
        public void SolveTest(string input, int k, string expected)
        {
            var stringBuilder = new StringBuilder(input);
            Problem021.Solve(stringBuilder, k);
            Assert.AreEqual(expected, stringBuilder.ToString());
        }

        [TestCase("abcdef", 2, "cdefab")]
        public void BetterSolveTest(string input, int k, string expected)
        {
            var stringBuilder = new StringBuilder(input);
            Problem021.BetterSolve(stringBuilder, k);
            Assert.AreEqual(expected, stringBuilder.ToString());
        }
    }
}
