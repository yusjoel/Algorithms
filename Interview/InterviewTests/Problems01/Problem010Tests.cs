using System.Collections.Generic;
using Interview.Problems01;
using NUnit.Framework;

namespace InterviewTests.Problems01
{
    [TestFixture]
    public class Problem010Tests
    {
        [Test]
        public void SolveTest()
        {
            var sortedNumber = new List<int> { 1, 2, 4, 7, 11, 15 };
            Problem010.Solve(sortedNumber, 15, out int a, out int b);
            Assert.IsTrue(a == 4 && b == 11);
        }
    }
}