using System.Collections.Generic;
using Interview.Problems01;
using NUnit.Framework;

namespace InterviewTests.Problems01
{
    [TestFixture]
    public class Problem003Tests
    {
        [Test]
        public void BetterSolveTest()
        {
            var list = new List<int>
            {
                1, -2, 3, 10, -4, 7, 2, -5
            };

            int max = Problem003.BetterSolve(list);
            Assert.AreEqual(18, max);
        }

        [Test]
        public void SolveTest()
        {
            var list = new List<int>
            {
                1, -2, 3, 10, -4, 7, 2, -5
            };

            int max = Problem003.Solve(list);
            Assert.AreEqual(18, max);
        }
    }
}