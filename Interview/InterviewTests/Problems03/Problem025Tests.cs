using Interview.Problems03;
using NUnit.Framework;

namespace InterviewTests.Problems03
{
    [TestFixture()]
    public class Problem025Tests
    {
        [TestCase(0u, 0u)]
        [TestCase(1u, 1u)]
        [TestCase(8u, 1u)]
        [TestCase(12u, 5u)]
        public void SolveTest(uint n, uint expected)
        {
            uint count = Problem025.Solve(n);
            Assert.AreEqual(expected, count);
        }
    }
}
