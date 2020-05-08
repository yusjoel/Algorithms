using Interview.Problems03;
using NUnit.Framework;

namespace InterviewTests.Problems03
{
    [TestFixture()]
    public class Problem022Tests
    {
        [TestCase(10, 2)]
        [TestCase(-1, 32)]
        public void SolveTest(int n , int expected)
        {
            int count = Problem022.Solve(n);
            Assert.AreEqual(expected, count);
        }
    }
}
