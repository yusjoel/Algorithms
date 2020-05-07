using Interview.Problems01;
using NUnit.Framework;

namespace InterviewTests.Problems01
{
    [TestFixture]
    public class Problem008Tests
    {
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(100)]
        public void SolveTest(int n)
        {
            int sum = (n + 1) * n / 2;
            Assert.AreEqual(sum, Problem008.Solve(n));
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(100)]
        public void Solve2Test(int n)
        {
            int sum = (n + 1) * n / 2;
            Assert.AreEqual(sum, Problem008.Solve2(n));
        }
    }
}